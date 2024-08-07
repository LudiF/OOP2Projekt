using System;
using System.Globalization;
using System.Resources;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Drawing.Text;

namespace OOP2Projekt
{
    public partial class RegistracijskaForma : Form
    {
        ResourceManager resManager; // Resource manager to access culture specific resources
        CultureInfo cultureInfo;    // Culture info

        public RegistracijskaForma()
        {
            InitializeComponent();
            SetLanguage("en");
        }

        private void SetLanguage(string langCode)
        {
            cultureInfo = CultureInfo.CreateSpecificCulture(langCode);
            resManager = new ResourceManager("OOP2Projekt.Resources", typeof(RegistracijskaForma).Assembly);
            // Update UI elements with resource values
            this.Text = resManager.GetString("FormTitle", cultureInfo);
            labelRegistracijaPozdrav.Text = resManager.GetString("WelcomeMessage", cultureInfo);
            buttonRegistracijaPotvrda.Text = resManager.GetString("RegisterButton", cultureInfo);
            labelRegistracijaKorisnickoIme.Text = resManager.GetString("LabelUsername", cultureInfo);
            labelLozinkaReg.Text = resManager.GetString("LabelPassword", cultureInfo);
            labelSpol.Text = resManager.GetString("LabelGender", cultureInfo);
            radioButtonMusko.Text = resManager.GetString("LabelMale", cultureInfo);
            radioButtonZensko.Text = resManager.GetString("LabelFemale", cultureInfo);
            //Ostali UI elementi ispod ove linije
        }

        private bool IsValidEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }

        private bool UserExists(string username, string email)
        {
            string connectinString = @"Data Source=E:\BazaOOP2\KorisniciPrograma.db;Version=3;";
            using(SQLiteConnection connection = new SQLiteConnection(connectinString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM Korisnici WHERE Username = @Username OR Email = @Email";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Email", email);
                    int count = Convert.ToInt32(command.ExecuteScalar()); //vraca broj redaka koji odgovara uvjetu da se poklapaju username ili email
                    return count > 0;
                }
            }
        }

        private void buttonRegistracijaPotvrda_Click(object sender, EventArgs e)
        {
            string username = textBoxKorisnickoImeRegistracija.Text;
            string password = textBoxLozinkaRegistracija.Text;
            string email = textBoxEmailRegistracija.Text;
            string gender = radioButtonMusko.Checked ? "Muško" : "Žensko";

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show(resManager.GetString("AllFieldsRequired", cultureInfo));
                return;
            }

            if (!IsValidEmail(email))
            {
                MessageBox.Show(resManager.GetString("InvalidEmailFormat", cultureInfo));
                return;
            }

            if(UserExists(username, email))
            {
                MessageBox.Show(resManager.GetString("UserExists", cultureInfo));
                return;
            }

            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(@"Data Source=E:\BazaOOP2\KorisniciPrograma.db;Version=3;"))
                {
                    connection.Open();
                    string query = "INSERT INTO Korisnici (Username, Password, Email, Gender) VALUES (@Username, @Password, @Email, @Gender)";
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@Gender", gender);
                        command.ExecuteNonQuery();
                    }
                    connection.Close();
                }
                MessageBox.Show(resManager.GetString("RegistrationSuccessful", cultureInfo));
            }
            catch(Exception ex)
            {
                MessageBox.Show(resManager.GetString("ErrorOccured", cultureInfo) + ": " + ex.Message);
            }
        }
        private void SwitchLanguage(string langCode)
        {
            SetLanguage(langCode);
        }

        private void comboBoxLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedLanguage = comboBoxLanguage.SelectedItem.ToString();
            if (selectedLanguage == "Hrvatski")
            {
                SwitchLanguage("hr");
            }
            else if (selectedLanguage == "English")
            {
                SwitchLanguage("en");
            }
        }
    }
}
