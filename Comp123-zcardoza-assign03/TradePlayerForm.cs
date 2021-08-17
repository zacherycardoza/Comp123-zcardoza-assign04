using System;
using System.Windows.Forms;

namespace Comp123_zcardoza_assign03
{
    public partial class TradePlayerForm : Form
    {
        private Player _player;
        private readonly TeamRepository _teamRepository;
        public TradePlayerForm()
        {
            InitializeComponent();
            _teamRepository = new TeamRepository("teamData.json");  
        }


        private void AcceptTradeButton_Click(object sender, EventArgs e)
        {
            if (possibleTeamList.SelectedItem != null)
            {
                foreach (Team team in _teamRepository.Teams) 
                    if (team.Roster != null)
                        foreach (Player player in team.Roster)                    
                            if (player.Name == playerNameLabel.Text)
                                _player = player;
                      
                foreach (Team team in _teamRepository.Teams)
                    if (team.Name == possibleTeamList.SelectedItem.ToString()) {
                        _teamRepository.TradePlayer(_player, _player.Team.TeamId, team.TeamId);
                        break;
                    }

                if (Application.OpenForms.Count > 1)
                    foreach (Form frm in Application.OpenForms)       
                        if (frm.Name == "Form1") {
                            Form main = frm as Form1;
                            main.Show();
                            break;
                        }
                _teamRepository.Save("teamData.json");
                Close();
            }
            else 
                MessageBox.Show("Select a Team.");   
        }

        private void CancelTradeButton_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.Count > 1)            
                foreach (Form frm in Application.OpenForms)                  
                    if (frm.Name == "Form1") {
                        Form main = frm as Form1;
                        main.Show();
                        break;
                    }
                                  
            Close();
        }
    }
}
