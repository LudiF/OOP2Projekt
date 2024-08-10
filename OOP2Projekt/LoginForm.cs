using System;
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
            linkLabelLozinka.Text = resManager.GetString("LabelPassword", cultureInfo);
            labelDobrodosli.Text = resManager.GetString("LabelDobrodosli", cultureInfo);
            // Add other UI elements here

            comboBoxLanguage.SelectedItem = langCode == "hr" ? "Hrvatski" : "English";
        }

        private void buttonPrijava_Click(object sender, EventArgs e)
        {
            // Logika za prijavu korisnika
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
