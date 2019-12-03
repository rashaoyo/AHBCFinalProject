using AHBCFinalProject.Models;
using AHBCFinalProject.SpoonacularServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AHBCFinalProject.Services
{
    public class RandomService : IRandomService
    {
        private readonly IRandomRecipeStore _randomRecipeStore;

        public RandomService(IRandomRecipeStore randomRecipeStore)
        {
            _randomRecipeStore = randomRecipeStore ?? throw new ArgumentNullException(nameof(randomRecipeStore));
        }

        public async Task<ListOfRecipesViewModel> GetAllRandomRecipes()
        {
            var result = await _randomRecipeStore.GetRandomRecipes();

            var listOfRecipesViewModel = new ListOfRecipesViewModel();

            foreach(var recipe in result.Recipes)
            {
                var recipeViewModel = new RecipesViewModel
                {
                    Title = recipe.Title
                };

                listOfRecipesViewModel.ListOfRecipes.Add(recipeViewModel);
            }

            /*
            {
                Recipes = result.Results.Select(randomRecipe =>
                new Recipe
                {
                    Name = randomRecipe.Name,
                })
            };
            to be refactored
            */

            return listOfRecipesViewModel;
        }
    }
}
