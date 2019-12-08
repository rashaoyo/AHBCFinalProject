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
            {   Id = _userIdService.UserId,
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

        public async Task<MPsViewModel> ViewMealPlanHistory(ViewMealPlanViewModel model)
        {
            model.TodaysDate = DateTime.Today;

            var dalResults = _mealPlanHistoryStore.ViewWeeklyMealPlan(model);
            var viewMealPlansModel = new List<ViewPlanViewModel>();
            
            foreach (var dalResult in dalResults)
            {                             
                var mealPlan = new MealPlanHistoryViewModel();
                mealPlan.Sunday = dalResult.Sunday;
                mealPlan.Monday = dalResult.Monday;
                mealPlan.Tuesday = dalResult.Tuesday;
                mealPlan.Wednesday = dalResult.Wednesday;
                mealPlan.Thursday = dalResult.Thursday;
                mealPlan.Friday = dalResult.Friday;
                mealPlan.Saturday = dalResult.Saturday;

                var sunday = await _recipeByIdService.GetRecipeVMById(mealPlan.Sunday);
                var monday = await _recipeByIdService.GetRecipeVMById(mealPlan.Monday);
                var tues = await _recipeByIdService.GetRecipeVMById(mealPlan.Tuesday);
                var wed = await _recipeByIdService.GetRecipeVMById(mealPlan.Wednesday);
                var thur = await _recipeByIdService.GetRecipeVMById(mealPlan.Thursday);
                var fri = await _recipeByIdService.GetRecipeVMById(mealPlan.Friday);
                var sat = await _recipeByIdService.GetRecipeVMById(mealPlan.Saturday);


                var viewPlan = new ViewPlanViewModel
                {
                    SundayId = sunday.Id,
                    SundayName = sunday.Title,
                    MondayId = monday.Id,
                    MondayName = monday.Title,
                    TuesdayId = tues.Id,
                    TuesdayName = tues.Title,
                    WednesdayId = wed.Id,
                    WednesdayName = wed.Title,
                    ThursdayId = thur.Id,
                    ThursdayName = thur.Title,
                    FridayId = fri.Id,
                    FridayName = fri.Title,
                    SaturdayId = sat.Id,
                    SaturdayName = sat.Title

                };

                viewMealPlansModel.Add(viewPlan);
            }

            var mpsViewModel = new MPsViewModel();
            mpsViewModel.MealPlans = viewMealPlansModel;


            return mpsViewModel;
        }

        
    }
}

