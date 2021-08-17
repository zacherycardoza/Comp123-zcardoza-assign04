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
    public partial class SeasonForm : Form
    {
        TeamRepository _teamRepository;
        MatchupRepository _matchupRepository;
        public SeasonForm()
        {
            InitializeComponent();
            _teamRepository = new TeamRepository("teamData.json");
            _matchupRepository = new MatchupRepository("matchupDataFile.json");
            if (_matchupRepository.Matchups != null)
                SeasonMatchupDataGrid.DataSource = _matchupRepository.Matchups;
        }

        private void ChangeToTeamViewButton_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.Count > 1)
                foreach (Form frm in Application.OpenForms)
                    if (frm.Name == "Form1")
                    {
                        Form main = frm as Form1;
                        main.Show();
                        break;
                    }
            Close();
        }

        private void GenerateSeasonButton_Click(object sender, EventArgs e)
        {
            _matchupRepository.GenerateSeason(_teamRepository.Teams);
            SeasonMatchupDataGrid.DataSource = _matchupRepository.Matchups;
        }
    }
}
