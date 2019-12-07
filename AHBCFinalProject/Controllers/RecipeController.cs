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

        public RecipeController(IRandomService randomService, IMealPlanHistoryService mealPlanHistoryService)
        {
            _randomService = randomService;
            _mealPlanHistoryService = mealPlanHistoryService;

        }

        public async Task<IActionResult> ViewRecipes()
        {
            //var viewModel = new ListOfRecipesViewModel();

            var viewModel = await _randomService.GetAllRandomRecipes();
                            
            return View(viewModel);
        }



    }
}