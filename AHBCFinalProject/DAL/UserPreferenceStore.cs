using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using AHBCFinalProject.Models;
using AHBCFinalProject.Services;
using Dapper;

namespace AHBCFinalProject.DAL
{
    public class UserPreferenceStore : IUserPreferenceStore
    {
        private readonly Database _config;
        private readonly IUserIdService _userIdService;

        public UserPreferenceStore(AHBCFinalProjectConfiguration config, IUserIdService userIdService)
        {
            _config = config.Database;
            _userIdService = userIdService;
        }

        public void CreateNewUserPrefEntry(int id)
        {
            var dalModel = new UserPreferenceDALModel();
            dalModel.UserId = id;
            var sql = $@"INSERT INTO DietaryRestrictions (Id, Diet, Intolerances, ExcludedIngredients) 
                            VALUES (@{nameof(dalModel.UserId)}, @{nameof(dalModel.Diet)}, @{nameof(dalModel.Intolerances)}, @{nameof(dalModel.ExcludedIngredients)})";

            using (var connection = new SqlConnection(_config.ConnectionString))
            {
                var results = connection.Execute(sql, dalModel);
                
            }
        }

        public bool InsertUserPreferences(UserPreferenceDALModel dalModel)
        {
            var sql = $@"INSERT INTO DietaryRestrictions (Id, Diet, Intolerances, ExcludedIngredients) 
                            VALUES (@{nameof(dalModel.UserId)}, @{nameof(dalModel.Diet)}, @{nameof(dalModel.Intolerances)}, @{nameof(dalModel.ExcludedIngredients)})";

            using (var connection = new SqlConnection(_config.ConnectionString))
            {
                var results = connection.Execute(sql, dalModel);

                return true;
            }    
        }

        public UserPreferenceDALModel SelectUserPreferences()
        {
            var userId = _userIdService.UserId;
            var sql = $@"SELECT * FROM DietaryRestrictions WHERE Id = {userId}";

            using (var connection = new SqlConnection(_config.ConnectionString))
            {
                var results = connection.QueryFirstOrDefault<UserPreferenceDALModel>(sql, new { Id = userId });
                return results;
            }
        }

        public bool UpdateUserPreferences(UserPreferenceDALModel dalModel)
        {
            var UserId = _userIdService.UserId;
            var sql = $@"UPDATE DietaryRestrictions SET Diet = {nameof(dalModel.Diet)}, Intolerances = {nameof(dalModel.Intolerances)}, ExcludedIngredients = {nameof(dalModel.ExcludedIngredients)} WHERE Id = {UserId}";

            using (var connection = new SqlConnection(_config.ConnectionString))
            {
                var result = connection.Execute(sql, dalModel);
                return true;
            }
        }
    }
}