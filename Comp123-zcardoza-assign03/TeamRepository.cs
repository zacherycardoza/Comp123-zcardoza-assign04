using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace Comp123_zcardoza_assign03
{
    internal class TeamRepository : IRepository
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
            foreach (Team team in _Teams)
                if(team.TeamId == currentTeamId) {
                    team.Roster.Remove(player);
                    break;
                }         
            foreach(Team team in _Teams)            
                if(team.TeamId == newTeamId) {
                    if (team.Roster == null)
                        team.Roster = new List<Player>();
                    team.Roster.Add(player);
                    player.Team = team;
                    break;
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

                foreach (Team team in _Teams)  
                    if (team.Roster != null)
                        foreach (Player player in team.Roster)
                            player.Team = team;            
            }

            catch (FileNotFoundException){
                MessageBox.Show("wHeRe FiLe?");
            }
        }
        public void Save(string teamRepository)
        {         
            try {
                foreach (Team team in _Teams)
                    if (team.Roster != null)
                        foreach (Player player in team.Roster)                   
                            player.Team = null;
                                   
                string serializedData = JsonSerializer.Serialize(_Teams);
                File.WriteAllText(teamRepository, serializedData);
            }
            catch {
                MessageBox.Show("FAILED TO SAVE");
            }
        }
        public void Save(string teamRepository, Team teamToAdd)
        {
            try
            {
                _Teams.Add(teamToAdd);
                foreach (Team team in _Teams)
                    if(team.Roster != null)
                        foreach (Player player in team.Roster)
                            player.Team = null;

                string serializedData = JsonSerializer.Serialize(_Teams);
                File.WriteAllText(teamRepository, serializedData);
            }
            catch
            {
                MessageBox.Show("FAILED TO SAVE");
            }
        }
    }
}
