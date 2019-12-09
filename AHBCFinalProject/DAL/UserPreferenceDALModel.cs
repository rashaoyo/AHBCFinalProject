using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AHBCFinalProject.DAL
{
    public class UserPreferenceDALModel
    {
        public int Id { get; set; }
        public string Diet { get; set; }
        public string Intolerances { get; set; }
        public string ExcludedIngredients { get; set; }
    }
}
