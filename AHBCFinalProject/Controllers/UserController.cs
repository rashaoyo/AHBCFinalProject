using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AHBCFinalProject.Models;
using AHBCFinalProject.Services;
using Microsoft.AspNetCore.Mvc;

namespace AHBCFinalProject.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserPreferenceService _userPreferenceService;
        private readonly IMealPlanHistoryService _mealPlanHistoryService;
        private readonly IFavoriteMealService _FavoriteMealService;

        public UserController(IUserPreferenceService userPreferenceService, IMealPlanHistoryService mealPlanHistoryService, IFavoriteMealService favoriteMealService)
        {
            _userPreferenceService = userPreferenceService;
            _mealPlanHistoryService = mealPlanHistoryService;
            _FavoriteMealService = favoriteMealService;
        }

        public IActionResult ViewUserPreferences(int userId)
        {
            var result = _userPreferenceService.GetUserPreferencesFromId(userId);
            return View(result);
        }

        public IActionResult SetUserPreferences(UserPreferencesViewModel model)
        {
            _userPreferenceService.CreateUserPreferences(model);
            var result = _userPreferenceService.GetUserPreferencesFromId(model.UserId);
            return View(result);
        }

        public IActionResult SearchMealPlanHistory()
        {
            return View();
        }

        public IActionResult ViewMealPlanResults(ViewMealPlanViewModel model)
        {
            var result = _mealPlanHistoryService.ViewMealPlanHistory(model);
            return View(result);
        }



        public IActionResult UpdatePreference(int userId)
        {
            var model = _userPreferenceService.GetUpdatedPreferenceView(userId);
            return View(model);
        }

        public IActionResult UpdatePreferenceResult(UpdateUserViewModel model)
        {
            var newModel = _userPreferenceService.EditPreference(model);
            return View("ViewUserPreferences", newModel);
        }

        public IActionResult FavoriteMealsView()
        {
            var viewModel = _FavoriteMealService.SelectAllFavoriteMeals();
            return View();
        }


    }
}