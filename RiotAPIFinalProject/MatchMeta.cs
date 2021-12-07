using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotAPIFinalProject
{
    public class MatchMeta
    {
        public string MatchID { get; set; }

        public List<string> Participants { get; set; }

        public MatchMeta(string id = null, List<string> participants = null)
        {

        }
    }
}
