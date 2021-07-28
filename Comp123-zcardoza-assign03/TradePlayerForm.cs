using System;
using System.Windows.Forms;

namespace Comp123_zcardoza_assign03
{
    public partial class TradePlayerForm : Form
    {
        private Player _player;
        private TeamRepository _teamRepository;
        public TradePlayerForm()
        {
            InitializeComponent();
            _teamRepository = new TeamRepository("teamData.json");  
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {   
            if (possibleTeamList.SelectedItem != null)
            {
                foreach (Team Team in _teamRepository.Teams)               
                    foreach (Player player in Team.Roster)                    
                        if (player.Name == playerNameLabel.Text)
                            _player = player;
                      
                foreach (Team team in _teamRepository.Teams)
                    if (team.Name == possibleTeamList.SelectedItem.ToString()) {
                        _teamRepository.TradePlayer(_player, _player.Team.TeamId, team.TeamId);
                        break;
                    }

                Form1 Main = new Form1();
                Main.Location = Location;               
                Main.Show();
                Close();
            }
            else 
                MessageBox.Show("Select a Team.");   
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Form1 Main = new Form1();
            Main.Location = Location;
            Main.Show();
            Close();
        }
    }
}
