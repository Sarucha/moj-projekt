namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            this.GenerateNumberButton = new System.Windows.Forms.Button();
            this.NewGameButton = new System.Windows.Forms.Button();
            this.PauseButton = new System.Windows.Forms.Button();
            this.InformationsButton = new System.Windows.Forms.Button();
            this.HistoryButton = new System.Windows.Forms.Button();
            this.CheckButton = new System.Windows.Forms.Button();
            this.NumbersToTextBox = new System.Windows.Forms.TextBox();
            this.NumbersFromTextBox = new System.Windows.Forms.TextBox();
            this.GuessTextBox = new System.Windows.Forms.TextBox();
            this.labelGeneratedNumber = new System.Windows.Forms.Label();
            this.labelTries = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.Generate = new System.Windows.Forms.GroupBox();
            this.Summarylabel = new System.Windows.Forms.Label();
            this.timerGame = new System.Windows.Forms.Timer(this.components);
            this.Generate.SuspendLayout();
            this.SuspendLayout();
            // 
            // GenerateNumberButton
            // 
            this.GenerateNumberButton.Location = new System.Drawing.Point(205, 102);
            this.GenerateNumberButton.Name = "GenerateNumberButton";
            this.GenerateNumberButton.Size = new System.Drawing.Size(141, 40);
            this.GenerateNumberButton.TabIndex = 0;
            this.GenerateNumberButton.Text = "GenerateNumber";
            this.GenerateNumberButton.UseVisualStyleBackColor = true;
            this.GenerateNumberButton.Visible = false;
            this.GenerateNumberButton.Click += new System.EventHandler(this.GenerateNumberButton_Click);
            // 
            // NewGameButton
            // 
            this.NewGameButton.Location = new System.Drawing.Point(12, 98);
            this.NewGameButton.Name = "NewGameButton";
            this.NewGameButton.Size = new System.Drawing.Size(115, 33);
            this.NewGameButton.TabIndex = 1;
            this.NewGameButton.Text = "NewGame";
            this.NewGameButton.UseVisualStyleBackColor = true;
            this.NewGameButton.Click += new System.EventHandler(this.NewGameButton_Click);
            // 
            // PauseButton
            // 
            this.PauseButton.Location = new System.Drawing.Point(6, 103);
            this.PauseButton.Name = "PauseButton";
            this.PauseButton.Size = new System.Drawing.Size(85, 39);
            this.PauseButton.TabIndex = 2;
            this.PauseButton.Text = "Pause";
            this.PauseButton.UseVisualStyleBackColor = true;
            this.PauseButton.Visible = false;
            this.PauseButton.Click += new System.EventHandler(this.PauseButton_Click);
            // 
            // InformationsButton
            // 
            this.InformationsButton.Location = new System.Drawing.Point(205, 188);
            this.InformationsButton.Name = "InformationsButton";
            this.InformationsButton.Size = new System.Drawing.Size(117, 41);
            this.InformationsButton.TabIndex = 3;
            this.InformationsButton.Text = "Informations";
            this.InformationsButton.UseVisualStyleBackColor = true;
            this.InformationsButton.Visible = false;
            this.InformationsButton.Click += new System.EventHandler(this.InformationsButton_Click);
            // 
            // HistoryButton
            // 
            this.HistoryButton.Location = new System.Drawing.Point(205, 32);
            this.HistoryButton.Name = "HistoryButton";
            this.HistoryButton.Size = new System.Drawing.Size(92, 33);
            this.HistoryButton.TabIndex = 4;
            this.HistoryButton.Text = "History";
            this.HistoryButton.UseVisualStyleBackColor = true;
            this.HistoryButton.Click += new System.EventHandler(this.HistoryButton_Click);
            // 
            // CheckButton
            // 
            this.CheckButton.Location = new System.Drawing.Point(6, 188);
            this.CheckButton.Name = "CheckButton";
            this.CheckButton.Size = new System.Drawing.Size(85, 41);
            this.CheckButton.TabIndex = 5;
            this.CheckButton.Text = "Check";
            this.CheckButton.UseVisualStyleBackColor = true;
            this.CheckButton.Visible = false;
            this.CheckButton.Click += new System.EventHandler(this.CheckButton_Click);
            // 
            // NumbersToTextBox
            // 
            this.NumbersToTextBox.Location = new System.Drawing.Point(457, 103);
            this.NumbersToTextBox.Name = "NumbersToTextBox";
            this.NumbersToTextBox.Size = new System.Drawing.Size(100, 22);
            this.NumbersToTextBox.TabIndex = 6;
            this.NumbersToTextBox.Text = "NumbersTo";
            this.NumbersToTextBox.Visible = false;
            this.NumbersToTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NumbersToTextBox_MouseClick);
            this.NumbersToTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumbersToTextBox_KeyPress);
            // 
            // NumbersFromTextBox
            // 
            this.NumbersFromTextBox.Location = new System.Drawing.Point(457, 43);
            this.NumbersFromTextBox.Name = "NumbersFromTextBox";
            this.NumbersFromTextBox.Size = new System.Drawing.Size(100, 22);
            this.NumbersFromTextBox.TabIndex = 7;
            this.NumbersFromTextBox.Text = "NumbersFrom";
            this.NumbersFromTextBox.Visible = false;
            this.NumbersFromTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NumbersFromTextBox_MouseClick);
            this.NumbersFromTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumbersfromTextBox_KeyPress);
            // 
            // GuessTextBox
            // 
            this.GuessTextBox.Location = new System.Drawing.Point(457, 176);
            this.GuessTextBox.Name = "GuessTextBox";
            this.GuessTextBox.Size = new System.Drawing.Size(100, 22);
            this.GuessTextBox.TabIndex = 8;
            this.GuessTextBox.Text = "Guess";
            this.GuessTextBox.Visible = false;
            this.GuessTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GuessTextBox_MouseClick);
            this.GuessTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GuessTextBox_KeyPress);
            // 
            // labelGeneratedNumber
            // 
            this.labelGeneratedNumber.AutoSize = true;
            this.labelGeneratedNumber.Location = new System.Drawing.Point(168, 55);
            this.labelGeneratedNumber.Name = "labelGeneratedNumber";
            this.labelGeneratedNumber.Size = new System.Drawing.Size(126, 17);
            this.labelGeneratedNumber.TabIndex = 9;
            this.labelGeneratedNumber.Text = "GeneratedNumber";
            this.labelGeneratedNumber.Visible = false;
            // 
            // labelTries
            // 
            this.labelTries.AutoSize = true;
            this.labelTries.Location = new System.Drawing.Point(369, 55);
            this.labelTries.Name = "labelTries";
            this.labelTries.Size = new System.Drawing.Size(112, 17);
            this.labelTries.TabIndex = 10;
            this.labelTries.Text = "NumbersOfTries";
            this.labelTries.Visible = false;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(631, 55);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(43, 17);
            this.labelTime.TabIndex = 11;
            this.labelTime.Text = "Time:";
            this.labelTime.Visible = false;
            // 
            // Generate
            // 
            this.Generate.Controls.Add(this.GuessTextBox);
            this.Generate.Controls.Add(this.NumbersFromTextBox);
            this.Generate.Controls.Add(this.NumbersToTextBox);
            this.Generate.Controls.Add(this.CheckButton);
            this.Generate.Controls.Add(this.HistoryButton);
            this.Generate.Controls.Add(this.InformationsButton);
            this.Generate.Controls.Add(this.PauseButton);
            this.Generate.Controls.Add(this.GenerateNumberButton);
            this.Generate.Location = new System.Drawing.Point(147, 76);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(580, 257);
            this.Generate.TabIndex = 12;
            this.Generate.TabStop = false;
            this.Generate.Text = "Generate";
            // 
            // Summarylabel
            // 
            this.Summarylabel.AutoSize = true;
            this.Summarylabel.Location = new System.Drawing.Point(318, 358);
            this.Summarylabel.Name = "Summarylabel";
            this.Summarylabel.Size = new System.Drawing.Size(67, 17);
            this.Summarylabel.TabIndex = 13;
            this.Summarylabel.Text = "Summary";
            this.Summarylabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerGame
            // 
            this.timerGame.Interval = 1000;
            this.timerGame.Tick += new System.EventHandler(this.timerGame_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Summarylabel);
            this.Controls.Add(this.Generate);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelTries);
            this.Controls.Add(this.labelGeneratedNumber);
            this.Controls.Add(this.NewGameButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Generate.ResumeLayout(false);
            this.Generate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GenerateNumberButton;
        private System.Windows.Forms.Button NewGameButton;
        private System.Windows.Forms.Button PauseButton;
        private System.Windows.Forms.Button InformationsButton;
        private System.Windows.Forms.Button HistoryButton;
        private System.Windows.Forms.Button CheckButton;
        private System.Windows.Forms.TextBox NumbersToTextBox;
        private System.Windows.Forms.TextBox NumbersFromTextBox;
        private System.Windows.Forms.TextBox GuessTextBox;
        private System.Windows.Forms.Label labelGeneratedNumber;
        private System.Windows.Forms.Label labelTries;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.GroupBox Generate;
        private System.Windows.Forms.Label Summarylabel;
        private System.Windows.Forms.Timer timerGame;
    }
}

