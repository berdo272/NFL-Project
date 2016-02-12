using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsManagement
{
    public class Roster
    {
        public  List<Player> Players;
        int OverallPlayerRating;
        int AveragePlayerAge;
        int AveragePlayerWieght;


        public Roster()
        {
            Random random = new Random();

            this.Players = new List<Player>()
            {
                new Quarterback("QB1", random.Next(25, 36), random.Next(180, 250), random.Next(10), random.Next(100), random.Next(10), random.Next(30)),
                new RunningBack("Runner1", random.Next(25, 36), random.Next(180, 250), random.Next(10), random.Next(100), random.Next(10), random.Next(30)),
                new RunningBack("Runner2", random.Next(25, 36), random.Next(180, 250), random.Next(10), random.Next(100), random.Next(10), random.Next(30)),
                new RunningBack("Runner3", random.Next(25, 36), random.Next(180, 250), random.Next(10), random.Next(100), random.Next(10), random.Next(30)),
                new RunningBack("Runner4", random.Next(25, 36), random.Next(180, 250), random.Next(10), random.Next(100), random.Next(10), random.Next(30)),
                new RunningBack("Runner5", random.Next(25, 36), random.Next(180, 250), random.Next(10), random.Next(100), random.Next(10), random.Next(30)),
                new WideReceiver("Receiver1", random.Next(25, 36), random.Next(180, 250), random.Next(10), random.Next(100), random.Next(10), random.Next(30)),
                new WideReceiver("Receiver2", random.Next(25, 36), random.Next(180, 250), random.Next(10), random.Next(100), random.Next(10), random.Next(30)),
                new WideReceiver("Receiver3", random.Next(25, 36), random.Next(180, 250), random.Next(10), random.Next(100), random.Next(10), random.Next(30)),
            
            };

        }

        public void GetAveragePlayerRating()
        {
            int totalPlayerRating = 0;

            foreach (Player player in Players)
            {
                totalPlayerRating += player._rating;
            }

            this.OverallPlayerRating = (totalPlayerRating / Players.Count);
        }
        public void GetAveragePlayerWeight()
        {
            int totalPlayerWeight = 0;

            foreach (Player player in Players)
            {
                totalPlayerWeight += player._weight;
            }

            this.AveragePlayerWieght = (totalPlayerWeight / Players.Count);
        }
        public void GetAveragePlayerAge()
        {
            int totalPlayerAge = 0;

            foreach (Player player in Players)
            {
                totalPlayerAge += player._age;
            }

            this.AveragePlayerAge = (totalPlayerAge / Players.Count);
        }

        public static Roster operator +(Roster roster,Player player)
        {
            roster.Players.Add(player);
            return roster;
        }
        public static Roster operator -(Roster roster,Player player) 
        {
            roster.Players.Remove(player);
            return roster;
        }

        public override string ToString()
        {
            string output = "";

            foreach (Player player in Players)
            {
                output += (Environment.NewLine + player.ToString());
            }

            return (output);
        }

    }
}
