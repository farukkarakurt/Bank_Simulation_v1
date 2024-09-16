namespace Bank_Simulation_v1
{
    partial class Form2
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
            this.msk_tc = new System.Windows.Forms.MaskedTextBox();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_soyad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.msk_telno = new System.Windows.Forms.MaskedTextBox();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.btn_rndm = new System.Windows.Forms.Button();
            this.msk_hesapno = new System.Windows.Forms.MaskedTextBox();
            this.lbl_sifregoster = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC KİMLİK NO :";
            // 
            // msk_tc
            // 
            this.msk_tc.Location = new System.Drawing.Point(219, 88);
            this.msk_tc.Mask = "00000000000";
            this.msk_tc.Name = "msk_tc";
            this.msk_tc.Size = new System.Drawing.Size(133, 28);
            this.msk_tc.TabIndex = 0;
            this.msk_tc.ValidatingType = typeof(int);
            // 
            // txt_ad
            // 
            this.txt_ad.Location = new System.Drawing.Point(219, 140);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(133, 28);
            this.txt_ad.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "AD :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "SOYAD :";
            // 
            // txt_soyad
            // 
            this.txt_soyad.Location = new System.Drawing.Point(219, 195);
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.Size = new System.Drawing.Size(133, 28);
            this.txt_soyad.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "HESAP NO :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(122, 374);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 22);
            this.label5.TabIndex = 0;
            this.label5.Text = "ŞİFRE :";
            // 
            // txt_sifre
            // 
            this.txt_sifre.Location = new System.Drawing.Point(219, 371);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.Size = new System.Drawing.Size(133, 28);
            this.txt_sifre.TabIndex = 5;
            this.txt_sifre.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 22);
            this.label6.TabIndex = 0;
            this.label6.Text = "TELEFON NO :";
            // 
            // msk_telno
            // 
            this.msk_telno.Location = new System.Drawing.Point(219, 252);
            this.msk_telno.Mask = "(999) 000-0000";
            this.msk_telno.Name = "msk_telno";
            this.msk_telno.Size = new System.Drawing.Size(133, 28);
            this.msk_telno.TabIndex = 3;
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Location = new System.Drawing.Point(219, 476);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(133, 35);
            this.btn_kaydet.TabIndex = 6;
            this.btn_kaydet.Text = "KAYDET";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // btn_rndm
            // 
            this.btn_rndm.Location = new System.Drawing.Point(368, 314);
            this.btn_rndm.Name = "btn_rndm";
            this.btn_rndm.Size = new System.Drawing.Size(47, 28);
            this.btn_rndm.TabIndex = 7;
            this.btn_rndm.Text = "...";
            this.btn_rndm.UseVisualStyleBackColor = true;
            this.btn_rndm.Click += new System.EventHandler(this.btn_rndm_Click);
            // 
            // msk_hesapno
            // 
            this.msk_hesapno.Location = new System.Drawing.Point(219, 314);
            this.msk_hesapno.Mask = "000000";
            this.msk_hesapno.Name = "msk_hesapno";
            this.msk_hesapno.Size = new System.Drawing.Size(133, 28);
            this.msk_hesapno.TabIndex = 4;
            this.msk_hesapno.ValidatingType = typeof(int);
            // 
            // lbl_sifregoster
            // 
            this.lbl_sifregoster.AutoSize = true;
            this.lbl_sifregoster.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sifregoster.Location = new System.Drawing.Point(240, 402);
            this.lbl_sifregoster.Name = "lbl_sifregoster";
            this.lbl_sifregoster.Size = new System.Drawing.Size(112, 20);
            this.lbl_sifregoster.TabIndex = 8;
            this.lbl_sifregoster.Text = "Şifreyi Göster";
            this.lbl_sifregoster.Click += new System.EventHandler(this.lbl_sifregoster_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 599);
            this.Controls.Add(this.lbl_sifregoster);
            this.Controls.Add(this.msk_hesapno);
            this.Controls.Add(this.btn_rndm);
            this.Controls.Add(this.btn_kaydet);
            this.Controls.Add(this.txt_sifre);
            this.Controls.Add(this.txt_soyad);
            this.Controls.Add(this.txt_ad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.msk_telno);
            this.Controls.Add(this.msk_tc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YENİ KAYIT EKRANI";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox msk_tc;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_soyad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox msk_telno;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.Button btn_rndm;
        private System.Windows.Forms.MaskedTextBox msk_hesapno;
        private System.Windows.Forms.Label lbl_sifregoster;
    }
}