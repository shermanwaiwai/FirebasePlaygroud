using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirebasePlayground.Model
{
    public class MATCH
    {
        [JsonProperty(PropertyName = "DATE")]
        public string DATE { get; set; }
        [JsonProperty(PropertyName = "HOME_TEAM")]
        public string HOME_TEAM { get; set; }
        [JsonProperty(PropertyName = "AWAY_TEAM")]
        public string AWAY_TEAM { get; set; }
        public RATE RATE { get; set; }
        public MATCH(string _DATE ,  string _HOME_TEAM, string _AWAY_TEAM, double _HOME, double _DRAW, double _AWAY, double _HOME_HANDI, double _AWAY_HANDI)
        {
            this.DATE = _DATE;
            this.HOME_TEAM = _HOME_TEAM;
            this.AWAY_TEAM = _AWAY_TEAM;
            this.RATE = new RATE(_HOME, _DRAW, _AWAY, _HOME_HANDI, _AWAY_HANDI);
        }
    }

    public class RATE
    {
        public double HOME { get; set; }
        public double DRAW { get; set; }
        public double AWAY { get; set; }
        public double HOME_HANDI { get; set; }
        public double AWAY_HANDI { get; set; }

        public RATE(double _HOME, double _DRAW, double _AWAY, double _HOME_HANDI, double _AWAY_HANDI)
        {
            this.HOME = _HOME;
            this.DRAW = _DRAW;
            this.AWAY = _AWAY;
            this.HOME_HANDI = _HOME_HANDI;
            this.AWAY_HANDI = _AWAY_HANDI;
        }
    }
}
