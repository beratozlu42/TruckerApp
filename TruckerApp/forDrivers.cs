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
    public partial class forDrivers : Form
    {
        SqlConnection connection = root.connection;

        public forDrivers()
        {
            InitializeComponent();
        }

        private void forDrivers_Load(object sender, EventArgs e)
        {
            //FOR DRIVERS DATA
            try
            {
                connection.Open();

                SqlCommand dReadData = new SqlCommand("SELECT * FROM Drivers", connection);
                SqlDataReader DriverReader = dReadData.ExecuteReader();

                while (DriverReader.Read())
                {
                    comboBox1.Items.Add(DriverReader["driver_name"].ToString().TrimEnd());
                    comboBox6.Items.Add(DriverReader["driver_name"].ToString().TrimEnd());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritaban Kaynakli Bir Sorun Meydana Geldi!", "Error1");
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }

            //FOR TRUCKS DATA
            try
            {
                connection.Open();

                SqlCommand tReadData = new SqlCommand("SELECT * FROM Vehicles", connection);
                SqlDataReader TruckReader = tReadData.ExecuteReader();

                while (TruckReader.Read())
                {
                    comboBox2.Items.Add(TruckReader["truck_name"].ToString().TrimEnd());
                    comboBox5.Items.Add(TruckReader["truck_name"].ToString().TrimEnd());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritaban Kaynakli Bir Sorun Meydana Geldi!", "Error2");
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }

            //FOR TRAILERS DATA
            try
            {
                connection.Open();

                SqlCommand trReadData = new SqlCommand("SELECT * FROM Trailers", connection);
                SqlDataReader TrailerReader = trReadData.ExecuteReader();

                while (TrailerReader.Read())
                {
                    comboBox3.Items.Add(TrailerReader["trailer_no"].ToString().TrimEnd());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritaban Kaynakli Bir Sorun Meydana Geldi!", "Error3");
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }

            //FOR "NAKLIYAT" DATA
            try
            {
                connection.Open();

                SqlCommand readData = new SqlCommand("SELECT * FROM Nakliyat", connection);
                SqlDataReader reader = readData.ExecuteReader();

                while (reader.Read())
                {
                    if (reader["nakliyat_no"] != null)
                    {
                        comboBox4.Items.Add(reader["nakliyat_no"].ToString().TrimEnd());
                    }
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
        }

        //"GONDER" BUTTON FUNCTION
        private void sendBtn_Click(object sender, EventArgs e)
        {
            string nakliyat_no = textBox1.Text;
            string surucu_ismi = comboBox1.Text;
            string sirket_ismi = textBox7.Text;
            string kullanilan_cekici = comboBox2.Text;
            string kullanilan_dorse = comboBox3.Text;
            string tarih = textBox4.Text;
            string saat = textBox5.Text;
            string mal_turu = textBox6.Text;
            string aciklama = richTextBox1.Text;
            string sehir_cikis = null;
            string sehir_varis = null;


            if (nakliyat_no == "" || surucu_ismi == "" || kullanilan_cekici == "" || kullanilan_dorse == "" || sirket_ismi == "" || radioButton1.Checked == false && radioButton2.Checked == false)
            {
                MessageBox.Show("Gerekli Alanlar Doldurulmadi.", "Error");
            }
            else
            {
                if (radioButton1.Checked)
                {
                    sehir_cikis = textBox2.Text;
                    sehir_varis = textBox2.Text;
                }
                else if (radioButton2.Checked)
                {
                    sehir_cikis = textBox2.Text;
                    sehir_varis = textBox3.Text;
                }

                DataControl data_control = new DataControl();
                bool problem = false;
                bool problem1 = false;
                bool problem2 = false;

                problem = data_control.control_driver(surucu_ismi);
                problem1 = data_control.control_truck(kullanilan_cekici);
                problem2 = data_control.control_trailer(kullanilan_dorse);

                if (problem && problem1 && problem2)
                {
                    try
                    {
                        connection.Open();
                        SqlCommand addData = new SqlCommand("INSERT INTO Nakliyat (nakliyat_no , surucu , cekici , dorse , sirket_ismi , cikis , varis , tarih , saat , mal_turu , aciklama) values ('" + nakliyat_no + "' , '" + surucu_ismi + "' , '" + kullanilan_cekici + "' , '" + kullanilan_dorse + "' , '" + sirket_ismi + "' , '" + sehir_cikis + "' , '" + sehir_varis + "' , '" + tarih + "' , '" + saat + "' , '" + mal_turu + "' , '" + aciklama + "')", connection);
                        addData.ExecuteNonQuery();

                        if (radioButton1.Checked)
                        {
                            MessageBox.Show(nakliyat_no + " Numarali " + sehir_cikis + " Icinde Nakliyat Bilgileri Kaydedildi.", "TruckerApp");

                        }
                        else if (radioButton2.Checked)
                        {
                            MessageBox.Show(nakliyat_no + " Numarali " + sehir_cikis + " - " + sehir_varis + " Istikametli Nakliyat Bilgileri Kaydedildi.", "TruckerApp");
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

                    try
                    {
                        connection.Open();

                        SqlCommand addData = new SqlCommand("INSERT INTO Trailers (trailer_driver) values ('" + surucu_ismi + "')", connection);
                        addData.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Nakliyat Bilgileri Kaydedilirken Bir Sorun Olustu.", "Error");
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

        private void editBtn_Click(object sender, EventArgs e)
        {
            string nakliyat_no = comboBox4.Text;
            string new_var = textBox8.Text;

            NakliyatEditor edit = new NakliyatEditor();

            if (nakliyat_no == "" || new_var == "")
            {
                MessageBox.Show("Lütfen Önce Gerekli Alanları Doldurunuz...", "Error");
            }
            else
            {
                if (radioButton3.Checked)
                {
                    edit.NoEditor(nakliyat_no, new_var);
                }
                else if (radioButton4.Checked)
                {
                    edit.SaatEditor(nakliyat_no, new_var);
                }
                else if (radioButton5.Checked)
                {
                    edit.TarihEditor(nakliyat_no, new_var);
                }
                else
                {
                    MessageBox.Show("Lütfen Yapmak İstediginiz İşlemi Seçin.", "Error");
                }
            }
        }

        private void finishOrderBtn_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox3.Enabled = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox3.Enabled = true;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label15.Text = "Nakliyat Numarası";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            label15.Text = "Nakliyat Saati";
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            label15.Text = "Nakliyat Tarihi";
        }

        private void atamaBtn_Click(object sender, EventArgs e)
        {
            string driver_name = comboBox6.Text;
            string truck_name = comboBox5.Text;

            DataControl datacontrol = new DataControl();
            bool problem1 = datacontrol.check_driver(driver_name, truck_name);
            bool problem2 = datacontrol.check_truck(truck_name);

            if (problem1 != true && problem2 != true)
            {
                try
                {
                    connection.Open();

                    SqlCommand updateData = new SqlCommand("UPDATE Drivers SET driver_current_truck = @current_truck WHERE driver_name = @driver_name", connection);
                    updateData.Parameters.AddWithValue("@current_truck", truck_name);
                    updateData.Parameters.AddWithValue("@driver_name", driver_name);
                    updateData.ExecuteNonQuery();

                    MessageBox.Show("Atama Islemi Basarili.", "TruckerApp");
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
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string driver_name = comboBox1.Text;

            connection.Open();

            SqlCommand readData = new SqlCommand("SELECT * FROM Drivers", connection);
            SqlDataReader reader = readData.ExecuteReader();

            while (reader.Read())
            {
                if (driver_name == reader["driver_name"].ToString().TrimEnd())
                {
                    comboBox2.Text = reader["driver_current_truck"].ToString().TrimEnd();
                }
            }
            connection.Close();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
