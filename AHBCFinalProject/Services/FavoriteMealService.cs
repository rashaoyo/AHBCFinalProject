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

        public FavoriteMealsViewModel DeleteAFavoriteMeal(string recipeId)
        {
            _favoriteMealStore.DeleteAFaveMeal(recipeId);

            var dalViewAllFavMeals = _favoriteMealStore.SelectAllFavMeals(_userIdService.UserId);
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
            return MapFavMealDALtoView(dalModel);
        }

        
        public async Task<ViewFavoriteMealViewModel> SelectAFavoriteMeal(string id)
        {
            var recipeInfo = await _recipeByIdService.GetRecipeVMById(id);

            var favMealInfo = _favoriteMealStore.SelectAFavMeal(id);

            var viewFavoriteMealViewModel = new ViewFavoriteMealViewModel
            {
                Id = recipeInfo.Id,
                Title = recipeInfo.Title,
                Image = recipeInfo.Image,
                Servings = recipeInfo.Servings,
                HealthScore = recipeInfo.HealthScore,
                Instructions = recipeInfo.Instructions,
                ExtendedIngredients = recipeInfo.ExtendedIngredients,
                AdditionalComments = favMealInfo.AdditionalComments
            };

            return viewFavoriteMealViewModel;

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
                favMeals.Add(favMeal);

            }

            var favMealsViewModel = new FavoriteMealsViewModel();
            favMealsViewModel.FavoriteMeals = favMeals;
            return favMealsViewModel;
        }

        public async Task<ViewFavoriteMealViewModel> UpdateFavoriteMealComments(ViewFavoriteMealViewModel model)
        {
            var dalModel = new FavoriteMealDALModel
            {
                Id = _userIdService.UserId,
                RecipeID = model.Id,
                AdditionalComments = model.AdditionalComments
            };

            _favoriteMealStore.UpdateFavoriteMealComments(dalModel);
            var viewModel = await SelectAFavoriteMeal(model.Id);
            return viewModel;
        }

        private FavoriteMealsViewModel MapFavMealDALtoView(FavoriteMealDALModel dalModel)
        {
            var dalViewAllFavMeals = _favoriteMealStore.SelectAllFavMeals(dalModel.Id);
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
    }
}
