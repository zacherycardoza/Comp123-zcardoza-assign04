using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace Comp123_zcardoza_assign03
{
    class TeamRepository
    {
        private List<Team> _Teams;
        public List<Team> Teams { get => _Teams; }

        public TeamRepository(string teamRepository)
        {
            Load(teamRepository);
        }
        public void TradePlayer(Player player, int currentTeamId, int newTeamId)
        {
            player.Team.Roster.Remove(player);
            foreach(Team team in _Teams)
            {
                if(team.TeamId == currentTeamId)
                {
                    team.Roster.Remove(player);
                    break;
                }
            }
            foreach(Team team in _Teams)
            {
                if(team.TeamId == newTeamId)
                {
                    team.Roster.Add(player);
                    break;
                }
            }
            Save("teamData.json");
        }
        public void Load(string teamRepository)
        {
            try {
                if (!File.Exists(teamRepository))
                    throw new FileNotFoundException();
                
                string teamData = File.ReadAllText(teamRepository);
                _Teams = JsonSerializer.Deserialize<List<Team>>(teamData);

                foreach(Team team in _Teams)
                {
                    foreach(Player player in team.Roster)
                    {
                        player.Team = team;
                    }
                }
            }

            catch (FileNotFoundException){
                MessageBox.Show("wHeRe FiLe?");
            }

            finally {
            }
        }
        public void Save(string teamRepository)
        {         
            try {
                MessageBox.Show("enter");
                string serializedData = JsonSerializer.Serialize(_Teams);
                File.WriteAllText(teamRepository, serializedData);
                MessageBox.Show("Serialized");
            }

            catch (JsonException e) {
                MessageBox.Show(e.Message);
            }

            catch {
                MessageBox.Show("FAILED TO SAVE");
            }
        }
    }
}
