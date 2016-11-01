namespace BankToets
{
    partial class MainForm
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
            this.BtnAccountAanmaken = new System.Windows.Forms.Button();
            this.BtnBankSelecteren = new System.Windows.Forms.Button();
            this.BtnAccountVerwijderen = new System.Windows.Forms.Button();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.LstAccounts = new System.Windows.Forms.ListBox();
            this.nudGeld = new System.Windows.Forms.NumericUpDown();
            this.btnGeldOvermaken = new System.Windows.Forms.Button();
            this.btnGeldStorten = new System.Windows.Forms.Button();
            this.btnGeldOpnemen = new System.Windows.Forms.Button();
            this.TxbBalans = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxbNaam = new System.Windows.Forms.TextBox();
            this.lstLog = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLogOpslaan = new System.Windows.Forms.Button();
            this.tbBankNaam = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbAccountSoort = new System.Windows.Forms.TextBox();
            this.ad = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudGeld)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnAccountAanmaken
            // 
            this.BtnAccountAanmaken.Enabled = false;
            this.BtnAccountAanmaken.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAccountAanmaken.Location = new System.Drawing.Point(4, 13);
            this.BtnAccountAanmaken.Name = "BtnAccountAanmaken";
            this.BtnAccountAanmaken.Size = new System.Drawing.Size(106, 71);
            this.BtnAccountAanmaken.TabIndex = 0;
            this.BtnAccountAanmaken.Text = "Account Aanmaken";
            this.BtnAccountAanmaken.UseVisualStyleBackColor = true;
            // 
            // BtnBankSelecteren
            // 
            this.BtnBankSelecteren.Location = new System.Drawing.Point(4, 244);
            this.BtnBankSelecteren.Name = "BtnBankSelecteren";
            this.BtnBankSelecteren.Size = new System.Drawing.Size(106, 23);
            this.BtnBankSelecteren.TabIndex = 2;
            this.BtnBankSelecteren.Text = "Bank Selecteren";
            this.BtnBankSelecteren.UseVisualStyleBackColor = true;
            // 
            // BtnAccountVerwijderen
            // 
            this.BtnAccountVerwijderen.Enabled = false;
            this.BtnAccountVerwijderen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAccountVerwijderen.Location = new System.Drawing.Point(4, 90);
            this.BtnAccountVerwijderen.Name = "BtnAccountVerwijderen";
            this.BtnAccountVerwijderen.Size = new System.Drawing.Size(106, 71);
            this.BtnAccountVerwijderen.TabIndex = 3;
            this.BtnAccountVerwijderen.Text = "Account Verwijderen";
            this.BtnAccountVerwijderen.UseVisualStyleBackColor = true;
            // 
            // BtnLogin
            // 
            this.BtnLogin.Enabled = false;
            this.BtnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogin.Location = new System.Drawing.Point(4, 167);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(106, 71);
            this.BtnLogin.TabIndex = 5;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.UseVisualStyleBackColor = true;
            // 
            // LstAccounts
            // 
            this.LstAccounts.FormattingEnabled = true;
            this.LstAccounts.Location = new System.Drawing.Point(323, 25);
            this.LstAccounts.Name = "LstAccounts";
            this.LstAccounts.Size = new System.Drawing.Size(151, 238);
            this.LstAccounts.TabIndex = 6;
            // 
            // nudGeld
            // 
            this.nudGeld.DecimalPlaces = 2;
            this.nudGeld.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudGeld.Location = new System.Drawing.Point(161, 182);
            this.nudGeld.Name = "nudGeld";
            this.nudGeld.Size = new System.Drawing.Size(75, 26);
            this.nudGeld.TabIndex = 7;
            // 
            // btnGeldOvermaken
            // 
            this.btnGeldOvermaken.Enabled = false;
            this.btnGeldOvermaken.Location = new System.Drawing.Point(242, 176);
            this.btnGeldOvermaken.Name = "btnGeldOvermaken";
            this.btnGeldOvermaken.Size = new System.Drawing.Size(75, 39);
            this.btnGeldOvermaken.TabIndex = 8;
            this.btnGeldOvermaken.Text = "Geld Overmaken";
            this.btnGeldOvermaken.UseVisualStyleBackColor = true;
            // 
            // btnGeldStorten
            // 
            this.btnGeldStorten.Enabled = false;
            this.btnGeldStorten.Location = new System.Drawing.Point(161, 221);
            this.btnGeldStorten.Name = "btnGeldStorten";
            this.btnGeldStorten.Size = new System.Drawing.Size(75, 42);
            this.btnGeldStorten.TabIndex = 9;
            this.btnGeldStorten.Text = "Geld Storten";
            this.btnGeldStorten.UseVisualStyleBackColor = true;
            // 
            // btnGeldOpnemen
            // 
            this.btnGeldOpnemen.Enabled = false;
            this.btnGeldOpnemen.Location = new System.Drawing.Point(242, 221);
            this.btnGeldOpnemen.Name = "btnGeldOpnemen";
            this.btnGeldOpnemen.Size = new System.Drawing.Size(75, 42);
            this.btnGeldOpnemen.TabIndex = 10;
            this.btnGeldOpnemen.Text = "Geld Opnemen";
            this.btnGeldOpnemen.UseVisualStyleBackColor = true;
            // 
            // TxbBalans
            // 
            this.TxbBalans.Location = new System.Drawing.Point(119, 136);
            this.TxbBalans.Name = "TxbBalans";
            this.TxbBalans.ReadOnly = true;
            this.TxbBalans.Size = new System.Drawing.Size(198, 20);
            this.TxbBalans.TabIndex = 11;
            this.TxbBalans.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Naam";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Balans";
            // 
            // TxbNaam
            // 
            this.TxbNaam.Location = new System.Drawing.Point(119, 59);
            this.TxbNaam.Name = "TxbNaam";
            this.TxbNaam.ReadOnly = true;
            this.TxbNaam.Size = new System.Drawing.Size(198, 20);
            this.TxbNaam.TabIndex = 13;
            // 
            // lstLog
            // 
            this.lstLog.FormattingEnabled = true;
            this.lstLog.Location = new System.Drawing.Point(483, 26);
            this.lstLog.Name = "lstLog";
            this.lstLog.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstLog.Size = new System.Drawing.Size(246, 212);
            this.lstLog.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(324, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Accounts";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(483, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Overdrachten";
            // 
            // btnLogOpslaan
            // 
            this.btnLogOpslaan.Enabled = false;
            this.btnLogOpslaan.Location = new System.Drawing.Point(483, 244);
            this.btnLogOpslaan.Name = "btnLogOpslaan";
            this.btnLogOpslaan.Size = new System.Drawing.Size(246, 22);
            this.btnLogOpslaan.TabIndex = 18;
            this.btnLogOpslaan.Text = "Log Opslaan";
            this.btnLogOpslaan.UseVisualStyleBackColor = true;
            // 
            // tbBankNaam
            // 
            this.tbBankNaam.Location = new System.Drawing.Point(119, 22);
            this.tbBankNaam.Name = "tbBankNaam";
            this.tbBankNaam.ReadOnly = true;
            this.tbBankNaam.Size = new System.Drawing.Size(198, 20);
            this.tbBankNaam.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(116, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Bank";
            // 
            // tbAccountSoort
            // 
            this.tbAccountSoort.Location = new System.Drawing.Point(119, 98);
            this.tbAccountSoort.Name = "tbAccountSoort";
            this.tbAccountSoort.ReadOnly = true;
            this.tbAccountSoort.Size = new System.Drawing.Size(198, 20);
            this.tbAccountSoort.TabIndex = 22;
            // 
            // ad
            // 
            this.ad.AutoSize = true;
            this.ad.Location = new System.Drawing.Point(116, 82);
            this.ad.Name = "ad";
            this.ad.Size = new System.Drawing.Size(81, 13);
            this.ad.TabIndex = 21;
            this.ad.Text = "Rekening Soort";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 278);
            this.Controls.Add(this.tbAccountSoort);
            this.Controls.Add(this.ad);
            this.Controls.Add(this.tbBankNaam);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnLogOpslaan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstLog);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxbNaam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxbBalans);
            this.Controls.Add(this.btnGeldOpnemen);
            this.Controls.Add(this.btnGeldStorten);
            this.Controls.Add(this.btnGeldOvermaken);
            this.Controls.Add(this.nudGeld);
            this.Controls.Add(this.LstAccounts);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.BtnAccountVerwijderen);
            this.Controls.Add(this.BtnBankSelecteren);
            this.Controls.Add(this.BtnAccountAanmaken);
            this.Name = "MainForm";
            this.Text = "BankApplicatie door Naam";
            ((System.ComponentModel.ISupportInitialize)(this.nudGeld)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAccountAanmaken;
        private System.Windows.Forms.Button BtnBankSelecteren;
        private System.Windows.Forms.Button BtnAccountVerwijderen;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.ListBox LstAccounts;
        private System.Windows.Forms.NumericUpDown nudGeld;
        private System.Windows.Forms.Button btnGeldOvermaken;
        private System.Windows.Forms.Button btnGeldStorten;
        private System.Windows.Forms.Button btnGeldOpnemen;
        private System.Windows.Forms.TextBox TxbBalans;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxbNaam;
        private System.Windows.Forms.ListBox lstLog;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLogOpslaan;
        private System.Windows.Forms.TextBox tbBankNaam;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbAccountSoort;
        private System.Windows.Forms.Label ad;
    }
}

