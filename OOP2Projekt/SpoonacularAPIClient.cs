using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using OOP2Projekt;

public class SpoonacularAPIClient
{
    private string _apiKey = "c0647e3ca34e44f6b1f5a4cc75ae9f72";
    private HttpClient _httpClient;

    public SpoonacularAPIClient()
    {
        _httpClient = new HttpClient();
    }

    public async Task<MealPlanResponse> GetMealPlan()
    {
        string requestUrl = $"https://api.spoonacular.com/mealplanner/generate?timeFrame=day&apiKey={_apiKey}";

        try
        {
            HttpResponseMessage response = await _httpClient.GetAsync(requestUrl);

            if (response.IsSuccessStatusCode)
            {
                string responseData = await response.Content.ReadAsStringAsync();
                MealPlanResponse mealPlan = JsonConvert.DeserializeObject<MealPlanResponse>(responseData);
                return mealPlan;
            }
            else
            {
                throw new Exception($"Greška prilikom dohvaćanja plana prehrane: {response.ReasonPhrase}");
            }
        }
        catch (Exception ex)
        {
            throw new Exception($"Došlo je do greške prilikom preuzimanja podataka: {ex.Message}");
        }
    }
}