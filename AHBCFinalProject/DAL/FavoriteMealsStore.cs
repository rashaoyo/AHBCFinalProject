using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
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
            throw new NotImplementedException();
        }

        public bool InsertAFaveMeal(FavoriteMealDALModel dalModel)
        {
            throw new NotImplementedException();
        }

        public FavoriteMealDALModel SelectAFavMeal(int recipeId)
        {
            throw new NotImplementedException();
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
