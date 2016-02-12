using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsManagement
{
    public class RunningBack : Player
    {
        int RushingAttempts;
        int RushingYards;
        int RushingTouchdowns;

        public RunningBack(string name, int age, int weight, int rating, int rushingAttempts, int rushingYards, int rushingTouchdowns)
        {
            this.Name = name;
            this.Age = age;
            this.Weight = weight;
            this.Rating = rating;
            this.RushingYards = rushingYards;
            this.RushingAttempts = rushingAttempts;
            this.RushingTouchdowns = rushingTouchdowns;
            this.Position = "RunningBack";
            this.branchOfTeam = BranchOfTeam.offense;

        }

        public override void PlayerAction()
        {
            Console.WriteLine("The Runningback runs the ball.");
        }

        public int _rushingAttempts
        {
            get
            {
                return RushingAttempts;
            }
        }
        public int _rushingYards
        {
            get
            {
                return RushingYards;
            }
        }
        public int _rushingTouchdowns
        {
            get
            {
                return RushingTouchdowns;
            }
        }
    }
}
