using AHBCFinalProject.DAL;
using AHBCFinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AHBCFinalProject.Services
{
    public class UserPreferenceService: IUserPreferenceService
    {
        private readonly IUserPreferenceStore _userPreferenceStore;

        public UserPreferenceService(IUserPreferenceStore userPreferenceStore)
        {
            _userPreferenceStore = userPreferenceStore;
        }

        public UserPreferencesViewModel SetUserPreferences(SetUserPreferencesViewModel model)
        {
            var dalModel = new UserPreferenceDALModel
            {
                UserId = model.UserId,
                Diet = model.Diet,
                Intolerances = model.Intolerances
            };

            _userPreferenceStore.InsertUserPreferences(dalModel);

            var userPreferencesViewModel = new UserPreferencesViewModel
            {
                UserId = model.UserId,
                Diet = model.Diet,
                Intolerances = model.Intolerances
            };

            return userPreferencesViewModel;
        }

        public UserPreferencesViewModel ViewUserPreferences(int userId)
        {
            var dalModel = _userPreferenceStore.SelectUserPreferences(userId);

            var viewModel = new UserPreferencesViewModel
            {
                UserId = dalModel.UserId,
                Diet = dalModel.Diet,
                Intolerances = dalModel.Intolerances
            };

            return viewModel;
        }
    }
}
