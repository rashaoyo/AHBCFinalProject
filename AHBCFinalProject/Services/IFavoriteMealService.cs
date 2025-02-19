﻿using AHBCFinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AHBCFinalProject.Services
{
    public interface IFavoriteMealService
    {
        Task<FavoriteMealsViewModel> InsertAFavoriteMeal(string recipeId);
        void DeleteAFavoriteMeal(int recipeId);
        FavoriteMealsViewModel SelectAllFavoriteMeals();
        RecipeViewModel SelectAFavoriteMeal(int recipeId);

    }
}
