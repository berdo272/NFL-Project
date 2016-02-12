using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace SportsManagement
{
    public class Team : IEnumerable
    {
        Roster Roster;
        string Name;
        int points;
        int PointsAllowed;
        int Touchdowns;
        int Interceptions;
        int Sacks;
        List<Player> Top5Players;

        public Team(string name)
        {
            Random rand = new Random();
            Top5Players = new List<Player>();

            Roster = new Roster();
            this.Name = name;
            this.points = rand.Next(450);
            this.PointsAllowed = rand.Next(450);
            this.Touchdowns = rand.Next(60);
            this.Interceptions = rand.Next(50);
            this.Sacks = rand.Next(50);

            Roster.GetAveragePlayerAge();
            Roster.GetAveragePlayerRating();
            Roster.GetAveragePlayerWeight();

            GetTop5Players();
        }

        private void GetTop5Players()
        {

            List<Player> SortedList =  Roster.Players.OrderByDescending(o => o._rating).ToList();

            Top5Players.Add(SortedList[0]);
            Top5Players.Add(SortedList[1]);
            Top5Players.Add(SortedList[2]);
            Top5Players.Add(SortedList[3]);
            Top5Players.Add(SortedList[4]);

        }
        public void displayTop5()
        {
            Console.WriteLine(Name + " Top 5 Players By Rating");

            foreach (Player player in Top5Players)
            {
                Console.WriteLine(player.ToString() + "   Rating: " + player._rating);
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            foreach (Player player in Top5Players)
            {
                yield return (player.ToString() + "   Rating: " + player._rating);
            }
        }

        public Roster _roster
        {
            get
            {
                return Roster;
            }
            set
            {
                Roster = value;
            }
        }
        public int _points
        {
            get
            {
                return points;
            }
            set
            {
                points = value;
            }
        }
        public int _PointsAllowed
        {
            get
            {
                return PointsAllowed;
            }
            set
            {
                PointsAllowed = value;
            }
        }
        public int _Touchdowns
        {
            get
            {
                return Touchdowns;
            }
            set
            {
                Touchdowns = value;
            }
        }
        public int _Interceptions
        {
            get
            {
                return Interceptions;
            }
            set
            {
                Interceptions = value;
            }
        }
        public int _Sacks
        {
            get
            {
                return Sacks;
            }
            set
            {
                Sacks = value;
            }
        }
        public List<Player> _top5Players
        {
            get
            {
                return Top5Players;
            }
        }
        public string _name
        {
            get
            {
                return Name;
            }
        }

    }
}
