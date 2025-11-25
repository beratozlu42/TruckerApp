using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TruckerApp
{
    public partial class trackActivity : Form
    {
        SqlConnection connection = root.connection;

        public trackActivity()
        {
            InitializeComponent();
        }

        private void trackActivity_Load(object sender, EventArgs e)
        {
            getData();
        }

        public void getData()
        {
            connection.Open();

            SqlCommand getData = new SqlCommand("SELECT * FROM Nakliyat", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(getData);

            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            dataGridView1.DataSource = dataTable;

            connection.Close();
        }
    }
}
