using Microsoft.AspNetCore.Mvc;
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
        public List<string> Diet { get; set; }
        public List<string> Intolerances { get; set; }
        public List<string> ExcludedIngredients { get; set; }
    }
}