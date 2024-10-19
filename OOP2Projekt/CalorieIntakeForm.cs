using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SQLite;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace OOP2Projekt
{
    public partial class CalorieIntakeForm : Form
    {
        private BindingList<CalorieIntakeData> calorieDataList = new BindingList<CalorieIntakeData>();
        private BindingSource bindingSource = new BindingSource();
        private string connectionString = @"Data Source=E:\BazaOOP2\KorisniciPrograma.db;Version=3;";
        private int currentUserId;

        public CalorieIntakeForm(int userId)
        {
            InitializeComponent();
            currentUserId = userId;
        }


        private void CalorieIntakeForm_Load(object sender, EventArgs e)
        {
            InitializeDataGridViewAndChart();
            LoadDataFromDatabase();
        }

        private void InitializeDataGridViewAndChart()
        {
            dataGridViewCalories.AutoGenerateColumns = true;  // Omogući automatsko generiranje stupaca u DataGridView

            if (chartCalories.ChartAreas.Count == 0)
            {
                chartCalories.ChartAreas.Add(new ChartArea("MainArea"));
            }

            chartCalories.Series.Clear();
            var series = new Series
            {
                Name = "Calorie Intake",
                Color = System.Drawing.Color.Green,
                ChartType = SeriesChartType.Line
            };

            chartCalories.Series.Add(series);
        }

        private void LoadDataFromDatabase()
        {
            calorieDataList.Clear();

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT Id, UserId, Date, Calories FROM CalorieIntake WHERE UserId = @UserId";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserId", currentUserId);
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var calorieData = new CalorieIntakeData
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                UserId = Convert.ToInt32(reader["UserId"]),
                                Date = DateTime.Parse(reader["Date"].ToString()),
                                Calories = Convert.ToInt32(reader["Calories"])
                            };
                            calorieDataList.Add(calorieData);
                        }
                    }
                }
                connection.Close();
            }

            bindingSource.DataSource = calorieDataList;
            dataGridViewCalories.DataSource = bindingSource;

            if (calorieDataList.Count > 0)
            {
                UpdateCaloriesChart();
            }
            else
            {
                chartCalories.Series[0].Points.Clear();
            }
        }

        private void UpdateCaloriesChart()
        {
            if (chartCalories.Series.Count > 0)
            {
                chartCalories.Series[0].Points.Clear();  // Očisti prethodne točke
            }

            foreach (var data in calorieDataList)
            {
                chartCalories.Series[0].Points.AddXY(data.Date, data.Calories);
            }

            chartCalories.Invalidate();  // Osvježi prikaz grafikona
        }

        private void buttonAddCalories_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxCalories.Text, out int calories))
            {
                MessageBox.Show("Please enter valid calories.");
                return;
            }

            var calorieData = new CalorieIntakeData
            {
                Date = dateTimePickerCalories.Value,
                Calories = calories,
                UserId = currentUserId
            };

            SaveDataToDatabase(calorieData);
            LoadDataFromDatabase();
        }


        private void buttonDeleteCalories_Click(object sender, EventArgs e)
        {
            if (dataGridViewCalories.SelectedRows.Count > 0)
            {
                var row = dataGridViewCalories.SelectedRows[0];
                int id = (int)row.Cells["Id"].Value;
                DeleteFromDatabase(id);
                LoadDataFromDatabase();
            }
        }

        private void buttonEditCalories_Click(object sender, EventArgs e)
        {
            if (dataGridViewCalories.SelectedRows.Count > 0)
            {
                var row = dataGridViewCalories.SelectedRows[0];
                int id = (int)row.Cells["Id"].Value;

                var calorieData = calorieDataList.FirstOrDefault(c => c.Id == id);
                if (calorieData != null)
                {
                    // Postavi unesene vrijednosti
                    calorieData.Date = dateTimePickerCalories.Value;
                    calorieData.Calories = int.Parse(textBoxCalories.Text);

                    // Ažuriraj bazu podataka
                    UpdateDatabase(calorieData);
                    LoadDataFromDatabase(); // Ponovno učitaj podatke da bi se prikazale promjene
                }
            }
        }

        private void SaveDataToDatabase(CalorieIntakeData data)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO CalorieIntake (UserId, Date, Calories) VALUES (@UserId, @Date, @Calories)";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserId", data.UserId);
                    command.Parameters.AddWithValue("@Date", data.Date);
                    command.Parameters.AddWithValue("@Calories", data.Calories);
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        private void DeleteFromDatabase(int id)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "DELETE FROM CalorieIntake WHERE Id = @Id";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        private void UpdateDatabase(CalorieIntakeData data)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE CalorieIntake SET Date = @Date, Calories = @Calories WHERE Id = @Id";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Date", data.Date);
                    command.Parameters.AddWithValue("@Calories", data.Calories);
                    command.Parameters.AddWithValue("@Id", data.Id);
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }
    }

    public class CalorieIntakeData
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime Date { get; set; }
        public int Calories { get; set; }
    }
    public class MealData
    {
        public string MealType { get; set; }
        public double Calories { get; set; }

        // Metoda koja prikazuje informacije o obroku
        public void DisplayMealInfo()
        {
            Console.WriteLine($"Meal Type: {MealType}, Calories: {Calories}");
        }

        // Metoda za izračun ukupnih kalorija za niz obroka
        public static double CalculateTotalCalories(List<MealData> meals)
        {
            return meals.Sum(meal => meal.Calories);
        }
    }

}
