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
    public partial class addTrailer : Form
    {
        SqlConnection connection = root.connection;

        public addTrailer()
        {
            InitializeComponent();
        }

        private void addTrailer_Load(object sender, EventArgs e)
        {
            getData();

            try
            {
                connection.Open();

                SqlCommand readData = new SqlCommand("SELECT * FROM Trailer_Type", connection);
                SqlDataReader reader = readData.ExecuteReader();

                while (reader.Read())
                {
                    comboBox1.Items.Add(reader["trailer_type"].ToString().TrimEnd());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritaban Kaynakli Bir Problem Olustu.", "Error");
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }


        }

        public void getData()
        {
            connection.Open();

            SqlCommand getData = new SqlCommand("SELECT * FROM Trailers", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(getData);

            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            dataGridView1.DataSource = dataTable;

            connection.Close();
        }

        private void addTrailerBtn_Click(object sender, EventArgs e)
        {
            string trailer_no = textBox1.Text;
            string trailer_type = comboBox1.Text;

            try
            {
                connection.Open();

                SqlCommand addData = new SqlCommand("INSERT INTO Trailers (trailer_no , trailer_type) values ('" + trailer_no + "' , '" + trailer_type + "')", connection);
                addData.ExecuteNonQuery();

                MessageBox.Show(trailer_no + " Numarali Dorse Kaydedildi.", "TruckerApp");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritaban Kaynakli Bir Problem Olustu.", "Error");
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }
    }
}
