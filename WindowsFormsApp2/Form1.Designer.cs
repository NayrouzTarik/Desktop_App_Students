namespace WindowsFormsApp2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.TextBox txtBranche;
        private System.Windows.Forms.Button btnAddData;
        private System.Windows.Forms.Button btnCheckConnection;
        private System.Windows.Forms.Button btnDeleteData;
        private System.Windows.Forms.Button btnUpdateData;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnCheckConnection = new System.Windows.Forms.Button();
            this.btnAddData = new System.Windows.Forms.Button();
            this.btnDeleteData = new System.Windows.Forms.Button();
            this.btnUpdateData = new System.Windows.Forms.Button();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.txtBranche = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 107);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(971, 460);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnCheckConnection
            // 
            this.btnCheckConnection.BackColor = System.Drawing.Color.LightBlue;
            this.btnCheckConnection.Location = new System.Drawing.Point(12, 12);
            this.btnCheckConnection.Name = "btnCheckConnection";
            this.btnCheckConnection.Size = new System.Drawing.Size(150, 40);
            this.btnCheckConnection.TabIndex = 1;
            this.btnCheckConnection.Text = "Check Connection";
            this.btnCheckConnection.Click += new System.EventHandler(this.btn_check_cnt);
            // 
            // btnAddData
            // 
            this.btnAddData.BackColor = System.Drawing.Color.LightGreen;
            this.btnAddData.Location = new System.Drawing.Point(170, 12);
            this.btnAddData.Name = "btnAddData";
            this.btnAddData.Size = new System.Drawing.Size(150, 40);
            this.btnAddData.TabIndex = 2;
            this.btnAddData.Text = "Add Data";
            this.btnAddData.Click += new System.EventHandler(this.btnAddData_Click);
            // 
            // btnDeleteData
            // 
            this.btnDeleteData.BackColor = System.Drawing.Color.Salmon;
            this.btnDeleteData.Location = new System.Drawing.Point(330, 12);
            this.btnDeleteData.Name = "btnDeleteData";
            this.btnDeleteData.Size = new System.Drawing.Size(150, 40);
            this.btnDeleteData.TabIndex = 3;
            this.btnDeleteData.Text = "Delete Data";
            this.btnDeleteData.Click += new System.EventHandler(this.btnDeleteData_Click);
            // 
            // btnUpdateData
            // 
            this.btnUpdateData.BackColor = System.Drawing.Color.Yellow;
            this.btnUpdateData.Location = new System.Drawing.Point(490, 12);
            this.btnUpdateData.Name = "btnUpdateData";
            this.btnUpdateData.Size = new System.Drawing.Size(190, 40);
            this.btnUpdateData.TabIndex = 3;
            this.btnUpdateData.Text = "Update Data";
            this.btnUpdateData.Click += new System.EventHandler(this.btnUpdateData_Click);
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(12, 60);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(100, 26);
            this.txtNom.TabIndex = 3;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(118, 60);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(100, 26);
            this.txtPrenom.TabIndex = 4;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(224, 60);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(100, 26);
            this.txtAge.TabIndex = 5;
            // 
            // txtGenre
            // 
            this.txtGenre.Location = new System.Drawing.Point(330, 60);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(100, 26);
            this.txtGenre.TabIndex = 6;
            // 
            // txtBranche
            // 
            this.txtBranche.Location = new System.Drawing.Point(436, 60);
            this.txtBranche.Name = "txtBranche";
            this.txtBranche.Size = new System.Drawing.Size(100, 26);
            this.txtBranche.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 600);
            this.Controls.Add(this.txtBranche);
            this.Controls.Add(this.txtGenre);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.btnAddData);
            this.Controls.Add(this.btnDeleteData);
            this.Controls.Add(this.btnUpdateData);
            this.Controls.Add(this.btnCheckConnection);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Data Management System";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}

