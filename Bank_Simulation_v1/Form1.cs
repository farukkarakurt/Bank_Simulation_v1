using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_Simulation_v1
{
    public partial class Form1 : Form
    {
        private readonly string connString = "Data Source=faruk\\sqlexpress;Initial Catalog=Db_Banka;Integrated Security=True;";
        public Form1()
        {
            InitializeComponent();
        }

        private void lnk_yenikayit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            
        }

        private void btn_girisyap_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from TBL_KISILER WHERE HESAPNO=@P1 AND SIFRE=@P2",conn);
                cmd.Parameters.AddWithValue("@P1",msk_hesapno.Text);
                cmd.Parameters.AddWithValue("@P2",txt_sifre.Text);
                SqlDataReader dr = cmd.ExecuteReader();
               
                if (dr.Read()) 
                {
                    Form3 frm3 = new Form3();
                    frm3.hesapno=msk_hesapno.Text;
                    frm3.Show();

                }
                else
                {
                    MessageBox.Show("İşlem başarısız");
                }
                conn.Close();
            }
        }

        private void lbl_sifregoster_Click(object sender, EventArgs e)
        {
            if (txt_sifre.UseSystemPasswordChar)
            {
                txt_sifre.UseSystemPasswordChar = false;
            }
            else
            {
                txt_sifre.UseSystemPasswordChar = true;
            }
        }
    }
}
