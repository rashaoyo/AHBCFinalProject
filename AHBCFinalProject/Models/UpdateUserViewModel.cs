﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AHBCFinalProject.Models
{
    public class UpdateUserViewModel
    {
        [HiddenInput]
        public int UserId { get; set; }
        public string Diet { get; set; }
        public string Intolerances { get; set; }
        public string ExcludedIngredients { get; set; }
    }
}
