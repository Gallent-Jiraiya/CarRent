
namespace CarRent
{
    partial class EndRentInvoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EndRentInvoice));
            this.printDocument2 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog2 = new System.Windows.Forms.PrintPreviewDialog();
            this.lbl_ED = new System.Windows.Forms.Label();
            this.lbl_SD = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbl_SM = new System.Windows.Forms.Label();
            this.lbl_erName = new System.Windows.Forms.Label();
            this.lbl_VID = new System.Windows.Forms.Label();
            this.lbl_erNIC = new System.Windows.Forms.Label();
            this.lbl_CNo = new System.Windows.Forms.Label();
            this.lbl_erCNo = new System.Windows.Forms.Label();
            this.lbl_NIC = new System.Windows.Forms.Label();
            this.lbl_erAPay = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_erVID = new System.Windows.Forms.Label();
            this.lbl_APay = new System.Windows.Forms.Label();
            this.lbl_erSM = new System.Windows.Forms.Label();
            this.lbl_erSD = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lbl_erED = new System.Windows.Forms.Label();
            this.lbl_TPay = new System.Windows.Forms.Label();
            this.lbl_FPay = new System.Windows.Forms.Label();
            this.lbl_erTPay = new System.Windows.Forms.Label();
            this.lbl_erFPay = new System.Windows.Forms.Label();
            this.lbl_EM = new System.Windows.Forms.Label();
            this.lbl_erEM = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelEndRent = new System.Windows.Forms.Panel();
            this.btn_finalConfirm = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.panelEndRent.SuspendLayout();
            this.SuspendLayout();
            // 
            // printDocument2
            // 
            this.printDocument2.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument2_PrintPage);
            // 
            // printPreviewDialog2
            // 
            this.printPreviewDialog2.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog2.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog2.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog2.Enabled = true;
            this.printPreviewDialog2.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog2.Icon")));
            this.printPreviewDialog2.Name = "printPreviewDialog2";
            this.printPreviewDialog2.Visible = false;
            // 
            // lbl_ED
            // 
            this.lbl_ED.AutoSize = true;
            this.lbl_ED.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ED.Location = new System.Drawing.Point(115, 471);
            this.lbl_ED.Name = "lbl_ED";
            this.lbl_ED.Size = new System.Drawing.Size(88, 24);
            this.lbl_ED.TabIndex = 65;
            this.lbl_ED.Text = "End Date";
            // 
            // lbl_SD
            // 
            this.lbl_SD.AutoSize = true;
            this.lbl_SD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SD.Location = new System.Drawing.Point(115, 435);
            this.lbl_SD.Name = "lbl_SD";
            this.lbl_SD.Size = new System.Drawing.Size(89, 24);
            this.lbl_SD.TabIndex = 64;
            this.lbl_SD.Text = "Start Date";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(270, 116);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(110, 29);
            this.label12.TabIndex = 66;
            this.label12.Text = "INVOICE";
            // 
            // lbl_SM
            // 
            this.lbl_SM.AutoSize = true;
            this.lbl_SM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SM.Location = new System.Drawing.Point(114, 363);
            this.lbl_SM.Name = "lbl_SM";
            this.lbl_SM.Size = new System.Drawing.Size(144, 24);
            this.lbl_SM.TabIndex = 63;
            this.lbl_SM.Text = "Starting Mileage";
            // 
            // lbl_erName
            // 
            this.lbl_erName.AutoSize = true;
            this.lbl_erName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_erName.Location = new System.Drawing.Point(348, 183);
            this.lbl_erName.Name = "lbl_erName";
            this.lbl_erName.Size = new System.Drawing.Size(20, 24);
            this.lbl_erName.TabIndex = 71;
            this.lbl_erName.Text = "?";
            // 
            // lbl_VID
            // 
            this.lbl_VID.AutoSize = true;
            this.lbl_VID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_VID.Location = new System.Drawing.Point(114, 327);
            this.lbl_VID.Name = "lbl_VID";
            this.lbl_VID.Size = new System.Drawing.Size(96, 24);
            this.lbl_VID.TabIndex = 58;
            this.lbl_VID.Text = "Vehicle ID";
            // 
            // lbl_erNIC
            // 
            this.lbl_erNIC.AutoSize = true;
            this.lbl_erNIC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_erNIC.Location = new System.Drawing.Point(348, 219);
            this.lbl_erNIC.Name = "lbl_erNIC";
            this.lbl_erNIC.Size = new System.Drawing.Size(20, 24);
            this.lbl_erNIC.TabIndex = 68;
            this.lbl_erNIC.Text = "?";
            // 
            // lbl_CNo
            // 
            this.lbl_CNo.AutoSize = true;
            this.lbl_CNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CNo.Location = new System.Drawing.Point(114, 255);
            this.lbl_CNo.Name = "lbl_CNo";
            this.lbl_CNo.Size = new System.Drawing.Size(147, 24);
            this.lbl_CNo.TabIndex = 60;
            this.lbl_CNo.Text = "Contact Number";
            // 
            // lbl_erCNo
            // 
            this.lbl_erCNo.AutoSize = true;
            this.lbl_erCNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_erCNo.Location = new System.Drawing.Point(348, 255);
            this.lbl_erCNo.Name = "lbl_erCNo";
            this.lbl_erCNo.Size = new System.Drawing.Size(20, 24);
            this.lbl_erCNo.TabIndex = 69;
            this.lbl_erCNo.Text = "?";
            // 
            // lbl_NIC
            // 
            this.lbl_NIC.AutoSize = true;
            this.lbl_NIC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NIC.Location = new System.Drawing.Point(114, 219);
            this.lbl_NIC.Name = "lbl_NIC";
            this.lbl_NIC.Size = new System.Drawing.Size(41, 24);
            this.lbl_NIC.TabIndex = 59;
            this.lbl_NIC.Text = "NIC";
            // 
            // lbl_erAPay
            // 
            this.lbl_erAPay.AutoSize = true;
            this.lbl_erAPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_erAPay.Location = new System.Drawing.Point(348, 291);
            this.lbl_erAPay.Name = "lbl_erAPay";
            this.lbl_erAPay.Size = new System.Drawing.Size(20, 24);
            this.lbl_erAPay.TabIndex = 70;
            this.lbl_erAPay.Text = "?";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(114, 183);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(61, 24);
            this.lbl_Name.TabIndex = 62;
            this.lbl_Name.Text = "Name";
            // 
            // lbl_erVID
            // 
            this.lbl_erVID.AutoSize = true;
            this.lbl_erVID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_erVID.Location = new System.Drawing.Point(348, 327);
            this.lbl_erVID.Name = "lbl_erVID";
            this.lbl_erVID.Size = new System.Drawing.Size(20, 24);
            this.lbl_erVID.TabIndex = 67;
            this.lbl_erVID.Text = "?";
            // 
            // lbl_APay
            // 
            this.lbl_APay.AutoSize = true;
            this.lbl_APay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_APay.Location = new System.Drawing.Point(114, 291);
            this.lbl_APay.Name = "lbl_APay";
            this.lbl_APay.Size = new System.Drawing.Size(174, 24);
            this.lbl_APay.TabIndex = 61;
            this.lbl_APay.Text = "Advanced Payment";
            // 
            // lbl_erSM
            // 
            this.lbl_erSM.AutoSize = true;
            this.lbl_erSM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_erSM.Location = new System.Drawing.Point(348, 363);
            this.lbl_erSM.Name = "lbl_erSM";
            this.lbl_erSM.Size = new System.Drawing.Size(20, 24);
            this.lbl_erSM.TabIndex = 72;
            this.lbl_erSM.Text = "?";
            // 
            // lbl_erSD
            // 
            this.lbl_erSD.AutoSize = true;
            this.lbl_erSD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_erSD.Location = new System.Drawing.Point(349, 435);
            this.lbl_erSD.Name = "lbl_erSD";
            this.lbl_erSD.Size = new System.Drawing.Size(20, 24);
            this.lbl_erSD.TabIndex = 73;
            this.lbl_erSD.Text = "?";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.FillColor = System.Drawing.Color.DarkRed;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(679, 100);
            this.guna2Panel1.TabIndex = 61;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(505, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "037 2247423";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(505, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kurunegala.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(505, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "No. 52, Puttalam Rd, ";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.BackgroundImage = global::CarRent.Properties.Resources.Carsons_Logo_white;
            this.guna2PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.guna2PictureBox1.Image = global::CarRent.Properties.Resources.Carsons_Logo_white;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(36, 13);
            this.guna2PictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(146, 72);
            this.guna2PictureBox1.TabIndex = 1;
            this.guna2PictureBox1.TabStop = false;
            // 
            // lbl_erED
            // 
            this.lbl_erED.AutoSize = true;
            this.lbl_erED.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_erED.Location = new System.Drawing.Point(349, 471);
            this.lbl_erED.Name = "lbl_erED";
            this.lbl_erED.Size = new System.Drawing.Size(20, 24);
            this.lbl_erED.TabIndex = 74;
            this.lbl_erED.Text = "?";
            // 
            // lbl_TPay
            // 
            this.lbl_TPay.AutoSize = true;
            this.lbl_TPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TPay.Location = new System.Drawing.Point(114, 507);
            this.lbl_TPay.Name = "lbl_TPay";
            this.lbl_TPay.Size = new System.Drawing.Size(99, 24);
            this.lbl_TPay.TabIndex = 75;
            this.lbl_TPay.Text = "Total Price";
            // 
            // lbl_FPay
            // 
            this.lbl_FPay.AutoSize = true;
            this.lbl_FPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FPay.Location = new System.Drawing.Point(114, 543);
            this.lbl_FPay.Name = "lbl_FPay";
            this.lbl_FPay.Size = new System.Drawing.Size(129, 24);
            this.lbl_FPay.TabIndex = 76;
            this.lbl_FPay.Text = "Final Payment";
            // 
            // lbl_erTPay
            // 
            this.lbl_erTPay.AutoSize = true;
            this.lbl_erTPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_erTPay.Location = new System.Drawing.Point(348, 507);
            this.lbl_erTPay.Name = "lbl_erTPay";
            this.lbl_erTPay.Size = new System.Drawing.Size(20, 24);
            this.lbl_erTPay.TabIndex = 77;
            this.lbl_erTPay.Text = "?";
            // 
            // lbl_erFPay
            // 
            this.lbl_erFPay.AutoSize = true;
            this.lbl_erFPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_erFPay.Location = new System.Drawing.Point(348, 543);
            this.lbl_erFPay.Name = "lbl_erFPay";
            this.lbl_erFPay.Size = new System.Drawing.Size(20, 24);
            this.lbl_erFPay.TabIndex = 78;
            this.lbl_erFPay.Text = "?";
            // 
            // lbl_EM
            // 
            this.lbl_EM.AutoSize = true;
            this.lbl_EM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EM.Location = new System.Drawing.Point(114, 399);
            this.lbl_EM.Name = "lbl_EM";
            this.lbl_EM.Size = new System.Drawing.Size(117, 24);
            this.lbl_EM.TabIndex = 79;
            this.lbl_EM.Text = "End Mileage";
            // 
            // lbl_erEM
            // 
            this.lbl_erEM.AutoSize = true;
            this.lbl_erEM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_erEM.Location = new System.Drawing.Point(348, 399);
            this.lbl_erEM.Name = "lbl_erEM";
            this.lbl_erEM.Size = new System.Drawing.Size(20, 24);
            this.lbl_erEM.TabIndex = 80;
            this.lbl_erEM.Text = "?";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(0, 611);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(679, 100);
            this.panel2.TabIndex = 60;
            // 
            // panelEndRent
            // 
            this.panelEndRent.BackColor = System.Drawing.Color.White;
            this.panelEndRent.Controls.Add(this.panel2);
            this.panelEndRent.Controls.Add(this.lbl_erEM);
            this.panelEndRent.Controls.Add(this.lbl_EM);
            this.panelEndRent.Controls.Add(this.lbl_erFPay);
            this.panelEndRent.Controls.Add(this.lbl_erTPay);
            this.panelEndRent.Controls.Add(this.lbl_FPay);
            this.panelEndRent.Controls.Add(this.lbl_TPay);
            this.panelEndRent.Controls.Add(this.lbl_erED);
            this.panelEndRent.Controls.Add(this.guna2Panel1);
            this.panelEndRent.Controls.Add(this.lbl_erSD);
            this.panelEndRent.Controls.Add(this.lbl_erSM);
            this.panelEndRent.Controls.Add(this.lbl_APay);
            this.panelEndRent.Controls.Add(this.lbl_erVID);
            this.panelEndRent.Controls.Add(this.lbl_Name);
            this.panelEndRent.Controls.Add(this.lbl_erAPay);
            this.panelEndRent.Controls.Add(this.lbl_NIC);
            this.panelEndRent.Controls.Add(this.lbl_erCNo);
            this.panelEndRent.Controls.Add(this.lbl_CNo);
            this.panelEndRent.Controls.Add(this.lbl_erNIC);
            this.panelEndRent.Controls.Add(this.lbl_VID);
            this.panelEndRent.Controls.Add(this.lbl_erName);
            this.panelEndRent.Controls.Add(this.lbl_SM);
            this.panelEndRent.Controls.Add(this.label12);
            this.panelEndRent.Controls.Add(this.lbl_SD);
            this.panelEndRent.Controls.Add(this.lbl_ED);
            this.panelEndRent.Location = new System.Drawing.Point(0, 1);
            this.panelEndRent.Name = "panelEndRent";
            this.panelEndRent.Size = new System.Drawing.Size(679, 682);
            this.panelEndRent.TabIndex = 0;
            // 
            // btn_finalConfirm
            // 
            this.btn_finalConfirm.CheckedState.Parent = this.btn_finalConfirm;
            this.btn_finalConfirm.CustomImages.Parent = this.btn_finalConfirm;
            this.btn_finalConfirm.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_finalConfirm.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_finalConfirm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_finalConfirm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_finalConfirm.DisabledState.Parent = this.btn_finalConfirm;
            this.btn_finalConfirm.FillColor = System.Drawing.Color.DarkRed;
            this.btn_finalConfirm.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_finalConfirm.ForeColor = System.Drawing.Color.White;
            this.btn_finalConfirm.HoverState.Parent = this.btn_finalConfirm;
            this.btn_finalConfirm.Location = new System.Drawing.Point(217, 640);
            this.btn_finalConfirm.Name = "btn_finalConfirm";
            this.btn_finalConfirm.ShadowDecoration.Parent = this.btn_finalConfirm;
            this.btn_finalConfirm.Size = new System.Drawing.Size(203, 45);
            this.btn_finalConfirm.TabIndex = 60;
            this.btn_finalConfirm.Text = "Confirm and Print Invoice";
            this.btn_finalConfirm.Click += new System.EventHandler(this.btn_finalConfirm_Click);
            // 
            // EndRentInvoice
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(679, 712);
            this.Controls.Add(this.btn_finalConfirm);
            this.Controls.Add(this.panelEndRent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EndRentInvoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EndRentInvoice";
            this.Load += new System.EventHandler(this.EndRentInvoice_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.panelEndRent.ResumeLayout(false);
            this.panelEndRent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Drawing.Printing.PrintDocument printDocument2;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog2;
        private System.Windows.Forms.Label lbl_ED;
        private System.Windows.Forms.Label lbl_SD;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbl_SM;
        private System.Windows.Forms.Label lbl_erName;
        private System.Windows.Forms.Label lbl_VID;
        private System.Windows.Forms.Label lbl_erNIC;
        private System.Windows.Forms.Label lbl_CNo;
        private System.Windows.Forms.Label lbl_erCNo;
        private System.Windows.Forms.Label lbl_NIC;
        private System.Windows.Forms.Label lbl_erAPay;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_erVID;
        private System.Windows.Forms.Label lbl_APay;
        private System.Windows.Forms.Label lbl_erSM;
        private System.Windows.Forms.Label lbl_erSD;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label lbl_erED;
        private System.Windows.Forms.Label lbl_TPay;
        private System.Windows.Forms.Label lbl_FPay;
        private System.Windows.Forms.Label lbl_erTPay;
        private System.Windows.Forms.Label lbl_erFPay;
        private System.Windows.Forms.Label lbl_EM;
        private System.Windows.Forms.Label lbl_erEM;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelEndRent;
        private Guna.UI2.WinForms.Guna2Button btn_finalConfirm;
    }
}