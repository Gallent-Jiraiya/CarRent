
namespace CarRent
{
    partial class US_VehDet
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.passenger = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Rad_Full = new System.Windows.Forms.RadioButton();
            this.Rad_NoAir = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Rad_Manual = new System.Windows.Forms.RadioButton();
            this.Rad_Auto = new System.Windows.Forms.RadioButton();
            this.Cmb_Luggage = new System.Windows.Forms.ComboBox();
            this.ModelYear = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.FreeMileage = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.PricePerKM = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.RentingPrice = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ModelVeh = new System.Windows.Forms.TextBox();
            this.Regno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.passenger);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.Cmb_Luggage);
            this.panel1.Controls.Add(this.ModelYear);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.FreeMileage);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.PricePerKM);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.RentingPrice);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.ModelVeh);
            this.panel1.Controls.Add(this.Regno);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(341, 490);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // passenger
            // 
            this.passenger.Location = new System.Drawing.Point(159, 99);
            this.passenger.Name = "passenger";
            this.passenger.Size = new System.Drawing.Size(174, 20);
            this.passenger.TabIndex = 29;
            this.passenger.TextChanged += new System.EventHandler(this.Passenger_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(7, 97);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(142, 20);
            this.label12.TabIndex = 28;
            this.label12.Text = "No. Of Passengers";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Rad_Full);
            this.panel3.Controls.Add(this.Rad_NoAir);
            this.panel3.Location = new System.Drawing.Point(159, 246);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(174, 20);
            this.panel3.TabIndex = 27;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // Rad_Full
            // 
            this.Rad_Full.AutoSize = true;
            this.Rad_Full.BackColor = System.Drawing.Color.Transparent;
            this.Rad_Full.Location = new System.Drawing.Point(7, 0);
            this.Rad_Full.Name = "Rad_Full";
            this.Rad_Full.Size = new System.Drawing.Size(41, 17);
            this.Rad_Full.TabIndex = 0;
            this.Rad_Full.TabStop = true;
            this.Rad_Full.Text = "Full";
            this.Rad_Full.UseVisualStyleBackColor = false;
            this.Rad_Full.CheckedChanged += new System.EventHandler(this.Rad_Full_CheckedChanged);
            // 
            // Rad_NoAir
            // 
            this.Rad_NoAir.AutoSize = true;
            this.Rad_NoAir.BackColor = System.Drawing.Color.Transparent;
            this.Rad_NoAir.Location = new System.Drawing.Point(117, 0);
            this.Rad_NoAir.Name = "Rad_NoAir";
            this.Rad_NoAir.Size = new System.Drawing.Size(39, 17);
            this.Rad_NoAir.TabIndex = 28;
            this.Rad_NoAir.TabStop = true;
            this.Rad_NoAir.Text = "No";
            this.Rad_NoAir.UseVisualStyleBackColor = false;
            this.Rad_NoAir.CheckedChanged += new System.EventHandler(this.Rad_NoAir_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Rad_Manual);
            this.panel2.Controls.Add(this.Rad_Auto);
            this.panel2.Location = new System.Drawing.Point(159, 218);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(174, 20);
            this.panel2.TabIndex = 26;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Rad_Manual
            // 
            this.Rad_Manual.AutoSize = true;
            this.Rad_Manual.BackColor = System.Drawing.Color.Transparent;
            this.Rad_Manual.Location = new System.Drawing.Point(117, 2);
            this.Rad_Manual.Name = "Rad_Manual";
            this.Rad_Manual.Size = new System.Drawing.Size(60, 17);
            this.Rad_Manual.TabIndex = 1;
            this.Rad_Manual.TabStop = true;
            this.Rad_Manual.Text = "Manual";
            this.Rad_Manual.UseVisualStyleBackColor = false;
            this.Rad_Manual.CheckedChanged += new System.EventHandler(this.Rad_Manual_CheckedChanged);
            // 
            // Rad_Auto
            // 
            this.Rad_Auto.AutoSize = true;
            this.Rad_Auto.BackColor = System.Drawing.Color.Transparent;
            this.Rad_Auto.Location = new System.Drawing.Point(7, 0);
            this.Rad_Auto.Name = "Rad_Auto";
            this.Rad_Auto.Size = new System.Drawing.Size(47, 17);
            this.Rad_Auto.TabIndex = 0;
            this.Rad_Auto.TabStop = true;
            this.Rad_Auto.Text = "Auto";
            this.Rad_Auto.UseVisualStyleBackColor = false;
            this.Rad_Auto.CheckedChanged += new System.EventHandler(this.Rad_Auto_CheckedChanged);
            // 
            // Cmb_Luggage
            // 
            this.Cmb_Luggage.FormattingEnabled = true;
            this.Cmb_Luggage.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.Cmb_Luggage.Location = new System.Drawing.Point(159, 273);
            this.Cmb_Luggage.Name = "Cmb_Luggage";
            this.Cmb_Luggage.Size = new System.Drawing.Size(174, 21);
            this.Cmb_Luggage.TabIndex = 25;
            this.Cmb_Luggage.SelectedIndexChanged += new System.EventHandler(this.Cmb_Luggage_SelectedIndexChanged);
            // 
            // ModelYear
            // 
            this.ModelYear.Location = new System.Drawing.Point(159, 72);
            this.ModelYear.Name = "ModelYear";
            this.ModelYear.Size = new System.Drawing.Size(174, 20);
            this.ModelYear.TabIndex = 24;
            this.ModelYear.TextChanged += new System.EventHandler(this.ModelYear_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(7, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 20);
            this.label9.TabIndex = 23;
            this.label9.Text = "Model Year";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 274);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Luggage";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Air Conditon";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Transmission Type";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // FreeMileage
            // 
            this.FreeMileage.Location = new System.Drawing.Point(159, 188);
            this.FreeMileage.Name = "FreeMileage";
            this.FreeMileage.Size = new System.Drawing.Size(174, 20);
            this.FreeMileage.TabIndex = 14;
            this.FreeMileage.TextChanged += new System.EventHandler(this.FreeMileage_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Free Mileage";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(159, 310);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.RoyalBlue;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(195, 443);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(138, 30);
            this.button4.TabIndex = 11;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.RoyalBlue;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(20, 443);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(138, 30);
            this.button3.TabIndex = 11;
            this.button3.Text = "Edit";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.RoyalBlue;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(195, 394);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 30);
            this.button2.TabIndex = 11;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(20, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 30);
            this.button1.TabIndex = 11;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(7, 310);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 20);
            this.label10.TabIndex = 8;
            this.label10.Text = "Vehicle Image";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // PricePerKM
            // 
            this.PricePerKM.Location = new System.Drawing.Point(159, 158);
            this.PricePerKM.Name = "PricePerKM";
            this.PricePerKM.Size = new System.Drawing.Size(174, 20);
            this.PricePerKM.TabIndex = 9;
            this.PricePerKM.TextChanged += new System.EventHandler(this.PricePerKM_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(7, 156);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(140, 20);
            this.label11.TabIndex = 8;
            this.label11.Text = "Price Per Extra Km";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // RentingPrice
            // 
            this.RentingPrice.Location = new System.Drawing.Point(159, 125);
            this.RentingPrice.Name = "RentingPrice";
            this.RentingPrice.Size = new System.Drawing.Size(174, 20);
            this.RentingPrice.TabIndex = 9;
            this.RentingPrice.TextChanged += new System.EventHandler(this.RentingPrice_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(7, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Renting Price (Rs.)";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // ModelVeh
            // 
            this.ModelVeh.Location = new System.Drawing.Point(159, 46);
            this.ModelVeh.Name = "ModelVeh";
            this.ModelVeh.Size = new System.Drawing.Size(174, 20);
            this.ModelVeh.TabIndex = 1;
            this.ModelVeh.TextChanged += new System.EventHandler(this.ModelVeh_TextChanged);
            // 
            // Regno
            // 
            this.Regno.Location = new System.Drawing.Point(159, 19);
            this.Regno.Name = "Regno";
            this.Regno.Size = new System.Drawing.Size(174, 20);
            this.Regno.TabIndex = 1;
            this.Regno.TextChanged += new System.EventHandler(this.RegNo_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Model";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Vehicle Reg. No.";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // US_VehDet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "US_VehDet";
            this.Size = new System.Drawing.Size(341, 490);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox passenger;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton Rad_Full;
        private System.Windows.Forms.RadioButton Rad_NoAir;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton Rad_Manual;
        private System.Windows.Forms.RadioButton Rad_Auto;
        private System.Windows.Forms.ComboBox Cmb_Luggage;
        private System.Windows.Forms.TextBox ModelYear;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox FreeMileage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox PricePerKM;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox RentingPrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ModelVeh;
        private System.Windows.Forms.TextBox Regno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}
