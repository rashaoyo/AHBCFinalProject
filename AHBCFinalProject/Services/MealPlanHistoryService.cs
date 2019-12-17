using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AHBCFinalProject.DAL;
using AHBCFinalProject.Models;

namespace AHBCFinalProject.Services
{
    public class MealPlanHistoryService : IMealPlanHistoryService
    {
        private readonly IMealPlanHistoryStore _mealPlanHistoryStore;
        private readonly IUserIdService _userIdService;
        private readonly IRecipeByIdService _recipeByIdService;

        public MealPlanHistoryService(IMealPlanHistoryStore mealPlanHistoryStore, IUserIdService userIdService, IRecipeByIdService recipeByIdService)
        {
            _mealPlanHistoryStore = mealPlanHistoryStore;
            _userIdService = userIdService;
            _recipeByIdService = recipeByIdService;
        }
                
        public void AddMealPlanToHistory(ListOfRecipesViewModel result) 
        {
            var today = DateTime.Today;

            var mealPlanHistoryViewModel = new MealPlanHistoryViewModel 
            {   Id = _userIdService.getUserId(),
                Sunday = result.ListOfRecipes[0].Id,
                Monday = result.ListOfRecipes[1].Id,
                Tuesday = result.ListOfRecipes[2].Id, 
                Wednesday = result.ListOfRecipes[3].Id,
                Thursday = result.ListOfRecipes[4].Id,
                Friday = result.ListOfRecipes[5].Id,
                Saturday = result.ListOfRecipes[6].Id,
                StartDate = today,
                EndDate = today.AddDays(7)

            };

            _mealPlanHistoryStore.InsertWeeklyMealPlan(mealPlanHistoryViewModel);
        }

        public async Task<ViewPlanViewModel> ViewCurrentMealPlan()
        {
            var currentViewModel = new CurrentMPViewModel
            {
                Id = _userIdService.getUserId(),
                TodaysDate = DateTime.Today                
            };

            var currentMP =_mealPlanHistoryStore.ViewCurrentMealPlan(currentViewModel);

            var sunday = _recipeByIdService.GetRecipeVMById(currentMP.Sunday);
            var monday = _recipeByIdService.GetRecipeVMById(currentMP.Monday);
            var tues = _recipeByIdService.GetRecipeVMById(currentMP.Tuesday);
            var wed = _recipeByIdService.GetRecipeVMById(currentMP.Wednesday);
            var thur = _recipeByIdService.GetRecipeVMById(currentMP.Thursday);
            var fri = _recipeByIdService.GetRecipeVMById(currentMP.Friday);
            var sat = _recipeByIdService.GetRecipeVMById(currentMP.Saturday);

            var result = await Task.WhenAll(sunday, monday, tues, wed, thur, fri, sat);

            var viewMealPlan = new ViewPlanViewModel
            {
                SundayId = result[0].Id,
                SundayName = result[0].Title,
                MondayId = result[1].Id,
                MondayName = result[1].Title,
                TuesdayId = result[2].Id,
                TuesdayName = result[2].Title,
                WednesdayId = result[3].Id,
                WednesdayName = result[3].Title,
                ThursdayId = result[4].Id,
                ThursdayName = result[4].Title,
                FridayId = result[5].Id,
                FridayName = result[5].Title,
                SaturdayId = result[6].Id,
                SaturdayName = result[6].Title
            };

            return viewMealPlan;
        }


        public async Task<ViewPlanViewModel> ViewMealPlanHistory(ViewMealPlanViewModel model)
        {
            model.TodaysDate = DateTime.Today;
            model.Id = _userIdService.getUserId();

            var dalResults = _mealPlanHistoryStore.SearchPastMealPlans(model);

            var sunday = _recipeByIdService.GetRecipeVMById(dalResults.Sunday);
            var monday = _recipeByIdService.GetRecipeVMById(dalResults.Monday);
            var tues = _recipeByIdService.GetRecipeVMById(dalResults.Tuesday);
            var wed = _recipeByIdService.GetRecipeVMById(dalResults.Wednesday);
            var thur = _recipeByIdService.GetRecipeVMById(dalResults.Thursday);
            var fri = _recipeByIdService.GetRecipeVMById(dalResults.Friday);
            var sat = _recipeByIdService.GetRecipeVMById(dalResults.Saturday);

            var result = await Task.WhenAll(sunday, monday, tues, wed, thur, fri, sat);

            var viewPlan = new ViewPlanViewModel
            {
                SundayId = result[0].Id,
                SundayName = result[0].Title,
                MondayId = result[1].Id,
                MondayName = result[1].Title,
                TuesdayId = result[2].Id,
                TuesdayName = result[2].Title,
                WednesdayId = result[3].Id,
                WednesdayName = result[3].Title,
                ThursdayId = result[4].Id,
                ThursdayName = result[4].Title,
                FridayId = result[5].Id,
                FridayName = result[5].Title,
                SaturdayId = result[6].Id,
                SaturdayName = result[6].Title
            };

            
            return viewPlan;
        }
    }
}