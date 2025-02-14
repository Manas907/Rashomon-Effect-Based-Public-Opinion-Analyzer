using RashomonEffectApp.Models;

namespace RashomonEffectApp.Services
{
    public class SentimentService
    {
        public AnalysisResult AnalyzeOpinion(Opinion opinion)
        {
            string sentiment = opinion.ReviewText.Contains("bad") ? "Negative" : "Positive";
            return new AnalysisResult
            {
                ReviewText = opinion.ReviewText,
                Sentiment = sentiment,
                BiasCategory = "Personal Bias"
            };
        }
    }
}
