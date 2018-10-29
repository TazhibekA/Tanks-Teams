using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLib.WordOfTanks
{
    public class Team
    {

        public string TeamName { get; set; }
        public List<Tank> Tanks { get; set; }

        public Team(string teamName, List<Tank> tanks)
        {
            Tanks = new List<Tank>();
            TeamName = teamName;
            Tanks = tanks;
        }


        public void  AddTank(Tank tank) {
            Tanks.Add(tank);
        }
 

        public static  Team operator *(Team firstTeam, Team secondTeam)
        {
            int firstTeamPoints = 0;
            int secondTeamPoints = 0;

            for (int i = 0; i < 5; i++)
            {
                if (firstTeam.Tanks[i].AmmunitionLevel > secondTeam.Tanks[i].AmmunitionLevel)
                    firstTeamPoints++;
                else
                    secondTeamPoints++;

                if (firstTeam.Tanks[i].ArmorLevel > secondTeam.Tanks[i].ArmorLevel)
                    firstTeamPoints++;
                else
                    secondTeamPoints++;

                if (firstTeam.Tanks[i].ManeuverabilityLevel > secondTeam.Tanks[i].ManeuverabilityLevel)
                    firstTeamPoints++;
                else
                    secondTeamPoints++;
            }

          

            if (firstTeamPoints > secondTeamPoints)
                return firstTeam;
            else
                return secondTeam;
        }
    }
}
