
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
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.SeasonManagerLabel = new System.Windows.Forms.Label();
            this.ChangeToSeasonViewerButton = new System.Windows.Forms.Button();
            this.Header = new System.Windows.Forms.Panel();
            this.SideMenu = new System.Windows.Forms.Panel();
            this.HeaderPanel.SuspendLayout();
            this.Header.SuspendLayout();
            this.SideMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(186, 100);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(765, 477);
            this.MainPanel.TabIndex = 7;
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
            this.SideMenu.Controls.Add(this.ChangeToSeasonViewerButton);
            this.SideMenu.Controls.Add(this.Header);
            this.SideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideMenu.Location = new System.Drawing.Point(0, 0);
            this.SideMenu.Name = "SideMenu";
            this.SideMenu.Size = new System.Drawing.Size(186, 577);
            this.SideMenu.TabIndex = 5;
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
        private System.Windows.Forms.Button ChangeToSeasonViewerButton;
        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Panel SideMenu;
    }
}