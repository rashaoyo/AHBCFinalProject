using System;
using System.Collections.Generic;

namespace AHBCFinalProject.Models
{
    public class RecipeResponse
    {
        public bool Vegetarian { get; set; }
        public bool Vegan { get; set; }
        public bool GlutenFree { get; set; }
        public bool DairyFree { get; set; }
        public bool VeryHealthy { get; set; }
        public bool Cheap { get; set; }
        public bool VeryPopular { get; set; }
        public bool Sustainable { get; set; }
        public int WeightWatcherSmartPoints { get; set; }
        public string Gaps { get; set; }
        public bool LowFodmap { get; set; }
        public bool Ketogenic { get; set; }
        public bool Whole30 { get; set; }
        public int Servings { get; set; }
        public int PreparationMinutes { get; set; }
        public int CookingMinutes { get; set; }
        public string SourceUrl { get; set; }
        public string SpoonacularSourceUrl { get; set; }
        public int AggregateLikes { get; set; }
        public string CreditText { get; set; }
        public string SourceName { get; set; }
        public List<IngredientResponse> ExtendedIngredients { get; set; }
        public int Id { get; set; }
        public string Title { get; set; }
        public int ReadyInMinutes { get; set; }
        public string Image { get; set; }
        public string ImageType { get; set; }
        public string Instructions { get; set; }
    }
}