using Microsoft.AspNetCore.Mvc;
using RashomonEffectApp.Models;
using RashomonEffectApp.Services;
using System.Collections.Generic;

namespace RashomonEffectApp.Controllers
{
    [ApiController]
    [Route("api/opinions")]
    public class OpinionController : ControllerBase
    {
        private readonly OpinionService _opinionService;

        public OpinionController(OpinionService opinionService)
        {
            _opinionService = opinionService;
        }

        [HttpGet]
        public IEnumerable<Opinion> GetOpinions()
        {
            return _opinionService.GetAllOpinions();
        }

        [HttpPost]
        public IActionResult AddOpinion(Opinion opinion)
        {
            _opinionService.AddOpinion(opinion);
            return Ok(opinion);
        }
    }
}
