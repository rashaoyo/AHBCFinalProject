using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AHBCFinalProject.Models;
using AHBCFinalProject.Services;
using AHBCFinalProject.DAL;
using Microsoft.AspNetCore.Mvc;

namespace AHBCFinalProject.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserPreferenceService _userPreferenceService;
        private readonly IMealPlanHistoryService _mealPlanHistoryService;
        private readonly IFavoriteMealService _FavoriteMealService;
        private readonly IUserPreferenceStore _userPreferenceStore;

        public UserController(IUserPreferenceService userPreferenceService,
            IMealPlanHistoryService mealPlanHistoryService,
            IFavoriteMealService favoriteMealService,
            IUserPreferenceStore userPreferenceStore)
        {
            _userPreferenceService = userPreferenceService;
            _mealPlanHistoryService = mealPlanHistoryService;
            _FavoriteMealService = favoriteMealService;
            _userPreferenceStore = userPreferenceStore;
        }
             

        public async Task<IActionResult> CreateUserPreferencesTable()
        {
            await _userPreferenceStore.CreateNewUserPrefEntry();
            return RedirectToAction(nameof(SetUserPreferences), "User");
            
        }

        public async Task<IActionResult> SetUserPreferences()
        {
            return View();
        }
        
        public IActionResult UpdateUserPreferences(UserPreferencesViewModel model)
        {
            _userPreferenceService.SetUserPreferences(model);
            return View("ConfirmUserPreferences", model);
        }

        public IActionResult ConfirmUserPreferences(UserPreferencesViewModel model)
        {
            return View(model);
        }

        public IActionResult SearchMealPlanHistory()
        {
            return View();
        }

        public async Task<IActionResult> ViewCurrentMealPlan()
        {
            var viewModel = await _mealPlanHistoryService.ViewCurrentMealPlan();
            return View("ViewMealPlanResults", viewModel);
        }
        
        public async Task<IActionResult> ViewMealPlanResults(ViewMealPlanViewModel model)
        {
            try
            {
                var result = await _mealPlanHistoryService.ViewMealPlanHistory(model);
                return View(result);
            }
            catch (Exception)
            {
                Response.StatusCode = 400;
                return View("Error");
            }
        }



        public IActionResult UpdatePreference()
        {
            var model = _userPreferenceService.GetUpdatedPreferenceView();
            return View(model);
        }

        public IActionResult FavoriteMealsView()
        {
            var viewModel = _FavoriteMealService.SelectAllFavoriteMeals();
            return View(viewModel);
        }

        public async Task<IActionResult> AddToFavorites(string id)   
        {
            var viewMealPlanResults = await _FavoriteMealService.InsertAFavoriteMeal(id);
            return View(nameof(FavoriteMealsView), viewMealPlanResults);
        }

        public async Task<IActionResult> ViewFavoriteMeal(string id)
        {
            var viewModel = await _FavoriteMealService.SelectAFavoriteMeal(id);
            return View(viewModel);
        }

        public async Task<IActionResult> UpdateFavoriteMeal(string id)
        {
            var viewModel = await _FavoriteMealService.SelectAFavoriteMeal(id);
            return View(viewModel);
        }

        public async Task<IActionResult> UpdateFavoriteMealResults(ViewFavoriteMealViewModel model)
        {
            var viewModel = await _FavoriteMealService.UpdateFavoriteMealComments(model);
            return View(viewModel);
        }

        public IActionResult DeleteFavoriteMeal(string id)
        {
            var viewModel = _FavoriteMealService.DeleteAFavoriteMeal(id);
            return View(viewModel);
        }

        public IActionResult FMReadyIn1To2Hrs()
        {
            var viewModel = _FavoriteMealService.FMReadyIn1To2Hrs();
            return View("FavoriteMealsView", viewModel);
        }

        public IActionResult FMReadyIn30Min()
        {
            var viewModel = _FavoriteMealService.FMReadyIn30Min();
            return View("FavoriteMealsView", viewModel);
        }

        public IActionResult FMReadyIn1Hrs()
        {
            var viewModel = _FavoriteMealService.FMReadyIn1Hrs();
            return View("FavoriteMealsView", viewModel);
        }

        public IActionResult FMReadyInMoreThan2Hrs()
        {
            var viewModel = _FavoriteMealService.FMReadyInMoreThan2Hrs();
            return View("FavoriteMealsView", viewModel);
        }
    }   
}