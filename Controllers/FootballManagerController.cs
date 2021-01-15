using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FootballManager.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace FootballManager.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FootballManagerController : ControllerBase
    {
        /*
         * Get all players
         */
        [HttpGet]
        public IEnumerable<PlayerTeam> Get() => FootballManagerModel.GetPlayers();

        /*
        * Get players in specific team
        */
        [HttpGet("{id}")]
        public IEnumerable<PlayerTeam> Get(int id) => FootballManagerModel.GetPlayersInTeam(id);
        /*
        * Create player
        */
        [HttpPost]
        public bool CreatePlayer([FromBody] Player value)
        {

            int teamId = value.FKTeamId;
            string playerName = value.PlayerName;
            string playerSurname = value.PlayerSurname;
            int playerNumber = value.PlayerNumber;
            PlayerPosition playerPosition = value.PlayerPosition;
            string playerBirthRate = value.PlayerBirthDate;
            return FootballManagerModel.CreatePlayer(teamId, playerName, playerSurname, playerNumber, playerPosition, playerBirthRate);

        }
        /*
        * Move player to the new team, returns team info, in case that needed for UI
        */
        [HttpPost]
        public bool MovePlayerToTeam(long playerId, int teamId) => FootballManagerModel.MovePlayerToTeam(playerId, teamId);

        [HttpPost]
        public Team CreateTeam([FromBody] Team team)
        {
            string teamLocation = team.TeamLocation;
            string teamName = team.TeamLocation;
            int stadiumId = team.FKStadiumId;
            return FootballManagerModel.CreateTeam(teamLocation, teamName, stadiumId);
        }

        /*
        * Create stadium, returns stadium info, in case needed for UI
        */
        [HttpPost]
        public Stadium CreateStadium([FromBody] Stadium stadium)
        {
            string stadiumName = stadium.StadiumName;
            int capacity = stadium.StadiumCapacity;

            return FootballManagerModel.CreateStadium(stadiumName, capacity);
        }

    }
}
