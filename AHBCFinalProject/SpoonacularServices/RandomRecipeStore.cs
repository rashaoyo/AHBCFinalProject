using System;
using System.Net.Http;
using System.Threading.Tasks;
using AHBCFinalProject.Models;
using Newtonsoft.Json;

namespace AHBCFinalProject.SpoonacularServices
{
    public class RandomRecipeStore : IRandomRecipeStore
    {
        public async Task<ListOfRecipesResponse> GetRandomRecipe()
        {
            using(var httpClient = new HttpClient { BaseAddress = new Uri("spoonacular-recipe-food-nutrition-v1.p.rapidapi.com/") })
            {
                httpClient.DefaultRequestHeaders.Add("x-rapidapi-host", "spoonacular-recipe-food-nutrition-v1.p.rapidapi.com");
                httpClient.DefaultRequestHeaders.Add("x-rapidapi-key", "dc427c57ac7d4169bdb990b3893ebe80");

                var result = await httpClient.GetStringAsync("recipes/random/?number=7");
                return JsonConvert.DeserializeObject<ListOfRecipesResponse>(result);
            }
        }
    }
}