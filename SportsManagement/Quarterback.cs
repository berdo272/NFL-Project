using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsManagement
{
    public class Quarterback : Player
    {
        int PassingPercentage;
        int PasserRating;
        int PassingTouchdowns;
        

        public Quarterback(string name, int age, int weight, int rating, int passingPercentage, int passerRating, int PassingTouchdowns)
        {
            this.Name = name;
            this.Age = age;
            this.Weight = weight;
            this.Rating = rating;
            this.PasserRating = passerRating;
            this.PassingPercentage = passingPercentage;
            this.PassingTouchdowns = PassingTouchdowns;
            this.Position = "Quarterback";
            this.branchOfTeam = BranchOfTeam.offense;

        }

        public override void PlayerAction()
        {
            Console.WriteLine("The Quarterback throws a pass!");
        }


        public int _passingPercentage
        {
            get
            {
                return PassingPercentage;
            }
        }
        public int _passerRating
        {
            get
            {
                return PasserRating;
            }
        }
        public int _passingTouchdowns
        {
            get
            {
                return PassingTouchdowns;
            }
        }

    }
}
