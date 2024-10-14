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
using System.IO;
using System.Linq;
using System.Net;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;

namespace OOP2Projekt
{
    public partial class GlavnaForma : Form, ILocalizable
    {
        private SpoonacularAPIClient _apiClient;
        private int userId;
        private int downloadSpeedLimit = 0; // Brzina preuzimanja u bajtovima po sekundi (0 znači bez ograničenja)

        public GlavnaForma(int userId)
        {
            InitializeComponent();
            _apiClient = new SpoonacularAPIClient(); // Inicijaliziraj API klijent
            this.userId = userId;

            // Postavljanje brzine preuzimanja (proizvoljne vrijednosti)
            comboBoxSpeed.Items.Add("Bez ograničenja");
            comboBoxSpeed.Items.Add("20 KB/s");
            comboBoxSpeed.Items.Add("100 KB/s");
            comboBoxSpeed.Items.Add("200 KB/s");
            comboBoxSpeed.SelectedIndex = 0;

            comboBoxSpeed.SelectedIndexChanged += ComboBoxSpeed_SelectedIndexChanged;

            LanguageSettings.OnLanguageChanged += LanguageChangedHandler; // Pretplata na događaj
            SetLanguage(LanguageSettings.CurrentLanguage);
        }

        private void ComboBoxSpeed_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Postavljanje ograničenja brzine na temelju izbora
            switch (comboBoxSpeed.SelectedIndex)
            {
                case 1: // 20 KB/s
                    downloadSpeedLimit = 20 * 1024;
                    break;
                case 2: // 100 KB/s
                    downloadSpeedLimit = 100 * 1024;
                    break;
                case 3: // 200 KB/s
                    downloadSpeedLimit = 200 * 1024;
                    break;
                default: // Bez ograničenja
                    downloadSpeedLimit = 0;
                    break;
            }
        }

        private async Task<bool> CheckInternetConnectionAsync()
        {
            try
            {
                using (var httpClient = new System.Net.Http.HttpClient())
                {
                    // Pokušaj napraviti zahtjev na Google
                    var response = await httpClient.GetAsync("https://www.google.com");
                    return response.IsSuccessStatusCode;
                }
            }
            catch
            {
                return false;
            }
        }

        private async void buttonGetMealPlan_Click(object sender, EventArgs e)
        {
            if (!await CheckInternetConnectionAsync())
            {
                MessageBox.Show("Nemate pristup internetu. Molimo provjerite mrežnu vezu.");
                return;
            }

            try
            {
                int targetCalories = (int)numericUpDownCalories.Value; // Ovdje uzmi ciljani broj kalorija
                MealPlanResponse mealPlanResponse = await _apiClient.GetMealPlan(targetCalories);

                richTextBoxMealPlan.Clear(); // Očisti RichTextBox
                foreach (var meal in mealPlanResponse.Meals)
                {
                    AppendTextToRichTextBox($"Naslov: {meal.Title}\n", FontStyle.Bold);
                    AppendTextToRichTextBox($"Vrijeme pripreme: {meal.ReadyInMinutes} minuta\n");
                    AppendTextToRichTextBox($"Porcije: {meal.Servings}\n");
                    AppendTextToRichTextBox($"Link: {meal.SourceUrl}\n");

                    // Dodaj URL slike
                    string imageUrl = $"https://spoonacular.com/recipeImages/{meal.Id}-312x231.{meal.ImageType}";
                    await AddImageToRichTextBox(imageUrl); // Preuzmi sliku i prikaži uz napredak

                    AppendTextToRichTextBox("\n\n"); // Razmak između obroka
                }

                // Dodaj informacije o hranjivim tvarima
                AppendTextToRichTextBox("Ukupni nutrijenti za dan:\n", FontStyle.Bold);
                AppendTextToRichTextBox($"Kalorije: {mealPlanResponse.Nutrients.Calories} kcal\n");
                AppendTextToRichTextBox($"Proteini: {mealPlanResponse.Nutrients.Protein} g\n");
                AppendTextToRichTextBox($"Masti: {mealPlanResponse.Nutrients.Fat} g\n");
                AppendTextToRichTextBox($"Ugljikohidrati: {mealPlanResponse.Nutrients.Carbohydrates} g\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Došlo je do greške: " + ex.Message);
            }
        }

        private async Task AddImageToRichTextBox(string imageUrl)
        {
            try
            {
                WebRequest request = WebRequest.Create(imageUrl);

                using (WebResponse response = await request.GetResponseAsync())
                using (Stream stream = response.GetResponseStream())
                using (MemoryStream ms = new MemoryStream())
                {
                    // Prikaz tijeka preuzimanja
                    progressBarDownload.Visible = true;
                    byte[] buffer = new byte[8192];
                    int bytesRead;
                    int totalBytesRead = 0;
                    int totalBytesToRead = (int)response.ContentLength;

                    while ((bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length)) > 0)
                    {
                        if (downloadSpeedLimit > 0)
                        {
                            // Ograniči brzinu preuzimanja
                            await Task.Delay(1000 * bytesRead / downloadSpeedLimit);
                        }

                        await ms.WriteAsync(buffer, 0, bytesRead);
                        totalBytesRead += bytesRead;

                        // Ažuriraj progress bar
                        progressBarDownload.Value = (int)((totalBytesRead / (float)totalBytesToRead) * 100);
                    }

                    Image img = Image.FromStream(ms);
                    Image resizedImage = new Bitmap(img, new Size(100, 100)); // Smanji sliku na 100x100
                    Clipboard.SetImage(resizedImage); // Kopiraj sliku u clipboard
                    richTextBoxMealPlan.ReadOnly = false;
                    richTextBoxMealPlan.Paste();
                    richTextBoxMealPlan.ReadOnly = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri dodavanju slike: " + ex.Message);
            }
            finally
            {
                progressBarDownload.Visible = false; // Sakrij progress bar kad preuzimanje završi
            }
        }

        private void AppendTextToRichTextBox(string text, FontStyle style = FontStyle.Regular)
        {
            richTextBoxMealPlan.SelectionFont = new Font(richTextBoxMealPlan.Font, style);
            richTextBoxMealPlan.AppendText(text);
            richTextBoxMealPlan.SelectionFont = new Font(richTextBoxMealPlan.Font, FontStyle.Regular); // Resetiraj stil
        }

        private void LanguageChangedHandler(object sender, EventArgs e)
        {
            SetLanguage(LanguageSettings.CurrentLanguage); // Ažuriraj jezik kad se događaj pokrene
        }

        public void SetLanguage(string langCode)
        {
            CultureInfo cultureInfo = CultureInfo.CreateSpecificCulture(langCode);
            ResourceManager resManager = new ResourceManager("OOP2Projekt.Resources", typeof(GlavnaForma).Assembly);

            this.Text = resManager.GetString("MainFormTitle", cultureInfo);
            comboBoxLanguage.SelectedItem = langCode == "hr" ? "Hrvatski" : "English";
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            LanguageSettings.OnLanguageChanged -= LanguageChangedHandler;
            base.OnFormClosed(e);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            UserProfileForm userProfileForm = new UserProfileForm();
            userProfileForm.ShowDialog();
        }

        private void buttonTrackProgress_Click(object sender, EventArgs e)
        {
            var progressForm = new ProgressForm(userId);
            progressForm.Show();
        }
    }
}
