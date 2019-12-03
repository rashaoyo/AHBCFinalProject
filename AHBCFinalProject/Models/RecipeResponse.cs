using System;
using System.Collections.Generic;

namespace AHBCFinalProject.Models
{
    public class RecipeResponse
    {
        public int id { get; set; }
        public string title { get; set; }
        public string image { get; set; }
        public string imageType { get; set; }
        public int servings { get; set; }
        public int readyInMinutes { get; set; }
        public string license { get; set; }
        public string sourceName { get; set; }
        public string sourceUrl { get; set; }
        public string spoonacularSourceUrl { get; set; }
        public int aggregateLikes { get; set; }
        public float healthScore { get; set; }
        public float spoonacularScore { get; set; }
        public float pricePerServing { get; set; }
        public object[] analyzedInstructions { get; set; }
        public bool cheap { get; set; }
        public string creditsText { get; set; }
        public object[] cuisines { get; set; }
        public bool dairyFree { get; set; }
        public object[] diets { get; set; }
        public string gaps { get; set; }
        public bool glutenFree { get; set; }
        public string instructions { get; set; }
        public bool ketogenic { get; set; }
        public bool lowFodmap { get; set; }
        public object[] occasions { get; set; }
        public bool sustainable { get; set; }
        public bool vegan { get; set; }
        public bool vegetarian { get; set; }
        public bool veryHealthy { get; set; }
        public bool veryPopular { get; set; }
        public bool whole30 { get; set; }
        public int weightWatcherSmartPoints { get; set; }
        public string[] dishTypes { get; set; }
        public Extendedingredient[] extendedIngredients { get; set; }
        public Winepairing winePairing { get; set; }
    }

    public class Winepairing
    {
        public object[] pairedWines { get; set; }
        public string pairingText { get; set; }
        public object[] productMatches { get; set; }
    }

    public class Extendedingredient
    {
        public string aisle { get; set; }
        public float amount { get; set; }
        public string consitency { get; set; }
        public int id { get; set; }
        public string image { get; set; }
        public Measures measures { get; set; }
        public string[] meta { get; set; }
        public string[] metaInformation { get; set; }
        public string name { get; set; }
        public string original { get; set; }
        public string originalName { get; set; }
        public string originalString { get; set; }
        public string unit { get; set; }
    }

    public class Measures
    {
        public Metric metric { get; set; }
        public Us us { get; set; }
    }

    public class Metric
    {
        public float amount { get; set; }
        public string unitLong { get; set; }
        public string unitShort { get; set; }
    }

    public class Us
    {
        public float amount { get; set; }
        public string unitLong { get; set; }
        public string unitShort { get; set; }
    }



}