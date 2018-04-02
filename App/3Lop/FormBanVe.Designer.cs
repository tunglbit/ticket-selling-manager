namespace _QuanLyBanVeXe
{
    partial class FormBanVe
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
            this.cbbMaChuyenDi = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtGiaTien = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtMaVeXe = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbbMaHanhKhach = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSoGheTrong = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(232, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "VÉ XE";
            // 
            // cbbMaChuyenDi
            // 
            this.cbbMaChuyenDi.FormattingEnabled = true;
            this.cbbMaChuyenDi.Location = new System.Drawing.Point(134, 50);
            this.cbbMaChuyenDi.Name = "cbbMaChuyenDi";
            this.cbbMaChuyenDi.Size = new System.Drawing.Size(100, 21);
            this.cbbMaChuyenDi.TabIndex = 1;
            this.cbbMaChuyenDi.SelectedIndexChanged += new System.EventHandler(this.cbbMaChuyenDi_SelectedIndexChanged);
            this.cbbMaChuyenDi.TextChanged += new System.EventHandler(this.cbbMaChuyenDi_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã chuyến đi";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Mã hành khách";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(35, 135);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Giá tiền";
            // 
            // txtGiaTien
            // 
            this.txtGiaTien.Location = new System.Drawing.Point(134, 132);
            this.txtGiaTien.Name = "txtGiaTien";
            this.txtGiaTien.Size = new System.Drawing.Size(100, 20);
            this.txtGiaTien.TabIndex = 20;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(103, 175);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 21;
            this.btnAdd.Text = "Lưu";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.Location = new System.Drawing.Point(214, 175);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(75, 23);
            this.btnClearAll.TabIndex = 22;
            this.btnClearAll.Text = "Tạo mới";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(326, 175);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 23;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtMaVeXe
            // 
            this.txtMaVeXe.Location = new System.Drawing.Point(383, 51);
            this.txtMaVeXe.Name = "txtMaVeXe";
            this.txtMaVeXe.Size = new System.Drawing.Size(100, 20);
            this.txtMaVeXe.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(303, 53);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Mã vé xe";
            // 
            // cbbMaHanhKhach
            // 
            this.cbbMaHanhKhach.FormattingEnabled = true;
            this.cbbMaHanhKhach.Location = new System.Drawing.Point(135, 77);
            this.cbbMaHanhKhach.Name = "cbbMaHanhKhach";
            this.cbbMaHanhKhach.Size = new System.Drawing.Size(99, 21);
            this.cbbMaHanhKhach.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(303, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Số ghế trống:";
            // 
            // lblSoGheTrong
            // 
            this.lblSoGheTrong.AutoSize = true;
            this.lblSoGheTrong.Location = new System.Drawing.Point(380, 85);
            this.lblSoGheTrong.Name = "lblSoGheTrong";
            this.lblSoGheTrong.Size = new System.Drawing.Size(13, 13);
            this.lblSoGheTrong.TabIndex = 29;
            this.lblSoGheTrong.Text = "0";
            // 
            // FormBanVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 213);
            this.Controls.Add(this.lblSoGheTrong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbbMaHanhKhach);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtMaVeXe);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtGiaTien);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbbMaChuyenDi);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "FormBanVe";
            this.Text = "FormBanVe";
            this.Load += new System.EventHandler(this.FormBanVe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbMaChuyenDi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtGiaTien;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtMaVeXe;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbbMaHanhKhach;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSoGheTrong;
    }
}