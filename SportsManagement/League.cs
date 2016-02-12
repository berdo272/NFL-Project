using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsManagement
{
    public class League
    {
        private List<Team> Teams;

        public League()
        {
            this.Teams = new List<Team>() { new Team("Packers"), new Team("Bears") };
        }

        public void TradePlayer(Team TradingTeam, Team ReceivingTeam, Player player)
        {
            TradingTeam._roster -= player;
            ReceivingTeam._roster += player;

            TradingTeam._roster.GetAveragePlayerAge();
            TradingTeam._roster.GetAveragePlayerRating();
            TradingTeam._roster.GetAveragePlayerWeight();

            ReceivingTeam._roster.GetAveragePlayerAge();
            ReceivingTeam._roster.GetAveragePlayerRating();
            ReceivingTeam._roster.GetAveragePlayerWeight();
        }

        public List<Team> _teams
        {
            get
            {
               return Teams;
            }
        }
    }
}
