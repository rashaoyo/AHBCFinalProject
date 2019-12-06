using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AHBCFinalProject.DAL;
using AHBCFinalProject.Models;

namespace AHBCFinalProject.Services
{
    public class FavoriteMealService : IFavoriteMealService
    {
        private readonly IFavoriteMealsStore _favoriteMealStore; 
        public FavoriteMealService(IFavoriteMealsStore favoriteMealStore)
        {
            _favoriteMealStore = favoriteMealStore;
        }

        public FavoriteMealViewModel DeleteAFavoriteMeal(int recipeId)
        {
        
            throw new NotImplementedException();
        }

        public FavoriteMealViewModel InsertAFavoriteMeal(int recipeId)
        {
            throw new NotImplementedException();
        }

        public RecipeViewModel SelectAFavoriteMeal(int recipeId)
        {
            throw new NotImplementedException();
        }

        public FavoriteMealViewModel SelectAllFavoriteMeals()
        {
            throw new NotImplementedException();
        }
    }
}
