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
            /*
            foreach (Team Team in _teamRepository.Teams)
            {
                foreach(Player Player in Team.Roster)
                {
                    if (Player.Name == playerNameLabel.Text)
                    {
                        _player = Player;
                    }
                }
            }

            playerCurrentTeam.Text = _player.Team.Name;
            

            foreach (Team Team in _teamRepository.Teams)
            {
                if (Team.Name != _player.Team.Name)
                {
                    possibleTeamList.Items.Add(Team);
                }
            } */
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {

        }
    }
}
