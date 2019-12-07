using AHBCFinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AHBCFinalProject.Services
{
    public interface IFavoriteMealService
    {
        FavoriteMealViewModel InsertAFavoriteMeal(int recipeId);
        FavoriteMealViewModel DeleteAFavoriteMeal(int recipeId);
        FavoriteMealViewModel SelectAllFavoriteMeals();
        RecipeViewModel SelectAFavoriteMeal(int recipeId);
    }
}
