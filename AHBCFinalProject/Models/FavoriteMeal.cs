namespace AHBCFinalProject.Models
{
    public class FavoriteMeal
    {
        public int Id { get; set; }
        public int RecipeID { get; set; }
        public string MealName { get; set; }
        public string Type { get; set; }
        public string AdditionalComments { get; set; }
    }
}