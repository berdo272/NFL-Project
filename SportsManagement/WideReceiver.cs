using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsManagement
{
    public class WideReceiver : Player
    {
        int Receptions;
        int ReceivingYards;
        int ReceivingTouchdowns;


        public WideReceiver(string name, int age, int weight, int rating, int receptions, int receivingYards, int receivingTouchdowns)
        {
            this.Name = name;
            this.Age = age;
            this.Weight = weight;
            this.Rating = rating;
            this.ReceivingYards = receivingYards;
            this.Receptions = receptions;
            this.ReceivingTouchdowns = receivingTouchdowns;
            this.Position = "WideReceiver";
            this.branchOfTeam = BranchOfTeam.offense;
            
        }

        public override void PlayerAction()
        {
            Console.WriteLine("The WideReceiver catches a pass!");
        }

        public int receptions
        {
            get
            {
                return Receptions;
            }
        }
        public int _receivingYards
        {
            get
            {
                return ReceivingYards;
            }
        }
        public int _receivingTouchdowns
        {
            get
            {
                return ReceivingTouchdowns;
            }
        }
    }
}
