using System;
using System.Threading.Tasks;
using AHBCFinalProject.Models;
using AHBCFinalProject.SpoonacularServices;

namespace AHBCFinalProject.Services
{
    public class RecipeByIdService : IRecipeByIdService
    {
        private IRecipeByIdStore _recipeByIdStore;
        private IComplexSearchService _complexSearchService;

        public RecipeByIdService(IRecipeByIdStore recipeByIdStore, IComplexSearchService complexSearchService)
        {
            _recipeByIdStore = recipeByIdStore;
            _complexSearchService = complexSearchService;
        }

        public async Task<RecipeViewModel> GetRecipeVMById(string recipeId)
        {
            var recipeResponse = await _recipeByIdStore.GetRecipeResponseFromId(recipeId);
            var recipeViewModel = _complexSearchService.ConvertRecipeResponseToVM(recipeResponse);
            return recipeViewModel;
        }
    }
}
