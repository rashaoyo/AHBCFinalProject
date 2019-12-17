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
        private readonly IRecipeByIdService _recipeByIdService;

        public RecipeController(IRecipeByIdService recipeByIdService)
        {
            _recipeByIdService = recipeByIdService;
        }
        
        public async Task<IActionResult> ViewRecipe(string id)
        {
            var viewModel = await _recipeByIdService.GetRecipeVMById(id);

            return View(viewModel);
        }
    }
}