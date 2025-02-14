namespace RashomonEffectApp.Models
{
    public class Opinion
    {
        public int Id { get; set; }
        public string Reviewer { get; set; }
        public string ReviewText { get; set; }
        public string Perspective { get; set; } // Rashomon Effect: Different viewpoints
    }
}
