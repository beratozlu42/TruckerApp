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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TruckerApp
{
    public partial class addTruck : Form
    {

        SqlConnection connection = root.connection;

        public addTruck()
        {
            InitializeComponent();
        }

        private void addTruck_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                SqlCommand readData = new SqlCommand("SELECT * FROM Brands", connection);
                SqlDataReader reader = readData.ExecuteReader();

                while (reader.Read())
                {
                    comboBox2.Items.Add(reader["brand_name"].ToString().TrimEnd());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritaban Kaynakli Bir Problem Olustu", "Error");
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }

            try
            {
                connection.Open();

                SqlCommand readData = new SqlCommand("SELECT * FROM Vehicles", connection);
                SqlDataReader reader = readData.ExecuteReader();

                while (reader.Read())
                {
                    comboBox1.Items.Add(reader["truck_name"].ToString().TrimEnd());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Veritaban Kaynakli Bir Sorun Olustu" , "Error");
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }

        public void pictureSelect()
        {
            template_path tempPath = new template_path();
            string truckBrand = comboBox2.Text;
            pictureBox1.Image = Image.FromFile(tempPath.path() + truckBrand + ".png");
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBox2.SelectedIndex;

            if (comboBox2.SelectedIndex == index)
            {
                pictureSelect();

            }
        }


        // BURASI BITMEDI
        private void addBtn_Click(object sender, EventArgs e)
        {
            string truckName = textBox1.Text;
            string truckPlate = textBox2.Text;
            string truckBrand = comboBox2.Text;

            try
            {
                connection.Open();
                SqlCommand addData = new SqlCommand("INSERT INTO Vehicles (truck_name , truck_plate , truck_brand) values ('" + truckName + "' , '" + truckPlate + "' , '" + truckBrand + "')", connection);
                addData.ExecuteNonQuery();
                MessageBox.Show(truckName + " Adli Arac Basari Ile Eklendi.", "TruckerApp");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cekici Ekleme Islemi Esnasinda Bir Hata Olustu!", "Error");
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }


        //BURASI BITMEDI
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            string truck_name = comboBox1.Text;

            try
            {
                connection.Open();
                SqlCommand deleteData = new SqlCommand("DELETE FROM Vehicles WHERE truck_name = @truckname", connection);
                deleteData.Parameters.AddWithValue("@truckname", truck_name);
                deleteData.ExecuteNonQuery();
                MessageBox.Show("Kayit Silindi", "Alert");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Silme Islemi Esnasinda Bir Hata Olustu!", "Error");
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label6.Text = "Cekicinin Yeni Ismi";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label6.Text = "Cekicinin Yeni Plakasi";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label6.Text = "Cekicinin Yeni Markasi";
        }

        private void data_Editor(string data_name)
        {
            string s_truck_var = comboBox1.Text;
            string n_truck_var = textBox3.Text;

            if (s_truck_var == "" || n_truck_var == "")
            {
                MessageBox.Show("Lutfen Once Gerekli Alanlari Doldurunuz.", "Error");
            }
            else
            {
                try
                {
                    connection.Open();
                    SqlCommand updateData = new SqlCommand("UPDATE Vehicles SET truck_name = @n_truckname WHERE @data_name = @s_truckname", connection);
                    updateData.Parameters.AddWithValue("@n_truckname", n_truck_var);
                    updateData.Parameters.AddWithValue("@s_truckname", s_truck_var);
                    updateData.Parameters.AddWithValue("@data_name", data_name);
                    updateData.ExecuteNonQuery();
                    MessageBox.Show("Duzenleme Islemi Yapildi.", "TruckerApp");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Guncelleme Islemi Esnasinda Bir Hata Olustu!", "Error");
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

        private void duzenleBtn_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == false && radioButton2.Checked == false && radioButton3.Checked == false)
            {
                MessageBox.Show("Lutfen Once Islemi Seciniz", "Error");
            }

            else if (radioButton1.Checked)
            {
                data_Editor("truck_name");
            }
            else if (radioButton2.Checked)
            {
                data_Editor("truck_plate");

            }
            else if (radioButton3.Checked)
            {
                data_Editor("truck_brand");
            }
        }
    }
}
