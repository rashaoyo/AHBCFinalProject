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

        public async Task<ListOfRecipesResponse> GetRecipesComplexSearch(UserPreferenceDALModel userPreferenceDAL)
        {
            var seedRecipe = await GetSeedRecipe(userPreferenceDAL);
            var includeIngredients = ExtractThreeIngredients(seedRecipe);
            var weekOfRecipes = new ListOfRecipesResponse()
            {
                Recipes = new List<RecipeResponse>()
                {
                    seedRecipe
                }
            };

            using (var httpClient = new HttpClient { BaseAddress = new Uri("https://api.spoonacular.com/recipes/complexSearch") })
            {
                var apiResult = await httpClient.GetStringAsync($"?apiKey={ApiKey}&number=6&includeIngredients={includeIngredients}&fillIngredients=true&sort=random&diet={userPreferenceDAL.Diet}&intolerances={userPreferenceDAL.Intolerances}&excludeIngredients={userPreferenceDAL.ExcludedIngredients}&type='main course'&instructionsRequired=true");
                var sixRecipes = JsonConvert.DeserializeObject<ListOfRecipesResponse>(apiResult);

                foreach (var recipe in sixRecipes.Recipes)
                {
                    weekOfRecipes.Recipes.Add(recipe);
                }

                return weekOfRecipes;
            }
        }

        private async Task<RecipeResponse> GetSeedRecipe(UserPreferenceDALModel userPreferenceDAL)
        {
            using (var httpClient = new HttpClient { BaseAddress = new Uri("https://api.spoonacular.com/recipes/complexSearch") })
            {
                var result = await httpClient.GetStringAsync($"?apiKey={ApiKey}&number=1&diet={userPreferenceDAL.Diet}&intolerances={userPreferenceDAL.Intolerances}&excludeIngredients={userPreferenceDAL.ExcludedIngredients}&type='main course'&instructionsRequired=true");
                return JsonConvert.DeserializeObject<RecipeResponse>(result);
            }
        }

        private string ExtractThreeIngredients(RecipeResponse seedRecipe)
        {
            var extractedIngredients = new List<Extendedingredient>();
            var ingredientNames = new List<string>();
            int ingredientsCount = 0;

            while(ingredientsCount < 3)
            {
                foreach (var ingredient in seedRecipe.ExtendedIngredients)
                {
                    if(ingredient.Aisle.Contains("Pasta") ||
                        ingredient.Aisle.Contains("Produce") ||
                        ingredient.Aisle.Contains("Meat") ||
                        ingredient.Aisle.Contains("Seafood"))
                    {
                        extractedIngredients.Add(ingredient);
                        ingredientsCount++;
                    }
                }

                while(ingredientsCount < 3)
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
            }

            foreach (var ingredient in extractedIngredients)
            {
                ingredientNames.Add($"'{ingredient.Name}'");
            }

            return String.Join(",", ingredientNames);
        }
    }
}