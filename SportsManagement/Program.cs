using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsManagement
{
    public class Program
    {
        static void Main(string[] args)
        {
            League AFC = new League();
            FileWrite fw = new FileWrite();
            FileRead fr = new FileRead();

            AFC.TradePlayer(AFC._teams[0], AFC._teams[1], AFC._teams[0]._roster.Players[3]);

            fw.WriteToFile("../../Team1Roster.txt", AFC._teams[0]._roster.ToString());
            fw.WriteToFile("../../Team2Roster.txt", AFC._teams[1]._roster.ToString());

            Console.WriteLine("Top 5 Players for the " + AFC._teams[0]._name);
           foreach(string msg in AFC._teams[0])
            {
                Console.WriteLine(msg);
            }

            Console.ReadKey();
            Console.WriteLine(fr.readFile("../../Team1Roster.txt"));
            Console.WriteLine(fr.readFile("../../Team2Roster.txt"));
            Console.ReadKey();
        }
    }
}
