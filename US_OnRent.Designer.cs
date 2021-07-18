
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerNIC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleRegNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fromDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driverName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(122, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(154, 31);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rentId,
            this.customerNIC,
            this.vehicleRegNum,
            this.fromDate,
            this.toDate,
            this.driverName});
            this.dataGridView1.Location = new System.Drawing.Point(37, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(641, 417);
            this.dataGridView1.TabIndex = 2;
            // 
            // rentId
            // 
            this.rentId.HeaderText = "Rent ID";
            this.rentId.Name = "rentId";
            this.rentId.ReadOnly = true;
            // 
            // customerNIC
            // 
            this.customerNIC.HeaderText = "Cust NIC";
            this.customerNIC.Name = "customerNIC";
            // 
            // vehicleRegNum
            // 
            this.vehicleRegNum.HeaderText = "Vehicle Number";
            this.vehicleRegNum.Name = "vehicleRegNum";
            // 
            // fromDate
            // 
            this.fromDate.HeaderText = "From Date";
            this.fromDate.Name = "fromDate";
            // 
            // toDate
            // 
            this.toDate.HeaderText = "End Date";
            this.toDate.Name = "toDate";
            // 
            // driverName
            // 
            this.driverName.HeaderText = "Driver Name";
            this.driverName.Name = "driverName";
            // 
            // US_OnRent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "US_OnRent";
            this.Size = new System.Drawing.Size(774, 540);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNIC;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleRegNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn fromDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn toDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn driverName;
    }
}
