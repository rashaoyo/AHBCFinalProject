using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AHBCFinalProject.Models
{
    public class MealPlanHistoryViewModel
    {
        public int Id { get; set; }
        public string Sunday { get; set; }
        public string Monday { get; set; }
        public string Tuesday { get; set; }
        public string Wednesday { get; set; }
        public string Thursday { get; set; }
        public string Friday { get; set; }
        public string Saturday { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; } 
    }
}