using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AHBCFinalProject.DAL
{
    public interface IFavoriteMealsStore
    {
        IEnumerable<FavoriteMealDALModel> SelectAllFavMeals();
        //IEnumerable<FavoriteMealDALModel> SelectAllFavMealsReadyIn1To2Hrs();
        //IEnumerable<FavoriteMealDALModel> SelectAllFavMealsReadyIn30Min();
        //IEnumerable<FavoriteMealDALModel> SelectAllFavMealsReadyIn1Hr();
        //IEnumerable<FavoriteMealDALModel> SelectAllFavMealsReadyInMoreThan2Hrs();
        FavoriteMealDALModel SelectAFavMeal(string recipeId);
        bool InsertAFaveMeal(FavoriteMealDALModel dalModel);
        bool DeleteAFaveMeal(string recipeId);
        bool UpdateFavoriteMealComments(FavoriteMealDALModel dalModel);
    }
}

