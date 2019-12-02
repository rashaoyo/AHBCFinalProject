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
                httpClient.DefaultRequestHeaders.Add("x-rapidapi-key", "a20e2189eamsh62909a90994a81ep16f226jsn158ad197afec");

                var result = await httpClient.GetStringAsync("recipes/random/?number=7");
                return JsonConvert.DeserializeObject<ListOfRecipesResponse>(result);
            }
        }
    }
}