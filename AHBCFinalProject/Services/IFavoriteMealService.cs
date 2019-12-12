using AHBCFinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AHBCFinalProject.Services
{
    public interface IFavoriteMealService
    {
        Task<FavoriteMealsViewModel> InsertAFavoriteMeal(string recipeId);
        FavoriteMealsViewModel DeleteAFavoriteMeal(string recipeId);
        FavoriteMealsViewModel SelectAllFavoriteMeals();
        Task<ViewFavoriteMealViewModel> SelectAFavoriteMeal(string recipeId);
        Task<ViewFavoriteMealViewModel> UpdateFavoriteMealComments(ViewFavoriteMealViewModel model);


    }
}
