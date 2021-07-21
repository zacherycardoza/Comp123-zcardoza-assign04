#region
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
#endregion

namespace Comp123_zcardoza_assign03
{
    public partial class Form1 : Form
    {
        private TeamRepository _teamRepository;
        public Form1()
        {
            InitializeComponent();
            _teamRepository = new TeamRepository("teamData.json");

            foreach(Team team in _teamRepository.Teams)
            {
                teamList.Items.Add(team.Name);
            }
            try {
                teamList.SelectedIndex = 0;

            }
            catch {
                throw new Exception();
            }            
        }
        private void TradePlayerButton_Click(object sender, EventArgs e)
        {
            TradePlayerForm tradePlayerForm = new TradePlayerForm();
            tradePlayerForm.playerNameLabel.Text = playerList.SelectedItem.ToString();
            tradePlayerForm.Enabled = true; 
            tradePlayerForm.Location = this.Location; 
            tradePlayerForm.Show();
            tradePlayerForm.Activate();
            this.Hide();
        }

        private void teamList_SelectedIndexChanged(object sender, EventArgs e)
        {
            playerList.Items.Clear();
            foreach (Player player in _teamRepository.Teams[teamList.SelectedIndex].Roster)
            {
                playerList.Items.Add(player.Name);
            }    
        }
    }
}
