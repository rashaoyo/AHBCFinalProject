using System;
using System.Net.Http;
using System.Threading.Tasks;
using AHBCFinalProject.DAL;
using AHBCFinalProject.Models;
using Newtonsoft.Json;

namespace AHBCFinalProject.SpoonacularServices
{
    public class RecipeByIdStore : IRecipeByIdStore
    {
        private string apiKey = "c07baad9b40d44dd9d700eb4928a1970";

        public async Task<RecipeResponse> GetRecipeResponseFromId(string recipeId)
        {
            using(var httpClient = new HttpClient { BaseAddress = new Uri("https://api.spoonacular.com/recipes/") })
            {
                var result = await httpClient.GetStringAsync($"{recipeId}/information?apiKey={apiKey}");
                return JsonConvert.DeserializeObject<RecipeResponse>(result);
            }
        }

       
    }
}