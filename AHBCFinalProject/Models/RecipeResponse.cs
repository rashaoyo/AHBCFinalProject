using System;
using System.Collections.Generic;

namespace AHBCFinalProject.Models
{
    public class RecipeResponse
    {
        public int Id { get; set; }
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
        public bool lowFodmap { get; set; }
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
    }

    public class Winepairing
    {
        public object[] PairedWines { get; set; }
        public string PairingText { get; set; }
        public object[] ProductMatches { get; set; }
    }

    public class Extendedingredient
    {
        public string Aisle { get; set; }
        public float Amount { get; set; }
        public string Consitency { get; set; }
        public int Id { get; set; }
        public string Image { get; set; }
        public Measures Measures { get; set; }
        public string[] Meta { get; set; }
        public string[] MetaInformation { get; set; }
        public string Name { get; set; }
        public string Original { get; set; }
        public string OriginalName { get; set; }
        public string OriginalString { get; set; }
        public string Unit { get; set; }
    }

    public class Measures
    {
        public Metric Metric { get; set; }
        public Us Us { get; set; }
    }

    public class Metric
    {
        public float Amount { get; set; }
        public string NitLong { get; set; }
        public string UnitShort { get; set; }
    }

    public class Us
    {
        public float Amount { get; set; }
        public string UnitLong { get; set; }
        public string UnitShort { get; set; }
    }



}