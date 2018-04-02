namespace _QuanLyBanVeXe
{
    partial class FormTraCuuChuyenDi
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbMaTuyenDi = new System.Windows.Forms.ComboBox();
            this.dtpThoiGianDau = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpThoiGianCuoi = new System.Windows.Forms.DateTimePicker();
            this.gridView = new System.Windows.Forms.DataGridView();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(181, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "TRA CỨU CHUYẾN ĐI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Tuyến đi";
            // 
            // cbbMaTuyenDi
            // 
            this.cbbMaTuyenDi.FormattingEnabled = true;
            this.cbbMaTuyenDi.Location = new System.Drawing.Point(134, 55);
            this.cbbMaTuyenDi.Name = "cbbMaTuyenDi";
            this.cbbMaTuyenDi.Size = new System.Drawing.Size(121, 21);
            this.cbbMaTuyenDi.TabIndex = 2;
            // 
            // dtpThoiGianDau
            // 
            this.dtpThoiGianDau.Location = new System.Drawing.Point(158, 92);
            this.dtpThoiGianDau.Name = "dtpThoiGianDau";
            this.dtpThoiGianDau.Size = new System.Drawing.Size(121, 20);
            this.dtpThoiGianDau.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ngày khởi hành:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(132, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Từ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(296, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "đến";
            // 
            // dtpThoiGianCuoi
            // 
            this.dtpThoiGianCuoi.Location = new System.Drawing.Point(339, 92);
            this.dtpThoiGianCuoi.Name = "dtpThoiGianCuoi";
            this.dtpThoiGianCuoi.Size = new System.Drawing.Size(121, 20);
            this.dtpThoiGianCuoi.TabIndex = 7;
            // 
            // gridView
            // 
            this.gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridView.Location = new System.Drawing.Point(44, 133);
            this.gridView.Name = "gridView";
            this.gridView.Size = new System.Drawing.Size(465, 150);
            this.gridView.TabIndex = 8;
            this.gridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.gridView_CellFormatting);
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(339, 53);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 23);
            this.btnTim.TabIndex = 9;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(434, 295);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FormTraCuuChuyenDi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 330);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.gridView);
            this.Controls.Add(this.dtpThoiGianCuoi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpThoiGianDau);
            this.Controls.Add(this.cbbMaTuyenDi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormTraCuuChuyenDi";
            this.Text = "Tra cứu chuyến đi";
            this.Load += new System.EventHandler(this.FormTraCuuChuyenDi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbMaTuyenDi;
        private System.Windows.Forms.DateTimePicker dtpThoiGianDau;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpThoiGianCuoi;
        private System.Windows.Forms.DataGridView gridView;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnExit;
    }
}