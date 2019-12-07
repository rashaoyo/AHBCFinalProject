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
        public string userId { get; set; }

        public FavoriteMealService(IFavoriteMealsStore favoriteMealStore)
        {
            _favoriteMealStore = favoriteMealStore;
        }



        public void DeleteAFavoriteMeal(int recipeId)
        {
            _favoriteMealStore.DeleteAFaveMeal(recipeId);
        }

        public void InsertAFavoriteMeal(int recipeId, string comments, int userId)
        {
            var dalModel = new FavoriteMealDALModel
            {
                RecipeID = recipeId,
                AdditionalComments = comments,
                Id = userId
            };

            _favoriteMealStore.InsertAFaveMeal(dalModel);
        }

        public RecipeViewModel SelectAFavoriteMeal(int recipeId)
        {
            throw new NotImplementedException();
        }

        public FavoriteMealsViewModel SelectAllFavoriteMeals()
        {
            var allMeals = _favoriteMealStore.SelectAllFavMeals();
            var viewModel = new FavoriteMealsViewModel
            {
                FavoriteMeals = allMeals.ToList()
            };

            return (viewModel);
        }



    }
}
