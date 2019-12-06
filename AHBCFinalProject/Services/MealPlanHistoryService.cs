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

        public MealPlanHistoryService(IMealPlanHistoryStore mealPlanHistoryStore)
        {
            _mealPlanHistoryStore = mealPlanHistoryStore;
        }

        public void AddMealPlanToHistory(MealPlanHistoryViewModel model)
        {
            _mealPlanHistoryStore.InsertWeeklyMealPlan(model);
            
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

