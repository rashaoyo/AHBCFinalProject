using System;
using System.Threading.Tasks;
using AHBCFinalProject.DAL;
using AHBCFinalProject.Models;

namespace AHBCFinalProject.Services
{
    public interface IComplexSearchService
    {
        Task<ListOfRecipesViewModel> GetWeekOfRecipes();
        RecipeViewModel ConvertRecipeResponseToVM(RecipeResponse recipeResponse);
    }
}