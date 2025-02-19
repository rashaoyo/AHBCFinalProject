﻿using AHBCFinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AHBCFinalProject.Services
{
    public interface IMealPlanHistoryService
    {
        void AddMealPlanToHistory(ListOfRecipesViewModel result);
        Task<MPsViewModel> ViewMealPlanHistory(ViewMealPlanViewModel model);
    }
}
