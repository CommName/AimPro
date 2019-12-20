using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIMProClient
{
    class Statistics
    {
        int Elo;
        string Username;
        int Rank;
        int HitRatio;
        int TotalRatioHits;

        public Statistics()
        {

        }


        public int Elo1 { get => Elo; set => Elo = value; }
        public string Username1 { get => Username; set => Username = value; }
        public int Rank1 { get => Rank; set => Rank = value; }
        public int HitRatio1 { get => HitRatio; set => HitRatio = value; }
        public int TotalRatioHits1 { get => TotalRatioHits; set => TotalRatioHits = value; }
    }
}
