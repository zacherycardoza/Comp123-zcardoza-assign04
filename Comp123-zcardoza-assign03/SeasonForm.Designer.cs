
namespace Comp123_zcardoza_assign03
{
    partial class SeasonForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainPanel = new System.Windows.Forms.Panel();
            this.SeasonMatchupDataGrid = new System.Windows.Forms.DataGridView();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.SeasonManagerLabel = new System.Windows.Forms.Label();
            this.GenerateSeasonButton = new System.Windows.Forms.Button();
            this.Header = new System.Windows.Forms.Panel();
            this.SideMenu = new System.Windows.Forms.Panel();
            this.ChangeToTeamViewButton = new System.Windows.Forms.Button();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SeasonMatchupDataGrid)).BeginInit();
            this.HeaderPanel.SuspendLayout();
            this.Header.SuspendLayout();
            this.SideMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.MainPanel.Controls.Add(this.SeasonMatchupDataGrid);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(186, 100);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(765, 477);
            this.MainPanel.TabIndex = 7;
            // 
            // SeasonMatchupDataGrid
            // 
            this.SeasonMatchupDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.SeasonMatchupDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SeasonMatchupDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SeasonMatchupDataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.SeasonMatchupDataGrid.Location = new System.Drawing.Point(0, 0);
            this.SeasonMatchupDataGrid.Name = "SeasonMatchupDataGrid";
            this.SeasonMatchupDataGrid.RowHeadersWidth = 62;
            this.SeasonMatchupDataGrid.RowTemplate.Height = 28;
            this.SeasonMatchupDataGrid.Size = new System.Drawing.Size(765, 477);
            this.SeasonMatchupDataGrid.TabIndex = 0;
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(132)))), ((int)(((byte)(117)))));
            this.HeaderPanel.Controls.Add(this.HeaderLabel);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(186, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(765, 100);
            this.HeaderPanel.TabIndex = 6;
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.HeaderLabel.Location = new System.Drawing.Point(148, 0);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(493, 96);
            this.HeaderLabel.TabIndex = 0;
            this.HeaderLabel.Text = "Season View";
            // 
            // SeasonManagerLabel
            // 
            this.SeasonManagerLabel.AutoSize = true;
            this.SeasonManagerLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SeasonManagerLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeasonManagerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.SeasonManagerLabel.Location = new System.Drawing.Point(2, 36);
            this.SeasonManagerLabel.Name = "SeasonManagerLabel";
            this.SeasonManagerLabel.Size = new System.Drawing.Size(181, 27);
            this.SeasonManagerLabel.TabIndex = 0;
            this.SeasonManagerLabel.Text = "Season Manager";
            // 
            // GenerateSeasonButton
            // 
            this.GenerateSeasonButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GenerateSeasonButton.FlatAppearance.BorderSize = 0;
            this.GenerateSeasonButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GenerateSeasonButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenerateSeasonButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(132)))), ((int)(((byte)(117)))));
            this.GenerateSeasonButton.Location = new System.Drawing.Point(0, 502);
            this.GenerateSeasonButton.Name = "GenerateSeasonButton";
            this.GenerateSeasonButton.Size = new System.Drawing.Size(186, 75);
            this.GenerateSeasonButton.TabIndex = 0;
            this.GenerateSeasonButton.Text = "Generate Season Matchups";
            this.GenerateSeasonButton.UseVisualStyleBackColor = true;
            this.GenerateSeasonButton.Click += new System.EventHandler(this.GenerateSeasonButton_Click);
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(71)))), ((int)(((byte)(63)))));
            this.Header.Controls.Add(this.SeasonManagerLabel);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(186, 100);
            this.Header.TabIndex = 0;
            // 
            // SideMenu
            // 
            this.SideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(71)))), ((int)(((byte)(63)))));
            this.SideMenu.Controls.Add(this.GenerateSeasonButton);
            this.SideMenu.Controls.Add(this.ChangeToTeamViewButton);
            this.SideMenu.Controls.Add(this.Header);
            this.SideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideMenu.Location = new System.Drawing.Point(0, 0);
            this.SideMenu.Name = "SideMenu";
            this.SideMenu.Size = new System.Drawing.Size(186, 577);
            this.SideMenu.TabIndex = 5;
            // 
            // ChangeToTeamViewButton
            // 
            this.ChangeToTeamViewButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ChangeToTeamViewButton.FlatAppearance.BorderSize = 0;
            this.ChangeToTeamViewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeToTeamViewButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeToTeamViewButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(132)))), ((int)(((byte)(117)))));
            this.ChangeToTeamViewButton.Location = new System.Drawing.Point(0, 100);
            this.ChangeToTeamViewButton.Name = "ChangeToTeamViewButton";
            this.ChangeToTeamViewButton.Size = new System.Drawing.Size(186, 75);
            this.ChangeToTeamViewButton.TabIndex = 1;
            this.ChangeToTeamViewButton.Text = "Team View";
            this.ChangeToTeamViewButton.UseVisualStyleBackColor = true;
            this.ChangeToTeamViewButton.Click += new System.EventHandler(this.ChangeToTeamViewButton_Click);
            // 
            // SeasonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(951, 577);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.HeaderPanel);
            this.Controls.Add(this.SideMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SeasonForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SeasonForm";
            this.MainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SeasonMatchupDataGrid)).EndInit();
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            this.SideMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.Label SeasonManagerLabel;
        private System.Windows.Forms.Button GenerateSeasonButton;
        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Panel SideMenu;
        private System.Windows.Forms.DataGridView SeasonMatchupDataGrid;
        private System.Windows.Forms.Button ChangeToTeamViewButton;
    }
}