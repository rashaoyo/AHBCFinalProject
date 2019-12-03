using AHBCFinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AHBCFinalProject.Services
{
    public interface IRandomService
    {
        Task<ListOfRecipesViewModel> GetAllRandomRecipes();
    }
}