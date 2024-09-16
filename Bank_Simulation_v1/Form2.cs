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
    public partial class Form2 : Form
    {

        private readonly string connString = "Data Source=faruk\\sqlexpress;Initial Catalog=Db_Banka;Integrated Security=True;";
        public Form2()
        {
            InitializeComponent();
        }


        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("insert into TBL_KISILER (AD,SOYAD,TC,TELELFON,HESAPNO,SIFRE) values (@P1,@P2,@P3,@P4,@P5,@P6)",conn);
                cmd.Parameters.AddWithValue("@P1",txt_ad.Text);
                cmd.Parameters.AddWithValue("@P2", txt_soyad.Text);
                cmd.Parameters.AddWithValue("@P3", msk_tc.Text);
                cmd.Parameters.AddWithValue("@P4", msk_telno.Text);
                cmd.Parameters.AddWithValue("@P5", msk_hesapno.Text);
                cmd.Parameters.AddWithValue("@P6", txt_sifre.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Kayıt işlemi başarılı ");
            }

        }

        private void btn_rndm_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int sayi=rnd.Next(100000,1000000);
            msk_hesapno.Text = sayi.ToString();
        }

        private void lbl_sifregoster_Click(object sender, EventArgs e)
        {
            if (txt_sifre.UseSystemPasswordChar)
            {
                txt_sifre.UseSystemPasswordChar = false;
            }
            else
            {
                txt_sifre.UseSystemPasswordChar=true;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
