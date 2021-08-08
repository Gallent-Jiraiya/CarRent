
namespace CarRent
{
    partial class ListVehicle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListVehicle));
            this.panel2 = new System.Windows.Forms.Panel();
            this.Lbl_Year = new System.Windows.Forms.Label();
            this.Lbl_Milage = new System.Windows.Forms.Label();
            this.Btn_Edit = new Guna.UI2.WinForms.Guna2Button();
            this.Lbl_PerKM = new System.Windows.Forms.Label();
            this.Lbl_AC = new System.Windows.Forms.Label();
            this.Lbl_Transmission = new System.Windows.Forms.Label();
            this.Lbl_NoPassenger = new System.Windows.Forms.Label();
            this.Lbl_Luggages = new System.Windows.Forms.Label();
            this.Lbl_Price = new System.Windows.Forms.Label();
            this.Lbl_BrandName = new System.Windows.Forms.Label();
            this.PB_VehicleImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Lbl_RegNo = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_VehicleImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.Lbl_RegNo);
            this.panel2.Controls.Add(this.Lbl_Year);
            this.panel2.Controls.Add(this.Lbl_Milage);
            this.panel2.Controls.Add(this.Btn_Edit);
            this.panel2.Controls.Add(this.Lbl_PerKM);
            this.panel2.Controls.Add(this.Lbl_AC);
            this.panel2.Controls.Add(this.Lbl_Transmission);
            this.panel2.Controls.Add(this.Lbl_NoPassenger);
            this.panel2.Controls.Add(this.Lbl_Luggages);
            this.panel2.Controls.Add(this.Lbl_Price);
            this.panel2.Controls.Add(this.Lbl_BrandName);
            this.panel2.Controls.Add(this.PB_VehicleImage);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(425, 200);
            this.panel2.TabIndex = 1;
            // 
            // Lbl_Year
            // 
            this.Lbl_Year.AutoSize = true;
            this.Lbl_Year.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Year.Location = new System.Drawing.Point(174, 173);
            this.Lbl_Year.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Year.Name = "Lbl_Year";
            this.Lbl_Year.Size = new System.Drawing.Size(76, 15);
            this.Lbl_Year.TabIndex = 5;
            this.Lbl_Year.Text = "Model Year: ";
            // 
            // Lbl_Milage
            // 
            this.Lbl_Milage.AutoSize = true;
            this.Lbl_Milage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Milage.Location = new System.Drawing.Point(174, 153);
            this.Lbl_Milage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Milage.Name = "Lbl_Milage";
            this.Lbl_Milage.Size = new System.Drawing.Size(119, 15);
            this.Lbl_Milage.TabIndex = 4;
            this.Lbl_Milage.Text = "Free Milage: 100Km";
            // 
            // Btn_Edit
            // 
            this.Btn_Edit.CheckedState.Parent = this.Btn_Edit;
            this.Btn_Edit.CustomImages.Parent = this.Btn_Edit;
            this.Btn_Edit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_Edit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_Edit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_Edit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_Edit.DisabledState.Parent = this.Btn_Edit;
            this.Btn_Edit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(169)))), ((int)(((byte)(108)))));
            this.Btn_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Edit.ForeColor = System.Drawing.Color.White;
            this.Btn_Edit.HoverState.Parent = this.Btn_Edit;
            this.Btn_Edit.Location = new System.Drawing.Point(322, 72);
            this.Btn_Edit.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Edit.Name = "Btn_Edit";
            this.Btn_Edit.ShadowDecoration.Parent = this.Btn_Edit;
            this.Btn_Edit.Size = new System.Drawing.Size(86, 24);
            this.Btn_Edit.TabIndex = 3;
            this.Btn_Edit.Text = "Edit ";
            this.Btn_Edit.Click += new System.EventHandler(this.Btn_Edit_Click);
            // 
            // Lbl_PerKM
            // 
            this.Lbl_PerKM.AutoSize = true;
            this.Lbl_PerKM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_PerKM.Location = new System.Drawing.Point(175, 132);
            this.Lbl_PerKM.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_PerKM.Name = "Lbl_PerKM";
            this.Lbl_PerKM.Size = new System.Drawing.Size(123, 15);
            this.Lbl_PerKM.TabIndex = 2;
            this.Lbl_PerKM.Text = "25 LKR Per Extra Km";
            // 
            // Lbl_AC
            // 
            this.Lbl_AC.AutoSize = true;
            this.Lbl_AC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_AC.Location = new System.Drawing.Point(175, 112);
            this.Lbl_AC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_AC.Name = "Lbl_AC";
            this.Lbl_AC.Size = new System.Drawing.Size(91, 15);
            this.Lbl_AC.TabIndex = 2;
            this.Lbl_AC.Text = "Air conditioning";
            // 
            // Lbl_Transmission
            // 
            this.Lbl_Transmission.AutoSize = true;
            this.Lbl_Transmission.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Transmission.Location = new System.Drawing.Point(175, 75);
            this.Lbl_Transmission.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Transmission.Name = "Lbl_Transmission";
            this.Lbl_Transmission.Size = new System.Drawing.Size(122, 15);
            this.Lbl_Transmission.TabIndex = 2;
            this.Lbl_Transmission.Text = "Manual transmission";
            // 
            // Lbl_NoPassenger
            // 
            this.Lbl_NoPassenger.AutoSize = true;
            this.Lbl_NoPassenger.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_NoPassenger.Location = new System.Drawing.Point(175, 56);
            this.Lbl_NoPassenger.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_NoPassenger.Name = "Lbl_NoPassenger";
            this.Lbl_NoPassenger.Size = new System.Drawing.Size(82, 15);
            this.Lbl_NoPassenger.TabIndex = 2;
            this.Lbl_NoPassenger.Text = "3 Passengers";
            // 
            // Lbl_Luggages
            // 
            this.Lbl_Luggages.AutoSize = true;
            this.Lbl_Luggages.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Luggages.Location = new System.Drawing.Point(175, 94);
            this.Lbl_Luggages.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Luggages.Name = "Lbl_Luggages";
            this.Lbl_Luggages.Size = new System.Drawing.Size(72, 15);
            this.Lbl_Luggages.TabIndex = 2;
            this.Lbl_Luggages.Text = "2 Luggages";
            // 
            // Lbl_Price
            // 
            this.Lbl_Price.AutoSize = true;
            this.Lbl_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Price.Location = new System.Drawing.Point(332, 47);
            this.Lbl_Price.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Price.Name = "Lbl_Price";
            this.Lbl_Price.Size = new System.Drawing.Size(75, 17);
            this.Lbl_Price.TabIndex = 1;
            this.Lbl_Price.Text = "LKR 7,000";
            // 
            // Lbl_BrandName
            // 
            this.Lbl_BrandName.AutoSize = true;
            this.Lbl_BrandName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_BrandName.Location = new System.Drawing.Point(174, 13);
            this.Lbl_BrandName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_BrandName.Name = "Lbl_BrandName";
            this.Lbl_BrandName.Size = new System.Drawing.Size(135, 20);
            this.Lbl_BrandName.TabIndex = 1;
            this.Lbl_BrandName.Text = "Suzuki Alto 800";
            // 
            // PB_VehicleImage
            // 
            this.PB_VehicleImage.Dock = System.Windows.Forms.DockStyle.Left;
            this.PB_VehicleImage.FillColor = System.Drawing.Color.Transparent;
            this.PB_VehicleImage.Image = ((System.Drawing.Image)(resources.GetObject("PB_VehicleImage.Image")));
            this.PB_VehicleImage.ImageRotate = 0F;
            this.PB_VehicleImage.Location = new System.Drawing.Point(0, 0);
            this.PB_VehicleImage.Margin = new System.Windows.Forms.Padding(2);
            this.PB_VehicleImage.Name = "PB_VehicleImage";
            this.PB_VehicleImage.ShadowDecoration.Parent = this.PB_VehicleImage;
            this.PB_VehicleImage.Size = new System.Drawing.Size(140, 198);
            this.PB_VehicleImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB_VehicleImage.TabIndex = 0;
            this.PB_VehicleImage.TabStop = false;
            // 
            // Lbl_RegNo
            // 
            this.Lbl_RegNo.AutoSize = true;
            this.Lbl_RegNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_RegNo.Location = new System.Drawing.Point(175, 37);
            this.Lbl_RegNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_RegNo.Name = "Lbl_RegNo";
            this.Lbl_RegNo.Size = new System.Drawing.Size(82, 15);
            this.Lbl_RegNo.TabIndex = 6;
            this.Lbl_RegNo.Text = "3 Passengers";
            // 
            // ListVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Name = "ListVehicle";
            this.Size = new System.Drawing.Size(425, 200);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_VehicleImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button Btn_Edit;
        private System.Windows.Forms.Label Lbl_PerKM;
        private System.Windows.Forms.Label Lbl_AC;
        private System.Windows.Forms.Label Lbl_Transmission;
        private System.Windows.Forms.Label Lbl_NoPassenger;
        private System.Windows.Forms.Label Lbl_Luggages;
        private System.Windows.Forms.Label Lbl_Price;
        private System.Windows.Forms.Label Lbl_BrandName;
        private Guna.UI2.WinForms.Guna2PictureBox PB_VehicleImage;
        private System.Windows.Forms.Label Lbl_Milage;
        private System.Windows.Forms.Label Lbl_Year;
        private System.Windows.Forms.Label Lbl_RegNo;
    }
}
