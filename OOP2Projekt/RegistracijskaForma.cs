using System;
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
        private bool IsValidEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }

        public RegistracijskaForma()
        {
            InitializeComponent();
        }

        private void buttonRegistracijaPotvrda_Click(object sender, EventArgs e)
        {
            string username = textBoxKorisnickoImeRegistracija.Text;
            string password = textBoxLozinkaRegistracija.Text;
            string email = textBoxEmailRegistracija.Text;
            string gender = radioButtonMusko.Checked ? "Muško" : "Žensko";

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("All fields are required");
                return;
            }

            if (!IsValidEmail(email))
            {
                MessageBox.Show("Invalid email format");
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
                MessageBox.Show("Registration successful!");
            }
            catch(Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void RegistracijskaForma_Load(object sender, EventArgs e)
        {

        }
    }
}
