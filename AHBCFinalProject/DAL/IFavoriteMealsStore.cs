using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AHBCFinalProject.DAL
{
    public interface IFavoriteMealsStore
    {
        IEnumerable<FavoriteMealDALModel> SelectAllFavMeals(int userId);
        IEnumerable<FavoriteMealDALModel> SelectAllFavMealsReadyIn1To2Hrs(int userId);
        IEnumerable<FavoriteMealDALModel> SelectAllFavMealsReadyIn30Min(int userId);
        IEnumerable<FavoriteMealDALModel> SelectAllFavMealsReadyIn1Hr(int userId);
        IEnumerable<FavoriteMealDALModel> SelectAllFavMealsReadyInMoreThan2Hrs(int userId);
        FavoriteMealDALModel SelectAFavMeal(string recipeId);
        bool InsertAFaveMeal(FavoriteMealDALModel dalModel);
        bool DeleteAFaveMeal(string recipeId);
        bool UpdateFavoriteMealComments(FavoriteMealDALModel dalModel);
    }
}

