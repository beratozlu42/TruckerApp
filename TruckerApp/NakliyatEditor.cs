using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TruckerApp
{
    internal class NakliyatEditor
    {
        SqlConnection connection = root.connection;

        public void NoEditor(string nakliyat_no , string new_var)
        {
            try
            {
                connection.Open();
                SqlCommand updateData = new SqlCommand("UPDATE Nakliyat SET nakliyat_no = @new_var WHERE nakliyat_no = @nakliyat_no", connection);
                updateData.Parameters.AddWithValue("@new_var", new_var);
                updateData.Parameters.AddWithValue("@nakliyat_no", nakliyat_no);
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
        public void SaatEditor(string nakliyat_no, string new_var)
        {
            try
            {
                connection.Open();
                SqlCommand updateData = new SqlCommand("UPDATE Nakliyat SET saat = @new_var WHERE nakliyat_no = @nakliyat_no", connection);
                updateData.Parameters.AddWithValue("@new_var", new_var);
                updateData.Parameters.AddWithValue("@nakliyat_no", nakliyat_no);
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
        public void TarihEditor(string nakliyat_no , string new_var)
        {
            try
            {
                connection.Open();
                SqlCommand updateData = new SqlCommand("UPDATE Nakliyat SET tarih = @new_var WHERE nakliyat_no = @nakliyat_no", connection);
                updateData.Parameters.AddWithValue("@new_var", new_var);
                updateData.Parameters.AddWithValue("@nakliyat_no", nakliyat_no);
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
}
