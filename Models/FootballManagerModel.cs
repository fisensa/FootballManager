using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FootballManager.Models
{
   /*
    * Note: Static class is used as there was no requirement for the database. I do not reccoment this approach in a real system. 
    */
    public static class FootballManagerModel
    {
        public static List<Stadium> Stadiums;
        public static List<Team> Teams;
        public static List<Player> Players;
        
        

        static FootballManagerModel() {
            Players = new List<Player>();
            Teams = new List<Team>();
            Stadiums = new List<Stadium>();
            LoadInitialData();
        }

        private static void LoadInitialData()
        {
            Stadiums.Add(new Stadium { StadiumId = 1, StadiumName = "Orlando Stadium", StadiumCity = "Soweto, Johannesburg" });
            Teams.Add(new Team {TeamId =1, TeamLocation="Soweto", TeamName="Orlando Pirates", FKStadiumId=1 });
            Players.Add(new Player { PlayerId = 1, PlayerName="Thabiso", PlayerSurname="Monyane", PlayerNumber=2, PlayerPosition=PlayerPosition.RIGHT_BACK, FKTeamId =1, PlayerBirthDate="2000/04/30" });
        }
    }
}
