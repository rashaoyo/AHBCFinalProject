using AHBCFinalProject.DAL;
using AHBCFinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AHBCFinalProject.SpoonacularServices
{
    interface IComplexSearchStore
    {
        Task<ListOfRecipesResponse> GetRecipesComplexSearch(User user, int number);
    }
}
