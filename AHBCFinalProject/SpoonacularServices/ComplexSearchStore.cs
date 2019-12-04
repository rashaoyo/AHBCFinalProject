using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using AHBCFinalProject.DAL;
using AHBCFinalProject.Models;
using Newtonsoft.Json;

namespace AHBCFinalProject.SpoonacularServices
{
    public class ComplexSearchStore : IComplexSearchStore
    {
        const string ApiKey = "dc427c57ac7d4169bdb990b3893ebe80";

        public async Task<ListOfRecipesResponse> GetRecipesComplexSearch(User user, int number)
        {
            using(var httpClient = new HttpClient { BaseAddress = new Uri("https://api.spoonacular.com/recipes/complexSearch") })
            {
                var result = await httpClient.GetStringAsync($"apiKey={ApiKey}&number={number}&offset={user.Offset}&diet={user.Diet}&intolerances={user.Intolerances}&type='main course'&instructionsRequired=true");
                return JsonConvert.DeserializeObject<ListOfRecipesResponse>(result);
            }
        }
    }
}