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
        UserPreferencesViewModel GetUserPreferencesFromId(int userId);
        UserPreferenceDALModel GetUserDALFromViewModel(UserPreferencesViewModel viewModel);
        UpdateUserViewModel GetUpdatedPreferenceView(int userId);
        void CreateUserPreferences(UserPreferencesViewModel model);
    }
}