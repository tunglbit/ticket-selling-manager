namespace _QuanLyBanVeXe
{
    partial class FormQuyDinhHanDatVe
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
            this.label5 = new System.Windows.Forms.Label();
            this.txtThoiGianDatVeChamNhat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtThoiGianHuyDatVeChamNhat = new System.Windows.Forms.TextBox();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(69, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(190, 18);
            this.label5.TabIndex = 22;
            this.label5.Text = "QUY ĐỊNH HẠN ĐẶT VÉ";
            // 
            // txtThoiGianDatVeChamNhat
            // 
            this.txtThoiGianDatVeChamNhat.Location = new System.Drawing.Point(207, 46);
            this.txtThoiGianDatVeChamNhat.Name = "txtThoiGianDatVeChamNhat";
            this.txtThoiGianDatVeChamNhat.Size = new System.Drawing.Size(100, 20);
            this.txtThoiGianDatVeChamNhat.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Thời gian đặt vé chậm nhất (giờ)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Thời gian hủy đặt vé chậm nhất (giờ)";
            // 
            // txtThoiGianHuyDatVeChamNhat
            // 
            this.txtThoiGianHuyDatVeChamNhat.Location = new System.Drawing.Point(207, 77);
            this.txtThoiGianHuyDatVeChamNhat.Name = "txtThoiGianHuyDatVeChamNhat";
            this.txtThoiGianHuyDatVeChamNhat.Size = new System.Drawing.Size(100, 20);
            this.txtThoiGianHuyDatVeChamNhat.TabIndex = 25;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(72, 111);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(75, 23);
            this.btnCapNhat.TabIndex = 27;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(184, 111);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 28;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormQuyDinhHanDatVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 146);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtThoiGianHuyDatVeChamNhat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtThoiGianDatVeChamNhat);
            this.Controls.Add(this.label5);
            this.Name = "FormQuyDinhHanDatVe";
            this.Text = "FormQuyDinhHanDatVe";
            this.Load += new System.EventHandler(this.FormQuyDinhHanDatVe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtThoiGianDatVeChamNhat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtThoiGianHuyDatVeChamNhat;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnThoat;
    }
}