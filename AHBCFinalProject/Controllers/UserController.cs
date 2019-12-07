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

        public UserController(IUserPreferenceService userPreferenceService, IMealPlanHistoryService mealPlanHistoryService)
        {
            _userPreferenceService = userPreferenceService;
            _mealPlanHistoryService = mealPlanHistoryService;
        }

        public IActionResult ViewUserPreferences(int userId)
        {
            var result = _userPreferenceService.GetUserPreferencesFromId(userId);
            return View(result);
        }

        public IActionResult SetUserPreferences(UserPreferencesViewModel model)
        {
            _userPreferenceService.CreateUserPreferences(model);
            return View();
        }

        public IActionResult SearchMealPlanHistory()
        {
            return View();
        }

        public IActionResult ViewMealPlanResults(ViewMealPlanViewModel model)
        {
            var result = _mealPlanHistoryService.ViewMealPlan(model);
            return View("ViewMealPlanResults", result);
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


    }
}