using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AHBCFinalProject.DAL;
using AHBCFinalProject.Models;
using AHBCFinalProject.Services;
using Microsoft.AspNetCore.Mvc;

namespace AHBCFinalProject.Controllers
{
    public class RecipeController : Controller
    {
        private readonly IMealPlanHistoryService _mealPlanHistoryService;
        private readonly IComplexSearchService _complexSearchService;
        private readonly IRecipeByIdService _recipeByIdService;
        private readonly IUserPreferenceService _userPreferenceService;
        private readonly IUserPreferenceStore _userPreferenceStore;

        public RecipeController(
            IMealPlanHistoryService mealPlanHistoryService,
            IComplexSearchService complexSearchService,
            IRecipeByIdService recipeByIdService,
            IUserPreferenceService userPreferenceService)
        {
            _mealPlanHistoryService = mealPlanHistoryService;
            _complexSearchService = complexSearchService;
            _recipeByIdService = recipeByIdService;
            _userPreferenceService = userPreferenceService;
        }

        //public async Task<IActionResult> ViewRecipes(UserPreferencesViewModel userPreferences)
        //{
        //    var viewModel = await _complexSearchService.GetWeekOfRecipes(userPreferences);
        //   _mealPlanHistoryService.AddMealPlanToHistory(viewModel);


        //    return View(viewModel);
        //}

        public async Task<IActionResult> ViewRecipe(string id)
        {
            var viewModel = await _recipeByIdService.GetRecipeVMById(id);

            return View(viewModel);
        }
    }
}