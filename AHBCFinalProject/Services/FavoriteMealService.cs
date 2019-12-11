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
        private readonly IUserIdService _userIdService;
        private readonly IRecipeByIdService _recipeByIdService;

        //public string userId { get; set; }

        public FavoriteMealService(IFavoriteMealsStore favoriteMealStore, IUserIdService userIdService, IRecipeByIdService recipeByIdService)
        {
            _favoriteMealStore = favoriteMealStore;
            _userIdService = userIdService;
            _recipeByIdService = recipeByIdService;

        }

        public void DeleteAFavoriteMeal(int recipeId)
        {
            _favoriteMealStore.DeleteAFaveMeal(recipeId);
        }

        public async Task<FavoriteMealsViewModel> InsertAFavoriteMeal(string recipeId)
        {
            var recipeInfo = await _recipeByIdService.GetRecipeVMById(recipeId);

            var dalModel = new FavoriteMealDALModel
            {
                Id = _userIdService.UserId,
                RecipeID = recipeInfo.Id,
                MealName = recipeInfo.Title
                
            };

            _favoriteMealStore.InsertAFaveMeal(dalModel);

            var dalViewAllFavMeals =_favoriteMealStore.SelectAllFavMeals(dalModel.Id);
            var favMeals = new List<FavoriteMealViewModel>();

            foreach (var dalMeal in dalViewAllFavMeals)
            {
                var favMeal = new FavoriteMealViewModel
                {
                    Id = dalMeal.Id,
                    RecipeID = dalMeal.RecipeID,
                    MealName = dalMeal.MealName,
                    AdditionalComments = dalMeal.AdditionalComments                    
                };

                favMeals.Add(favMeal);
            }

            var favMealsViewModel = new FavoriteMealsViewModel();
            favMealsViewModel.FavoriteMeals = favMeals;
            return favMealsViewModel;
        }

        public RecipeViewModel SelectAFavoriteMeal(int recipeId)
        {
            throw new NotImplementedException();
        }

        public FavoriteMealsViewModel SelectAllFavoriteMeals()
        {
            var allMeals = _favoriteMealStore.SelectAllFavMeals(_userIdService.UserId);
            var favMeals = new List<FavoriteMealViewModel>();

            foreach (var dalMeal in allMeals)
            {
                var favMeal = new FavoriteMealViewModel
                {
                    Id = dalMeal.Id,
                    RecipeID = dalMeal.RecipeID,
                    MealName = dalMeal.MealName,
                    AdditionalComments = dalMeal.AdditionalComments
                };
            }

            var favMealsViewModel = new FavoriteMealsViewModel();
            favMealsViewModel.FavoriteMeals = favMeals;
            return favMealsViewModel;
        }



    }
}
