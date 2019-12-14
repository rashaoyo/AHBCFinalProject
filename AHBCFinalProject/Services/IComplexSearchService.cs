using System;
using System.Threading.Tasks;
using AHBCFinalProject.DAL;
using AHBCFinalProject.Models;

namespace AHBCFinalProject.Services
{
    public interface IComplexSearchService
    {
        //Task<ListOfRecipesViewModel> GetWeekOfRecipes(UserPreferencesViewModel userPreferencesViewModel);
        RecipeViewModel ConvertRecipeResponseToVM(RecipeResponse recipeResponse);

    }
}