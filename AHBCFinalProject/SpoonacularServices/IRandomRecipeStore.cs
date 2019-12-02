using System;
using System.Threading.Tasks;
using AHBCFinalProject.Models;

namespace AHBCFinalProject.SpoonacularServices
{
    public interface IRandomRecipeStore
    {
        Task<ListOfRecipesResponse> GetRandomRecipe();
    }
}
