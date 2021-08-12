
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
            this.teamList = new System.Windows.Forms.ListBox();
            this.playerList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.teamViewerLabel = new System.Windows.Forms.Label();
            this.addPlayerButton = new System.Windows.Forms.Button();
            this.TradePlayerButton = new System.Windows.Forms.Button();
            this.addTeamButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.changeToSeasonViewerButton = new System.Windows.Forms.Button();
            this.addTeamPanel = new System.Windows.Forms.Panel();
            this.ConfirmAddTeamButton = new System.Windows.Forms.Button();
            this.NewTeamNameBox = new System.Windows.Forms.TextBox();
            this.newTeamNameLabel = new System.Windows.Forms.Label();
            this.NewTeamPlayer7Box = new System.Windows.Forms.TextBox();
            this.NewTeamPlayer8Box = new System.Windows.Forms.TextBox();
            this.NewTeamPlayer6Box = new System.Windows.Forms.TextBox();
            this.NewTeamPlayer5Box = new System.Windows.Forms.TextBox();
            this.NewTeamPlayer2Box = new System.Windows.Forms.TextBox();
            this.NewTeamPlayer1Box = new System.Windows.Forms.TextBox();
            this.NewTeamPlayer4Box = new System.Windows.Forms.TextBox();
            this.NewTeamPlayer3Box = new System.Windows.Forms.TextBox();
            this.NewTeamRosterLabel = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.addTeamPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // teamList
            // 
            this.teamList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.teamList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.teamList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamList.ForeColor = System.Drawing.Color.White;
            this.teamList.FormattingEnabled = true;
            this.teamList.ItemHeight = 20;
            this.teamList.Location = new System.Drawing.Point(0, 181);
            this.teamList.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.teamList.Name = "teamList";
            this.teamList.Size = new System.Drawing.Size(316, 460);
            this.teamList.TabIndex = 1;
            this.teamList.SelectedIndexChanged += new System.EventHandler(this.TeamList_SelectedIndexChanged);
            // 
            // playerList
            // 
            this.playerList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.playerList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.playerList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerList.ForeColor = System.Drawing.Color.White;
            this.playerList.FormattingEnabled = true;
            this.playerList.ItemHeight = 20;
            this.playerList.Location = new System.Drawing.Point(344, 181);
            this.playerList.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.playerList.Name = "playerList";
            this.playerList.Size = new System.Drawing.Size(316, 460);
            this.playerList.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label1.Location = new System.Drawing.Point(-7, 136);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 44);
            this.label1.TabIndex = 5;
            this.label1.Text = "Teams";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label2.Location = new System.Drawing.Point(337, 136);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 44);
            this.label2.TabIndex = 6;
            this.label2.Text = "Players";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel4.Controls.Add(this.teamViewerLabel);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(958, 86);
            this.panel4.TabIndex = 2;
            // 
            // teamViewerLabel
            // 
            this.teamViewerLabel.AutoSize = true;
            this.teamViewerLabel.Font = new System.Drawing.Font("Nirmala UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamViewerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.teamViewerLabel.Location = new System.Drawing.Point(2, 0);
            this.teamViewerLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.teamViewerLabel.Name = "teamViewerLabel";
            this.teamViewerLabel.Size = new System.Drawing.Size(421, 86);
            this.teamViewerLabel.TabIndex = 0;
            this.teamViewerLabel.Text = "Team Viewer";
            // 
            // addPlayerButton
            // 
            this.addPlayerButton.FlatAppearance.BorderSize = 0;
            this.addPlayerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPlayerButton.Font = new System.Drawing.Font("Nirmala UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPlayerButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.addPlayerButton.Location = new System.Drawing.Point(0, 102);
            this.addPlayerButton.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.addPlayerButton.Name = "addPlayerButton";
            this.addPlayerButton.Size = new System.Drawing.Size(261, 99);
            this.addPlayerButton.TabIndex = 0;
            this.addPlayerButton.Text = "Add Player";
            this.addPlayerButton.UseVisualStyleBackColor = true;
            this.addPlayerButton.Click += new System.EventHandler(this.AddPlayerButton_Click);
            // 
            // TradePlayerButton
            // 
            this.TradePlayerButton.FlatAppearance.BorderSize = 0;
            this.TradePlayerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TradePlayerButton.Font = new System.Drawing.Font("Nirmala UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TradePlayerButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.TradePlayerButton.Location = new System.Drawing.Point(0, 204);
            this.TradePlayerButton.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.TradePlayerButton.Name = "TradePlayerButton";
            this.TradePlayerButton.Size = new System.Drawing.Size(261, 99);
            this.TradePlayerButton.TabIndex = 4;
            this.TradePlayerButton.Text = "Trade Player";
            this.TradePlayerButton.UseVisualStyleBackColor = true;
            this.TradePlayerButton.Click += new System.EventHandler(this.TradePlayerButton_Click);
            // 
            // addTeamButton
            // 
            this.addTeamButton.FlatAppearance.BorderSize = 0;
            this.addTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTeamButton.Font = new System.Drawing.Font("Nirmala UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTeamButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.addTeamButton.Location = new System.Drawing.Point(0, 0);
            this.addTeamButton.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.addTeamButton.Name = "addTeamButton";
            this.addTeamButton.Size = new System.Drawing.Size(260, 99);
            this.addTeamButton.TabIndex = 0;
            this.addTeamButton.Text = "Add Team";
            this.addTeamButton.UseVisualStyleBackColor = true;
            this.addTeamButton.Click += new System.EventHandler(this.AddTeamButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.addTeamButton);
            this.panel1.Controls.Add(this.TradePlayerButton);
            this.panel1.Controls.Add(this.addPlayerButton);
            this.panel1.Location = new System.Drawing.Point(696, 327);
            this.panel1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(262, 304);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel2.Controls.Add(this.changeToSeasonViewerButton);
            this.panel2.Location = new System.Drawing.Point(699, 179);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(259, 133);
            this.panel2.TabIndex = 8;
            // 
            // changeToSeasonViewerButton
            // 
            this.changeToSeasonViewerButton.FlatAppearance.BorderSize = 0;
            this.changeToSeasonViewerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeToSeasonViewerButton.Font = new System.Drawing.Font("Nirmala UI", 10.125F);
            this.changeToSeasonViewerButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.changeToSeasonViewerButton.Location = new System.Drawing.Point(0, 0);
            this.changeToSeasonViewerButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.changeToSeasonViewerButton.Name = "changeToSeasonViewerButton";
            this.changeToSeasonViewerButton.Size = new System.Drawing.Size(259, 131);
            this.changeToSeasonViewerButton.TabIndex = 0;
            this.changeToSeasonViewerButton.Text = "Switch To Season Viewer";
            this.changeToSeasonViewerButton.UseVisualStyleBackColor = true;
            this.changeToSeasonViewerButton.Click += new System.EventHandler(this.ChangeToSeasonViewerButton_Click);
            // 
            // addTeamPanel
            // 
            this.addTeamPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.addTeamPanel.Controls.Add(this.NewTeamRosterLabel);
            this.addTeamPanel.Controls.Add(this.NewTeamPlayer2Box);
            this.addTeamPanel.Controls.Add(this.NewTeamPlayer1Box);
            this.addTeamPanel.Controls.Add(this.NewTeamPlayer4Box);
            this.addTeamPanel.Controls.Add(this.NewTeamPlayer3Box);
            this.addTeamPanel.Controls.Add(this.NewTeamPlayer6Box);
            this.addTeamPanel.Controls.Add(this.NewTeamPlayer5Box);
            this.addTeamPanel.Controls.Add(this.NewTeamPlayer8Box);
            this.addTeamPanel.Controls.Add(this.NewTeamPlayer7Box);
            this.addTeamPanel.Controls.Add(this.ConfirmAddTeamButton);
            this.addTeamPanel.Controls.Add(this.NewTeamNameBox);
            this.addTeamPanel.Controls.Add(this.newTeamNameLabel);
            this.addTeamPanel.Location = new System.Drawing.Point(0, 179);
            this.addTeamPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addTeamPanel.Name = "addTeamPanel";
            this.addTeamPanel.Size = new System.Drawing.Size(316, 451);
            this.addTeamPanel.TabIndex = 9;
            this.addTeamPanel.Visible = false;
            // 
            // ConfirmAddTeamButton
            // 
            this.ConfirmAddTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConfirmAddTeamButton.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmAddTeamButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.ConfirmAddTeamButton.Location = new System.Drawing.Point(0, 356);
            this.ConfirmAddTeamButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ConfirmAddTeamButton.Name = "ConfirmAddTeamButton";
            this.ConfirmAddTeamButton.Size = new System.Drawing.Size(315, 94);
            this.ConfirmAddTeamButton.TabIndex = 2;
            this.ConfirmAddTeamButton.Text = "Add";
            this.ConfirmAddTeamButton.UseVisualStyleBackColor = true;
            this.ConfirmAddTeamButton.Click += new System.EventHandler(this.ConfirmAddTeamButton_Click);
            // 
            // NewTeamNameBox
            // 
            this.NewTeamNameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(36)))), ((int)(((byte)(58)))));
            this.NewTeamNameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NewTeamNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewTeamNameBox.ForeColor = System.Drawing.Color.White;
            this.NewTeamNameBox.Location = new System.Drawing.Point(17, 41);
            this.NewTeamNameBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NewTeamNameBox.Name = "NewTeamNameBox";
            this.NewTeamNameBox.Size = new System.Drawing.Size(281, 22);
            this.NewTeamNameBox.TabIndex = 1;
            // 
            // newTeamNameLabel
            // 
            this.newTeamNameLabel.AutoSize = true;
            this.newTeamNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newTeamNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.newTeamNameLabel.Location = new System.Drawing.Point(13, 15);
            this.newTeamNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.newTeamNameLabel.Name = "newTeamNameLabel";
            this.newTeamNameLabel.Size = new System.Drawing.Size(120, 24);
            this.newTeamNameLabel.TabIndex = 0;
            this.newTeamNameLabel.Text = "Team Name:";
            // 
            // NewTeamPlayer7Box
            // 
            this.NewTeamPlayer7Box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(36)))), ((int)(((byte)(58)))));
            this.NewTeamPlayer7Box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NewTeamPlayer7Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewTeamPlayer7Box.ForeColor = System.Drawing.Color.White;
            this.NewTeamPlayer7Box.Location = new System.Drawing.Point(17, 287);
            this.NewTeamPlayer7Box.Margin = new System.Windows.Forms.Padding(2);
            this.NewTeamPlayer7Box.Name = "NewTeamPlayer7Box";
            this.NewTeamPlayer7Box.Size = new System.Drawing.Size(281, 22);
            this.NewTeamPlayer7Box.TabIndex = 3;
            // 
            // NewTeamPlayer8Box
            // 
            this.NewTeamPlayer8Box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(36)))), ((int)(((byte)(58)))));
            this.NewTeamPlayer8Box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NewTeamPlayer8Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewTeamPlayer8Box.ForeColor = System.Drawing.Color.White;
            this.NewTeamPlayer8Box.Location = new System.Drawing.Point(17, 317);
            this.NewTeamPlayer8Box.Margin = new System.Windows.Forms.Padding(2);
            this.NewTeamPlayer8Box.Name = "NewTeamPlayer8Box";
            this.NewTeamPlayer8Box.Size = new System.Drawing.Size(281, 22);
            this.NewTeamPlayer8Box.TabIndex = 4;
            // 
            // NewTeamPlayer6Box
            // 
            this.NewTeamPlayer6Box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(36)))), ((int)(((byte)(58)))));
            this.NewTeamPlayer6Box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NewTeamPlayer6Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewTeamPlayer6Box.ForeColor = System.Drawing.Color.White;
            this.NewTeamPlayer6Box.Location = new System.Drawing.Point(17, 257);
            this.NewTeamPlayer6Box.Margin = new System.Windows.Forms.Padding(2);
            this.NewTeamPlayer6Box.Name = "NewTeamPlayer6Box";
            this.NewTeamPlayer6Box.Size = new System.Drawing.Size(281, 22);
            this.NewTeamPlayer6Box.TabIndex = 6;
            // 
            // NewTeamPlayer5Box
            // 
            this.NewTeamPlayer5Box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(36)))), ((int)(((byte)(58)))));
            this.NewTeamPlayer5Box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NewTeamPlayer5Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewTeamPlayer5Box.ForeColor = System.Drawing.Color.White;
            this.NewTeamPlayer5Box.Location = new System.Drawing.Point(17, 227);
            this.NewTeamPlayer5Box.Margin = new System.Windows.Forms.Padding(2);
            this.NewTeamPlayer5Box.Name = "NewTeamPlayer5Box";
            this.NewTeamPlayer5Box.Size = new System.Drawing.Size(281, 22);
            this.NewTeamPlayer5Box.TabIndex = 5;
            // 
            // NewTeamPlayer2Box
            // 
            this.NewTeamPlayer2Box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(36)))), ((int)(((byte)(58)))));
            this.NewTeamPlayer2Box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NewTeamPlayer2Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewTeamPlayer2Box.ForeColor = System.Drawing.Color.White;
            this.NewTeamPlayer2Box.Location = new System.Drawing.Point(17, 137);
            this.NewTeamPlayer2Box.Margin = new System.Windows.Forms.Padding(2);
            this.NewTeamPlayer2Box.Name = "NewTeamPlayer2Box";
            this.NewTeamPlayer2Box.Size = new System.Drawing.Size(281, 22);
            this.NewTeamPlayer2Box.TabIndex = 10;
            // 
            // NewTeamPlayer1Box
            // 
            this.NewTeamPlayer1Box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(36)))), ((int)(((byte)(58)))));
            this.NewTeamPlayer1Box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NewTeamPlayer1Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewTeamPlayer1Box.ForeColor = System.Drawing.Color.White;
            this.NewTeamPlayer1Box.Location = new System.Drawing.Point(17, 107);
            this.NewTeamPlayer1Box.Margin = new System.Windows.Forms.Padding(2);
            this.NewTeamPlayer1Box.Name = "NewTeamPlayer1Box";
            this.NewTeamPlayer1Box.Size = new System.Drawing.Size(281, 22);
            this.NewTeamPlayer1Box.TabIndex = 9;
            // 
            // NewTeamPlayer4Box
            // 
            this.NewTeamPlayer4Box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(36)))), ((int)(((byte)(58)))));
            this.NewTeamPlayer4Box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NewTeamPlayer4Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewTeamPlayer4Box.ForeColor = System.Drawing.Color.White;
            this.NewTeamPlayer4Box.Location = new System.Drawing.Point(17, 197);
            this.NewTeamPlayer4Box.Margin = new System.Windows.Forms.Padding(2);
            this.NewTeamPlayer4Box.Name = "NewTeamPlayer4Box";
            this.NewTeamPlayer4Box.Size = new System.Drawing.Size(281, 22);
            this.NewTeamPlayer4Box.TabIndex = 8;
            // 
            // NewTeamPlayer3Box
            // 
            this.NewTeamPlayer3Box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(36)))), ((int)(((byte)(58)))));
            this.NewTeamPlayer3Box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NewTeamPlayer3Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewTeamPlayer3Box.ForeColor = System.Drawing.Color.White;
            this.NewTeamPlayer3Box.Location = new System.Drawing.Point(17, 167);
            this.NewTeamPlayer3Box.Margin = new System.Windows.Forms.Padding(2);
            this.NewTeamPlayer3Box.Name = "NewTeamPlayer3Box";
            this.NewTeamPlayer3Box.Size = new System.Drawing.Size(281, 22);
            this.NewTeamPlayer3Box.TabIndex = 7;
            // 
            // NewTeamRosterLabel
            // 
            this.NewTeamRosterLabel.AutoSize = true;
            this.NewTeamRosterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewTeamRosterLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.NewTeamRosterLabel.Location = new System.Drawing.Point(13, 81);
            this.NewTeamRosterLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NewTeamRosterLabel.Name = "NewTeamRosterLabel";
            this.NewTeamRosterLabel.Size = new System.Drawing.Size(193, 24);
            this.NewTeamRosterLabel.TabIndex = 11;
            this.NewTeamRosterLabel.Text = "Roster:  (not required)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(36)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(958, 631);
            this.Controls.Add(this.addTeamPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.playerList);
            this.Controls.Add(this.teamList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trade Program - Assignment03";
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.addTeamPanel.ResumeLayout(false);
            this.addTeamPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.ListBox teamList;
        public System.Windows.Forms.ListBox playerList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label teamViewerLabel;
        private System.Windows.Forms.Button addPlayerButton;
        private System.Windows.Forms.Button TradePlayerButton;
        private System.Windows.Forms.Button addTeamButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button changeToSeasonViewerButton;
        private System.Windows.Forms.Panel addTeamPanel;
        private System.Windows.Forms.Label newTeamNameLabel;
        private System.Windows.Forms.TextBox NewTeamNameBox;
        private System.Windows.Forms.Button ConfirmAddTeamButton;
        private System.Windows.Forms.TextBox NewTeamPlayer6Box;
        private System.Windows.Forms.TextBox NewTeamPlayer5Box;
        private System.Windows.Forms.TextBox NewTeamPlayer8Box;
        private System.Windows.Forms.TextBox NewTeamPlayer7Box;
        private System.Windows.Forms.Label NewTeamRosterLabel;
        private System.Windows.Forms.TextBox NewTeamPlayer2Box;
        private System.Windows.Forms.TextBox NewTeamPlayer1Box;
        private System.Windows.Forms.TextBox NewTeamPlayer4Box;
        private System.Windows.Forms.TextBox NewTeamPlayer3Box;
    }
}

