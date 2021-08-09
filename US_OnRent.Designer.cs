
namespace CarRent
{
    partial class US_OnRent
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewOnRent = new System.Windows.Forms.DataGridView();
            this.btn_EndRent = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_orFP = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_Invoice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Advance = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_StartMile = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmb_Driver = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gunaEndDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.gunaStartDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_VehRegNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_ConNum = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_NIC = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_CustName = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtTotalCost = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_EndMile = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btn_Calc = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOnRent)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(549, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(158, 31);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(460, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search";
            // 
            // dataGridViewOnRent
            // 
            this.dataGridViewOnRent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOnRent.Location = new System.Drawing.Point(380, 90);
            this.dataGridViewOnRent.Name = "dataGridViewOnRent";
            this.dataGridViewOnRent.RowHeadersWidth = 51;
            this.dataGridViewOnRent.Size = new System.Drawing.Size(391, 417);
            this.dataGridViewOnRent.TabIndex = 2;
            this.dataGridViewOnRent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOnRent_CellClick);
            this.dataGridViewOnRent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOnRent_CellContentClick);
            this.dataGridViewOnRent.MouseEnter += new System.EventHandler(this.dataGridViewOnRent_MouseEnter);
            // 
            // btn_EndRent
            // 
            this.btn_EndRent.CheckedState.Parent = this.btn_EndRent;
            this.btn_EndRent.CustomImages.Parent = this.btn_EndRent;
            this.btn_EndRent.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_EndRent.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_EndRent.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_EndRent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_EndRent.DisabledState.Parent = this.btn_EndRent;
            this.btn_EndRent.Enabled = false;
            this.btn_EndRent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EndRent.ForeColor = System.Drawing.Color.White;
            this.btn_EndRent.HoverState.Parent = this.btn_EndRent;
            this.btn_EndRent.Location = new System.Drawing.Point(189, 479);
            this.btn_EndRent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_EndRent.Name = "btn_EndRent";
            this.btn_EndRent.ShadowDecoration.Parent = this.btn_EndRent;
            this.btn_EndRent.Size = new System.Drawing.Size(173, 37);
            this.btn_EndRent.TabIndex = 42;
            this.btn_EndRent.Text = "End Rent";
            this.btn_EndRent.Click += new System.EventHandler(this.btn_EndRent_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(123, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "Rent Details";
            // 
            // txt_orFP
            // 
            this.txt_orFP.Location = new System.Drawing.Point(145, 448);
            this.txt_orFP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_orFP.Name = "txt_orFP";
            this.txt_orFP.Size = new System.Drawing.Size(210, 20);
            this.txt_orFP.TabIndex = 48;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(6, 448);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 18);
            this.label13.TabIndex = 47;
            this.label13.Text = "Final Payment";
            // 
            // txt_Invoice
            // 
            this.txt_Invoice.Enabled = false;
            this.txt_Invoice.Location = new System.Drawing.Point(145, 50);
            this.txt_Invoice.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Invoice.Name = "txt_Invoice";
            this.txt_Invoice.Size = new System.Drawing.Size(210, 20);
            this.txt_Invoice.TabIndex = 70;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 51);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 18);
            this.label3.TabIndex = 69;
            this.label3.Text = "Invoice NO";
            // 
            // txt_Advance
            // 
            this.txt_Advance.Enabled = false;
            this.txt_Advance.Location = new System.Drawing.Point(146, 330);
            this.txt_Advance.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Advance.Name = "txt_Advance";
            this.txt_Advance.Size = new System.Drawing.Size(210, 20);
            this.txt_Advance.TabIndex = 68;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(7, 331);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(126, 18);
            this.label11.TabIndex = 67;
            this.label11.Text = "Advance Payment";
            // 
            // txt_StartMile
            // 
            this.txt_StartMile.Enabled = false;
            this.txt_StartMile.Location = new System.Drawing.Point(146, 358);
            this.txt_StartMile.Margin = new System.Windows.Forms.Padding(2);
            this.txt_StartMile.Name = "txt_StartMile";
            this.txt_StartMile.Size = new System.Drawing.Size(210, 20);
            this.txt_StartMile.TabIndex = 64;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(7, 359);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 18);
            this.label8.TabIndex = 63;
            this.label8.Text = "Start Mileage";
            // 
            // cmb_Driver
            // 
            this.cmb_Driver.Enabled = false;
            this.cmb_Driver.FormattingEnabled = true;
            this.cmb_Driver.Location = new System.Drawing.Point(147, 206);
            this.cmb_Driver.Name = "cmb_Driver";
            this.cmb_Driver.Size = new System.Drawing.Size(209, 21);
            this.cmb_Driver.TabIndex = 62;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 207);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 18);
            this.label4.TabIndex = 61;
            this.label4.Text = "Driver";
            // 
            // gunaEndDate
            // 
            this.gunaEndDate.CheckedState.Parent = this.gunaEndDate;
            this.gunaEndDate.Enabled = false;
            this.gunaEndDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.gunaEndDate.HoverState.Parent = this.gunaEndDate;
            this.gunaEndDate.Location = new System.Drawing.Point(146, 283);
            this.gunaEndDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.gunaEndDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.gunaEndDate.Name = "gunaEndDate";
            this.gunaEndDate.ShadowDecoration.Parent = this.gunaEndDate;
            this.gunaEndDate.Size = new System.Drawing.Size(210, 36);
            this.gunaEndDate.TabIndex = 60;
            this.gunaEndDate.Value = new System.DateTime(2021, 7, 18, 12, 4, 6, 420);
            // 
            // gunaStartDate
            // 
            this.gunaStartDate.CheckedState.Parent = this.gunaStartDate;
            this.gunaStartDate.Enabled = false;
            this.gunaStartDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.gunaStartDate.HoverState.Parent = this.gunaStartDate;
            this.gunaStartDate.Location = new System.Drawing.Point(146, 235);
            this.gunaStartDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.gunaStartDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.gunaStartDate.Name = "gunaStartDate";
            this.gunaStartDate.ShadowDecoration.Parent = this.gunaStartDate;
            this.gunaStartDate.Size = new System.Drawing.Size(211, 36);
            this.gunaStartDate.TabIndex = 59;
            this.gunaStartDate.Value = new System.DateTime(2021, 7, 18, 12, 4, 6, 420);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(7, 301);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 18);
            this.label10.TabIndex = 58;
            this.label10.Text = "End Date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(8, 248);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 18);
            this.label9.TabIndex = 57;
            this.label9.Text = "Start Date";
            // 
            // txt_VehRegNo
            // 
            this.txt_VehRegNo.Enabled = false;
            this.txt_VehRegNo.Location = new System.Drawing.Point(146, 175);
            this.txt_VehRegNo.Margin = new System.Windows.Forms.Padding(2);
            this.txt_VehRegNo.Name = "txt_VehRegNo";
            this.txt_VehRegNo.Size = new System.Drawing.Size(210, 20);
            this.txt_VehRegNo.TabIndex = 55;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 175);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 18);
            this.label7.TabIndex = 52;
            this.label7.Text = "Vehicle ID";
            // 
            // txt_ConNum
            // 
            this.txt_ConNum.Location = new System.Drawing.Point(146, 143);
            this.txt_ConNum.Margin = new System.Windows.Forms.Padding(2);
            this.txt_ConNum.Name = "txt_ConNum";
            this.txt_ConNum.Size = new System.Drawing.Size(210, 20);
            this.txt_ConNum.TabIndex = 54;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 144);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 18);
            this.label5.TabIndex = 51;
            this.label5.Text = "Contact Number";
            // 
            // txt_NIC
            // 
            this.txt_NIC.Location = new System.Drawing.Point(146, 113);
            this.txt_NIC.Margin = new System.Windows.Forms.Padding(2);
            this.txt_NIC.Name = "txt_NIC";
            this.txt_NIC.Size = new System.Drawing.Size(210, 20);
            this.txt_NIC.TabIndex = 53;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(7, 113);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 18);
            this.label12.TabIndex = 50;
            this.label12.Text = "NIC";
            // 
            // txt_CustName
            // 
            this.txt_CustName.Location = new System.Drawing.Point(146, 80);
            this.txt_CustName.Margin = new System.Windows.Forms.Padding(2);
            this.txt_CustName.Name = "txt_CustName";
            this.txt_CustName.Size = new System.Drawing.Size(210, 20);
            this.txt_CustName.TabIndex = 56;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(7, 81);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 18);
            this.label14.TabIndex = 49;
            this.label14.Text = "Name";
            // 
            // txtTotalCost
            // 
            this.txtTotalCost.Enabled = false;
            this.txtTotalCost.Location = new System.Drawing.Point(146, 417);
            this.txtTotalCost.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotalCost.Name = "txtTotalCost";
            this.txtTotalCost.Size = new System.Drawing.Size(210, 20);
            this.txtTotalCost.TabIndex = 72;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 418);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 18);
            this.label6.TabIndex = 71;
            this.label6.Text = "Total Cost";
            // 
            // txt_EndMile
            // 
            this.txt_EndMile.Location = new System.Drawing.Point(146, 386);
            this.txt_EndMile.Margin = new System.Windows.Forms.Padding(2);
            this.txt_EndMile.Name = "txt_EndMile";
            this.txt_EndMile.Size = new System.Drawing.Size(210, 20);
            this.txt_EndMile.TabIndex = 74;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(7, 387);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(89, 18);
            this.label15.TabIndex = 73;
            this.label15.Text = "End Mileage";
            // 
            // btn_Calc
            // 
            this.btn_Calc.CheckedState.Parent = this.btn_Calc;
            this.btn_Calc.CustomImages.Parent = this.btn_Calc;
            this.btn_Calc.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Calc.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Calc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Calc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Calc.DisabledState.Parent = this.btn_Calc;
            this.btn_Calc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Calc.ForeColor = System.Drawing.Color.White;
            this.btn_Calc.HoverState.Parent = this.btn_Calc;
            this.btn_Calc.Location = new System.Drawing.Point(12, 479);
            this.btn_Calc.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Calc.Name = "btn_Calc";
            this.btn_Calc.ShadowDecoration.Parent = this.btn_Calc;
            this.btn_Calc.Size = new System.Drawing.Size(173, 37);
            this.btn_Calc.TabIndex = 75;
            this.btn_Calc.Text = "Calculate";
            this.btn_Calc.Click += new System.EventHandler(this.btn_Calc_Click);
            // 
            // US_OnRent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_Calc);
            this.Controls.Add(this.txt_EndMile);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtTotalCost);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_Invoice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Advance);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_StartMile);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmb_Driver);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gunaEndDate);
            this.Controls.Add(this.gunaStartDate);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_VehRegNo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_ConNum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_NIC);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txt_CustName);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txt_orFP);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btn_EndRent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewOnRent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "US_OnRent";
            this.Size = new System.Drawing.Size(774, 540);
            this.Load += new System.EventHandler(this.US_OnRent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOnRent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewOnRent;
        private Guna.UI2.WinForms.Guna2Button btn_EndRent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_orFP;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_Invoice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Advance;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_StartMile;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmb_Driver;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2DateTimePicker gunaEndDate;
        private Guna.UI2.WinForms.Guna2DateTimePicker gunaStartDate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_VehRegNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_ConNum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_NIC;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_CustName;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtTotalCost;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_EndMile;
        private System.Windows.Forms.Label label15;
        private Guna.UI2.WinForms.Guna2Button btn_Calc;
    }
}
