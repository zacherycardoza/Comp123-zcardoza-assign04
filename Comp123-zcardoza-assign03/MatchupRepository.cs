using System;
using System.IO;
using System.Collections.Generic;
using System.Text.Json;
using System.Windows.Forms;
using System.Linq;

namespace Comp123_zcardoza_assign03
{
    internal class MatchupRepository : IRepository
    {
        private List<Matchup> _Matchups;
        public List<Matchup> Matchups { get => _Matchups; }

        public MatchupRepository(string matchupRepositoryFile)
        {
            Load(matchupRepositoryFile);
        }

        public void Load(string matchupRepositoryFile)
        {
            try {
                if (!File.Exists(matchupRepositoryFile))
                    throw new FileNotFoundException();
                
                string matchupData = File.ReadAllText(matchupRepositoryFile);
                _Matchups = JsonSerializer.Deserialize<List<Matchup>>(matchupData);         
            }

            catch (FileNotFoundException){
                MessageBox.Show("wHeRe MaTcHuP fIlE?");
            }
        }

        public void Save(string matchupRepositoryFile)
        {
            try {    
                foreach (Matchup matchup in _Matchups)
                {
                    foreach (Player player in matchup.HomeTeam.Roster)
                        player.Team = null;
                    foreach (Player player in matchup.AwayTeam.Roster)
                        player.Team = null;
                }

                string serializedData = JsonSerializer.Serialize(_Matchups);
                File.WriteAllText(matchupRepositoryFile, serializedData);
            }
            catch {
                MessageBox.Show("FAILED TO SAVE");
            }
        }

        public void GenerateSeason(List<Team> currentTeams)
        {
            List<Team> validCurrentSeasonTeams = new List<Team>();
            validCurrentSeasonTeams = currentTeams.Where(team => team.Roster != null).Where(team => team.Roster.Count > 0).ToList();
            _Matchups.Clear();
            foreach (Team homeTeam in validCurrentSeasonTeams) 
                foreach (Team awayTeam in validCurrentSeasonTeams)
                    if (awayTeam.TeamId != homeTeam.TeamId)
                        _Matchups.Add(new Matchup(homeTeam, awayTeam));
            Save("matchupDataFile.json");
        }
    }
}