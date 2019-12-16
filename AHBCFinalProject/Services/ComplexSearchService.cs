using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AHBCFinalProject.DAL;
using AHBCFinalProject.Models;
using AHBCFinalProject.SpoonacularServices;

namespace AHBCFinalProject.Services
{
    public class ComplexSearchService : IComplexSearchService
    {
        private readonly IComplexSearchStore _complexSearchStore;
        private readonly IUserPreferenceService _userPreferenceService;
        private readonly IUserPreferenceStore _userPreferenceStore;
        private readonly IUserIdService _userIdService;
       



        public ComplexSearchService(IComplexSearchStore complexSearchStore, IUserPreferenceService userPreferenceService, IUserPreferenceStore userPreferenceStore, IUserIdService userIdService)
        {
            _complexSearchStore = complexSearchStore;
            _userPreferenceService = userPreferenceService;
            _userPreferenceStore = userPreferenceStore;
            _userIdService = userIdService;
            

        }

        public async Task<ListOfRecipesViewModel> GetWeekOfRecipes()
        {
            var UserID =  _userIdService.getUserId();
            var userPrefDalModel = _userPreferenceStore.SelectUserPreferences(UserID);
            //var userPreferenceDALModel = _userPreferenceService.SetUserPreferences(userPrefDalModel);
            //var stringedThings = StringifyPreferencesForAPI(userPrefDalModel);
            var weekOfRecipesResponse = await _complexSearchStore.GetRecipesComplexSearch();

            var result = new ListOfRecipesViewModel()
            {
                ListOfRecipes = new List<RecipeViewModel>()
            };

            foreach (var recipe in weekOfRecipesResponse.Results)
            {
                var recipeVM = ConvertRecipeResponseToVM(recipe);
                result.ListOfRecipes.Add(recipeVM);
            }

            return result;
        }

        private UserPreferenceDALModel GetUpdatedPreferenceView(int id)
        {
            var dalPreference = _userPreferenceStore.SelectUserPreferences(id);
            var dalModel = new UserPreferenceDALModel()
            {
                Id = id,
                Diet = dalPreference.Diet,
                Intolerances = dalPreference.Intolerances,
                ExcludedIngredients = dalPreference.ExcludedIngredients
            };

            return dalModel;
        }

        public RecipeViewModel ConvertRecipeResponseToVM(RecipeResponse recipeResponse)
        {
            var result = new RecipeViewModel();

            result.Id = recipeResponse.id;
            result.Title = recipeResponse.Title;
            result.Image = recipeResponse.Image;
            result.ImageType = recipeResponse.ImageType;
            result.Servings = recipeResponse.Servings;
            result.ReadyInMinutes = recipeResponse.ReadyInMinutes;
            result.License = recipeResponse.License;
            result.License = recipeResponse.SourceName;
            result.SourceUrl = recipeResponse.SourceUrl;
            result.SpoonacularSourceUrl = recipeResponse.SpoonacularSourceUrl;
            result.AggregateLikes = recipeResponse.AggregateLikes;
            result.HealthScore = recipeResponse.HealthScore;
            result.SpoonacularScore = recipeResponse.SpoonacularScore;
            result.PricePerServing = recipeResponse.PricePerServing;
            result.AnalyzedInstructions = recipeResponse.AnalyzedInstructions;
            result.Cheap = recipeResponse.Cheap;
            result.CreditsText = recipeResponse.CreditsText;
            result.Cuisines = recipeResponse.Cuisines;
            result.DairyFree = recipeResponse.DairyFree;
            result.Diets = recipeResponse.Diets;
            result.Gaps = recipeResponse.Gaps;
            result.GlutenFree = recipeResponse.GlutenFree;
            result.Instructions = recipeResponse.Instructions;
            result.Ketogenic = recipeResponse.Ketogenic;
            result.LowFodmap = recipeResponse.LowFodmap;
            result.Occasions = recipeResponse.Occasions;
            result.Sustainable = recipeResponse.Sustainable;
            result.Vegan = recipeResponse.Vegan;
            result.Vegetarian = recipeResponse.Vegetarian;
            result.VeryHealthy = recipeResponse.VeryHealthy;
            result.VeryPopular = recipeResponse.VeryPopular;
            result.Whole30 = recipeResponse.Whole30;
            result.WeightWatcherSmartPoints = recipeResponse.WeightWatcherSmartPoints;
            result.ExtendedIngredients = recipeResponse.ExtendedIngredients;
            result.WinePairing = recipeResponse.WinePairing;

            return result;
        }

        //private UserPreferenceDALModel StringifyPreferencesForAPI(UserPreferenceDALModel userPreferences)
        //{
        //    var newDietSplit = new List<string>();
        //    var newIntoleranceSplit = new List<string>();
        //    var newExcludedSplit = new List<string>();

        //    var stringifiedDALModel = new UserPreferenceDALModel()
        //    {
        //        Id = userPreferences.Id,
        //        Diet = "",
        //        Intolerances = "",
        //        ExcludedIngredients = ""
        //    };

        //    var dietSplit = userPreferences.Diet.Split(',');
        //    var intolerancesSplit = userPreferences.Intolerances.Split(',');
        //    var excludedSplit = userPreferences.ExcludedIngredients.Split(',');
                     
        //    if(dietSplit != null)
        //    {
        //        foreach (var diet in dietSplit)
        //        {
        //            string toAdd;

        //            if (diet.Contains(' '))
        //            {
        //                toAdd = $@"'{diet}'";
        //            }
        //            else
        //            {
        //                toAdd = diet;
        //            }

        //            newDietSplit.Add(toAdd);
        //        }

        //        stringifiedDALModel.Diet = String.Join(',', newDietSplit);
        //    }
            
        //    if(intolerancesSplit != null)
        //    {
        //        foreach (var intolerance in intolerancesSplit)
        //        {
        //            string toAdd;

        //            if (intolerance.Contains(' '))
        //            {
        //                toAdd = $@"'{intolerance}'";
        //            }
        //            else
        //            {
        //                toAdd = intolerance;
        //            }

        //            newIntoleranceSplit.Add(toAdd);
        //        }

        //        stringifiedDALModel.Intolerances = String.Join(',', newIntoleranceSplit);
        //    }
            
        //    if(excludedSplit !=null)
        //    {
        //        foreach (var excludedIngredient in excludedSplit)
        //        {
        //            string toAdd;

        //            if (excludedIngredient.Contains(' '))
        //            {
        //                toAdd = $@"'{excludedIngredient}'";
        //            }
        //            else
        //            {
        //                toAdd = excludedIngredient;
        //            }

        //            newExcludedSplit.Add(toAdd);
        //        }

        //        stringifiedDALModel.ExcludedIngredients = String.Join(',', newExcludedSplit);
        //    }
            
        //    return stringifiedDALModel;
        //}
    }
}