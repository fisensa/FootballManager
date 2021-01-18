using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FootballManager.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.Serialization.Json;

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
        public List<PlayerTeam> Get()
        {

            var s = FootballManagerModel.GetPlayers();
            return s;
        }

        /*
       * Get all teams
       */
        [Route("[action]")]
        public List<Team> GetTeams()
        {
            var s = FootballManagerModel.GetTeams();
            return s;
        }

        /*
        * Get players in specific team
        */
        [HttpGet("{id}")]
        public List<PlayerTeam> Get(int id)
        {
            return FootballManagerModel.GetPlayersInTeam(id);
        }

        [Route("[action]")]
        public List<Stadium> GetStadiums()
        {
            return FootballManagerModel.Stadiums;
        }


        /*
        * Create player
        */
        [Route("[action]")]
        [HttpPost]
        public bool CreatePlayer([FromBody] Player value)
        {

            int teamId = value.FKTeamId;
            string playerName = value.PlayerName;
            string playerSurname = value.PlayerSurname;
            int playerNumber = value.PlayerNumber;
            PlayerPosition playerPosition = (PlayerPosition) value.PlayerPosition;
            string playerBirthRate = value.PlayerBirthDate;
            return FootballManagerModel.CreatePlayer(teamId, playerName, playerSurname, playerNumber, playerPosition, playerBirthRate);

        }
        /*
        * Move player to the new team, returns team info, in case that needed for UI
        */
        [Route("[action]/{playerId}/{teamId}")]
        [HttpPost]
        public bool MovePlayerToTeam(long playerId, int teamId)
        {
            return FootballManagerModel.MovePlayerToTeam(playerId, teamId);
        }

        [Route("[action]")]
        [HttpPost]
        public Team CreateTeam([FromBody] Team team)
        {
            string teamLocation = team.TeamLocation;
            string teamName = team.TeamName;
            int stadiumId = team.FKStadiumId;
            return FootballManagerModel.CreateTeam(teamLocation, teamName, stadiumId);
        }

        /*
        * Create stadium, returns stadium info, in case needed for UI
        */
        [Route("[action]")]
        [HttpPost]
        public Stadium CreateStadium([FromBody] Stadium stadium)
        {
            string stadiumName = stadium.StadiumName;
            int capacity = stadium.StadiumCapacity;

            return FootballManagerModel.CreateStadium(stadiumName, capacity);
        }



    }
}
