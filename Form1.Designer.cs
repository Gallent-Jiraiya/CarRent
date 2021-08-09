
namespace CarRent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.usersButton = new System.Windows.Forms.RadioButton();
            this.vehiclesButton = new System.Windows.Forms.RadioButton();
            this.reservedButton = new System.Windows.Forms.RadioButton();
            this.onrentButton = new System.Windows.Forms.RadioButton();
            this.searchButton = new System.Windows.Forms.RadioButton();
            this.dashboardButton = new System.Windows.Forms.RadioButton();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.lbl_UserName = new System.Windows.Forms.Label();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.roundPictureBox1 = new CarRent.RoundPictureBox();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roundPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.button2);
            this.guna2Panel1.Controls.Add(this.button1);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel1.FillColor = System.Drawing.Color.DarkRed;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(1024, 100);
            this.guna2Panel1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(964, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(30, 30);
            this.button2.TabIndex = 3;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(994, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(279, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(537, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enjoy the efficient and specialized services of Carsons Rent a Car";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.BackgroundImage")));
            this.guna2PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(46, 13);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(200, 73);
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.usersButton);
            this.guna2Panel2.Controls.Add(this.vehiclesButton);
            this.guna2Panel2.Controls.Add(this.reservedButton);
            this.guna2Panel2.Controls.Add(this.onrentButton);
            this.guna2Panel2.Controls.Add(this.searchButton);
            this.guna2Panel2.Controls.Add(this.dashboardButton);
            this.guna2Panel2.Controls.Add(this.guna2Panel3);
            this.guna2Panel2.Location = new System.Drawing.Point(0, 100);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(250, 540);
            this.guna2Panel2.TabIndex = 2;
            // 
            // usersButton
            // 
            this.usersButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.usersButton.FlatAppearance.BorderSize = 0;
            this.usersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.usersButton.Location = new System.Drawing.Point(0, 467);
            this.usersButton.Margin = new System.Windows.Forms.Padding(0);
            this.usersButton.Name = "usersButton";
            this.usersButton.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.usersButton.Size = new System.Drawing.Size(250, 60);
            this.usersButton.TabIndex = 6;
            this.usersButton.TabStop = true;
            this.usersButton.Text = "Users";
            this.usersButton.UseVisualStyleBackColor = true;
            this.usersButton.CheckedChanged += new System.EventHandler(this.usersButton_CheckedChanged);
            this.usersButton.Click += new System.EventHandler(this.usersButton_Click);
            // 
            // vehiclesButton
            // 
            this.vehiclesButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.vehiclesButton.FlatAppearance.BorderSize = 0;
            this.vehiclesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vehiclesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehiclesButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.vehiclesButton.Location = new System.Drawing.Point(0, 407);
            this.vehiclesButton.Margin = new System.Windows.Forms.Padding(0);
            this.vehiclesButton.Name = "vehiclesButton";
            this.vehiclesButton.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.vehiclesButton.Size = new System.Drawing.Size(250, 60);
            this.vehiclesButton.TabIndex = 5;
            this.vehiclesButton.TabStop = true;
            this.vehiclesButton.Text = "Vehicles";
            this.vehiclesButton.UseVisualStyleBackColor = true;
            this.vehiclesButton.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            this.vehiclesButton.Click += new System.EventHandler(this.vehiclesButton_Click);
            // 
            // reservedButton
            // 
            this.reservedButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.reservedButton.FlatAppearance.BorderSize = 0;
            this.reservedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reservedButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservedButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reservedButton.Location = new System.Drawing.Point(0, 347);
            this.reservedButton.Margin = new System.Windows.Forms.Padding(0);
            this.reservedButton.Name = "reservedButton";
            this.reservedButton.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.reservedButton.Size = new System.Drawing.Size(250, 60);
            this.reservedButton.TabIndex = 4;
            this.reservedButton.TabStop = true;
            this.reservedButton.Text = "Reserved";
            this.reservedButton.UseVisualStyleBackColor = true;
            this.reservedButton.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            this.reservedButton.Click += new System.EventHandler(this.reservedButton_Click);
            // 
            // onrentButton
            // 
            this.onrentButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.onrentButton.FlatAppearance.BorderSize = 0;
            this.onrentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.onrentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onrentButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.onrentButton.Location = new System.Drawing.Point(0, 287);
            this.onrentButton.Margin = new System.Windows.Forms.Padding(0);
            this.onrentButton.Name = "onrentButton";
            this.onrentButton.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.onrentButton.Size = new System.Drawing.Size(250, 60);
            this.onrentButton.TabIndex = 3;
            this.onrentButton.TabStop = true;
            this.onrentButton.Text = "OnRent";
            this.onrentButton.UseVisualStyleBackColor = true;
            this.onrentButton.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            this.onrentButton.Click += new System.EventHandler(this.onrentButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.searchButton.FlatAppearance.BorderSize = 0;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchButton.Location = new System.Drawing.Point(0, 227);
            this.searchButton.Margin = new System.Windows.Forms.Padding(0);
            this.searchButton.Name = "searchButton";
            this.searchButton.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.searchButton.Size = new System.Drawing.Size(250, 60);
            this.searchButton.TabIndex = 2;
            this.searchButton.TabStop = true;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // dashboardButton
            // 
            this.dashboardButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.dashboardButton.BackColor = System.Drawing.Color.Transparent;
            this.dashboardButton.FlatAppearance.BorderSize = 0;
            this.dashboardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboardButton.Location = new System.Drawing.Point(0, 167);
            this.dashboardButton.Margin = new System.Windows.Forms.Padding(0);
            this.dashboardButton.Name = "dashboardButton";
            this.dashboardButton.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.dashboardButton.Size = new System.Drawing.Size(250, 60);
            this.dashboardButton.TabIndex = 1;
            this.dashboardButton.TabStop = true;
            this.dashboardButton.Text = "DashBoard";
            this.dashboardButton.UseVisualStyleBackColor = false;
            this.dashboardButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            this.dashboardButton.Click += new System.EventHandler(this.radioButton1_Click);
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("guna2Panel3.BackgroundImage")));
            this.guna2Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2Panel3.Controls.Add(this.roundPictureBox1);
            this.guna2Panel3.Controls.Add(this.lbl_UserName);
            this.guna2Panel3.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.ShadowDecoration.Parent = this.guna2Panel3;
            this.guna2Panel3.Size = new System.Drawing.Size(250, 168);
            this.guna2Panel3.TabIndex = 0;
            this.guna2Panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel3_Paint);
            // 
            // lbl_UserName
            // 
            this.lbl_UserName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_UserName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UserName.ForeColor = System.Drawing.Color.White;
            this.lbl_UserName.Location = new System.Drawing.Point(12, 118);
            this.lbl_UserName.Name = "lbl_UserName";
            this.lbl_UserName.Size = new System.Drawing.Size(232, 20);
            this.lbl_UserName.TabIndex = 1;
            this.lbl_UserName.Text = "John Doe";
            this.lbl_UserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_UserName.Click += new System.EventHandler(this.label2_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.Location = new System.Drawing.Point(250, 100);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(774, 540);
            this.panelContainer.TabIndex = 3;
            // 
            // roundPictureBox1
            // 
            this.roundPictureBox1.Location = new System.Drawing.Point(74, 15);
            this.roundPictureBox1.Name = "roundPictureBox1";
            this.roundPictureBox1.Size = new System.Drawing.Size(100, 100);
            this.roundPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.roundPictureBox1.TabIndex = 2;
            this.roundPictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 640);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.roundPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private System.Windows.Forms.Label lbl_UserName;
        private System.Windows.Forms.RadioButton dashboardButton;
        private System.Windows.Forms.RadioButton searchButton;
        private System.Windows.Forms.RadioButton usersButton;
        private System.Windows.Forms.RadioButton vehiclesButton;
        private System.Windows.Forms.RadioButton reservedButton;
        private System.Windows.Forms.RadioButton onrentButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelContainer;
        private RoundPictureBox roundPictureBox1;
    }
}

