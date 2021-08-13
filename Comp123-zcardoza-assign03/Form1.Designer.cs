
namespace Comp123_zcardoza_assign03
{
    partial class Form1
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
            this.Header = new System.Windows.Forms.Panel();
            this.SeasonManagerLabel = new System.Windows.Forms.Label();
            this.ChangeToSeasonViewerButton = new System.Windows.Forms.Button();
            this.SideMenu = new System.Windows.Forms.Panel();
            this.AddTeamButton = new System.Windows.Forms.Button();
            this.AddPlayerButton = new System.Windows.Forms.Button();
            this.TradePlayerButton = new System.Windows.Forms.Button();
            this.TeamList = new System.Windows.Forms.ListBox();
            this.PlayerList = new System.Windows.Forms.ListBox();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.AddPlayerPanel = new System.Windows.Forms.Panel();
            this.AddPlayerNameLabel = new System.Windows.Forms.Label();
            this.AddConfirmButton = new System.Windows.Forms.Button();
            this.AddPlayerNewNameBox = new System.Windows.Forms.TextBox();
            this.AddPlayerNewTeamLabel = new System.Windows.Forms.Label();
            this.AddPlayerNewTeamList = new System.Windows.Forms.ListBox();
            this.AddCancelButton = new System.Windows.Forms.Button();
            this.Header.SuspendLayout();
            this.SideMenu.SuspendLayout();
            this.HeaderPanel.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.AddPlayerPanel.SuspendLayout();
            this.SuspendLayout();
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
            // ChangeToSeasonViewerButton
            // 
            this.ChangeToSeasonViewerButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ChangeToSeasonViewerButton.FlatAppearance.BorderSize = 0;
            this.ChangeToSeasonViewerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeToSeasonViewerButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeToSeasonViewerButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(132)))), ((int)(((byte)(117)))));
            this.ChangeToSeasonViewerButton.Location = new System.Drawing.Point(0, 100);
            this.ChangeToSeasonViewerButton.Name = "ChangeToSeasonViewerButton";
            this.ChangeToSeasonViewerButton.Size = new System.Drawing.Size(186, 75);
            this.ChangeToSeasonViewerButton.TabIndex = 0;
            this.ChangeToSeasonViewerButton.Text = "Season View";
            this.ChangeToSeasonViewerButton.UseVisualStyleBackColor = true;
            // 
            // SideMenu
            // 
            this.SideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(71)))), ((int)(((byte)(63)))));
            this.SideMenu.Controls.Add(this.AddCancelButton);
            this.SideMenu.Controls.Add(this.AddConfirmButton);
            this.SideMenu.Controls.Add(this.AddTeamButton);
            this.SideMenu.Controls.Add(this.AddPlayerButton);
            this.SideMenu.Controls.Add(this.TradePlayerButton);
            this.SideMenu.Controls.Add(this.ChangeToSeasonViewerButton);
            this.SideMenu.Controls.Add(this.Header);
            this.SideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideMenu.Location = new System.Drawing.Point(0, 0);
            this.SideMenu.Name = "SideMenu";
            this.SideMenu.Size = new System.Drawing.Size(186, 577);
            this.SideMenu.TabIndex = 0;
            // 
            // AddTeamButton
            // 
            this.AddTeamButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddTeamButton.FlatAppearance.BorderSize = 0;
            this.AddTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddTeamButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddTeamButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(132)))), ((int)(((byte)(117)))));
            this.AddTeamButton.Location = new System.Drawing.Point(0, 325);
            this.AddTeamButton.Name = "AddTeamButton";
            this.AddTeamButton.Size = new System.Drawing.Size(186, 75);
            this.AddTeamButton.TabIndex = 3;
            this.AddTeamButton.Text = "Add Team";
            this.AddTeamButton.UseVisualStyleBackColor = true;
            this.AddTeamButton.Click += new System.EventHandler(this.AddTeamButton_Click);
            // 
            // AddPlayerButton
            // 
            this.AddPlayerButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddPlayerButton.FlatAppearance.BorderSize = 0;
            this.AddPlayerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddPlayerButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPlayerButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(132)))), ((int)(((byte)(117)))));
            this.AddPlayerButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddPlayerButton.Location = new System.Drawing.Point(0, 250);
            this.AddPlayerButton.Name = "AddPlayerButton";
            this.AddPlayerButton.Size = new System.Drawing.Size(186, 75);
            this.AddPlayerButton.TabIndex = 2;
            this.AddPlayerButton.Text = "Add Player";
            this.AddPlayerButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddPlayerButton.UseVisualStyleBackColor = true;
            this.AddPlayerButton.Click += new System.EventHandler(this.AddPlayerButton_Click);
            // 
            // TradePlayerButton
            // 
            this.TradePlayerButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.TradePlayerButton.FlatAppearance.BorderSize = 0;
            this.TradePlayerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TradePlayerButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TradePlayerButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(132)))), ((int)(((byte)(117)))));
            this.TradePlayerButton.Location = new System.Drawing.Point(0, 175);
            this.TradePlayerButton.Name = "TradePlayerButton";
            this.TradePlayerButton.Size = new System.Drawing.Size(186, 75);
            this.TradePlayerButton.TabIndex = 1;
            this.TradePlayerButton.Text = "Trade Player";
            this.TradePlayerButton.UseVisualStyleBackColor = true;
            this.TradePlayerButton.Click += new System.EventHandler(this.TradePlayerButton_Click);
            // 
            // TeamList
            // 
            this.TeamList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.TeamList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TeamList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TeamList.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(132)))), ((int)(((byte)(117)))));
            this.TeamList.FormattingEnabled = true;
            this.TeamList.ItemHeight = 27;
            this.TeamList.Location = new System.Drawing.Point(6, 6);
            this.TeamList.Name = "TeamList";
            this.TeamList.Size = new System.Drawing.Size(256, 270);
            this.TeamList.TabIndex = 1;
            this.TeamList.SelectedIndexChanged += new System.EventHandler(this.TeamList_SelectedIndexChanged);
            // 
            // PlayerList
            // 
            this.PlayerList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.PlayerList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PlayerList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PlayerList.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(132)))), ((int)(((byte)(117)))));
            this.PlayerList.FormattingEnabled = true;
            this.PlayerList.ItemHeight = 27;
            this.PlayerList.Location = new System.Drawing.Point(290, 6);
            this.PlayerList.Name = "PlayerList";
            this.PlayerList.Size = new System.Drawing.Size(256, 270);
            this.PlayerList.TabIndex = 2;
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(132)))), ((int)(((byte)(117)))));
            this.HeaderPanel.Controls.Add(this.HeaderLabel);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(186, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(765, 100);
            this.HeaderPanel.TabIndex = 3;
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.HeaderLabel.Location = new System.Drawing.Point(148, 0);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(436, 96);
            this.HeaderLabel.TabIndex = 0;
            this.HeaderLabel.Text = "Team View";
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.MainPanel.Controls.Add(this.TeamList);
            this.MainPanel.Controls.Add(this.AddPlayerPanel);
            this.MainPanel.Location = new System.Drawing.Point(186, 100);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(765, 477);
            this.MainPanel.TabIndex = 4;
            // 
            // AddPlayerPanel
            // 
            this.AddPlayerPanel.Controls.Add(this.PlayerList);
            this.AddPlayerPanel.Controls.Add(this.AddPlayerNewTeamList);
            this.AddPlayerPanel.Controls.Add(this.AddPlayerNewTeamLabel);
            this.AddPlayerPanel.Controls.Add(this.AddPlayerNameLabel);
            this.AddPlayerPanel.Controls.Add(this.AddPlayerNewNameBox);
            this.AddPlayerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddPlayerPanel.Location = new System.Drawing.Point(0, 0);
            this.AddPlayerPanel.Name = "AddPlayerPanel";
            this.AddPlayerPanel.Size = new System.Drawing.Size(765, 477);
            this.AddPlayerPanel.TabIndex = 3;
            // 
            // AddPlayerNameLabel
            // 
            this.AddPlayerNameLabel.AutoSize = true;
            this.AddPlayerNameLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPlayerNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(71)))), ((int)(((byte)(63)))));
            this.AddPlayerNameLabel.Location = new System.Drawing.Point(16, 20);
            this.AddPlayerNameLabel.Name = "AddPlayerNameLabel";
            this.AddPlayerNameLabel.Size = new System.Drawing.Size(166, 31);
            this.AddPlayerNameLabel.TabIndex = 0;
            this.AddPlayerNameLabel.Text = "Player Name:";
            // 
            // AddConfirmButton
            // 
            this.AddConfirmButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AddConfirmButton.FlatAppearance.BorderSize = 0;
            this.AddConfirmButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddConfirmButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddConfirmButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(132)))), ((int)(((byte)(117)))));
            this.AddConfirmButton.Location = new System.Drawing.Point(0, 502);
            this.AddConfirmButton.Name = "AddConfirmButton";
            this.AddConfirmButton.Size = new System.Drawing.Size(186, 75);
            this.AddConfirmButton.TabIndex = 4;
            this.AddConfirmButton.Text = "Confirm";
            this.AddConfirmButton.UseVisualStyleBackColor = true;
            this.AddConfirmButton.Visible = false;
            this.AddConfirmButton.Click += new System.EventHandler(this.AddConfirmButton_Click);
            // 
            // AddPlayerNewNameBox
            // 
            this.AddPlayerNewNameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.AddPlayerNewNameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AddPlayerNewNameBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPlayerNewNameBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(71)))), ((int)(((byte)(63)))));
            this.AddPlayerNewNameBox.Location = new System.Drawing.Point(22, 65);
            this.AddPlayerNewNameBox.Name = "AddPlayerNewNameBox";
            this.AddPlayerNewNameBox.Size = new System.Drawing.Size(484, 38);
            this.AddPlayerNewNameBox.TabIndex = 1;
            this.AddPlayerNewNameBox.Visible = false;
            // 
            // AddPlayerNewTeamLabel
            // 
            this.AddPlayerNewTeamLabel.AutoSize = true;
            this.AddPlayerNewTeamLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPlayerNewTeamLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(71)))), ((int)(((byte)(63)))));
            this.AddPlayerNewTeamLabel.Location = new System.Drawing.Point(16, 134);
            this.AddPlayerNewTeamLabel.Name = "AddPlayerNewTeamLabel";
            this.AddPlayerNewTeamLabel.Size = new System.Drawing.Size(177, 31);
            this.AddPlayerNewTeamLabel.TabIndex = 2;
            this.AddPlayerNewTeamLabel.Text = "Player\'s Team:";
            // 
            // AddPlayerNewTeamList
            // 
            this.AddPlayerNewTeamList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.AddPlayerNewTeamList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AddPlayerNewTeamList.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPlayerNewTeamList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(71)))), ((int)(((byte)(63)))));
            this.AddPlayerNewTeamList.FormattingEnabled = true;
            this.AddPlayerNewTeamList.ItemHeight = 31;
            this.AddPlayerNewTeamList.Location = new System.Drawing.Point(22, 168);
            this.AddPlayerNewTeamList.Name = "AddPlayerNewTeamList";
            this.AddPlayerNewTeamList.Size = new System.Drawing.Size(398, 250);
            this.AddPlayerNewTeamList.TabIndex = 3;
            this.AddPlayerNewTeamList.Visible = false;
            // 
            // AddCancelButton
            // 
            this.AddCancelButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AddCancelButton.FlatAppearance.BorderSize = 0;
            this.AddCancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddCancelButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCancelButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(132)))), ((int)(((byte)(117)))));
            this.AddCancelButton.Location = new System.Drawing.Point(0, 427);
            this.AddCancelButton.Name = "AddCancelButton";
            this.AddCancelButton.Size = new System.Drawing.Size(186, 75);
            this.AddCancelButton.TabIndex = 5;
            this.AddCancelButton.Text = "Cancel";
            this.AddCancelButton.UseVisualStyleBackColor = true;
            this.AddCancelButton.Visible = false;
            this.AddCancelButton.Click += new System.EventHandler(this.AddCancelButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(951, 577);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.HeaderPanel);
            this.Controls.Add(this.SideMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Season Manager - Assignment04";
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            this.SideMenu.ResumeLayout(false);
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            this.MainPanel.ResumeLayout(false);
            this.AddPlayerPanel.ResumeLayout(false);
            this.AddPlayerPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Label SeasonManagerLabel;
        private System.Windows.Forms.Button ChangeToSeasonViewerButton;
        private System.Windows.Forms.Panel SideMenu;
        private System.Windows.Forms.Button AddTeamButton;
        private System.Windows.Forms.Button AddPlayerButton;
        private System.Windows.Forms.Button TradePlayerButton;
        private System.Windows.Forms.ListBox TeamList;
        public System.Windows.Forms.ListBox PlayerList;
        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel AddPlayerPanel;
        private System.Windows.Forms.Label AddPlayerNameLabel;
        private System.Windows.Forms.Button AddConfirmButton;
        private System.Windows.Forms.ListBox AddPlayerNewTeamList;
        private System.Windows.Forms.Label AddPlayerNewTeamLabel;
        private System.Windows.Forms.TextBox AddPlayerNewNameBox;
        private System.Windows.Forms.Button AddCancelButton;
    }
}

