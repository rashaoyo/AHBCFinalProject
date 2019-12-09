using AHBCFinalProject.DAL;
using AHBCFinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AHBCFinalProject.Services
{
    public interface IUserPreferenceService
    {
        UserPreferencesViewModel GetUserPreferencesFromId();
        UserPreferenceDALModel GetUserDALFromViewModel(UserPreferencesViewModel viewModel);
        UpdateUserViewModel GetUpdatedPreferenceView();
        void CreateUserPreferences(UserPreferencesViewModel model);
        void UpdateUserPreferences(UserPreferencesViewModel model);
    }
}