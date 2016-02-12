using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsManagement
{
    public class Player
    {
        protected string Name;
        protected int Age;
        protected int Weight;
        protected string Position;
        protected int Rating;
        protected BranchOfTeam branchOfTeam;


        protected enum BranchOfTeam
        {
            offense = 1,
            defense = 2,
            specialTeams = 3
        }

        public virtual void PlayerAction()
        {

        }
        public override string ToString()
        {
            return (Name + " " + Position);
        }

        public int _weight
        {
            get
            {
                return Weight;
            }
        }
        public int _age
        {
            get
            {
                return Age;
            }
        }
        public int _rating
        {
            get
            {
                return Rating;
            }
        }
        public string _name
        {
            get
            {
                return Name;
            }
        }
        public string _position
        {
            get
            {
                return Position;
            }
        }
    }
}
