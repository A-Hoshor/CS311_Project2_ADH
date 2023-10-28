namespace CS311_Project2_ADH
{
    partial class frmMain
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
            this.lblDiceOne = new System.Windows.Forms.Label();
            this.lblDice1 = new System.Windows.Forms.Label();
            this.lblDice2 = new System.Windows.Forms.Label();
            this.lblBankBalance = new System.Windows.Forms.Label();
            this.txtEnterYourBet = new System.Windows.Forms.TextBox();
            this.btnRoll = new System.Windows.Forms.Button();
            this.lblWinLose = new System.Windows.Forms.Label();
            this.lblBet = new System.Windows.Forms.Label();
            this.lblBankBalanceTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDiceOne
            // 
            this.lblDiceOne.AutoSize = true;
            this.lblDiceOne.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiceOne.Location = new System.Drawing.Point(143, 126);
            this.lblDiceOne.Name = "lblDiceOne";
            this.lblDiceOne.Size = new System.Drawing.Size(0, 41);
            this.lblDiceOne.TabIndex = 0;
            // 
            // lblDice1
            // 
            this.lblDice1.AutoSize = true;
            this.lblDice1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDice1.Location = new System.Drawing.Point(188, 166);
            this.lblDice1.Name = "lblDice1";
            this.lblDice1.Size = new System.Drawing.Size(0, 46);
            this.lblDice1.TabIndex = 1;
            this.lblDice1.UseWaitCursor = true;
            // 
            // lblDice2
            // 
            this.lblDice2.AutoSize = true;
            this.lblDice2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDice2.Location = new System.Drawing.Point(317, 166);
            this.lblDice2.Name = "lblDice2";
            this.lblDice2.Size = new System.Drawing.Size(0, 46);
            this.lblDice2.TabIndex = 2;
            this.lblDice2.UseWaitCursor = true;
            // 
            // lblBankBalance
            // 
            this.lblBankBalance.AutoSize = true;
            this.lblBankBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBankBalance.Location = new System.Drawing.Point(44, 26);
            this.lblBankBalance.Name = "lblBankBalance";
            this.lblBankBalance.Size = new System.Drawing.Size(226, 37);
            this.lblBankBalance.TabIndex = 3;
            this.lblBankBalance.Text = "Bank Balance";
            // 
            // txtEnterYourBet
            // 
            this.txtEnterYourBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnterYourBet.Location = new System.Drawing.Point(173, 293);
            this.txtEnterYourBet.Name = "txtEnterYourBet";
            this.txtEnterYourBet.Size = new System.Drawing.Size(232, 44);
            this.txtEnterYourBet.TabIndex = 4;
            this.txtEnterYourBet.Text = "Enter your bet";
            this.txtEnterYourBet.TextChanged += new System.EventHandler(this.txtEnterYourBet_TextChanged);
            // 
            // btnRoll
            // 
            this.btnRoll.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoll.Location = new System.Drawing.Point(503, 93);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(243, 105);
            this.btnRoll.TabIndex = 5;
            this.btnRoll.Text = "Roll";
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // lblWinLose
            // 
            this.lblWinLose.AutoSize = true;
            this.lblWinLose.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinLose.Location = new System.Drawing.Point(463, 254);
            this.lblWinLose.Name = "lblWinLose";
            this.lblWinLose.Size = new System.Drawing.Size(312, 59);
            this.lblWinLose.TabIndex = 6;
            this.lblWinLose.Text = "Win or Lose";
            // 
            // lblBet
            // 
            this.lblBet.AutoSize = true;
            this.lblBet.Location = new System.Drawing.Point(192, 340);
            this.lblBet.Name = "lblBet";
            this.lblBet.Size = new System.Drawing.Size(0, 20);
            this.lblBet.TabIndex = 7;
            // 
            // lblBankBalanceTotal
            // 
            this.lblBankBalanceTotal.AutoSize = true;
            this.lblBankBalanceTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBankBalanceTotal.Location = new System.Drawing.Point(337, 32);
            this.lblBankBalanceTotal.Name = "lblBankBalanceTotal";
            this.lblBankBalanceTotal.Size = new System.Drawing.Size(97, 29);
            this.lblBankBalanceTotal.TabIndex = 9;
            this.lblBankBalanceTotal.Text = "$100.00";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblBankBalanceTotal);
            this.Controls.Add(this.lblBet);
            this.Controls.Add(this.lblWinLose);
            this.Controls.Add(this.btnRoll);
            this.Controls.Add(this.txtEnterYourBet);
            this.Controls.Add(this.lblBankBalance);
            this.Controls.Add(this.lblDice2);
            this.Controls.Add(this.lblDice1);
            this.Controls.Add(this.lblDiceOne);
            this.Name = "frmMain";
            this.Text = "Craps";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDiceOne;
        private System.Windows.Forms.Label lblDice1;
        private System.Windows.Forms.Label lblDice2;
        private System.Windows.Forms.Label lblBankBalance;
        private System.Windows.Forms.TextBox txtEnterYourBet;
        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.Label lblWinLose;
        private System.Windows.Forms.Label lblBet;
        private System.Windows.Forms.Label lblBankBalanceTotal;
    }
}

