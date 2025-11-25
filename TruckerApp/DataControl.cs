using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TruckerApp
{
    internal class DataControl
    {
        SqlConnection connection = root.connection;
        
        public bool control_driver(string driver_name)
        {
            bool control = false;

            try
            {
                connection.Open();

                SqlCommand readData = new SqlCommand("SELECT *FROM Nakliyat", connection);
                SqlDataReader reader = readData.ExecuteReader();

                while (reader.Read())
                {
                    if (reader["surucu"].ToString().TrimEnd() == driver_name)
                    {
                        MessageBox.Show("Bu Surucu Adina Zaten Bir Nakliyat Bulunmaktadir." , "Error");
                        control = false;
                        break;
                    }
                    else
                    {
                        control = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritaban Kaynakli Bir Problem Meydana Geldi" , "Error");
                return false;
            }
            finally 
            {
                if(connection != null)
                {
                    connection.Close();
                }
            }

            return control;
        }

        public bool control_truck(string truck_name)
        {
            bool control = false;

            try
            {
                connection.Open();

                SqlCommand readData = new SqlCommand("SELECT *FROM Nakliyat", connection);
                SqlDataReader reader = readData.ExecuteReader();

                while (reader.Read())
                {
                    if (reader["cekici"].ToString().TrimEnd() == truck_name)
                    {
                        MessageBox.Show("Bu Tir Zaten Kullanimda");
                        control = false; 
                        break;
                    }
                    else
                    {
                        control = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritaban Kaynakli Bir Problem Olustu." , "Error");
                return false;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }

            return control;
        }

        public bool control_trailer(string trailer_name)
        {
            bool control = false;

            try
            {
                connection.Open();

                SqlCommand readData = new SqlCommand("SELECT *FROM Nakliyat", connection);
                SqlDataReader reader = readData.ExecuteReader();

                while (reader.Read())
                {
                    if (reader["dorse"].ToString().TrimEnd() == trailer_name)
                    {
                        MessageBox.Show("Bu Dorse Zaten Kullanimda");
                        control = false;
                    }
                    else
                    {
                        control = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir Hata Olustu" , "Error");
                return false;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }

            return control;
        }

        bool messageCheck = true;

        public bool check_truck(string truck_name)
        {
            bool problem = false;

            try
            {
                connection.Open();

                SqlCommand dataRead = new SqlCommand("SELECT * FROM Drivers", connection);
                SqlDataReader reader = dataRead.ExecuteReader();

                while (reader.Read())
                {
                    if (truck_name == reader["driver_current_truck"].ToString().TrimEnd())
                    {
                        problem = true;

                        if(messageCheck)
                        {
                            MessageBox.Show("Bu Çekici Zaten Başka Bir Sürücü Tarafından Kullanımda", "Error");
                        }

                        messageCheck = true;
                        break;
                    }
                    else
                    {
                        problem = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir Hata Olustu", "Error");
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }

            return problem;
        }

        public bool check_driver(string driver_name , string truck_name)
        {
            bool problem = false;

            try
            {
                connection.Open();

                SqlCommand dataRead = new SqlCommand("SELECT * FROM Drivers", connection);
                SqlDataReader reader = dataRead.ExecuteReader();

                while (reader.Read())
                {
                    if (driver_name == reader["driver_name"].ToString().TrimEnd())
                    {
                        if (reader["driver_current_truck"].ToString().TrimEnd() == truck_name)
                        {
                            MessageBox.Show("Bu Sürücü Zaten Bu Çekiciyi Kullanıyor...", "Error");
                            messageCheck = false;
                            problem = true;
                            break;
                        }
                        else
                        {
                            problem = false;                            
                        }
                    }
                    else
                    {
                        problem = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir Hata Olustu", "Error");
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }

            return problem;
        }
    }
}
