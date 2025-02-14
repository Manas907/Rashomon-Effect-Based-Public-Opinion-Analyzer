using RashomonEffectApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace RashomonEffectApp.Services
{
    public class OpinionService
    {
        private readonly List<Opinion> _opinions = new List<Opinion>();

        public IEnumerable<Opinion> GetAllOpinions()
        {
            return _opinions;
        }

        public void AddOpinion(Opinion opinion)
        {
            _opinions.Add(opinion);
        }
    }
}
