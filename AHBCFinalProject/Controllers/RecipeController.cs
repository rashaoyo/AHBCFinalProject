using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AHBCFinalProject.Models;
using AHBCFinalProject.Services;
using Microsoft.AspNetCore.Mvc;

namespace AHBCFinalProject.Controllers
{
    public class RecipeController : Controller
    {
        private readonly IMealPlanHistoryService _mealPlanHistoryService;
        private readonly IComplexSearchService _complexSearchService;

        public RecipeController(IMealPlanHistoryService mealPlanHistoryService, IComplexSearchService complexSearchService)
        {
            _mealPlanHistoryService = mealPlanHistoryService;
            _complexSearchService = complexSearchService;
        }

        public async Task<IActionResult> ViewRecipes(UserPreferencesViewModel userPreferences)
        {
            var viewModel = await _complexSearchService.GetWeekOfRecipes(userPreferences);
                            
            return View(viewModel);
        }


        public async Task<IActionResult> ViewRecipe(int id)
        {
            //var viewModel = await _complexSearchService.ViewARecipe(id);  

            return View();
        }

    }

}