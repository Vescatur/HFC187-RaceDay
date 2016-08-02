namespace HFC187_RaceBetting
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.minimumBetLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.joeRadioButton = new System.Windows.Forms.RadioButton();
            this.bobRadioButton = new System.Windows.Forms.RadioButton();
            this.alRadioButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bobBetLabel = new System.Windows.Forms.Label();
            this.joeBetLabel = new System.Windows.Forms.Label();
            this.AlBetLabel = new System.Windows.Forms.Label();
            this.ButtonBet = new System.Windows.Forms.Button();
            this.MoneyNumeric = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.DogNumeric = new System.Windows.Forms.NumericUpDown();
            this.ButtonRace = new System.Windows.Forms.Button();
            this.Dog1 = new System.Windows.Forms.PictureBox();
            this.Dog4 = new System.Windows.Forms.PictureBox();
            this.Dog2 = new System.Windows.Forms.PictureBox();
            this.Dog3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MoneyNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DogNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HFC187_RaceBetting.Properties.Resources.racetrack;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(600, 200);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // minimumBetLabel
            // 
            this.minimumBetLabel.AutoSize = true;
            this.minimumBetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimumBetLabel.Location = new System.Drawing.Point(12, 232);
            this.minimumBetLabel.Name = "minimumBetLabel";
            this.minimumBetLabel.Size = new System.Drawing.Size(104, 13);
            this.minimumBetLabel.TabIndex = 1;
            this.minimumBetLabel.Text = "minimumBetLabel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Betting Parlor";
            // 
            // joeRadioButton
            // 
            this.joeRadioButton.AutoSize = true;
            this.joeRadioButton.Location = new System.Drawing.Point(15, 248);
            this.joeRadioButton.Name = "joeRadioButton";
            this.joeRadioButton.Size = new System.Drawing.Size(42, 17);
            this.joeRadioButton.TabIndex = 3;
            this.joeRadioButton.TabStop = true;
            this.joeRadioButton.Text = "Joe";
            this.joeRadioButton.UseVisualStyleBackColor = true;
            // 
            // bobRadioButton
            // 
            this.bobRadioButton.AutoSize = true;
            this.bobRadioButton.Location = new System.Drawing.Point(15, 272);
            this.bobRadioButton.Name = "bobRadioButton";
            this.bobRadioButton.Size = new System.Drawing.Size(44, 17);
            this.bobRadioButton.TabIndex = 4;
            this.bobRadioButton.TabStop = true;
            this.bobRadioButton.Text = "Bob";
            this.bobRadioButton.UseVisualStyleBackColor = true;
            // 
            // alRadioButton
            // 
            this.alRadioButton.AutoSize = true;
            this.alRadioButton.Location = new System.Drawing.Point(15, 296);
            this.alRadioButton.Name = "alRadioButton";
            this.alRadioButton.Size = new System.Drawing.Size(34, 17);
            this.alRadioButton.TabIndex = 5;
            this.alRadioButton.TabStop = true;
            this.alRadioButton.Text = "Al";
            this.alRadioButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 330);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(204, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Bets";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // bobBetLabel
            // 
            this.bobBetLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bobBetLabel.Location = new System.Drawing.Point(207, 272);
            this.bobBetLabel.Name = "bobBetLabel";
            this.bobBetLabel.Size = new System.Drawing.Size(200, 15);
            this.bobBetLabel.TabIndex = 9;
            this.bobBetLabel.Text = "label5";
            // 
            // joeBetLabel
            // 
            this.joeBetLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.joeBetLabel.Location = new System.Drawing.Point(207, 249);
            this.joeBetLabel.Name = "joeBetLabel";
            this.joeBetLabel.Size = new System.Drawing.Size(200, 15);
            this.joeBetLabel.TabIndex = 10;
            this.joeBetLabel.Text = "label4";
            this.joeBetLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // AlBetLabel
            // 
            this.AlBetLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AlBetLabel.Location = new System.Drawing.Point(207, 296);
            this.AlBetLabel.Name = "AlBetLabel";
            this.AlBetLabel.Size = new System.Drawing.Size(200, 15);
            this.AlBetLabel.TabIndex = 11;
            this.AlBetLabel.Text = "label6";
            // 
            // ButtonBet
            // 
            this.ButtonBet.Location = new System.Drawing.Point(54, 325);
            this.ButtonBet.Name = "ButtonBet";
            this.ButtonBet.Size = new System.Drawing.Size(46, 23);
            this.ButtonBet.TabIndex = 12;
            this.ButtonBet.Text = "Bets";
            this.ButtonBet.UseVisualStyleBackColor = true;
            // 
            // MoneyNumeric
            // 
            this.MoneyNumeric.Location = new System.Drawing.Point(106, 328);
            this.MoneyNumeric.Name = "MoneyNumeric";
            this.MoneyNumeric.Size = new System.Drawing.Size(45, 20);
            this.MoneyNumeric.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(158, 330);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "bucks on dog number";
            // 
            // DogNumeric
            // 
            this.DogNumeric.Location = new System.Drawing.Point(274, 328);
            this.DogNumeric.Name = "DogNumeric";
            this.DogNumeric.Size = new System.Drawing.Size(45, 20);
            this.DogNumeric.TabIndex = 15;
            // 
            // ButtonRace
            // 
            this.ButtonRace.Location = new System.Drawing.Point(439, 248);
            this.ButtonRace.Name = "ButtonRace";
            this.ButtonRace.Size = new System.Drawing.Size(173, 63);
            this.ButtonRace.TabIndex = 16;
            this.ButtonRace.Text = "Race";
            this.ButtonRace.UseVisualStyleBackColor = true;
            // 
            // Dog1
            // 
            this.Dog1.Image = global::HFC187_RaceBetting.Properties.Resources.dog;
            this.Dog1.Location = new System.Drawing.Point(25, 23);
            this.Dog1.Name = "Dog1";
            this.Dog1.Size = new System.Drawing.Size(75, 20);
            this.Dog1.TabIndex = 17;
            this.Dog1.TabStop = false;
            // 
            // Dog4
            // 
            this.Dog4.Image = global::HFC187_RaceBetting.Properties.Resources.dog;
            this.Dog4.Location = new System.Drawing.Point(25, 178);
            this.Dog4.Name = "Dog4";
            this.Dog4.Size = new System.Drawing.Size(75, 20);
            this.Dog4.TabIndex = 18;
            this.Dog4.TabStop = false;
            // 
            // Dog2
            // 
            this.Dog2.Image = global::HFC187_RaceBetting.Properties.Resources.dog;
            this.Dog2.Location = new System.Drawing.Point(25, 70);
            this.Dog2.Name = "Dog2";
            this.Dog2.Size = new System.Drawing.Size(75, 20);
            this.Dog2.TabIndex = 18;
            this.Dog2.TabStop = false;
            // 
            // Dog3
            // 
            this.Dog3.Image = global::HFC187_RaceBetting.Properties.Resources.dog;
            this.Dog3.Location = new System.Drawing.Point(25, 120);
            this.Dog3.Name = "Dog3";
            this.Dog3.Size = new System.Drawing.Size(75, 20);
            this.Dog3.TabIndex = 19;
            this.Dog3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 361);
            this.Controls.Add(this.Dog3);
            this.Controls.Add(this.Dog2);
            this.Controls.Add(this.Dog4);
            this.Controls.Add(this.Dog1);
            this.Controls.Add(this.ButtonRace);
            this.Controls.Add(this.DogNumeric);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.MoneyNumeric);
            this.Controls.Add(this.ButtonBet);
            this.Controls.Add(this.AlBetLabel);
            this.Controls.Add(this.joeBetLabel);
            this.Controls.Add(this.bobBetLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.alRadioButton);
            this.Controls.Add(this.bobRadioButton);
            this.Controls.Add(this.joeRadioButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.minimumBetLabel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MoneyNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DogNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label minimumBetLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton joeRadioButton;
        private System.Windows.Forms.RadioButton bobRadioButton;
        private System.Windows.Forms.RadioButton alRadioButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label bobBetLabel;
        private System.Windows.Forms.Label joeBetLabel;
        private System.Windows.Forms.Label AlBetLabel;
        private System.Windows.Forms.Button ButtonBet;
        private System.Windows.Forms.NumericUpDown MoneyNumeric;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown DogNumeric;
        private System.Windows.Forms.Button ButtonRace;
        private System.Windows.Forms.PictureBox Dog1;
        private System.Windows.Forms.PictureBox Dog4;
        private System.Windows.Forms.PictureBox Dog2;
        private System.Windows.Forms.PictureBox Dog3;
    }
}

