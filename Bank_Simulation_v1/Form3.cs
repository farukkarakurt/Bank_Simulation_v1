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
            }

        }

        private void btn_gonder_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {

                // Göderilern hesabin para artışı

                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE TBLHESAP SET BAKIYE=BAKIYE+@P1 WHERE HESAPNO=@P2", conn);
                cmd.Parameters.AddWithValue("@P1",decimal.Parse(txt_tutar.Text));
                cmd.Parameters.AddWithValue("@P2",msk_hesapno.Text);
                cmd.ExecuteNonQuery();
                conn.Close();

                conn.Open();


                SqlCommand cmd2 = new SqlCommand("UPDATE TBLHESAP SET BAKIYE=BAKIYE-@K1 WHERE HESAPNO=@K2", conn);
                cmd2.Parameters.AddWithValue("@K1",decimal.Parse(txt_tutar.Text));
                cmd2.Parameters.AddWithValue("@K2", hesapno);
                cmd2.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("işlem Gerçekleşti");
            }
        }
    }
}
