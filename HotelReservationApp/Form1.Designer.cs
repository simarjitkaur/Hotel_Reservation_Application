namespace HotelReservationApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LogoPictureBox1 = new System.Windows.Forms.PictureBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GuestNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ArrivalDateLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.clockLabel = new System.Windows.Forms.Label();
            this.checkin = new System.Windows.Forms.DateTimePicker();
            this.checkout = new System.Windows.Forms.DateTimePicker();
            this.noOfNights = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.PhoneTextBox = new System.Windows.Forms.TextBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.stateTextBox = new System.Windows.Forms.TextBox();
            this.countaryTextBox = new System.Windows.Forms.TextBox();
            this.postalcodeTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.roomtypeTextBox = new System.Windows.Forms.TextBox();
            this.closeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GuestNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noOfNights)).BeginInit();
            this.SuspendLayout();
            // 
            // LogoPictureBox1
            // 
            this.LogoPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.LogoPictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LogoPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("LogoPictureBox1.Image")));
            this.LogoPictureBox1.Location = new System.Drawing.Point(410, 12);
            this.LogoPictureBox1.Name = "LogoPictureBox1";
            this.LogoPictureBox1.Size = new System.Drawing.Size(256, 131);
            this.LogoPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoPictureBox1.TabIndex = 0;
            this.LogoPictureBox1.TabStop = false;
            this.LogoPictureBox1.WaitOnLoad = true;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.ForeColor = System.Drawing.Color.Black;
            this.NameLabel.Location = new System.Drawing.Point(57, 176);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(69, 25);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Name ";
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(292, 177);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(157, 26);
            this.FirstNameTextBox.TabIndex = 2;
            this.FirstNameTextBox.Text = "Enter first name";
            this.FirstNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FirstNameTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FirstNameTextBox_MouseClick);
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(455, 177);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(157, 26);
            this.LastNameTextBox.TabIndex = 3;
            this.LastNameTextBox.Text = "Enter last name";
            this.LastNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LastNameTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LastNameTextBox_MouseClick);
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameLabel.Location = new System.Drawing.Point(57, 226);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(72, 25);
            this.LastNameLabel.TabIndex = 4;
            this.LastNameLabel.Text = "E-mail ";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(231, 227);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(381, 26);
            this.EmailTextBox.TabIndex = 4;
            this.EmailTextBox.Text = "Ex: myname@example.com";
            this.EmailTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EmailTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.EmailTextBox_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(650, 325);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Room Type ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(650, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Number Of Guests ";
            // 
            // GuestNumericUpDown
            // 
            this.GuestNumericUpDown.Location = new System.Drawing.Point(827, 270);
            this.GuestNumericUpDown.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.GuestNumericUpDown.Name = "GuestNumericUpDown";
            this.GuestNumericUpDown.Size = new System.Drawing.Size(176, 26);
            this.GuestNumericUpDown.TabIndex = 11;
            this.GuestNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.GuestNumericUpDown.ValueChanged += new System.EventHandler(this.GuestNumericUpDown_ValueChanged);
            // 
            // ArrivalDateLabel
            // 
            this.ArrivalDateLabel.AutoSize = true;
            this.ArrivalDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArrivalDateLabel.Location = new System.Drawing.Point(57, 372);
            this.ArrivalDateLabel.Name = "ArrivalDateLabel";
            this.ArrivalDateLabel.Size = new System.Drawing.Size(172, 25);
            this.ArrivalDateLabel.TabIndex = 10;
            this.ArrivalDateLabel.Text = "Arrival Date & Time ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(534, 373);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 25);
            this.label3.TabIndex = 22;
            this.label3.Text = "Departure Date ";
            // 
            // SubmitButton
            // 
            this.SubmitButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.SubmitButton.Location = new System.Drawing.Point(655, 422);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(139, 54);
            this.SubmitButton.TabIndex = 15;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = false;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // clockLabel
            // 
            this.clockLabel.AutoSize = true;
            this.clockLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.clockLabel.Location = new System.Drawing.Point(758, 146);
            this.clockLabel.Name = "clockLabel";
            this.clockLabel.Size = new System.Drawing.Size(0, 20);
            this.clockLabel.TabIndex = 27;
            // 
            // checkin
            // 
            this.checkin.Location = new System.Drawing.Point(268, 372);
            this.checkin.Name = "checkin";
            this.checkin.Size = new System.Drawing.Size(200, 26);
            this.checkin.TabIndex = 13;
            this.checkin.ValueChanged += new System.EventHandler(this.checkin_ValueChanged);
            // 
            // checkout
            // 
            this.checkout.Enabled = false;
            this.checkout.Location = new System.Drawing.Point(803, 371);
            this.checkout.Name = "checkout";
            this.checkout.Size = new System.Drawing.Size(200, 26);
            this.checkout.TabIndex = 14;
            // 
            // noOfNights
            // 
            this.noOfNights.Location = new System.Drawing.Point(827, 225);
            this.noOfNights.Name = "noOfNights";
            this.noOfNights.Size = new System.Drawing.Size(176, 26);
            this.noOfNights.TabIndex = 10;
            this.noOfNights.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.noOfNights.ValueChanged += new System.EventHandler(this.noOfNights_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(650, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 25);
            this.label4.TabIndex = 31;
            this.label4.Text = "No. of nights ";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(233, 177);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(53, 26);
            this.titleTextBox.TabIndex = 1;
            this.titleTextBox.Text = "Title";
            this.titleTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.titleTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.titleTextBox_MouseClick);
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(651, 181);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(83, 20);
            this.phoneLabel.TabIndex = 33;
            this.phoneLabel.Text = "Phone No.";
            // 
            // PhoneTextBox
            // 
            this.PhoneTextBox.Location = new System.Drawing.Point(827, 178);
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.Size = new System.Drawing.Size(176, 26);
            this.PhoneTextBox.TabIndex = 9;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(58, 278);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(68, 20);
            this.addressLabel.TabIndex = 35;
            this.addressLabel.Text = "Address";
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(231, 272);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(140, 26);
            this.cityTextBox.TabIndex = 5;
            this.cityTextBox.Text = "City";
            this.cityTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cityTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cityTextBox_MouseClick);
            // 
            // stateTextBox
            // 
            this.stateTextBox.Location = new System.Drawing.Point(484, 272);
            this.stateTextBox.Name = "stateTextBox";
            this.stateTextBox.Size = new System.Drawing.Size(128, 26);
            this.stateTextBox.TabIndex = 6;
            this.stateTextBox.Text = "State";
            this.stateTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.stateTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.stateTextBox_MouseClick);
            // 
            // countaryTextBox
            // 
            this.countaryTextBox.Location = new System.Drawing.Point(231, 326);
            this.countaryTextBox.Name = "countaryTextBox";
            this.countaryTextBox.Size = new System.Drawing.Size(140, 26);
            this.countaryTextBox.TabIndex = 7;
            this.countaryTextBox.Text = "Country";
            this.countaryTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.countaryTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.countaryTextBox_MouseClick);
            // 
            // postalcodeTextBox
            // 
            this.postalcodeTextBox.Location = new System.Drawing.Point(484, 326);
            this.postalcodeTextBox.Name = "postalcodeTextBox";
            this.postalcodeTextBox.Size = new System.Drawing.Size(128, 26);
            this.postalcodeTextBox.TabIndex = 8;
            this.postalcodeTextBox.Text = "Postal Code";
            this.postalcodeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.postalcodeTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.postalcodeTextBox_MouseClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(421, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(227, 20);
            this.label5.TabIndex = 40;
            this.label5.Text = "Thunder Bay, Ontario , Canada";
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.resetButton.Location = new System.Drawing.Point(655, 482);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(139, 54);
            this.resetButton.TabIndex = 41;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.descriptionLabel.Location = new System.Drawing.Point(62, 422);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(550, 181);
            this.descriptionLabel.TabIndex = 6;
            this.descriptionLabel.Text = "Summary Description";
            // 
            // roomtypeTextBox
            // 
            this.roomtypeTextBox.Enabled = false;
            this.roomtypeTextBox.Location = new System.Drawing.Point(829, 324);
            this.roomtypeTextBox.Name = "roomtypeTextBox";
            this.roomtypeTextBox.Size = new System.Drawing.Size(174, 26);
            this.roomtypeTextBox.TabIndex = 12;
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.closeButton.Location = new System.Drawing.Point(655, 546);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(139, 54);
            this.closeButton.TabIndex = 44;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1067, 612);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.roomtypeTextBox);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.postalcodeTextBox);
            this.Controls.Add(this.countaryTextBox);
            this.Controls.Add(this.stateTextBox);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.PhoneTextBox);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.noOfNights);
            this.Controls.Add(this.checkout);
            this.Controls.Add(this.checkin);
            this.Controls.Add(this.clockLabel);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ArrivalDateLabel);
            this.Controls.Add(this.GuestNumericUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.FirstNameTextBox);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.LogoPictureBox1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Hotel Reservation Form";
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GuestNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noOfNights)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox LogoPictureBox1;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown GuestNumericUpDown;
        private System.Windows.Forms.Label ArrivalDateLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label clockLabel;
        private System.Windows.Forms.DateTimePicker checkin;
        private System.Windows.Forms.DateTimePicker checkout;
        private System.Windows.Forms.NumericUpDown noOfNights;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.TextBox PhoneTextBox;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox stateTextBox;
        private System.Windows.Forms.TextBox countaryTextBox;
        private System.Windows.Forms.TextBox postalcodeTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.TextBox roomtypeTextBox;
        private System.Windows.Forms.Button closeButton;
    }
}

