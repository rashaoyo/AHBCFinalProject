using AHBCFinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AHBCFinalProject.DAL
{
    public interface IMealPlanHistoryStore
    {
        MealPlanHistoryDALModel ViewWeeklyMealPlan(ViewMealPlanViewModel dalModel);
        bool InsertWeeklyMealPlan(MealPlanHistoryViewModel dalModel);
    }
}
