using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AHBCFinalProject.Models
{
    public class ViewFavoriteMealViewModel
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
        public string ImageType { get; set; }
        public int Servings { get; set; }
        public int ReadyInMinutes { get; set; }
        public string License { get; set; }
        public string SourceName { get; set; }
        public string SourceUrl { get; set; }
        public string SpoonacularSourceUrl { get; set; }
        public int AggregateLikes { get; set; }
        public float HealthScore { get; set; }
        public float SpoonacularScore { get; set; }
        public float PricePerServing { get; set; }
        public object[] AnalyzedInstructions { get; set; }
        public bool Cheap { get; set; }
        public string CreditsText { get; set; }
        public object[] Cuisines { get; set; }
        public bool DairyFree { get; set; }
        public object[] Diets { get; set; }
        public string Gaps { get; set; }
        public bool GlutenFree { get; set; }
        public string Instructions { get; set; }
        public bool Ketogenic { get; set; }
        public bool LowFodmap { get; set; }
        public object[] Occasions { get; set; }
        public bool Sustainable { get; set; }
        public bool Vegan { get; set; }
        public bool Vegetarian { get; set; }
        public bool VeryHealthy { get; set; }
        public bool VeryPopular { get; set; }
        public bool Whole30 { get; set; }
        public int WeightWatcherSmartPoints { get; set; }
        public string[] DishTypes { get; set; }
        public Extendedingredient[] ExtendedIngredients { get; set; }
        public Winepairing WinePairing { get; set; }
        public string AdditionalComments { get; set; }
    }
}