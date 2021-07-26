
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
            this.TradePlayerButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // teamList
            // 
            this.teamList.FormattingEnabled = true;
            this.teamList.ItemHeight = 25;
            this.teamList.Location = new System.Drawing.Point(12, 73);
            this.teamList.Name = "teamList";
            this.teamList.Size = new System.Drawing.Size(280, 254);
            this.teamList.TabIndex = 1;
            this.teamList.SelectedIndexChanged += new System.EventHandler(this.teamList_SelectedIndexChanged);
            // 
            // playerList
            // 
            this.playerList.FormattingEnabled = true;
            this.playerList.ItemHeight = 25;
            this.playerList.Location = new System.Drawing.Point(343, 73);
            this.playerList.Name = "playerList";
            this.playerList.Size = new System.Drawing.Size(283, 254);
            this.playerList.TabIndex = 2;
            // 
            // TradePlayerButton
            // 
            this.TradePlayerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TradePlayerButton.Location = new System.Drawing.Point(193, 353);
            this.TradePlayerButton.Name = "TradePlayerButton";
            this.TradePlayerButton.Size = new System.Drawing.Size(260, 62);
            this.TradePlayerButton.TabIndex = 4;
            this.TradePlayerButton.Text = "Trade Player";
            this.TradePlayerButton.UseVisualStyleBackColor = true;
            this.TradePlayerButton.Click += new System.EventHandler(this.TradePlayerButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 51);
            this.label1.TabIndex = 5;
            this.label1.Text = "Teams";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(336, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 42);
            this.label2.TabIndex = 6;
            this.label2.Text = "Players";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 446);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TradePlayerButton);
            this.Controls.Add(this.playerList);
            this.Controls.Add(this.teamList);
            this.Name = "Form1";
            this.Text = "Trade Program - Assignment03";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button TradePlayerButton;
        public System.Windows.Forms.ListBox teamList;
        public System.Windows.Forms.ListBox playerList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

