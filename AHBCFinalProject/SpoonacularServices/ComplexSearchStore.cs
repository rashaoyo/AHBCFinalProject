using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using AHBCFinalProject.DAL;
using AHBCFinalProject.Models;
using AHBCFinalProject.Services;
using Newtonsoft.Json;

namespace AHBCFinalProject.SpoonacularServices
{
    public class ComplexSearchStore : IComplexSearchStore
    {
        const string ApiKey = "c07baad9b40d44dd9d700eb4928a1970";

        private readonly IUserPreferenceStore _userPreferenceStore;
        private readonly IUserIdService _userIdService;

        public ComplexSearchStore(IUserPreferenceStore userPreferenceStore, IUserIdService userIdService)
        {
            _userPreferenceStore = userPreferenceStore;
            _userIdService = userIdService;
        }

        public async Task<ListOfRecipesResponse> GetRecipesComplexSearch()
        {
            var id = _userIdService.getUserId();
            var userPreferenceDAL = _userPreferenceStore.SelectUserPreferences(id);
            var weekOfRecipes = new ListOfRecipesResponse()
            {
                Results = new List<RecipeResponse>()
            };

            using (var httpClient = new HttpClient { BaseAddress = new Uri("https://api.spoonacular.com/recipes/complexSearch") })
            {

                var apiResult = await httpClient.GetStringAsync($"?apiKey={ApiKey}&number=7&sort=random&diet={userPreferenceDAL.Diet}&intolerances={userPreferenceDAL.Intolerances}&excludeIngredients={userPreferenceDAL.ExcludedIngredients}&type='main course'&instructionsRequired=true");

                var sevenRecipes = JsonConvert.DeserializeObject<ListOfRecipesResponse>(apiResult);

                foreach (var recipe in sevenRecipes.Results)
                {
                    weekOfRecipes.Results.Add(recipe);
                }

                return weekOfRecipes;
            }
        }
    }
}