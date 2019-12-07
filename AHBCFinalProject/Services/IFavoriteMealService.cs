using AHBCFinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AHBCFinalProject.Services
{
    public interface IFavoriteMealService
    {
        void InsertAFavoriteMeal(int recipeId, string comments, int userId);
        void DeleteAFavoriteMeal(int recipeId);
        FavoriteMealsViewModel SelectAllFavoriteMeals();
        RecipeViewModel SelectAFavoriteMeal(int recipeId);
    }
}
