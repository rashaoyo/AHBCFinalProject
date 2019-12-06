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
        void CreateUserPreferences(UserPreferencesViewModel model);
        UserPreferenceDALModel GetUserDALFromViewModel(UserPreferencesViewModel viewModel);
    }
}
