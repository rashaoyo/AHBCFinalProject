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
        

        private readonly IUserIdService _userIdService;

        public UserController(IUserPreferenceService userPreferenceService,
            IMealPlanHistoryService mealPlanHistoryService,
            IFavoriteMealService favoriteMealService,
            IUserPreferenceStore userPreferenceStore,
            IUserIdService userIdService)
        {
            _userPreferenceService = userPreferenceService;
            _mealPlanHistoryService = mealPlanHistoryService;
            _FavoriteMealService = favoriteMealService;
            _userPreferenceStore = userPreferenceStore;
            _userIdService = userIdService;
        }

        public IActionResult ViewUserPreferences(UserPreferencesViewModel viewModel)
        {
            var result = _userPreferenceService.GetUserPreferencesFromId();
            return View(result);
        }

        public IActionResult SetUserPreferences()
        {
            return View();
        }

        public IActionResult CreateUserPreferences(UserPreferencesViewModel model)
        {
            var dalModel = _userPreferenceService.GetUserDALFromViewModel(model);
            _userPreferenceService.UpdateUserPreferences(model);
            var result = _userPreferenceService.GetUserPreferencesFromId();

            return View(nameof(ViewUserPreferences), result);
        }

        public IActionResult SearchMealPlanHistory()
        {
            return View();
        }

        public async Task<IActionResult> ViewMealPlanResults(ViewMealPlanViewModel model)
        {
            var result = await _mealPlanHistoryService.ViewMealPlanHistory(model);
            return View(result);
        }



        public IActionResult UpdatePreference(/*int userId*/)
        {
            var model = _userPreferenceService.GetUpdatedPreferenceView();
            return View(model);
        }

        /*
        public IActionResult UpdatePreferenceResult(UpdateUserViewModel model)
        {
            var newModel = _userPreferenceService.EditPreference(model);
            return View("ViewUserPreferences", newModel);
        }
        */

        public IActionResult AddToFavoritesResults(FavoriteMealsViewModel model)
        {
            return View(model);
        }

        public IActionResult FavoriteMealsView()
        {
            var viewModel = _FavoriteMealService.SelectAllFavoriteMeals();
            return View();
        }

        public async Task<IActionResult> AddToFavorites(string id)   
        {
            var viewMealPlanResults = await _FavoriteMealService.InsertAFavoriteMeal(id);
            return View(viewMealPlanResults);
        }

        public async Task<IActionResult> ViewFavoriteMeal(string id)
        {
            var viewModel = await _FavoriteMealService.SelectAFavoriteMeal(id);
            return View(viewModel);
        }
        

    }
}