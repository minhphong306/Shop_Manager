namespace Shop_Manager {
    partial class frmDangKy {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.cbMod = new System.Windows.Forms.ComboBox();
            this.btnTroLai = new System.Windows.Forms.Button();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAcc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbMod
            // 
            this.cbMod.FormattingEnabled = true;
            this.cbMod.Location = new System.Drawing.Point(158, 216);
            this.cbMod.Name = "cbMod";
            this.cbMod.Size = new System.Drawing.Size(192, 24);
            this.cbMod.TabIndex = 23;
            // 
            // btnTroLai
            // 
            this.btnTroLai.Location = new System.Drawing.Point(237, 278);
            this.btnTroLai.Name = "btnTroLai";
            this.btnTroLai.Size = new System.Drawing.Size(103, 37);
            this.btnTroLai.TabIndex = 21;
            this.btnTroLai.Text = "Trở lại";
            this.btnTroLai.UseVisualStyleBackColor = true;
            this.btnTroLai.Click += new System.EventHandler(this.btnTroLai_Click);
            // 
            // btnDangKy
            // 
            this.btnDangKy.Location = new System.Drawing.Point(115, 278);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(103, 37);
            this.btnDangKy.TabIndex = 22;
            this.btnDangKy.Text = "Đăng ký";
            this.btnDangKy.UseVisualStyleBackColor = true;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(158, 165);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(191, 23);
            this.txtPass.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 215);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Bộ phận";
            // 
            // txtAcc
            // 
            this.txtAcc.Location = new System.Drawing.Point(158, 114);
            this.txtAcc.Name = "txtAcc";
            this.txtAcc.Size = new System.Drawing.Size(191, 23);
            this.txtAcc.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 171);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Mật khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 120);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Tài khoản";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(26, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 39);
            this.label1.TabIndex = 15;
            this.label1.Text = "Quản lý bán quần áo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmDangKy
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(431, 367);
            this.Controls.Add(this.cbMod);
            this.Controls.Add(this.btnTroLai);
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAcc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Name = "frmDangKy";
            this.Text = "frmDangKy";
            this.Load += new System.EventHandler(this.frmDangKy_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbMod;
        private System.Windows.Forms.Button btnTroLai;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAcc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}