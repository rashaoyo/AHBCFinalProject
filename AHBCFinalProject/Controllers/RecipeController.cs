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
        public RecipeController(IRandomService randomService)
        {
            _randomService = randomService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> ViewRecipes(IRandomService _randomService)
        {
            //var viewModel = new ListOfRecipesViewModel();

            var viewModel = await _randomService.GetAllRandomRecipes();
        
            return View(viewModel);
        }


    }
}