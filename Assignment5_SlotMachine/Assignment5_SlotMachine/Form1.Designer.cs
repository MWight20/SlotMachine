namespace Assignment5_SlotMachine
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
            this.spinButton = new System.Windows.Forms.Button();
            this.guestButton = new System.Windows.Forms.Button();
            this.selectUserButton = new System.Windows.Forms.Button();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.newUserButton = new System.Windows.Forms.Button();
            this.playerGroupBox = new System.Windows.Forms.GroupBox();
            this.userTextBox = new System.Windows.Forms.TextBox();
            this.switchGameButton = new System.Windows.Forms.Button();
            this.creditsLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textLabel = new System.Windows.Forms.Label();
            this.cashOutButton = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.addTenDollarsButton = new System.Windows.Forms.Button();
            this.modeLabel = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.playerGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // spinButton
            // 
            this.spinButton.Location = new System.Drawing.Point(322, 375);
            this.spinButton.Name = "spinButton";
            this.spinButton.Size = new System.Drawing.Size(121, 48);
            this.spinButton.TabIndex = 3;
            this.spinButton.Text = "SPIN";
            this.spinButton.UseVisualStyleBackColor = true;
            this.spinButton.Click += new System.EventHandler(this.SpinButton_Click);
            // 
            // guestButton
            // 
            this.guestButton.Location = new System.Drawing.Point(96, 80);
            this.guestButton.Name = "guestButton";
            this.guestButton.Size = new System.Drawing.Size(75, 23);
            this.guestButton.TabIndex = 6;
            this.guestButton.Text = "Guest";
            this.guestButton.UseVisualStyleBackColor = true;
            this.guestButton.Click += new System.EventHandler(this.GuestButton_Click);
            // 
            // selectUserButton
            // 
            this.selectUserButton.Location = new System.Drawing.Point(158, 27);
            this.selectUserButton.Name = "selectUserButton";
            this.selectUserButton.Size = new System.Drawing.Size(75, 23);
            this.selectUserButton.TabIndex = 7;
            this.selectUserButton.Text = "Select User";
            this.selectUserButton.UseVisualStyleBackColor = true;
            this.selectUserButton.Click += new System.EventHandler(this.SelectUserButton_Click);
            // 
            // comboBox
            // 
            this.comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(31, 27);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(121, 21);
            this.comboBox.TabIndex = 8;
            // 
            // newUserButton
            // 
            this.newUserButton.Location = new System.Drawing.Point(158, 51);
            this.newUserButton.Name = "newUserButton";
            this.newUserButton.Size = new System.Drawing.Size(75, 23);
            this.newUserButton.TabIndex = 9;
            this.newUserButton.Text = "New User";
            this.newUserButton.UseVisualStyleBackColor = true;
            this.newUserButton.Click += new System.EventHandler(this.NewUserButton_Click);
            // 
            // playerGroupBox
            // 
            this.playerGroupBox.Controls.Add(this.userTextBox);
            this.playerGroupBox.Controls.Add(this.comboBox);
            this.playerGroupBox.Controls.Add(this.newUserButton);
            this.playerGroupBox.Controls.Add(this.guestButton);
            this.playerGroupBox.Controls.Add(this.selectUserButton);
            this.playerGroupBox.Location = new System.Drawing.Point(29, 25);
            this.playerGroupBox.Name = "playerGroupBox";
            this.playerGroupBox.Size = new System.Drawing.Size(258, 109);
            this.playerGroupBox.TabIndex = 10;
            this.playerGroupBox.TabStop = false;
            this.playerGroupBox.Text = "Player";
            // 
            // userTextBox
            // 
            this.userTextBox.Location = new System.Drawing.Point(31, 53);
            this.userTextBox.Name = "userTextBox";
            this.userTextBox.Size = new System.Drawing.Size(121, 20);
            this.userTextBox.TabIndex = 10;
            // 
            // switchGameButton
            // 
            this.switchGameButton.Location = new System.Drawing.Point(633, 421);
            this.switchGameButton.Name = "switchGameButton";
            this.switchGameButton.Size = new System.Drawing.Size(114, 24);
            this.switchGameButton.TabIndex = 11;
            this.switchGameButton.Text = "Switch Game Mode";
            this.switchGameButton.UseVisualStyleBackColor = true;
            this.switchGameButton.Click += new System.EventHandler(this.SwitchGameButton_Click);
            // 
            // creditsLabel
            // 
            this.creditsLabel.AutoSize = true;
            this.creditsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditsLabel.Location = new System.Drawing.Point(43, 27);
            this.creditsLabel.Name = "creditsLabel";
            this.creditsLabel.Size = new System.Drawing.Size(0, 55);
            this.creditsLabel.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.creditsLabel);
            this.groupBox1.Location = new System.Drawing.Point(436, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 109);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "[ ] Credits:";
            // 
            // textLabel
            // 
            this.textLabel.AutoSize = true;
            this.textLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLabel.Location = new System.Drawing.Point(217, 159);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(322, 37);
            this.textLabel.TabIndex = 14;
            this.textLabel.Text = "Select Player To Spin";
            // 
            // cashOutButton
            // 
            this.cashOutButton.Location = new System.Drawing.Point(580, 140);
            this.cashOutButton.Name = "cashOutButton";
            this.cashOutButton.Size = new System.Drawing.Size(114, 23);
            this.cashOutButton.TabIndex = 15;
            this.cashOutButton.Text = "Cash Out";
            this.cashOutButton.UseVisualStyleBackColor = true;
            this.cashOutButton.Click += new System.EventHandler(this.CashOutButton_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Assignment5_SlotMachine.Properties.Resources.smashBall;
            this.pictureBox5.Location = new System.Drawing.Point(601, 226);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(120, 124);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 5;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Assignment5_SlotMachine.Properties.Resources.backGround;
            this.pictureBox4.Location = new System.Drawing.Point(463, 226);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(120, 124);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Assignment5_SlotMachine.Properties.Resources.smashBall;
            this.pictureBox3.Location = new System.Drawing.Point(323, 226);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(120, 124);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Assignment5_SlotMachine.Properties.Resources.backGround;
            this.pictureBox2.Location = new System.Drawing.Point(187, 226);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(120, 124);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Assignment5_SlotMachine.Properties.Resources.smashBall;
            this.pictureBox1.Location = new System.Drawing.Point(48, 226);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // addTenDollarsButton
            // 
            this.addTenDollarsButton.Location = new System.Drawing.Point(13, 451);
            this.addTenDollarsButton.Name = "addTenDollarsButton";
            this.addTenDollarsButton.Size = new System.Drawing.Size(49, 23);
            this.addTenDollarsButton.TabIndex = 16;
            this.addTenDollarsButton.Text = "+$10";
            this.addTenDollarsButton.UseVisualStyleBackColor = true;
            this.addTenDollarsButton.Click += new System.EventHandler(this.AddTenDollarsButton_Click);
            // 
            // modeLabel
            // 
            this.modeLabel.AutoSize = true;
            this.modeLabel.Location = new System.Drawing.Point(630, 393);
            this.modeLabel.Name = "modeLabel";
            this.modeLabel.Size = new System.Drawing.Size(114, 13);
            this.modeLabel.TabIndex = 17;
            this.modeLabel.Text = "Currently playing: 3Slot";
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(633, 451);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(114, 23);
            this.ExitButton.TabIndex = 18;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 485);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.modeLabel);
            this.Controls.Add(this.addTenDollarsButton);
            this.Controls.Add(this.cashOutButton);
            this.Controls.Add(this.textLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.switchGameButton);
            this.Controls.Add(this.playerGroupBox);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.spinButton);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.playerGroupBox.ResumeLayout(false);
            this.playerGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button spinButton;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button guestButton;
        private System.Windows.Forms.Button selectUserButton;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Button newUserButton;
        private System.Windows.Forms.GroupBox playerGroupBox;
        private System.Windows.Forms.Button switchGameButton;
        private System.Windows.Forms.Label creditsLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label textLabel;
        private System.Windows.Forms.Button cashOutButton;
        private System.Windows.Forms.TextBox userTextBox;
        private System.Windows.Forms.Button addTenDollarsButton;
        private System.Windows.Forms.Label modeLabel;
        private System.Windows.Forms.Button ExitButton;
    }
}

