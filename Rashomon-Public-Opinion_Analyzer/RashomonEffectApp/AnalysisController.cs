using Microsoft.AspNetCore.Mvc;
using RashomonEffectApp.Models;
using RashomonEffectApp.Services;
using System.Collections.Generic;

namespace RashomonEffectApp.Controllers
{
    [ApiController]
    [Route("api/analysis")]
    public class AnalysisController : ControllerBase
    {
        private readonly SentimentService _sentimentService;

        public AnalysisController(SentimentService sentimentService)
        {
            _sentimentService = sentimentService;
        }

        [HttpPost]
        public AnalysisResult AnalyzeOpinion([FromBody] Opinion opinion)
        {
            return _sentimentService.AnalyzeOpinion(opinion);
        }
    }
}
