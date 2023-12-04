namespace _0001
{
    partial class frmBorrow
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
            this.btnHomeborrow = new System.Windows.Forms.Button();
            this.dt1 = new System.Windows.Forms.DataGridView();
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnDanhsachmuon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dt1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHomeborrow
            // 
            this.btnHomeborrow.Location = new System.Drawing.Point(674, 35);
            this.btnHomeborrow.Name = "btnHomeborrow";
            this.btnHomeborrow.Size = new System.Drawing.Size(75, 35);
            this.btnHomeborrow.TabIndex = 0;
            this.btnHomeborrow.Text = "Home";
            this.btnHomeborrow.UseVisualStyleBackColor = true;
            this.btnHomeborrow.Click += new System.EventHandler(this.btnHomeborrow_Click);
            // 
            // dt1
            // 
            this.dt1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt1.Location = new System.Drawing.Point(67, 151);
            this.dt1.Name = "dt1";
            this.dt1.RowHeadersWidth = 51;
            this.dt1.RowTemplate.Height = 24;
            this.dt1.Size = new System.Drawing.Size(682, 167);
            this.dt1.TabIndex = 1;
            this.dt1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(67, 91);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(111, 36);
            this.btnUpload.TabIndex = 2;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnDanhsachmuon
            // 
            this.btnDanhsachmuon.Location = new System.Drawing.Point(234, 91);
            this.btnDanhsachmuon.Name = "btnDanhsachmuon";
            this.btnDanhsachmuon.Size = new System.Drawing.Size(117, 36);
            this.btnDanhsachmuon.TabIndex = 3;
            this.btnDanhsachmuon.Text = "Borrowed List";
            this.btnDanhsachmuon.UseVisualStyleBackColor = true;
            this.btnDanhsachmuon.Click += new System.EventHandler(this.btnDanhsachmuon_Click);
            // 
            // frmBorrow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDanhsachmuon);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.dt1);
            this.Controls.Add(this.btnHomeborrow);
            this.Name = "frmBorrow";
            this.Text = "Borrow";
            this.Load += new System.EventHandler(this.frmBorrow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dt1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHomeborrow;
        private System.Windows.Forms.DataGridView dt1;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button btnDanhsachmuon;
    }
}