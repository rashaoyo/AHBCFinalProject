using System;
using System.Threading.Tasks;
using AHBCFinalProject.Models;

namespace AHBCFinalProject.Services
{
    public interface IComplexSearchService
    {
        Task<RecipeViewModel> GetSeedRecipeFromPreferences(UserPreferencesViewModel viewModel);
        Task<ListOfRecipesViewModel> GetWeekOfRecipesFromSeed(RecipeViewModel seedRecipe);
    }
}
