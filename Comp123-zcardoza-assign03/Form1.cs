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
        private readonly TeamRepository _teamRepository;
        public Form1()
        {
            InitializeComponent();
            _teamRepository = new TeamRepository("teamData.json");
            foreach(Team team in _teamRepository.Teams)
                teamList.Items.Add(team.Name);
            teamList.SelectedIndex = 0;           
        }
        private void TradePlayerButton_Click(object sender, EventArgs e)
        {
            if (playerList.SelectedItem != null) {
                TradePlayerForm tradePlayerForm = new TradePlayerForm();
                tradePlayerForm.playerNameLabel.Text = playerList.SelectedItem.ToString();
                tradePlayerForm.playerCurrentTeam.Text = teamList.SelectedItem.ToString();
                foreach (Team Team in _teamRepository.Teams)
                    if (Team.Name != teamList.SelectedItem.ToString())
                        tradePlayerForm.possibleTeamList.Items.Add(Team.Name);
                tradePlayerForm.Location = Location;
                tradePlayerForm.Show();
                Hide();
            }
            else
                MessageBox.Show("Select a Player.");
        }

        private void TeamList_SelectedIndexChanged(object sender, EventArgs e)
        {
            playerList.Items.Clear();
            if (_teamRepository.Teams[teamList.SelectedIndex].Roster != null)
                foreach (Player player in _teamRepository.Teams[teamList.SelectedIndex].Roster)
                    playerList.Items.Add(player.Name);           
        }

        private void AddTeamButton_Click(object sender, EventArgs e)
        {
            addTeamPanel.Visible = true;
            /* Linq
            List<Player> players = new List<Player>();
            foreach (Team team in _teamRepository.Teams)
                if (team.Roster != null)
                    foreach (Player player in team.Roster)
                        players.Add(player);
            List<Player> playersidovernumber = players.Where(player => player.PlayerId >= 30).ToList();
            string playerIDString = "Players Ids";
            foreach (Player player in playersidovernumber)
                playerIDString += $"\nPlayer ID: {player.PlayerId} ; Player Name: {player.Name}";
            MessageBox.Show(playerIDString);*/ 
        }


        private void AddPlayerButton_Click(object sender, EventArgs e)
        {
            string playerIDString = "Players Ids";

            foreach (Team team in _teamRepository.Teams)
                if (team.Roster != null)
                    foreach (Player player in team.Roster)
                        playerIDString += $"\nPlayer ID: {player.PlayerId} ; Player Name: {player.Name}";

            MessageBox.Show(playerIDString);
        }

        private void ChangeToSeasonViewerButton_Click(object sender, EventArgs e)
        {
            
        }

        private void ConfirmAddTeamButton_Click(object sender, EventArgs e)
        {
            addTeamPanel.Visible = false;
            if (NewTeamNameBox.TextLength > 0)
            {
                Team newTeam = new Team(NewTeamNameBox.Text);
                if (NewTeamPlayer1Box.TextLength > 0)
                {
                    newTeam.Roster = new List<Player> { new Player(NewTeamPlayer1Box.Text, newTeam) };

                    if (NewTeamPlayer2Box.TextLength > 0)
                        newTeam.Roster.Add(new Player(NewTeamPlayer2Box.Text, newTeam)); 
                    if (NewTeamPlayer3Box.TextLength > 0)
                        newTeam.Roster.Add(new Player(NewTeamPlayer3Box.Text, newTeam));
                    if (NewTeamPlayer4Box.TextLength > 0)
                        newTeam.Roster.Add(new Player(NewTeamPlayer4Box.Text, newTeam));
                    if (NewTeamPlayer5Box.TextLength > 0)
                        newTeam.Roster.Add(new Player(NewTeamPlayer5Box.Text, newTeam));
                    if (NewTeamPlayer6Box.TextLength > 0)
                        newTeam.Roster.Add(new Player(NewTeamPlayer6Box.Text, newTeam));
                    if (NewTeamPlayer7Box.TextLength > 0)
                        newTeam.Roster.Add(new Player(NewTeamPlayer7Box.Text, newTeam));
                    if (NewTeamPlayer8Box.TextLength > 0)
                        newTeam.Roster.Add(new Player(NewTeamPlayer8Box.Text, newTeam));
                }
                
                _teamRepository.Save("teamData.Json", newTeam);

                teamList.Items.Add(newTeam.Name);
                teamList.SelectedItem = newTeam.Name;
                playerList.Items.Clear();
                if (newTeam.Roster != null)
                    foreach (Player player in newTeam.Roster)
                        playerList.Items.Add(player.Name);
            }
            else
                MessageBox.Show("Enter a Name For Your Team");
        }
    }
}
