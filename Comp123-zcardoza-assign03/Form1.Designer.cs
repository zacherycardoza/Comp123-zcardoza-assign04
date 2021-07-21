
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
            this.SuspendLayout();
            // 
            // teamList
            // 
            this.teamList.FormattingEnabled = true;
            this.teamList.ItemHeight = 25;
            this.teamList.Location = new System.Drawing.Point(96, 172);
            this.teamList.Name = "teamList";
            this.teamList.Size = new System.Drawing.Size(405, 379);
            this.teamList.TabIndex = 1;
            this.teamList.SelectedIndexChanged += new System.EventHandler(this.teamList_SelectedIndexChanged);
            // 
            // playerList
            // 
            this.playerList.FormattingEnabled = true;
            this.playerList.ItemHeight = 25;
            this.playerList.Location = new System.Drawing.Point(639, 172);
            this.playerList.Name = "playerList";
            this.playerList.Size = new System.Drawing.Size(409, 379);
            this.playerList.TabIndex = 2;
            // 
            // TradePlayerButton
            // 
            this.TradePlayerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TradePlayerButton.Location = new System.Drawing.Point(422, 642);
            this.TradePlayerButton.Name = "TradePlayerButton";
            this.TradePlayerButton.Size = new System.Drawing.Size(295, 73);
            this.TradePlayerButton.TabIndex = 4;
            this.TradePlayerButton.Text = "Initiate Trade";
            this.TradePlayerButton.UseVisualStyleBackColor = true;
            this.TradePlayerButton.Click += new System.EventHandler(this.TradePlayerButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 758);
            this.Controls.Add(this.TradePlayerButton);
            this.Controls.Add(this.playerList);
            this.Controls.Add(this.teamList);
            this.Name = "Form1";
            this.Text = "Trade Program - Assignment03";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button TradePlayerButton;
        public System.Windows.Forms.ListBox teamList;
        public System.Windows.Forms.ListBox playerList;
    }
}

