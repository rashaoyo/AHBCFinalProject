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
        const string ApiKey = "dc427c57ac7d4169bdb990b3893ebe80";
        private readonly IRecipeByIdStore _recipeByIdStore;

        public ComplexSearchStore(IRecipeByIdStore recipeByIdStore)
        {
            _recipeByIdStore = recipeByIdStore;
        }

        public async Task<ListOfRecipesResponse> GetRecipesComplexSearch(UserPreferenceDALModel userPreferenceDAL)
        {
            var seedRecipe = await GetSeedRecipe(userPreferenceDAL);
            var includeIngredients = ExtractThreeIngredients(seedRecipe);
            var weekOfRecipes = new ListOfRecipesResponse()
            {
                Results = new List<RecipeResponse>()
                {
                    seedRecipe
                }
            };

            using (var httpClient = new HttpClient { BaseAddress = new Uri("https://api.spoonacular.com") })
            {
                var apiResult = await httpClient.GetStringAsync($"/recipes/complexSearch?apiKey={ApiKey}&number=6&includeIngredients={includeIngredients}&fillIngredients=true&sort=random&diet={userPreferenceDAL.Diet}&intolerances={userPreferenceDAL.Intolerances}&excludeIngredients={userPreferenceDAL.ExcludedIngredients}&type='main course'&instructionsRequired=true");
                var sixRecipes = JsonConvert.DeserializeObject<ListOfRecipesResponse>(apiResult);

                foreach (var recipe in sixRecipes.Results)
                {
                    weekOfRecipes.Results.Add(recipe);
                }

                return weekOfRecipes;
            }
        }

        private async Task<RecipeResponse> GetSeedRecipe(UserPreferenceDALModel userPreferenceDAL)
        {
            using (var httpClient = new HttpClient { BaseAddress = new Uri("https://api.spoonacular.com/recipes/complexSearch") })
            {
                var result = await httpClient.GetStringAsync($"?apiKey={ApiKey}&fillIngredients=true&includeIngredients=&number=1&diet={userPreferenceDAL.Diet}&intolerances={userPreferenceDAL.Intolerances}&excludeIngredients={userPreferenceDAL.ExcludedIngredients}&type='main course'&instructionsRequired=true");
                var seedRecipe = JsonConvert.DeserializeObject<ListOfRecipesResponse>(result);

                var recipeId = seedRecipe.Results[0].id;
                return await _recipeByIdStore.GetRecipeResponseFromId(recipeId);
            }
        }

        private string ExtractThreeIngredients(RecipeResponse seedRecipe)
        {
            var extractedIngredients = new List<Extendedingredient>();
            var ingredientNames = new List<string>();
            int ingredientsCount = 0;

            foreach (var ingredient in seedRecipe.ExtendedIngredients)
            {
                if(ingredientsCount < 2 &&
                    (ingredient.Aisle.Contains("Pasta") ||
                    ingredient.Aisle.Contains("Produce") ||
                    ingredient.Aisle.Contains("Meat") ||
                    ingredient.Aisle.Contains("Seafood")))
                {
                    extractedIngredients.Add(ingredient);
                    ingredientsCount++;
                }
            }

            while(ingredientsCount < 2)
            {
                foreach (var ingredient in seedRecipe.ExtendedIngredients)
                {
                    if (!extractedIngredients.Contains(ingredient))
                    {
                        extractedIngredients.Add(ingredient);
                        ingredientsCount++;
                    }
                }
            }

            foreach (var ingredient in extractedIngredients)
            {
                ingredientNames.Add($"'{ingredient.Name}'");
            }

            return String.Join(",", ingredientNames);
        }
    }
}