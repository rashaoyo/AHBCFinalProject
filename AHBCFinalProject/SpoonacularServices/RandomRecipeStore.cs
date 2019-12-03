using System;
using System.Net.Http;
using System.Threading.Tasks;
using AHBCFinalProject.Models;
using Newtonsoft.Json;

namespace AHBCFinalProject.SpoonacularServices
{
    public class RandomRecipeStore : IRandomRecipeStore
    {
        const string ApiKey = "dc427c57ac7d4169bdb990b3893ebe80";

        public async Task<ListOfRecipesResponse> GetRandomRecipe()
        {
            using(var httpClient = new HttpClient { BaseAddress = new Uri("https://api.spoonacular.com/recipes/random") })
            {
                var result = await httpClient.GetStringAsync($"?number=7&apiKey={ApiKey}");
                return JsonConvert.DeserializeObject<ListOfRecipesResponse>(result);
            }
        }
    }
}