using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportsManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsManagement.Tests
{
    [TestClass()]
    public class LeagueTests
    {
        [TestMethod()]
        public void TradePlayerTest()
        {
            League league = new League();
            Quarterback expected;
            Team Team1;
            Team Team2;

            Quarterback TestQB;

            expected = new Quarterback("Bilbo Baggins", 110, 95, 10, 75, 8, 55);
            TestQB = new Quarterback("Bilbo Baggins", 110, 95, 10, 75, 8, 55);
            Team1 = new Team("The Shire");
            Team2 = new Team("Mordor");

            Team1._roster.Players.Add(TestQB);

            league.TradePlayer(Team1, Team2, Team1._roster.Players[9]);


            Assert.AreEqual(expected._name, Team2._roster.Players[9]._name);
            Assert.AreEqual(expected._age, Team2._roster.Players[9]._age);
            Assert.AreEqual(expected._position, Team2._roster.Players[9]._position);
            Assert.AreEqual(expected._rating, Team2._roster.Players[9]._rating);
            Assert.AreEqual(expected._weight, Team2._roster.Players[9]._weight);
        }
    }
}