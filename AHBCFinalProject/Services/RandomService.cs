using AHBCFinalProject.Models;
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

        public async Task<RecipeViewModel> GetAllRandomRecipes()
        {
            var result = await _randomRecipeStore.GetAllRandomRecipes();

            var recipeViewModel = new RecipeViewModel
            {
                Recipes = result.Results.Select(randomRecipe =>
                new Recipe
                {
                    Name = randomRecipe.Name,
                })
            };
            return recipeViewModel;
        }
    }
}
