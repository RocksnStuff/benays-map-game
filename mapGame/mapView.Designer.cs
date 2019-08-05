namespace mapGame
{
    partial class mapView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mapView));
            this.NamericaButton = new System.Windows.Forms.Button();
            this.SamericaButton = new System.Windows.Forms.Button();
            this.AfricaButton = new System.Windows.Forms.Button();
            this.EuropeButton = new System.Windows.Forms.Button();
            this.AsiaButton = new System.Windows.Forms.Button();
            this.OutputBox = new System.Windows.Forms.RichTextBox();
            this.NamericaText = new System.Windows.Forms.Label();
            this.SamericaText = new System.Windows.Forms.Label();
            this.AfricaText = new System.Windows.Forms.Label();
            this.EuropeText = new System.Windows.Forms.Label();
            this.AsiaText = new System.Windows.Forms.Label();
            this.turnText = new System.Windows.Forms.Label();
            this.attackCheck = new System.Windows.Forms.CheckBox();
            this.AustraliaButton = new System.Windows.Forms.Button();
            this.AustraliaText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.turnCounter = new System.Windows.Forms.Label();
            this.winLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.powerLabel = new System.Windows.Forms.Label();
            this.passButton = new System.Windows.Forms.Button();
            this.invadeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NamericaButton
            // 
            this.NamericaButton.Location = new System.Drawing.Point(215, 130);
            this.NamericaButton.Name = "NamericaButton";
            this.NamericaButton.Size = new System.Drawing.Size(113, 23);
            this.NamericaButton.TabIndex = 0;
            this.NamericaButton.Text = "North America";
            this.NamericaButton.UseVisualStyleBackColor = true;
            this.NamericaButton.Click += new System.EventHandler(this.NamericaButton_Click);
            // 
            // SamericaButton
            // 
            this.SamericaButton.Location = new System.Drawing.Point(310, 275);
            this.SamericaButton.Name = "SamericaButton";
            this.SamericaButton.Size = new System.Drawing.Size(106, 23);
            this.SamericaButton.TabIndex = 1;
            this.SamericaButton.Text = "South America";
            this.SamericaButton.UseVisualStyleBackColor = true;
            this.SamericaButton.Click += new System.EventHandler(this.SamericaButton_Click);
            // 
            // AfricaButton
            // 
            this.AfricaButton.Location = new System.Drawing.Point(540, 237);
            this.AfricaButton.Name = "AfricaButton";
            this.AfricaButton.Size = new System.Drawing.Size(75, 23);
            this.AfricaButton.TabIndex = 2;
            this.AfricaButton.Text = "Africa";
            this.AfricaButton.UseVisualStyleBackColor = true;
            this.AfricaButton.Click += new System.EventHandler(this.AfricaButton_Click);
            // 
            // EuropeButton
            // 
            this.EuropeButton.Location = new System.Drawing.Point(522, 102);
            this.EuropeButton.Name = "EuropeButton";
            this.EuropeButton.Size = new System.Drawing.Size(75, 23);
            this.EuropeButton.TabIndex = 3;
            this.EuropeButton.Text = "Europe";
            this.EuropeButton.UseVisualStyleBackColor = true;
            this.EuropeButton.Click += new System.EventHandler(this.EuropeButton_Click);
            // 
            // AsiaButton
            // 
            this.AsiaButton.Location = new System.Drawing.Point(752, 188);
            this.AsiaButton.Name = "AsiaButton";
            this.AsiaButton.Size = new System.Drawing.Size(75, 23);
            this.AsiaButton.TabIndex = 4;
            this.AsiaButton.Text = "Asia";
            this.AsiaButton.UseVisualStyleBackColor = true;
            this.AsiaButton.Click += new System.EventHandler(this.AsiaButton_Click);
            // 
            // OutputBox
            // 
            this.OutputBox.Location = new System.Drawing.Point(12, 319);
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.ReadOnly = true;
            this.OutputBox.Size = new System.Drawing.Size(213, 185);
            this.OutputBox.TabIndex = 6;
            this.OutputBox.Text = "";
            // 
            // NamericaText
            // 
            this.NamericaText.AutoSize = true;
            this.NamericaText.Location = new System.Drawing.Point(230, 102);
            this.NamericaText.Name = "NamericaText";
            this.NamericaText.Size = new System.Drawing.Size(41, 13);
            this.NamericaText.TabIndex = 7;
            this.NamericaText.Text = "Neutral";
            this.NamericaText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SamericaText
            // 
            this.SamericaText.AutoSize = true;
            this.SamericaText.Location = new System.Drawing.Point(307, 247);
            this.SamericaText.Name = "SamericaText";
            this.SamericaText.Size = new System.Drawing.Size(41, 13);
            this.SamericaText.TabIndex = 8;
            this.SamericaText.Text = "Neutral";
            this.SamericaText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AfricaText
            // 
            this.AfricaText.AutoSize = true;
            this.AfricaText.Location = new System.Drawing.Point(510, 207);
            this.AfricaText.Name = "AfricaText";
            this.AfricaText.Size = new System.Drawing.Size(41, 13);
            this.AfricaText.TabIndex = 9;
            this.AfricaText.Text = "Neutral";
            this.AfricaText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EuropeText
            // 
            this.EuropeText.AutoSize = true;
            this.EuropeText.Location = new System.Drawing.Point(537, 68);
            this.EuropeText.Name = "EuropeText";
            this.EuropeText.Size = new System.Drawing.Size(41, 13);
            this.EuropeText.TabIndex = 10;
            this.EuropeText.Text = "Neutral";
            this.EuropeText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AsiaText
            // 
            this.AsiaText.AutoSize = true;
            this.AsiaText.Location = new System.Drawing.Point(735, 156);
            this.AsiaText.Name = "AsiaText";
            this.AsiaText.Size = new System.Drawing.Size(41, 13);
            this.AsiaText.TabIndex = 11;
            this.AsiaText.Text = "Neutral";
            this.AsiaText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // turnText
            // 
            this.turnText.AutoSize = true;
            this.turnText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.turnText.Location = new System.Drawing.Point(12, 13);
            this.turnText.Name = "turnText";
            this.turnText.Size = new System.Drawing.Size(150, 24);
            this.turnText.TabIndex = 12;
            this.turnText.Text = "Player 1\'s Turn";
            // 
            // attackCheck
            // 
            this.attackCheck.AutoSize = true;
            this.attackCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attackCheck.Location = new System.Drawing.Point(821, 12);
            this.attackCheck.Name = "attackCheck";
            this.attackCheck.Size = new System.Drawing.Size(171, 28);
            this.attackCheck.TabIndex = 13;
            this.attackCheck.Text = "Invade this turn";
            this.attackCheck.UseVisualStyleBackColor = true;
            this.attackCheck.Visible = false;
            this.attackCheck.CheckedChanged += new System.EventHandler(this.attackCheck_CheckedChanged);
            // 
            // AustraliaButton
            // 
            this.AustraliaButton.Location = new System.Drawing.Point(831, 348);
            this.AustraliaButton.Name = "AustraliaButton";
            this.AustraliaButton.Size = new System.Drawing.Size(75, 23);
            this.AustraliaButton.TabIndex = 14;
            this.AustraliaButton.Text = "Australia";
            this.AustraliaButton.UseVisualStyleBackColor = true;
            this.AustraliaButton.Click += new System.EventHandler(this.AustraliaButton_Click);
            // 
            // AustraliaText
            // 
            this.AustraliaText.AutoSize = true;
            this.AustraliaText.Location = new System.Drawing.Point(808, 319);
            this.AustraliaText.Name = "AustraliaText";
            this.AustraliaText.Size = new System.Drawing.Size(41, 13);
            this.AustraliaText.TabIndex = 15;
            this.AustraliaText.Text = "Neutral";
            this.AustraliaText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(848, 491);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Copyright (c) That\'s Nice Studios 2019";
            // 
            // turnCounter
            // 
            this.turnCounter.AutoSize = true;
            this.turnCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.turnCounter.Location = new System.Drawing.Point(13, 57);
            this.turnCounter.Name = "turnCounter";
            this.turnCounter.Size = new System.Drawing.Size(50, 18);
            this.turnCounter.TabIndex = 17;
            this.turnCounter.Text = "Turn 0";
            // 
            // winLabel
            // 
            this.winLabel.AutoSize = true;
            this.winLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winLabel.Location = new System.Drawing.Point(297, 431);
            this.winLabel.Name = "winLabel";
            this.winLabel.Size = new System.Drawing.Size(444, 73);
            this.winLabel.TabIndex = 18;
            this.winLabel.Text = "Player p Wins!";
            this.winLabel.Visible = false;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(12, 290);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(121, 23);
            this.saveButton.TabIndex = 19;
            this.saveButton.Text = "Save Game Log";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Visible = false;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // powerLabel
            // 
            this.powerLabel.AutoSize = true;
            this.powerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.powerLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.powerLabel.Location = new System.Drawing.Point(12, 37);
            this.powerLabel.Name = "powerLabel";
            this.powerLabel.Size = new System.Drawing.Size(84, 20);
            this.powerLabel.TabIndex = 20;
            this.powerLabel.Text = "Power - 0";
            // 
            // passButton
            // 
            this.passButton.Font = new System.Drawing.Font("Old English Text MT", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passButton.Location = new System.Drawing.Point(296, 431);
            this.passButton.Name = "passButton";
            this.passButton.Size = new System.Drawing.Size(445, 73);
            this.passButton.TabIndex = 21;
            this.passButton.Text = "Pass Turn";
            this.passButton.UseVisualStyleBackColor = true;
            this.passButton.Click += new System.EventHandler(this.PassButton_Click);
            // 
            // invadeLabel
            // 
            this.invadeLabel.AutoSize = true;
            this.invadeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invadeLabel.Location = new System.Drawing.Point(847, 16);
            this.invadeLabel.Name = "invadeLabel";
            this.invadeLabel.Size = new System.Drawing.Size(192, 20);
            this.invadeLabel.TabIndex = 22;
            this.invadeLabel.Text = "Invasions Begin on Turn 5";
            this.invadeLabel.Click += new System.EventHandler(this.InvadeLabel_Click);
            // 
            // mapView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1048, 516);
            this.Controls.Add(this.attackCheck);
            this.Controls.Add(this.invadeLabel);
            this.Controls.Add(this.passButton);
            this.Controls.Add(this.powerLabel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.winLabel);
            this.Controls.Add(this.turnCounter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AustraliaText);
            this.Controls.Add(this.AustraliaButton);
            this.Controls.Add(this.turnText);
            this.Controls.Add(this.AsiaText);
            this.Controls.Add(this.EuropeText);
            this.Controls.Add(this.AfricaText);
            this.Controls.Add(this.SamericaText);
            this.Controls.Add(this.NamericaText);
            this.Controls.Add(this.OutputBox);
            this.Controls.Add(this.AsiaButton);
            this.Controls.Add(this.EuropeButton);
            this.Controls.Add(this.AfricaButton);
            this.Controls.Add(this.SamericaButton);
            this.Controls.Add(this.NamericaButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "mapView";
            this.Text = "Benay\'s Map Game";
            this.Load += new System.EventHandler(this.mapView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NamericaButton;
        private System.Windows.Forms.Button SamericaButton;
        private System.Windows.Forms.Button AfricaButton;
        private System.Windows.Forms.Button EuropeButton;
        private System.Windows.Forms.Button AsiaButton;
        private System.Windows.Forms.RichTextBox OutputBox;
        private System.Windows.Forms.Label NamericaText;
        private System.Windows.Forms.Label SamericaText;
        private System.Windows.Forms.Label AfricaText;
        private System.Windows.Forms.Label EuropeText;
        private System.Windows.Forms.Label AsiaText;
        private System.Windows.Forms.Label turnText;
        private System.Windows.Forms.CheckBox attackCheck;
        private System.Windows.Forms.Button AustraliaButton;
        private System.Windows.Forms.Label AustraliaText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label turnCounter;
        private System.Windows.Forms.Label winLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label powerLabel;
        private System.Windows.Forms.Button passButton;
        private System.Windows.Forms.Label invadeLabel;
    }
}