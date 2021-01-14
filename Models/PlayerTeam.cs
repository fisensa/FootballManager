using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FootballManager.Models
{
    public class PlayerTeam
    {
        public long PlayerId { get; set; }
        public string PlayerName { get; set; }
        public string PlayerSurname { get; set; }
        public string PlayerDateOfBirth { get; set; }
        public int PlayerNumber { get; set; }
        public string PlayerPosition { get; set; }
        public string PlayerTeamName { get; set; }
    }
}
