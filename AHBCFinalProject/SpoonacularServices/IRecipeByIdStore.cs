using System;
using System.Threading.Tasks;
using AHBCFinalProject.Models;

namespace AHBCFinalProject.SpoonacularServices
{
    public interface IRecipeByIdStore
    {
        Task<RecipeResponse> GetRecipeResponseFromId(int recipeId);
    }
}