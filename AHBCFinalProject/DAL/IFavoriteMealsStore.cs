using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AHBCFinalProject.DAL
{
    public interface IFavoriteMealsStore
    {
        IEnumerable<FavoriteMealDALModel> SelectAllFavMeals(int userId);
        FavoriteMealDALModel SelectAFavMeal(string recipeId);
        bool InsertAFaveMeal(FavoriteMealDALModel dalModel);
        bool DeleteAFaveMeal(int recipeId);
        bool UpdateFavoriteMealComments(FavoriteMealDALModel dalModel);
    }
}
