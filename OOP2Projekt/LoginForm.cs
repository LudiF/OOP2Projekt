using System;
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

        private void buttonPrijava_Click(object sender, EventArgs e)
        {
            string username = textBoxKorisnickoIme.Text;
            string password = textBoxLozinka.Text;

            string pepper = "mojPapar";
            string saltedPassword = password + pepper;

            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(@"Data Source=E:\BazaOOP2\KorisniciPrograma.db;Version=3;"))
                {
                    connection.Open();
                    string query = "SELECT Password FROM Korisnici WHERE Username = @Username";
                    using(SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        string storedHashedPassword = command.ExecuteScalar() as string;

                        if (storedHashedPassword != null &&  BCrypt.Net.BCrypt.Verify(saltedPassword, storedHashedPassword))
                        {
                            MessageBox.Show("Prijava uspješna!");
                            //nastavak prijave
                        }
                        else
                        {
                            MessageBox.Show("Pogrešno korisničko ime ili lozinka.");
                        }
                    }
                    connection.Close();
                }
            }
            catch(Exception ex)
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
