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



        static FootballManagerModel()
        {
            Players = new List<Player>();
            Teams = new List<Team>();
            Stadiums = new List<Stadium>();
            LoadInitialData();
        }

        private static void LoadInitialData()
        {
            Stadiums.Add(new Stadium { StadiumId = 1, StadiumName = "Orlando Stadium", StadiumCapacity = 20000 });
            Stadiums.Add(new Stadium { StadiumId = 2, StadiumName = "Manchester City Stadium", StadiumCapacity = 55017 });
            Teams.Add(new Team { TeamId = 1, TeamLocation = "Soweto", TeamName = "Orlando Pirates", FKStadiumId = 1 });
            Teams.Add(new Team { TeamId = 2, TeamLocation = "Manchester", TeamName = "Manchester City", FKStadiumId = 2 });
            Players.Add(new Player { PlayerId = 1, PlayerName = "Thabiso", PlayerSurname = "Monyane", PlayerNumber = 2, PlayerPosition = PlayerPosition.GOALKEEPER, FKTeamId = 1, PlayerBirthDate = "2000/04/30" });
            Players.Add(new Player { PlayerId = 2, PlayerName = "Joris", PlayerSurname = "Delle", PlayerNumber = 1, PlayerPosition = PlayerPosition.BACK, FKTeamId = 1, PlayerBirthDate = "1990/03/29" });
            Players.Add(new Player { PlayerId = 3, PlayerName = "Ruben", PlayerSurname = "Dias", PlayerNumber = 3, PlayerPosition = PlayerPosition.CENTRE, FKTeamId = 2, PlayerBirthDate = "1997/05/14" });

        }

        internal static List<Team> GetTeams()
        {
            return Teams;
        }

        /*
* Returns list of all players
*/
        public static List<PlayerTeam> GetPlayers()
        {
            var pls = (from pl in Players
                       join tm in Teams on pl.FKTeamId equals tm.TeamId
                       select new PlayerTeam
                       {
                           PlayerId = pl.PlayerId,
                           PlayerName = pl.PlayerName,
                           PlayerSurname = pl.PlayerSurname,
                           PlayerDateOfBirth = pl.PlayerBirthDate,
                           PlayerNumber = pl.PlayerNumber,
                           PlayerPosition = pl.PlayerPosition.ToString().Replace('_', ' '),
                           PlayerTeamName = tm.TeamName
                       }
                      ).ToList();

            return pls;
        }
        /*
         * Returns list of players of a specific team
         */
        public static List<PlayerTeam> GetPlayersInTeam(int teamId)
        {
            var pls = (from pl in Players
                       join tm in Teams on pl.FKTeamId equals tm.TeamId
                       where tm.TeamId == teamId
                       select new PlayerTeam
                       {
                           PlayerId = pl.PlayerId,
                           PlayerName = pl.PlayerName,
                           PlayerSurname = pl.PlayerSurname,
                           PlayerDateOfBirth = pl.PlayerBirthDate,
                           PlayerNumber = pl.PlayerNumber,
                           PlayerPosition = pl.PlayerPosition.ToString().Replace('_', ' '),
                           PlayerTeamName = tm.TeamName

                       }).ToList();

            return pls;
        }
        /*
         * Inserts new player. Returns true if insert is sucessful.
         */
        public static bool CreatePlayer(int teamId, string playerName, string playerSurname, int playerNumber, PlayerPosition playerPosition, string playerBirthRate)
        {

            bool result = false;
            if (DateTime.TryParse(playerBirthRate, out DateTime dateResult) && Teams.Exists(x => x.TeamId == teamId))
            {
                long MaxPlayerId = Players.Max(x => x.PlayerId);
                Players.Add(new Player
                {
                    PlayerId = MaxPlayerId + 1,
                    PlayerName = playerName,
                    PlayerSurname = playerSurname,
                    PlayerNumber = playerNumber,
                    PlayerPosition = playerPosition,
                    FKTeamId = teamId,
                    PlayerBirthDate = playerBirthRate
                });
                result = true;
            }
            return result;
        }
        /*
        * Moves a player to a new team
        */
        public static bool MovePlayerToTeam(long playerId, int teamId)
        {
            bool result = false;
            if (Players.Exists(x => x.PlayerId == playerId && Teams.Exists(x => x.TeamId == teamId)))
            {
                Players.Find(x => x.PlayerId == playerId).FKTeamId = teamId;
                result = true;
            }
            return result;
        }
        /*
         * Adds new team, returns team details or null if unable to add
         */
        public static Team CreateTeam(string teamLocation, string teamName, int stadiumId)
        {
            Team result = null;
            if (Stadiums.Exists(x => x.StadiumId == stadiumId))
            {
                int maxTeamId = Teams.Max(x => x.TeamId);
                result = new Team
                {
                    TeamId = maxTeamId + 1,
                    TeamLocation = teamLocation,
                    TeamName = teamName,
                    FKStadiumId = stadiumId
                };
                Teams.Add(result);

            }
            return result;
        }
        /*
         * Adds new stadium and its data, including its id
         */
        public static Stadium CreateStadium(string stadiumName, int stadiumCapacity)
        {
            Stadium result;
            int maxStadiumId = Teams.Max(x => x.TeamId);
            result = new Stadium
            {
                StadiumId = maxStadiumId + 1,
                StadiumName = stadiumName,
                StadiumCapacity = stadiumCapacity
            };
            Stadiums.Add(result);
            return result;
        }
    }
}
