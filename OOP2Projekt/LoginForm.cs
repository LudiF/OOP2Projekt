using System;
using FontAwesome.Sharp;
using BCrypt.Net;
using OOP2Projekt;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace OOP2Projekt
{
    public partial class LoginForm : Form, ILocalizable
    {
        ResourceManager resManager;
        CultureInfo cultureInfo;
        private bool IsBase64String(string base64)
        {
            Span<byte> buffer = new Span<byte>(new byte[base64.Length]);
            return Convert.TryFromBase64String(base64, buffer, out _);
        }

        public LoginForm()
        {
            InitializeComponent();
            comboBoxLanguage.SelectedItem = LanguageSettings.CurrentLanguage == "hr" ? "Hrvatski" : "English";

            LanguageSettings.OnLanguageChanged += LanguageChangedHandler;
            SetLanguage(LanguageSettings.CurrentLanguage);
        }

        private void LanguageChangedHandler(object sender, EventArgs e)
        {
            SetLanguage(LanguageSettings.CurrentLanguage); // Ažuriraj jezik kad se događaj pokrene
        }

        public void SetLanguage(string langCode) // Promijenite u public
        {
            LanguageSettings.CurrentLanguage = langCode;

            cultureInfo = CultureInfo.CreateSpecificCulture(langCode);
            resManager = new ResourceManager("OOP2Projekt.Resources", typeof(LoginForm).Assembly);

            // Update UI elements with resource values
            this.Text = resManager.GetString("LoginFormTitle", cultureInfo);
            labelKorisnickoIme.Text = resManager.GetString("LabelUsername", cultureInfo);
            labelLozinka.Text = resManager.GetString("LabelPassword", cultureInfo);
            buttonPrijava.Text = resManager.GetString("ButtonLogin", cultureInfo);
            buttonRegistracija.Text = resManager.GetString("ButtonRegister", cultureInfo);
            linkLabelLozinka.Text = resManager.GetString("LabelForgotPassword", cultureInfo);
            labelDobrodosli.Text = resManager.GetString("LabelDobrodosli", cultureInfo);
            // Add other UI elements here

            comboBoxLanguage.SelectedItem = langCode == "hr" ? "Hrvatski" : "English";
        }
        private int GetUserIdFromDatabase(string username)
        {
            int userId = -1; // Zadana vrijednost za nepostojećeg korisnika

            // Povezivanje s bazom podataka
            using (SQLiteConnection connection = new SQLiteConnection(@"Data Source=E:\BazaOOP2\KorisniciPrograma.db;Version=3;"))
            {
                connection.Open();
                string query = "SELECT Id FROM Korisnici WHERE Username = @Username";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    object result = command.ExecuteScalar();

                    // Ako je pronađen korisnik, spremamo njegov ID
                    if (result != null)
                    {
                        userId = Convert.ToInt32(result);
                    }
                }
            }

            return userId; // Vraćamo korisnički ID ili -1 ako korisnik nije pronađen
        }
        private void buttonPrijava_Click(object sender, EventArgs e)
        {
            string username = textBoxKorisnickoIme.Text;
            string password = textBoxLozinka.Text;

            int userId = GetUserIdFromDatabase(username); // Dobivanje userId-a iz baze podataka

            if (userId == -1)
            {
                MessageBox.Show("Korisnik nije pronađen.");
                return;
            }

            string pepper = "mojPapar";
            string saltedPassword = password + pepper;

            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(@"Data Source=E:\BazaOOP2\KorisniciPrograma.db;Version=3;"))
                {
                    connection.Open();
                    string query = "SELECT Password, EncryptedData, EncryptedKey, IV, PublicKey, PrivateKey FROM Korisnici WHERE Username = @Username";
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string storedHashedPassword = reader["Password"].ToString();
                                if (BCrypt.Net.BCrypt.Verify(saltedPassword, storedHashedPassword))
                                {
                                    // Dešifriranje pohranjenih podataka
                                    string encryptedDataStr = reader["EncryptedData"].ToString();
                                    string encryptedKeyStr = reader["EncryptedKey"].ToString();
                                    string ivStr = reader["IV"].ToString();

                                    // Dekodiranje iz Base64 formata natrag u byte nizove
                                    byte[] encryptedData = Convert.FromBase64String(encryptedDataStr);
                                    byte[] encryptedKey = Convert.FromBase64String(encryptedKeyStr);
                                    byte[] iv = Convert.FromBase64String(ivStr);

                                    // Otvori GlavnaForma i proslijedi userId
                                    GlavnaForma glavnaForma = new GlavnaForma(userId);
                                    glavnaForma.Show();
                                    this.Hide();
                                }
                                else
                                {
                                    MessageBox.Show("Pogrešno korisničko ime ili lozinka.");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Pogrešno korisničko ime ili lozinka.");
                            }
                        }
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(resManager.GetString("ErrorOccured", cultureInfo) + ": " + ex.Message);
            }
        }

        private void buttonRegistracija_Click(object sender, EventArgs e)
        {
            RegistracijskaForma registrationForm = new RegistracijskaForma();
            registrationForm.Show();
        }

        private void comboBoxLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedLanguage = comboBoxLanguage.SelectedItem.ToString() == "Hrvatski" ? "hr" : "en";
            LanguageSettings.CurrentLanguage = selectedLanguage;

            // Neposredno primijenite promjenu jezika
            SetLanguage(selectedLanguage);
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            // Odjavite se s događaja kada se forma zatvori da biste izbjegli memory leak
            LanguageSettings.OnLanguageChanged -= LanguageChangedHandler;
            base.OnFormClosed(e);
        }
    }

}
