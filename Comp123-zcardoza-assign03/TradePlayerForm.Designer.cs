
namespace Comp123_zcardoza_assign03
{
    partial class TradePlayerForm
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
            this.AcceptButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.playerNameLabel = new System.Windows.Forms.Label();
            this.playerCurrentTeam = new System.Windows.Forms.Label();
            this.possibleTeamList = new System.Windows.Forms.ListBox();
            this.possibleTeamListLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AcceptButton
            // 
            this.AcceptButton.Location = new System.Drawing.Point(36, 208);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.Size = new System.Drawing.Size(309, 67);
            this.AcceptButton.TabIndex = 0;
            this.AcceptButton.Text = "Trade";
            this.AcceptButton.UseVisualStyleBackColor = true;
            this.AcceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(36, 282);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(309, 65);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // playerNameLabel
            // 
            this.playerNameLabel.AutoSize = true;
            this.playerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerNameLabel.Location = new System.Drawing.Point(12, 16);
            this.playerNameLabel.Name = "playerNameLabel";
            this.playerNameLabel.Size = new System.Drawing.Size(573, 79);
            this.playerNameLabel.TabIndex = 2;
            this.playerNameLabel.Text = "playerNameLabel";
            // 
            // playerCurrentTeam
            // 
            this.playerCurrentTeam.AutoSize = true;
            this.playerCurrentTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerCurrentTeam.Location = new System.Drawing.Point(29, 143);
            this.playerCurrentTeam.Name = "playerCurrentTeam";
            this.playerCurrentTeam.Size = new System.Drawing.Size(292, 37);
            this.playerCurrentTeam.TabIndex = 3;
            this.playerCurrentTeam.Text = "playerCurrentTeam";
            // 
            // possibleTeamList
            // 
            this.possibleTeamList.FormattingEnabled = true;
            this.possibleTeamList.ItemHeight = 25;
            this.possibleTeamList.Location = new System.Drawing.Point(351, 143);
            this.possibleTeamList.Name = "possibleTeamList";
            this.possibleTeamList.Size = new System.Drawing.Size(234, 204);
            this.possibleTeamList.TabIndex = 4;
            // 
            // possibleTeamListLabel
            // 
            this.possibleTeamListLabel.AutoSize = true;
            this.possibleTeamListLabel.Location = new System.Drawing.Point(346, 109);
            this.possibleTeamListLabel.Name = "possibleTeamListLabel";
            this.possibleTeamListLabel.Size = new System.Drawing.Size(171, 25);
            this.possibleTeamListLabel.TabIndex = 5;
            this.possibleTeamListLabel.Text = "Available Teams";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Current Team";
            // 
            // TradePlayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 370);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.possibleTeamListLabel);
            this.Controls.Add(this.possibleTeamList);
            this.Controls.Add(this.playerCurrentTeam);
            this.Controls.Add(this.playerNameLabel);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AcceptButton);
            this.Name = "TradePlayerForm";
            this.Text = "TradePlayerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private new System.Windows.Forms.Button AcceptButton;
        private new System.Windows.Forms.Button CancelButton;
        public System.Windows.Forms.Label playerNameLabel;
        private System.Windows.Forms.Label possibleTeamListLabel;
        public System.Windows.Forms.Label playerCurrentTeam;
        public System.Windows.Forms.ListBox possibleTeamList;
        private System.Windows.Forms.Label label1;
    }
}