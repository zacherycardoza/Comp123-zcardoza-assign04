using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            foreach (Team Team in _teamRepository.Teams)
            {
                foreach(Player player in Team.Roster)
                {
                    if(player.Name == playerNameLabel.Text)
                    {
                        _player = player;
                    }
                }    
            }
            foreach(Team team in _teamRepository.Teams)
            {
                if(team.Name == possibleTeamList.SelectedItem.ToString())
                {
                    _teamRepository.TradePlayer(_player, _player.Team.TeamId, team.TeamId);
                    break;
                }
            }
            Form1 Main = new Form1();
            Main.Enabled = true;
            Main.Location = this.Location;
            Main.Show();
            Main.Activate();
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Form1 Main = new Form1();
            Main.Enabled = true;
            Main.Location = this.Location;
            Main.Show();
            Main.Activate();
            this.Close();
        }

        private void possibleTeamList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
