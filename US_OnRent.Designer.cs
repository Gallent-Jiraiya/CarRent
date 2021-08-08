
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
            this.dtp_orEnd = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtp_orStart = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_orSM = new System.Windows.Forms.TextBox();
            this.txt_orVID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_orAdPay = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_orCNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_orNIC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_orName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_orEM = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_orTP = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_orFP = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOnRent)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(732, 41);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(209, 37);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(613, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search";
            // 
            // dataGridViewOnRent
            // 
            this.dataGridViewOnRent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOnRent.Location = new System.Drawing.Point(507, 111);
            this.dataGridViewOnRent.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewOnRent.Name = "dataGridViewOnRent";
            this.dataGridViewOnRent.RowHeadersWidth = 51;
            this.dataGridViewOnRent.Size = new System.Drawing.Size(521, 513);
            this.dataGridViewOnRent.TabIndex = 2;
            this.dataGridViewOnRent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOnRent_CellClick);
            this.dataGridViewOnRent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOnRent_CellContentClick);
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
            this.btn_EndRent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EndRent.ForeColor = System.Drawing.Color.White;
            this.btn_EndRent.HoverState.Parent = this.btn_EndRent;
            this.btn_EndRent.Location = new System.Drawing.Point(128, 590);
            this.btn_EndRent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_EndRent.Name = "btn_EndRent";
            this.btn_EndRent.ShadowDecoration.Parent = this.btn_EndRent;
            this.btn_EndRent.Size = new System.Drawing.Size(231, 46);
            this.btn_EndRent.TabIndex = 42;
            this.btn_EndRent.Text = "End Rent";
            this.btn_EndRent.Click += new System.EventHandler(this.btn_EndRent_Click);
            // 
            // dtp_orEnd
            // 
            this.dtp_orEnd.CheckedState.Parent = this.dtp_orEnd;
            this.dtp_orEnd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtp_orEnd.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtp_orEnd.HoverState.Parent = this.dtp_orEnd;
            this.dtp_orEnd.Location = new System.Drawing.Point(196, 430);
            this.dtp_orEnd.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_orEnd.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_orEnd.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp_orEnd.Name = "dtp_orEnd";
            this.dtp_orEnd.ShadowDecoration.Parent = this.dtp_orEnd;
            this.dtp_orEnd.Size = new System.Drawing.Size(267, 44);
            this.dtp_orEnd.TabIndex = 41;
            this.dtp_orEnd.Value = new System.DateTime(2021, 7, 18, 12, 4, 6, 420);
            // 
            // dtp_orStart
            // 
            this.dtp_orStart.CheckedState.Parent = this.dtp_orStart;
            this.dtp_orStart.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtp_orStart.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtp_orStart.HoverState.Parent = this.dtp_orStart;
            this.dtp_orStart.Location = new System.Drawing.Point(196, 370);
            this.dtp_orStart.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_orStart.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_orStart.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp_orStart.Name = "dtp_orStart";
            this.dtp_orStart.ShadowDecoration.Parent = this.dtp_orStart;
            this.dtp_orStart.Size = new System.Drawing.Size(267, 44);
            this.dtp_orStart.TabIndex = 40;
            this.dtp_orStart.Value = new System.DateTime(2021, 7, 18, 12, 4, 6, 420);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(9, 444);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 24);
            this.label10.TabIndex = 39;
            this.label10.Text = "End Date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(9, 386);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 24);
            this.label9.TabIndex = 38;
            this.label9.Text = "Start Date";
            // 
            // txt_orSM
            // 
            this.txt_orSM.Location = new System.Drawing.Point(196, 294);
            this.txt_orSM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_orSM.Name = "txt_orSM";
            this.txt_orSM.Size = new System.Drawing.Size(303, 22);
            this.txt_orSM.TabIndex = 33;
            // 
            // txt_orVID
            // 
            this.txt_orVID.Location = new System.Drawing.Point(196, 256);
            this.txt_orVID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_orVID.Name = "txt_orVID";
            this.txt_orVID.Size = new System.Drawing.Size(303, 22);
            this.txt_orVID.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 295);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 24);
            this.label8.TabIndex = 30;
            this.label8.Text = "Start Mileage";
            // 
            // txt_orAdPay
            // 
            this.txt_orAdPay.Location = new System.Drawing.Point(196, 214);
            this.txt_orAdPay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_orAdPay.Name = "txt_orAdPay";
            this.txt_orAdPay.Size = new System.Drawing.Size(303, 22);
            this.txt_orAdPay.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 24);
            this.label7.TabIndex = 25;
            this.label7.Text = "Vehicle ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 24);
            this.label6.TabIndex = 28;
            this.label6.Text = "Advanced Payment";
            // 
            // txt_orCNo
            // 
            this.txt_orCNo.Location = new System.Drawing.Point(196, 176);
            this.txt_orCNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_orCNo.Name = "txt_orCNo";
            this.txt_orCNo.Size = new System.Drawing.Size(303, 22);
            this.txt_orCNo.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 24);
            this.label5.TabIndex = 27;
            this.label5.Text = "Contact Number";
            // 
            // txt_orNIC
            // 
            this.txt_orNIC.Location = new System.Drawing.Point(196, 139);
            this.txt_orNIC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_orNIC.Name = "txt_orNIC";
            this.txt_orNIC.Size = new System.Drawing.Size(303, 22);
            this.txt_orNIC.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 24);
            this.label4.TabIndex = 26;
            this.label4.Text = "NIC";
            // 
            // txt_orName
            // 
            this.txt_orName.Location = new System.Drawing.Point(196, 98);
            this.txt_orName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_orName.Name = "txt_orName";
            this.txt_orName.Size = new System.Drawing.Size(303, 22);
            this.txt_orName.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 24);
            this.label3.TabIndex = 29;
            this.label3.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(144, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 25);
            this.label2.TabIndex = 31;
            this.label2.Text = "Rent Details";
            // 
            // txt_orEM
            // 
            this.txt_orEM.Location = new System.Drawing.Point(196, 332);
            this.txt_orEM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_orEM.Name = "txt_orEM";
            this.txt_orEM.Size = new System.Drawing.Size(303, 22);
            this.txt_orEM.TabIndex = 44;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(8, 334);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 24);
            this.label11.TabIndex = 43;
            this.label11.Text = "End Mileage";
            // 
            // txt_orTP
            // 
            this.txt_orTP.Enabled = false;
            this.txt_orTP.Location = new System.Drawing.Point(196, 492);
            this.txt_orTP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_orTP.Name = "txt_orTP";
            this.txt_orTP.Size = new System.Drawing.Size(303, 22);
            this.txt_orTP.TabIndex = 46;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(8, 494);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 24);
            this.label12.TabIndex = 45;
            this.label12.Text = "Total Price";
            // 
            // txt_orFP
            // 
            this.txt_orFP.Location = new System.Drawing.Point(196, 533);
            this.txt_orFP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_orFP.Name = "txt_orFP";
            this.txt_orFP.Size = new System.Drawing.Size(303, 22);
            this.txt_orFP.TabIndex = 48;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(8, 534);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(129, 24);
            this.label13.TabIndex = 47;
            this.label13.Text = "Final Payment";
            // 
            // US_OnRent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txt_orFP);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txt_orTP);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txt_orEM);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btn_EndRent);
            this.Controls.Add(this.dtp_orEnd);
            this.Controls.Add(this.dtp_orStart);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_orSM);
            this.Controls.Add(this.txt_orVID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_orAdPay);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_orCNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_orNIC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_orName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewOnRent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "US_OnRent";
            this.Size = new System.Drawing.Size(1032, 665);
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
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp_orEnd;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp_orStart;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_orSM;
        private System.Windows.Forms.TextBox txt_orVID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_orAdPay;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_orCNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_orNIC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_orName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_orEM;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_orTP;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_orFP;
        private System.Windows.Forms.Label label13;
    }
}
