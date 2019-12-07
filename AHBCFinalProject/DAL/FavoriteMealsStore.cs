using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace AHBCFinalProject.DAL
{
    public class FavoriteMealsStore: IFavoriteMealsStore
    {
        private readonly Database _config;

        public FavoriteMealsStore(AHBCFinalProjectConfiguration config)
        {
            _config = config.Database;
        }

        public bool DeleteAFaveMeal(int recipeId)
        {
            var sql = @"delete from FavoriteMeals where recipeId = @recipeId";

            using (var connection = new SqlConnection(_config.ConnectionString))
            {
                var result = connection.Execute(sql, new { recipeId = recipeId });
                return true;
            }
        }

        public bool InsertAFaveMeal(FavoriteMealDALModel dalModel)
        {
            var sql = $@"INSERT INTO FavoriteMeals (Id, RecipeID, AdditionalComments) 
                            VALUES (@{nameof(dalModel.Id)}, @{nameof(dalModel.RecipeID)},@{nameof(dalModel.AdditionalComments)}";

            using (var connection = new SqlConnection(_config.ConnectionString))
            {
                var results = connection.Execute(sql, dalModel);

                return true;
            }
        }

        public FavoriteMealDALModel SelectAFavMeal(int recipeId)
        {
            var sql = @"select * from FavoriteMeals where recipeId = @recipeId";

            using (var connection = new SqlConnection(_config.ConnectionString))
            {
                var result = connection.QueryFirstOrDefault<FavoriteMealDALModel>(sql, new { recipeId = recipeId });
                return result;
            }
        }

        public IEnumerable<FavoriteMealDALModel> SelectAllFavMeals()
        {
            var sql = @"SELECT * FROM FavoriteMeals WHERE  ORDER BY ProductName ASC";

            using (var connection = new SqlConnection(_config.ConnectionString))   
            {
                var results = connection.Query<FavoriteMealDALModel>(sql) ?? new List<FavoriteMealDALModel>();
                return results;

            }
        }

        
    }
}
