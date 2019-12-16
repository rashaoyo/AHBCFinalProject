using AHBCFinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AHBCFinalProject.DAL
{
    public interface IMealPlanHistoryStore
    {
        MealPlanHistoryDALModel ViewCurrentMealPlan(CurrentMPViewModel model);
        bool InsertWeeklyMealPlan(MealPlanHistoryViewModel dalModel);
        IEnumerable<MealPlanHistoryDALModel> ViewWeeklyMealPlan(ViewMealPlanViewModel dalModel);

    }
}
