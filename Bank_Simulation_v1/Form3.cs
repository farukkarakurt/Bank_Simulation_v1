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
    public partial class Form3 : Form
    {
        public string hesapno;
        private readonly string connString = "Data Source=faruk\\sqlexpress;Initial Catalog=Db_Banka;Integrated Security=True;";

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            lbl_hesapno.Text = hesapno;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM TBL_KISILER WHERE HESAPNO=@P1", conn);
                cmd.Parameters.AddWithValue("@P1", hesapno);

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lbl_adSoyad.Text = dr[1] + " " + dr[2];
                    lbl_tc.Text = dr[3].ToString();
                    lbl_telno.Text = dr[4].ToString();

                }
                conn.Close();

                conn.Open();
                SqlCommand cmd2 = new SqlCommand("SELECT BAKIYE FROM TBLHESAP WHERE HESAPNO=@P1", conn);
                cmd2.Parameters.AddWithValue("@P1", hesapno);
                SqlDataReader dr2 = cmd2.ExecuteReader();

                if (dr2.Read())
                {
                    decimal bakiye = dr2.GetDecimal(0); // BAKIYE kolonundaki değeri al
                    lbl_bakiye.Text = bakiye.ToString("N2");
                }
                conn.Close();

            }

        }

        private void btn_gonder_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {

                // Göderilern hesabin para artışı

                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE TBLHESAP SET BAKIYE=BAKIYE+@P1 WHERE HESAPNO=@P2", conn);
                cmd.Parameters.AddWithValue("@P1", decimal.Parse(txt_tutar.Text));
                cmd.Parameters.AddWithValue("@P2", msk_hesapno.Text);
                cmd.ExecuteNonQuery();
                conn.Close();

                conn.Open();

                // Alınan paradan sonra azalış

                SqlCommand cmd2 = new SqlCommand("UPDATE TBLHESAP SET BAKIYE=BAKIYE-@K1 WHERE HESAPNO=@K2", conn);
                cmd2.Parameters.AddWithValue("@K1", decimal.Parse(txt_tutar.Text));
                cmd2.Parameters.AddWithValue("@K2", hesapno);
                cmd2.ExecuteNonQuery();
                conn.Close();


                // hareketler....
                conn.Open();
                SqlCommand cmd3 = new SqlCommand("insert into TBlHAREKET (GONDEREN,ALICI,TUTAR) VALUES (@M1,@M2,@M3)", conn);
                cmd3.Parameters.AddWithValue("@M1", hesapno);
                cmd3.Parameters.AddWithValue("@M2", msk_hesapno.Text);
                cmd3.Parameters.AddWithValue("@M3", decimal.Parse(txt_tutar.Text));
                cmd3.ExecuteNonQuery();
                MessageBox.Show("işlem Gerçekleşti");
                conn.Close();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form4 frm4 = new Form4();
            frm4.Show();
            this.Hide();
        }
    }
}
