﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AHBCFinalProject.Models
{
    public class FavoriteMealViewModel
    {
        public int Id { get; set; }
        public string RecipeID { get; set; }
        public string MealName { get; set; }
        public string Type { get; set; }
        public string AdditionalComments { get; set; }
    }
}
