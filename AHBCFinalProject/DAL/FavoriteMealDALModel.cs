using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AHBCFinalProject.DAL
{
    public class FavoriteMealDALModel
    {
        public int Id { get; set; }
        public string RecipeID { get; set; }
        public string MealName { get; set; }
        public int ReadyInMinutes { get; set; }
        public string AdditionalComments { get; set; }
    }
}
