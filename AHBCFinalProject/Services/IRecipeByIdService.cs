using System;
using System.Threading.Tasks;
using AHBCFinalProject.Models;

namespace AHBCFinalProject.Services
{
    public interface IRecipeByIdService
    {
        Task<RecipeViewModel> GetRecipeVMById(string recipeId);
    }
}
