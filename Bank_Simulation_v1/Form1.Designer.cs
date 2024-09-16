namespace Bank_Simulation_v1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.msk_hesapno = new System.Windows.Forms.MaskedTextBox();
            this.btn_girisyap = new System.Windows.Forms.Button();
            this.lnk_yenikayit = new System.Windows.Forms.LinkLabel();
            this.lbl_sifregoster = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "HESAP NO :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "ŞİFRE :";
            // 
            // txt_sifre
            // 
            this.txt_sifre.Location = new System.Drawing.Point(187, 142);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.Size = new System.Drawing.Size(197, 28);
            this.txt_sifre.TabIndex = 1;
            this.txt_sifre.UseSystemPasswordChar = true;
            // 
            // msk_hesapno
            // 
            this.msk_hesapno.Location = new System.Drawing.Point(187, 82);
            this.msk_hesapno.Mask = "000000";
            this.msk_hesapno.Name = "msk_hesapno";
            this.msk_hesapno.Size = new System.Drawing.Size(197, 28);
            this.msk_hesapno.TabIndex = 0;
            this.msk_hesapno.ValidatingType = typeof(int);
            // 
            // btn_girisyap
            // 
            this.btn_girisyap.Location = new System.Drawing.Point(187, 241);
            this.btn_girisyap.Name = "btn_girisyap";
            this.btn_girisyap.Size = new System.Drawing.Size(197, 33);
            this.btn_girisyap.TabIndex = 2;
            this.btn_girisyap.Text = "GİRİŞ YAP";
            this.btn_girisyap.UseVisualStyleBackColor = true;
            this.btn_girisyap.Click += new System.EventHandler(this.btn_girisyap_Click);
            // 
            // lnk_yenikayit
            // 
            this.lnk_yenikayit.AutoSize = true;
            this.lnk_yenikayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lnk_yenikayit.Location = new System.Drawing.Point(236, 291);
            this.lnk_yenikayit.Name = "lnk_yenikayit";
            this.lnk_yenikayit.Size = new System.Drawing.Size(85, 18);
            this.lnk_yenikayit.TabIndex = 3;
            this.lnk_yenikayit.TabStop = true;
            this.lnk_yenikayit.Text = "YENİ KAYIT";
            this.lnk_yenikayit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_yenikayit_LinkClicked);
            // 
            // lbl_sifregoster
            // 
            this.lbl_sifregoster.AutoSize = true;
            this.lbl_sifregoster.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sifregoster.Location = new System.Drawing.Point(272, 188);
            this.lbl_sifregoster.Name = "lbl_sifregoster";
            this.lbl_sifregoster.Size = new System.Drawing.Size(112, 20);
            this.lbl_sifregoster.TabIndex = 9;
            this.lbl_sifregoster.Text = "Şifreyi Göster";
            this.lbl_sifregoster.Click += new System.EventHandler(this.lbl_sifregoster_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 354);
            this.Controls.Add(this.lbl_sifregoster);
            this.Controls.Add(this.lnk_yenikayit);
            this.Controls.Add(this.btn_girisyap);
            this.Controls.Add(this.msk_hesapno);
            this.Controls.Add(this.txt_sifre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GİRİŞ SAYFASI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.MaskedTextBox msk_hesapno;
        private System.Windows.Forms.Button btn_girisyap;
        private System.Windows.Forms.LinkLabel lnk_yenikayit;
        private System.Windows.Forms.Label lbl_sifregoster;
    }
}

