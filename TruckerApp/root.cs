using Microsoft.VisualBasic.Devices;
using System.Data.SqlClient;
using System.Reflection.Metadata;
using System.Timers;
using System.Windows.Forms;

namespace TruckerApp
{
    public partial class root : Form
    {

        public static SqlConnection connection = new SqlConnection("Data Source = Lenovo\\SQLEXPRESS; Initial Catalog = TruckerApp; Integrated Security = TRUE");

        public root()
        {
            InitializeComponent();
        }

        public void FormLoader(Form form)
        {
            screen.Controls.Clear();
            form.MdiParent = this;
            form.FormBorderStyle = FormBorderStyle.None;
            screen.Controls.Add(form);
            form.Show();
        }

        private void root_Load(object sender, EventArgs e)
        {
            //
        }

        private void user_interface(string v_name)
        {
            UIManager manager = new UIManager(label11, navbar, screen, addDriverBtn, addTruckBtn, addTrailerBtn, trackBtn);
            manager.UserInterface(v_name);
        }

        public void admin_interface(string v_name)
        {
            UIManager manager = new UIManager(label11, navbar, screen, addDriverBtn, addTruckBtn, addTrailerBtn, trackBtn);
            manager.AdminInterface(v_name);
        }


        private void loginBtn_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            string verified_name = null;
            int admin = 0;
            bool auth = false;
            bool check = false;

            try
            {
                connection.Open();
                SqlCommand dataRead = new SqlCommand("SELECT *FROM Auth", connection);
                SqlDataReader reader = dataRead.ExecuteReader();

                while (reader.Read())
                {
                    if (username == reader["username"].ToString().TrimEnd() && password == reader["password"].ToString().TrimEnd())
                    {
                        check = true;
                        admin = Convert.ToInt32(reader["admin"]);
                        verified_name = reader["username"].ToString().TrimEnd();
                        break;
                    }
                    else
                    {
                        check = false;
                    }
                }
                if (check)
                {
                    MessageBox.Show("Hesabiniza Giris Yaptiniz.", "TruckerApp");
                    auth = true;
                }
                else
                {
                    MessageBox.Show("Hesabiniza Giris Yapilamadi... Lutfen Sifrenizi ya da Kullanici Isminizi Kontrol Ediniz.", "Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabaninda Bir Sorun Meydana Geldi...");
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }

            if (auth)
            {
                switch (admin)
                {
                    case 0:
                        user_interface(verified_name);
                        break;
                    case 1:
                        admin_interface(verified_name);
                        break;
                }
            }
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            string username = textBox3.Text;
            string e_mail = textBox4.Text;
            string password = textBox5.Text;
            string re_password = textBox6.Text;
            bool problem = false;

            try
            {
                connection.Open();
                SqlCommand readData = new SqlCommand("SELECT * FROM Auth", connection);
                SqlDataReader reader = readData.ExecuteReader();

                while (reader.Read())
                {
                    if (e_mail == reader["e_mail"].ToString().TrimEnd())
                    {
                        MessageBox.Show("Bu E-mail Zaten Baska Bir Hesap Tarafindan Kullanilmaktadir", "Error");
                        problem = true;
                        break;
                    }
                    else if (username == reader["username"].ToString().TrimEnd())
                    {
                        MessageBox.Show("Bu Kullanici Adi Zaten Baska Bir Hesap Tarafindan Kullanilmaktadir", "Error");
                        problem = true;
                        break;
                    }
                }

                connection.Close();

                if (problem == false)
                {
                    if (password != re_password)
                    {
                        MessageBox.Show("Girilen Sifreler Ayni Degil!", "Error");

                    }
                    else
                    {
                        connection.Open();

                        SqlCommand newUser = new SqlCommand("INSERT INTO Auth (username, password, re_password, e_mail , admin) values ('" + username + "' , '" + password + "' , '" + re_password + "' , '" + e_mail + "' , '" + 0 + "')", connection);
                        newUser.ExecuteNonQuery();
                        MessageBox.Show("Hesabiniz Olusturuldu.", "TruckerApp");
                        tabControl1.SelectedIndex = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kayit Islemi Sirasinda Bir Hata Meydana Geldi", "Error");
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

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void addDriverBtn_Click(object sender, EventArgs e)
        {
            addDriver add_driver = new addDriver();
            FormLoader(add_driver);
        }

        private void addTruckBtn_Click(object sender, EventArgs e)
        {
            addTruck add_truck = new addTruck();
            FormLoader(add_truck);
        }

        private void addTrailerBtn_Click(object sender, EventArgs e)
        {
            addTrailer add_trailer = new addTrailer();
            FormLoader(add_trailer);
        }

        private void forDriversBtn_Click(object sender, EventArgs e)
        {
            forDrivers for_drivers = new forDrivers();
            FormLoader(for_drivers);
        }

        private void trackBtn_Click(object sender, EventArgs e)
        {
            trackActivity trackAct = new trackActivity();
            FormLoader(trackAct);
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }



        private int move;
        private int mouse_X;
        private int mouse_Y;

        private void topNavbar_MouseMove(object sender, MouseEventArgs e)
        {
            if (move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_X, MousePosition.Y - mouse_Y);
            }
        }

        private void topNavbar_MouseDown(object sender, MouseEventArgs e)
        {
            move = 1;
            mouse_X = e.X;
            mouse_Y = e.Y;
        }

        private void topNavbar_MouseUp(object sender, MouseEventArgs e)
        {
            move = 0;
        }

        private void mapViewButton_Click(object sender, EventArgs e)
        {
            mapView map = new mapView();
            map.Show();
        }
    }
}