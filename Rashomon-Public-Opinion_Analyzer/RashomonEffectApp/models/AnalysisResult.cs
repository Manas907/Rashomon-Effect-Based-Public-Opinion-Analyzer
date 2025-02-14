namespace RashomonEffectApp.Models
{
    public class AnalysisResult
    {
        public int Id { get; set; }
        public string ReviewText { get; set; }
        public string Sentiment { get; set; } // Positive, Negative, Neutral
        public string BiasCategory { get; set; } // Example: "Corporate Bias", "Personal Bias"
    }
}
