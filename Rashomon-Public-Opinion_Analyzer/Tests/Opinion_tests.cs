using Microsoft.VisualStudio.TestTools.UnitTesting;
using RashomonEffectApp.Models;
using RashomonEffectApp.Services;

namespace RashomonEffectApp.Tests
{
    [TestClass]
    public class OpinionTests
    {
        private readonly SentimentService _sentimentService = new SentimentService();

        [TestMethod]
        public void TestPositiveSentiment()
        {
            Opinion testOpinion = new Opinion { ReviewText = "This product is excellent!" };
            var result = _sentimentService.AnalyzeOpinion(testOpinion);
            Assert.AreEqual("Positive", result.Sentiment);
        }

        [TestMethod]
        public void TestNegativeSentiment()
        {
            Opinion testOpinion = new Opinion { ReviewText = "This product is bad!" };
            var result = _sentimentService.AnalyzeOpinion(testOpinion);
            Assert.AreEqual("Negative", result.Sentiment);
        }
    }
}
