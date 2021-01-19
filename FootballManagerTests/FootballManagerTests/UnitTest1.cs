using FootballManager.Controllers;
using FootballManager.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace FootballManagerTests
{
    [TestClass]
    public class UnitTest1
    {

        [TestClass()]
        public class FootballManagerControllerTests
        {
            /*
             * Returns list of all players
             */
            [TestMethod()]
            public void GetTest()
            {
                var controller = new FootballManagerController();
                List<PlayerTeam> playerTeams = (List<PlayerTeam>)controller.Get();

                Assert.IsNotNull(playerTeams);
            }

            [TestMethod()]
            public void TestGetStadiums()
            {
                var controller = new FootballManagerController();
                List<Stadium> stadiums = (List<Stadium>)controller.GetStadiums();

                Assert.IsNotNull(stadiums);
            }

            [DataTestMethod]
            [DataRow(0, true)]      //return empty list as there is not team with id 0
            [DataRow(1, false)]     //return list of players
            [DataRow(25, true)]      //return empty list as there is not team with id 25
            [DataRow(2, false)]      //return list of players
            public void GetTestWithParams(int teamId, bool isEmpty)
            {

                var controller = new FootballManagerController();
                List<PlayerTeam> playerTeams = (List<PlayerTeam>)controller.Get(teamId);
                Assert.AreEqual((playerTeams.Count == 0), isEmpty);
            }

            [DataTestMethod]
            [DataRow(0, "testname", "testsurname", 34, PlayerPosition.CENTRE_MIDFIELDER, "2019/03/12", false)]  //player not created, there is no team with id 0
            [DataRow(1, "testname1", "testsurname1", 34, PlayerPosition.CENTRE_BACK, "2019/04/12", true)]       //player created
            public void TestCreatePlayer(int teamId, string playerName, string playerSurname, int playerNumber, PlayerPosition playerPosition, string playerBirthRate, bool expected)
            {
                var controller = new FootballManagerController();
                var player = new Player { FKTeamId = teamId, PlayerName = playerName, PlayerSurname = playerSurname, PlayerNumber = playerNumber, PlayerPosition = playerPosition, PlayerBirthDate = playerBirthRate };
                bool result = controller.CreatePlayer(player);
                Assert.AreEqual(result, expected);



            }

            [DataTestMethod]
            [DataRow(0, 0, false)]      //cannot move, there is no team id 0
            [DataRow(1, 2, true)]       //should move
            [DataRow(1, 1, true)]       //should move
            [DataRow(2, 25, false)]     //cannot move, there is no team id 0
            [DataRow(3, 1, true)]       //should move
            public void TestMovePlayer(long playerId, int teamId, bool isMoved)
            {

                var controller = new FootballManagerController();
                bool result = controller.MovePlayerToTeam(playerId, teamId);
                Assert.AreEqual(result, isMoved);
            }

            [DataTestMethod]
            [DataRow("CT", "Ama", 2, true)]     //team added
            [DataRow("CT", "Ama", 0, false)]    //team not added, as there is no 0 id for the stadium
            [DataRow("CT", "Ama", 1, true)]     //team added
            public void TestCreateTeam(string teamLocation, string teamName, int stadiumId, bool isNull)
            {
                var controller = new FootballManagerController();
                Team team = new Team { TeamLocation = teamLocation, TeamName = teamName, FKStadiumId = stadiumId };
                Team addedTeam = controller.CreateTeam(team);
                bool result = (addedTeam != null);
                Assert.AreEqual(result, isNull);
            }

            /*
             * Should always pass, as there are no checks on the backend
             */
            [DataTestMethod]
            [DataRow("FNB Stadium", 30000, true)]
            [DataRow("Ellis Park", 20000, true)]
            [DataRow("Maracana", 80000, true)]
            public void TestCreateStadium(string stadiumName, int stadiumCapacity, bool isNull)
            {
                var controller = new FootballManagerController();
                Stadium stadium = new Stadium { StadiumName = stadiumName, StadiumCapacity = stadiumCapacity };
                Stadium createdStadium = controller.CreateStadium(stadium);
                bool result = (createdStadium != null);
                Assert.AreEqual(result, isNull);
            }
        }


    }
}
