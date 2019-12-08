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
        private readonly IRandomService _randomService;
        private readonly IMealPlanHistoryService _mealPlanHistoryService;
        private readonly IComplexSearchService _complexSearchService;

        public RecipeController(IRandomService randomService, IMealPlanHistoryService mealPlanHistoryService, IComplexSearchService complexSearchService)
        {
            _randomService = randomService;
            _mealPlanHistoryService = mealPlanHistoryService;
            _complexSearchService = complexSearchService;
        }

        public async Task<IActionResult> ViewRecipes()
        {
            //var viewModel = new ListOfRecipesViewModel();

            var viewModel = await _randomService.GetAllRandomRecipes();
                            
            return View(viewModel);
        }

        public async Task<IActionResult> ViewRecipe(int id)
        {
            //var viewModel = await _complexSearchService.ViewARecipe(id);  

            //return View(viewModel);
        }

    }
}