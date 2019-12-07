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

        public MealPlanHistoryService(IMealPlanHistoryStore mealPlanHistoryStore, IUserIdService userIdService)
        {
            _mealPlanHistoryStore = mealPlanHistoryStore;
            _userIdService = userIdService;
        }
                
        public void AddMealPlanToHistory(RecipeViewModel model, ListOfRecipesViewModel result)  //Might need to change input, based on ComplexSearchService
        {
            var today = DateTime.Today;

            var mealPlanHistoryViewModel = new MealPlanHistoryViewModel //might need to adjust UserId based on how the SetUserIdService is set up
            {   Id = _userIdService.UserId,
                Sunday = model.Id,
                Monday = result.ListOfRecipes[0].Id,
                Tuesday = result.ListOfRecipes[1].Id, 
                Wednesday = result.ListOfRecipes[2].Id,
                Thursday = result.ListOfRecipes[3].Id,
                Friday = result.ListOfRecipes[4].Id,
                Saturday = result.ListOfRecipes[5].Id,
                StartDate = today,
                EndDate = today.AddDays(7)

            };

            
        }

        public MealPlanHistoryViewModel ViewMealPlan(ViewMealPlanViewModel model)
        {                      
            var dalModel = _mealPlanHistoryStore.ViewWeeklyMealPlan(model);

            var viewModel = new MealPlanHistoryViewModel
            {
                Id = dalModel.Id,
                Sunday = dalModel.Monday,
                Monday = dalModel.Monday,
                Tuesday = dalModel.Tuesday,
                Wednesday = dalModel.Wednesday,
                Thursday = dalModel.Thursday,
                Friday = dalModel.Friday,
                Saturday = dalModel.Saturday
            };

            return viewModel;
        }
    }
}

