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

        public UserController(IUserPreferenceService userPreferenceService)
        {
            _userPreferenceService = userPreferenceService;
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
    }
}