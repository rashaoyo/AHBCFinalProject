using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using AHBCFinalProject.Models;
using Dapper;

namespace AHBCFinalProject.DAL
{
    public class UserPreferenceStore : IUserPreferenceStore
    {
        private readonly Database _config;

        public UserPreferenceStore(AHBCFinalProjectConfiguration config)
        {
            _config = config.Database;
        }

        public bool InsertUserPreferences(UserPreferenceDALModel dalModel)
        {
            var sql = $@"INSERT INTO DietaryRestrictions (Id, Diet, Intolerances, ExcludedIngredients) 
                            VALUES (3, @{nameof(dalModel.Diet)}, @{nameof(dalModel.Intolerances)}, @{nameof(dalModel.ExcludedIngredients)})";

            using (var connection = new SqlConnection(_config.ConnectionString))
            {
                var results = connection.Execute(sql, dalModel);

                return true;
            }    
        }

        public UserPreferenceDALModel SelectUserPreferences(int userId)
        {
            var temp = 3;
            var sql = @"SELECT * FROM DietaryRestrictions WHERE Id = 3";

            using (var connection = new SqlConnection(_config.ConnectionString))
            {
                var results = connection.QueryFirstOrDefault<UserPreferenceDALModel>(sql, new { Id = temp });
                return results;
            }
        }

        public bool UpdateUserPreferences(UserPreferenceDALModel dalModel)
        {
            var sql = $@"UPDATE DietaryRestrictions SET Diet = @{nameof(dalModel.Diet)}, Intolerances = @{nameof(dalModel.Intolerances)}, ExcludedIngredients = @{nameof(dalModel.ExcludedIngredients)} WHERE UserId = @UserId";

            using (var connection = new SqlConnection(_config.ConnectionString))
            {
                var result = connection.Execute(sql, dalModel);
                return true;
            }
        }
    }
}