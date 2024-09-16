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
    public partial class Form4 : Form
    {
        private readonly string hesapNo;
        private readonly string connString = "Data Source=faruk\\sqlexpress;Initial Catalog=Db_Banka;Integrated Security=True;";

        public Form4()
        {
            InitializeComponent();
            this.hesapNo = hesapNo;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT GONDEREN,ALICI,TUTAR FROM TBLHAREKET WHERE GONDEREN=@M1 OR ALICI=@M2", conn);
                da.SelectCommand.Parameters.AddWithValue("@M1", hesapNo);
                da.SelectCommand.Parameters.AddWithValue("@M2", hesapNo);

                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                conn.Close();
            }
        }
    }
}
