using MingweiSamuel.Camille.MatchV4;
using MingweiSamuel.Camille.SummonerV4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotAPIFinalProject
{
    public class MatchInfo
    {

        public string GameName { get; set; }

        public string GameMode { get; set; }

        public List<Participant> Participants { get; set; }

        public MatchInfo(string gameName = null, string gameMode = null, List<Participant> participants = null)
        {
            GameName = gameName;
            GameMode = gameMode;
            Participants = participants;
        }
    }
}
