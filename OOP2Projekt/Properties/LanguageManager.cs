using System;
using System.Globalization;
using System.Resources;


namespace OOP2Projekt
{
    public static class LanguageManager
    {
        public static event Action LanguageChanged;

        private static CultureInfo currentCulture = CultureInfo.CreateSpecificCulture("en");
        private static ResourceManager resourceManager = new ResourceManager("OOP2Projekt.Resources", typeof(LanguageManager).Assembly);

        public static CultureInfo CurrentCulture
        {
            get => currentCulture;
            private set
            {
                currentCulture = value;
                LanguageChanged?.Invoke();
            }
        }

        public static ResourceManager ResourceManager => resourceManager;

        public static void SetLanguage(string langCode)
        {
            CurrentCulture = CultureInfo.CreateSpecificCulture(langCode);
        }
    }
}
/*
 Objašnjenje koda

    public static event Action LanguageChanged;
        Definira događaj koji će se pokrenuti svaki put kad se jezik promijeni. Forme će se pretplatiti na ovaj događaj kako bi ažurirale svoje tekstove kad se jezik promijeni.

    private static CultureInfo currentCulture = CultureInfo.CreateSpecificCulture("en");
        Drži trenutnu jezičnu kulturu. Zadana vrijednost je engleski ("en").

    private static ResourceManager resourceManager = new ResourceManager("OOP2Projekt.Resources", typeof(LanguageManager).Assembly);
        Upravljanje resursima za dohvaćanje prijevoda iz resursnih datoteka.

    public static CultureInfo CurrentCulture
        Svojstvo koje omogućava dohvaćanje i postavljanje trenutne kulture. Kad se kultura postavi, pokreće se događaj LanguageChanged.

    public static ResourceManager ResourceManager => resourceManager;
        Svojstvo koje vraća upravitelj resursima za dohvaćanje prijevoda.

    public static void SetLanguage(string langCode)
        Metoda za postavljanje trenutne kulture. Kad se pozove, ažurira trenutnu kulturu i pokreće događaj LanguageChanged.
 */
