using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AHBCFinalProject.Models
{
    public class UserPreferencesViewModel
    {
        public int UserId { get; set; }
        public bool GlutenFree { get; set; }
        public bool Ketogenic { get; set; }
        public bool Vegetarian { get; set; }
        public bool LactoVegetarian { get; set; }
        public bool OvoVegetarian { get; set; }
        public bool Vegan { get; set; }
        public bool Pescetarian { get; set; }
        public bool Paleo { get; set; }
        public bool Primal { get; set; }
        public bool Whole30 { get; set; }
        public bool Dairy { get; set; }
        public bool Egg { get; set; }
        public bool Gluten { get; set; }
        public bool Grain { get; set; }
        public bool Peanut { get; set; }
        public bool Seafood { get; set; }
        public bool Sesame { get; set; }
        public bool Shellfish { get; set; }
        public bool Soy { get; set; }
        public bool Sulfite { get; set; }
        public bool TreeNut { get; set; }
        public bool Wheat { get; set; }
        public string ExcludedIngredients { get; set; }
    }
}