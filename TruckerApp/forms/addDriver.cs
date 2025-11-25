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
    public partial class addDriver : Form
    {
        SqlConnection connection = root.connection;

        public addDriver()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            string driver_name = textBox1.Text;
            string driver_phone = textBox3.Text;
            string driver_number = textBox2.Text;
            string driver_age = textBox5.Text;
            string driver_experience = textBox6.Text;

            if(driver_name == "" || driver_phone == "" || driver_number == "" || driver_age == "" || driver_experience == "")
            {
                MessageBox.Show("Lütfen Gerekli Alanları Doldurun...", "Error");
            }
            else
            {
                try
                {
                    connection.Open();
                    SqlCommand addData = new SqlCommand("INSERT INTO Drivers (driver_name , driver_phone , driver_number , driver_age , driver_exp_year) values ('" + driver_name + "' , '" + driver_phone + "' , '" + driver_number + "' , '" + driver_age + "' , '" + driver_experience + "')", connection);
                    addData.ExecuteNonQuery();
                    MessageBox.Show(driver_name + " Adli Surucu Basari Ile Eklendi.", "TruckerApp");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Surucu Ekleme Islemi Esnasinda Bir Hata Olustu!", "Error");
                }
                finally
                {
                    if (connection != null)
                    {
                        connection.Close();
                    }
                }
            }
        }
    }
}
