namespace Bank_Simulation_v1
{
    partial class Form3
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_adSoyad = new System.Windows.Forms.Label();
            this.lbl_hesapno = new System.Windows.Forms.Label();
            this.lbl_telno = new System.Windows.Forms.Label();
            this.lbl_tc = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.msk_hesapno = new System.Windows.Forms.MaskedTextBox();
            this.txt_tutar = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_gonder = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "AD SOYAD :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "HESAP NO :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "TELEFON NO :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "TC KİMLİK NO:";
            // 
            // lbl_adSoyad
            // 
            this.lbl_adSoyad.AutoSize = true;
            this.lbl_adSoyad.Location = new System.Drawing.Point(232, 53);
            this.lbl_adSoyad.Name = "lbl_adSoyad";
            this.lbl_adSoyad.Size = new System.Drawing.Size(56, 22);
            this.lbl_adSoyad.TabIndex = 0;
            this.lbl_adSoyad.Text = "NULL";
            // 
            // lbl_hesapno
            // 
            this.lbl_hesapno.AutoSize = true;
            this.lbl_hesapno.Location = new System.Drawing.Point(232, 103);
            this.lbl_hesapno.Name = "lbl_hesapno";
            this.lbl_hesapno.Size = new System.Drawing.Size(56, 22);
            this.lbl_hesapno.TabIndex = 0;
            this.lbl_hesapno.Text = "NULL";
            // 
            // lbl_telno
            // 
            this.lbl_telno.AutoSize = true;
            this.lbl_telno.Location = new System.Drawing.Point(232, 154);
            this.lbl_telno.Name = "lbl_telno";
            this.lbl_telno.Size = new System.Drawing.Size(56, 22);
            this.lbl_telno.TabIndex = 0;
            this.lbl_telno.Text = "NULL";
            // 
            // lbl_tc
            // 
            this.lbl_tc.AutoSize = true;
            this.lbl_tc.Location = new System.Drawing.Point(232, 207);
            this.lbl_tc.Name = "lbl_tc";
            this.lbl_tc.Size = new System.Drawing.Size(56, 22);
            this.lbl_tc.TabIndex = 0;
            this.lbl_tc.Text = "NULL";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_gonder);
            this.groupBox1.Controls.Add(this.txt_tutar);
            this.groupBox1.Controls.Add(this.msk_hesapno);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 311);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(522, 274);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "HAVALE";
            // 
            // msk_hesapno
            // 
            this.msk_hesapno.Location = new System.Drawing.Point(197, 75);
            this.msk_hesapno.Mask = "000000";
            this.msk_hesapno.Name = "msk_hesapno";
            this.msk_hesapno.Size = new System.Drawing.Size(198, 28);
            this.msk_hesapno.TabIndex = 1;
            this.msk_hesapno.ValidatingType = typeof(int);
            // 
            // txt_tutar
            // 
            this.txt_tutar.Location = new System.Drawing.Point(197, 128);
            this.txt_tutar.Name = "txt_tutar";
            this.txt_tutar.Size = new System.Drawing.Size(198, 28);
            this.txt_tutar.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(96, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 22);
            this.label9.TabIndex = 0;
            this.label9.Text = "HESAP NO :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(88, 128);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 22);
            this.label10.TabIndex = 0;
            this.label10.Text = "TUTAR :";
            // 
            // btn_gonder
            // 
            this.btn_gonder.Location = new System.Drawing.Point(214, 191);
            this.btn_gonder.Name = "btn_gonder";
            this.btn_gonder.Size = new System.Drawing.Size(181, 34);
            this.btn_gonder.TabIndex = 3;
            this.btn_gonder.Text = "GÖNDER";
            this.btn_gonder.UseVisualStyleBackColor = true;
            this.btn_gonder.Click += new System.EventHandler(this.btn_gonder_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 640);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_tc);
            this.Controls.Add(this.lbl_telno);
            this.Controls.Add(this.lbl_hesapno);
            this.Controls.Add(this.lbl_adSoyad);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ANA SAYFA";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_adSoyad;
        private System.Windows.Forms.Label lbl_hesapno;
        private System.Windows.Forms.Label lbl_telno;
        private System.Windows.Forms.Label lbl_tc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_tutar;
        private System.Windows.Forms.MaskedTextBox msk_hesapno;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_gonder;
    }
}