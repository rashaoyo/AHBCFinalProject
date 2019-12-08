using AHBCFinalProject.DAL;
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
        private readonly IMealPlanHistoryService _mealPlanHistoryService;

        public RandomService(IRandomRecipeStore randomRecipeStore, IMealPlanHistoryService mealPlanHistoryService)
        {
            _randomRecipeStore = randomRecipeStore ?? throw new ArgumentNullException(nameof(randomRecipeStore));
            _mealPlanHistoryService = mealPlanHistoryService;
        }

        public async Task<ListOfRecipesViewModel> GetAllRandomRecipes()
        {
            var result = await _randomRecipeStore.GetRandomRecipes();

            var listOfRecipesViewModel = new ListOfRecipesViewModel
            {
               // ListOfRecipes = new List<RecipesViewModel>()

            };


            foreach (var recipe in result.Recipes)
            {               
                var recipeViewModel = new RecipesViewModel
                {
                    Title = recipe.Title
                };

               // listOfRecipesViewModel.ListOfRecipes.Add(recipeViewModel);
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
