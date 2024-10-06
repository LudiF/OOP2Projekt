using System;
using ProgressTrackingLibrary;
using UserProfileLibrary;
using FontAwesome.Sharp;
using OOP2Projekt;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;

namespace OOP2Projekt
{
    public partial class GlavnaForma : Form, ILocalizable
    {
        private int userId;
        public GlavnaForma(int userId)
        {
            InitializeComponent();
            this.userId = userId;

            // Dodavanje ikone na gumb
            //IconButton button = new IconButton();
            //button.IconChar = IconChar.Home;
            //button.IconColor = Color.Black;
            //button.Text = "Home";
            //button.Size = new Size(100, 50);
            //this.Controls.Add(button);

            LanguageSettings.OnLanguageChanged += LanguageChangedHandler; // Pretplata na događaj
            SetLanguage(LanguageSettings.CurrentLanguage);
        }


        private void LanguageChangedHandler(object sender, EventArgs e)
        {
            SetLanguage(LanguageSettings.CurrentLanguage); // Ažuriraj jezik kad se događaj pokrene
        }

        public void SetLanguage(string langCode) // Promijenite u public
        {
            // Inicijalizirajte cultureInfo i resManager
            CultureInfo cultureInfo = CultureInfo.CreateSpecificCulture(langCode);
            ResourceManager resManager = new ResourceManager("OOP2Projekt.Resources", typeof(GlavnaForma).Assembly);

            // Ažurirajte UI elemente
            this.Text = resManager.GetString("MainFormTitle", cultureInfo);
            // Postavite ispravnu vrijednost u ComboBox-u
            comboBoxLanguage.SelectedItem = langCode == "hr" ? "Hrvatski" : "English";
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            // Odjavite se s događaja kada se forma zatvori
            LanguageSettings.OnLanguageChanged -= LanguageChangedHandler;
            base.OnFormClosed(e);
        }

        private void GlavnaForma_Load(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            // Ovdje otvaramo formu za postavke iz vanjskog DLL-a
            UserProfileForm userProfileForm = new UserProfileForm(); // pretpostavljamo da se klasa iz DLL-a zove UserProfileForm
            userProfileForm.ShowDialog(); // Otvara formu kao modalni dijalog
        }

        private void buttonTrackProgress_Click(object sender, EventArgs e)
        {
            var progressForm = new ProgressForm(userId);
            progressForm.Show();
        }


    }
}
