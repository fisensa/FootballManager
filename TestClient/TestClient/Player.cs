using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FootballManager.Models
{
    public class Player
    {
        public long PlayerId { get; set; }
        public string PlayerName { get; set; }
        public string PlayerSurname { get; set; }
        public string PlayerBirthDate { get; set; }
        public int PlayerNumber { get; set; }
        public PlayerPosition PlayerPosition { get; set; }
        public int PlayerHeightCm { get; set; }
        public int PlayerWeightKg { get; set; }
        public int FKTeamId { get; set; }
        public override string ToString()
        {
            return PlayerName;
        }
    }

    public enum PlayerPosition { RIGHT_BACK, CENTRE_BACK, LEFT_BACK, CENTRE_MIDFIELDER, LEFT_MIDFIELDER, RIGHT_MIDFIELDER }


}
