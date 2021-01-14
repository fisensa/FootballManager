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
        [HttpGet]

        public IEnumerable<PlayerTeam> Get()
        {

            return FootballManagerModel.GetPlayers();
        }
        [HttpGet("{id}")]
        public IEnumerable<PlayerTeam> Get(int id)
        {
            return FootballManagerModel.GetPlayersInTeam(id);
        }

        [HttpPost]
        public bool InsertPlayer([FromBody] Player value)
        {

            int teamId = value.FKTeamId;
            string playerName = value.PlayerName;
            string playerSurname = value.PlayerSurname;
            int playerNumber = value.PlayerNumber;
            PlayerPosition playerPosition = value.PlayerPosition;
            string playerBirthRate = value.PlayerBirthDate;
            return FootballManagerModel.InsertPlayer(teamId, playerName, playerSurname, playerNumber, playerPosition, playerBirthRate);

        }

        [HttpPost]
        public bool MovePlayerToTeam(long playerId, int teamId)
        {
            return FootballManagerModel.MovePlayerToTeam(playerId, teamId);
        }

        [HttpPost]
        public Team AddTeam([FromBody] Team team)
        {
            string teamLocation = team.TeamLocation;
            string teamName = team.TeamLocation;
            int stadiumId = team.FKStadiumId;
            return FootballManagerModel.AddTeam(teamLocation,teamName,stadiumId);
        }

    }
}
