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
            foreach (Team team in _teamRepository.Teams)
                TeamList.Items.Add(team.ToString());
            TeamList.SelectedIndex = 0;
        }   

        

        private void TeamList_SelectedIndexChanged(object sender, EventArgs e)
        {
            PlayerList.Items.Clear();
            _teamRepository = new TeamRepository("teamData.json");
            if (_teamRepository.Teams[TeamList.SelectedIndex].Roster != null)
                foreach (Player player in _teamRepository.Teams[TeamList.SelectedIndex].Roster)
                    PlayerList.Items.Add(player.Name);
        }

        private void TradePlayerButton_Click(object sender, EventArgs e)
        {
            if (PlayerList.SelectedItem != null) {
                TradePlayerForm tradePlayerForm = new TradePlayerForm();
                tradePlayerForm.playerNameLabel.Text = PlayerList.SelectedItem.ToString();
                tradePlayerForm.playerCurrentTeam.Text = TeamList.SelectedItem.ToString();
                foreach (Team Team in _teamRepository.Teams)
                    if (Team.Name != TeamList.SelectedItem.ToString())
                        tradePlayerForm.possibleTeamList.Items.Add(Team.Name);
                tradePlayerForm.Show();
                Hide();
                TeamList.SelectedIndex = 0;
            }
            else
                MessageBox.Show("Select a Player.");
        }

        private void AddConfirmButton_Click(object sender, EventArgs e)
        {
            if (AddPlayerNewNameBox.Visible == true) // Add player logic
            {
                if (AddPlayerNewTeamList.SelectedIndex != -1)
                {
                    if ( !string.IsNullOrEmpty(AddPlayerNewNameBox.Text) ) {
                        _teamRepository.Teams[AddPlayerNewTeamList.SelectedIndex].Roster.Add(new Player(AddPlayerNewNameBox.Text, _teamRepository.Teams[AddPlayerNewTeamList.SelectedIndex]));
                        _teamRepository.Save("teamData.json");
                        TeamList.SelectedIndex = 0;
                        AddPlayerNewNameBox.Visible = false;
                        AddPlayerNewTeamList.Visible = false;
                        AddPlayerPanel.Visible = false;
                    }
                    else { 
                        MessageBox.Show("Enter a Player Name");
                        return;
                    }
                }
                else { 
                    MessageBox.Show("Select a Team");
                    return;
                }
            }

            if (AddTeamNewName.Visible)                  //  Add Team (Optional Players) logic
            {
                if (!string.IsNullOrEmpty(AddTeamNewName.Text))
                {
                    Team newTeam = new Team(AddTeamNewName.Text);
                    if (AddTeamRosterPanel.Controls.Count >= 1)
                    {
                        newTeam.Roster = new List<Player>();
                        foreach (Control playerName in AddTeamRosterPanel.Controls)
                            if (!string.IsNullOrEmpty(playerName.Text))
                                newTeam.Roster.Add(new Player(playerName.Text, newTeam));
                    }
                    _teamRepository.Save("teamData.json", newTeam);
                    TeamList.Items.Add(newTeam);
                    TeamList.SelectedItem = newTeam;

                    AddTeamNewName.Visible = false;
                    AddTeamNameLabel.Visible = false;
                    AddTeamRosterLabel.Visible = false;
                    AddTeamRosterPanel.Visible = false;
                    AddTeamPanel.Visible = false;
                }
                else
                {
                    MessageBox.Show("Enter a Team Name");
                    return;
                }
            }
           

            AddConfirmButton.Visible = false; // Cleanup
            AddCancelButton.Visible = false;

            TeamList.Visible = true;
            PlayerList.Visible = true;
            ChangeToSeasonViewerButton.Visible = true;
            TradePlayerButton.Visible = true;
            AddPlayerButton.Visible = true;
            AddTeamButton.Visible = true;
            AddPlayerPanel.SendToBack();
            AddTeamPanel.SendToBack();
            MainPanel.BringToFront();
            MainPanel.Visible = true;
        }

        private void AddCancelButton_Click(object sender, EventArgs e)
        {
            if (AddPlayerNewNameBox.Visible == true) {
                AddPlayerNewNameBox.Visible = false;
                AddPlayerNewTeamList.Visible = false;
                AddPlayerPanel.SendToBack();
                AddPlayerPanel.Visible = false;
            }
            else {
                AddTeamNewName.Visible = false;
                AddTeamNameLabel.Visible = false;
                AddTeamRosterLabel.Visible = false;
                AddTeamRosterPlayerOneName.Visible = false;
                AddTeamPanel.SendToBack();
                AddTeamPanel.Visible = false;
            }

            AddConfirmButton.Visible = false;
            AddCancelButton.Visible = false;

            ChangeToSeasonViewerButton.Visible = true;
            TradePlayerButton.Visible = true;
            AddPlayerButton.Visible = true;
            AddTeamButton.Visible = true;
            TeamList.Visible = true;
            PlayerList.Visible = true;
            MainPanel.BringToFront();
            MainPanel.Visible = true;
        }

        private void AddPlayerButton_Click(object sender, EventArgs e)
        {
            TeamList.Visible = false;
            PlayerList.Visible = false;
            MainPanel.Visible = false;
            ChangeToSeasonViewerButton.Visible = false;
            TradePlayerButton.Visible = false;
            AddPlayerButton.Visible = false;
            AddTeamButton.Visible = false;

            AddPlayerNewTeamList.Items.Clear();
            foreach (Team team in _teamRepository.Teams)
                AddPlayerNewTeamList.Items.Add(team.Name);

            AddPlayerNewNameBox.Visible = true;
            AddPlayerNewTeamList.Visible = true;
            AddConfirmButton.Visible = true;
            AddCancelButton.Visible = true;
            AddPlayerNewTeamList.Visible = true;
            AddPlayerPanel.BringToFront();
            AddPlayerPanel.Visible = true;
        }

        private void AddTeamButton_Click(object sender, EventArgs e)
        {
            TeamList.Visible = false;
            PlayerList.Visible = false;
            MainPanel.Visible = false;
            ChangeToSeasonViewerButton.Visible = false;
            TradePlayerButton.Visible = false;
            AddPlayerButton.Visible = false;
            AddTeamButton.Visible = false;

            AddTeamNameLabel.Visible = true;
            AddTeamNewName.Visible = true;
            AddTeamRosterLabel.Visible = true;
            AddConfirmButton.Visible = true;
            AddCancelButton.Visible = true;
            AddTeamRosterPlayerOneName.Visible = true;
            AddTeamPanel.BringToFront();
            AddTeamPanel.Visible = true;
        }

        private void ChangeToSeasonViewerButton_Click_1(object sender, EventArgs e)
        {
            SeasonForm seasonForm = new SeasonForm();
            seasonForm.Show();
            Hide();
        }

        int x = 40;
        private void AddTeamRosterAdditionalPlayerButton_Click(object sender, EventArgs e)
        {
            if (AddTeamRosterPanel.Controls.Count <= 4)
            {
                TextBox txtBox = new TextBox
                {
                    Visible = true,
                    BackColor = Color.FromArgb(245, 248, 247),
                    BorderStyle = BorderStyle.FixedSingle,
                    Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0),
                    ForeColor = Color.FromArgb(46, 71, 63),
                    Location = new Point(0, x),
                    Size = new Size(405, 40)
                };
                x += 40;
                AddTeamRosterPanel.Controls.Add(txtBox);
            }
        }
    }
}
