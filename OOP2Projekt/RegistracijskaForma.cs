using System;
using FontAwesome.Sharp;
using BCrypt.Net;
using OOP2Projekt;
using System.Security.Cryptography;
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
            this.buttonRegistracijaPotvrda.Click += new System.EventHandler(this.buttonRegistracijaPotvrda_Click);
            LanguageSettings.OnLanguageChanged += LanguageChangedHandler; // Pretplata na događaj
            SetLanguage(LanguageSettings.CurrentLanguage);
        }
        private void LanguageChangedHandler(object sender, EventArgs e)
        {
            SetLanguage(LanguageSettings.CurrentLanguage); // Ažuriraj jezik kad se događaj pokrene
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

            comboBoxLanguage.SelectedItem = langCode == "hr" ? "Hrvatski" : "English";
        }
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            // Odjavite se s događaja kada se forma zatvori
            LanguageSettings.OnLanguageChanged -= LanguageChangedHandler;
            base.OnFormClosed(e);
        }

        private bool IsValidEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }

        private bool UserExists(string username, string email)
        {
            string connectinString = @"Data Source=E:\BazaOOP2\KorisniciPrograma.db;Version=3;";
            using (SQLiteConnection connection = new SQLiteConnection(connectinString))
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

            if (UserExists(username, email))
            {
                MessageBox.Show(resManager.GetString("UserExists", cultureInfo));
                return;
            }

            try
            {
                string pepper = "mojPapar";
                string saltedPassword = password + pepper;
                string hashedPassword = BCrypt.Net.BCrypt.HashPassword(saltedPassword);

                // Šifriranje podataka korisnika pomoću AES-a
                string userData = $"{username},{email},{gender}";
                var (encryptedContent, aesKey, aesIV) = AesEncryption.EncryptContent(userData);

                // Generiranje RSA ključeva
                var (publicKey, privateKey) = RsaEncryption.GenerateRsaKeys();

                // Šifriranje AES ključa pomoću RSA-a
                byte[] encryptedKey = RsaEncryption.EncryptSymmetricKey(aesKey, publicKey);

                using (SQLiteConnection connection = new SQLiteConnection(@"Data Source=E:\BazaOOP2\KorisniciPrograma.db;Version=3;"))
                {
                    connection.Open();
                    string query = "INSERT INTO Korisnici (Username, Password, Email, Gender, EncryptedData, EncryptedKey, IV, PublicKey, PrivateKey) " + "VALUES (@Username, @Password, @Email, @Gender, @EncryptedData, @EncryptedKey, @IV, @PublicKey, @PrivateKey)";
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", hashedPassword);
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@Gender", gender);
                        command.Parameters.AddWithValue("@EncryptedData", Convert.ToBase64String(encryptedContent));
                        command.Parameters.AddWithValue("@EncryptedKey", Convert.ToBase64String(encryptedKey));
                        command.Parameters.AddWithValue("@IV", Convert.ToBase64String(aesIV));
                        command.Parameters.AddWithValue("@PublicKey", publicKey);
                        command.Parameters.AddWithValue("@PrivateKey", privateKey);
                        command.ExecuteNonQuery();
                    }
                    connection.Close();
                }
                MessageBox.Show(resManager.GetString("RegistrationSuccessful", cultureInfo));
            }
            catch (Exception ex)
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
            string selectedLanguage = comboBoxLanguage.SelectedItem.ToString() == "Hrvatski" ? "hr" : "en";
            LanguageSettings.CurrentLanguage = selectedLanguage;
            SetLanguage(selectedLanguage); // Odmah primijenite promjenu jezika
        }
    }
}
