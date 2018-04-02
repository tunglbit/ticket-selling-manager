namespace _QuanLyBanVeXe
{
    partial class GeneralFormNV
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
            this.btnBanVe = new System.Windows.Forms.Button();
            this.btnNhanLich = new System.Windows.Forms.Button();
            this.btnTraCuu = new System.Windows.Forms.Button();
            this.btnGhiNhan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(58, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 36);
            this.label5.TabIndex = 25;
            this.label5.Text = "QUẢN LÝ BÁN VÉ XE\r\n       (Nhân viên)";
            // 
            // btnBanVe
            // 
            this.btnBanVe.Location = new System.Drawing.Point(14, 111);
            this.btnBanVe.Name = "btnBanVe";
            this.btnBanVe.Size = new System.Drawing.Size(112, 23);
            this.btnBanVe.TabIndex = 27;
            this.btnBanVe.Text = "Bán vé chuyến đi";
            this.btnBanVe.UseVisualStyleBackColor = true;
            this.btnBanVe.Click += new System.EventHandler(this.btnBanVe_Click);
            // 
            // btnNhanLich
            // 
            this.btnNhanLich.Location = new System.Drawing.Point(14, 69);
            this.btnNhanLich.Name = "btnNhanLich";
            this.btnNhanLich.Size = new System.Drawing.Size(112, 23);
            this.btnNhanLich.TabIndex = 26;
            this.btnNhanLich.Text = "Nhận lịch chuyến đi";
            this.btnNhanLich.UseVisualStyleBackColor = true;
            this.btnNhanLich.Click += new System.EventHandler(this.btnNhanLich_Click);
            // 
            // btnTraCuu
            // 
            this.btnTraCuu.Location = new System.Drawing.Point(153, 111);
            this.btnTraCuu.Name = "btnTraCuu";
            this.btnTraCuu.Size = new System.Drawing.Size(112, 23);
            this.btnTraCuu.TabIndex = 29;
            this.btnTraCuu.Text = "Tra cứu chuyến đi";
            this.btnTraCuu.UseVisualStyleBackColor = true;
            this.btnTraCuu.Click += new System.EventHandler(this.btnTraCuu_Click);
            // 
            // btnGhiNhan
            // 
            this.btnGhiNhan.Location = new System.Drawing.Point(153, 69);
            this.btnGhiNhan.Name = "btnGhiNhan";
            this.btnGhiNhan.Size = new System.Drawing.Size(112, 23);
            this.btnGhiNhan.TabIndex = 28;
            this.btnGhiNhan.Text = "Ghi nhận đặt vé";
            this.btnGhiNhan.UseVisualStyleBackColor = true;
            this.btnGhiNhan.Click += new System.EventHandler(this.button2_Click);
            // 
            // GeneralFormNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 160);
            this.Controls.Add(this.btnTraCuu);
            this.Controls.Add(this.btnGhiNhan);
            this.Controls.Add(this.btnBanVe);
            this.Controls.Add(this.btnNhanLich);
            this.Controls.Add(this.label5);
            this.Name = "GeneralFormNV";
            this.Text = "Giao diện chính (Nhân viên)";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GeneralFormNV_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBanVe;
        private System.Windows.Forms.Button btnNhanLich;
        private System.Windows.Forms.Button btnTraCuu;
        private System.Windows.Forms.Button btnGhiNhan;
    }
}