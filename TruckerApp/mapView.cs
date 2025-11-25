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
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;

namespace TruckerApp
{
    public partial class mapView : Form
    {
        SqlConnection connection = root.connection;
        private GMapControl gmap;
        List<PointLatLng> _points;

        public mapView()
        {
            InitializeComponent();
        }

        double startLat = 0;
        double startLng = 0;
        double endLat = 0;
        double endLng = 0;

        private void mapView_Load(object sender, EventArgs e)
        {
            _points = new List<PointLatLng>();

            try
            {
                connection.Open();

                SqlCommand readData = new SqlCommand("SELECT * FROM Nakliyat", connection);
                SqlDataReader reader = readData.ExecuteReader();

                while (reader.Read())
                {
                    comboBox1.Items.Add(reader["nakliyat_no"].ToString().TrimEnd());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritaban Kaynakli Bir Sorun Olustu", "Error");
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }

        private void InitializeGMap(double startLat, double startLng, double endLat, double endLng)
        {
            gmap = new GMapControl();

            screen.Controls.Clear();

            gmap.Dock = DockStyle.Fill;
            gmap.MapProvider = GMapProviders.GoogleMap;
            GMaps.Instance.Mode = AccessMode.ServerOnly;

            gmap.Position = new PointLatLng(startLat, startLng); // Turkiye Koordinatlari

            gmap.MinZoom = 5;
            gmap.MaxZoom = 100;
            gmap.Zoom = 9;

            

            _points.Add(new PointLatLng(startLat, startLng));
            _points.Add(new PointLatLng(endLat, endLng));

            var route = GoogleMapProvider.Instance.GetRoute(_points[0], _points[1], false, false, 14);

            var r = new GMapRoute(route.Points, "Truck Route");

            var routes = new GMapOverlay("routes");
            routes.Routes.Add(r);

            gmap.Overlays.Add(routes);

            screen.Controls.Add(gmap);

            /*GMapOverlay truck_overlay = new GMapOverlay("TruckOverlay");

            TruckMarker truck1 = new TruckMarker(new PointLatLng(startLat, startLng));
            truck_overlay.Markers.Add(truck1);
            gmap.Overlays.Add(truck_overlay);

            PointLatLng truckStart = new PointLatLng(startLat, startLng);
            PointLatLng truckEnd = new PointLatLng(endLat, endLng);

            // Create a GMapRoute from the current location to the destination
            GMapRoute truckRoute = new GMapRoute(new List<PointLatLng> { truckStart, truckEnd }, "Truck Route");
            truck_overlay.Routes.Add(truckRoute);*/
        }

        public void searchBtn_Click(object sender, EventArgs e)
        {
            string nakliyat_no = comboBox1.Text;
            string truckStart = null;
            string truckEnd = null;

            if (nakliyat_no == "")
            {
                MessageBox.Show("Haritada Görüntülemek İsteğiniz Nakliyatın Numarasını Giriniz.");
            }
            else
            {
                try
                {
                    connection.Open();

                    SqlCommand readData = new SqlCommand("SELECT * FROM Nakliyat", connection);
                    SqlDataReader reader = readData.ExecuteReader();

                    while (reader.Read())
                    {
                        if (reader["nakliyat_no"].ToString().TrimEnd() == nakliyat_no)
                        {
                            truckStart = reader["cikis"].ToString().TrimEnd();
                            truckEnd = reader["varis"].ToString().TrimEnd();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veritaban Kaynakli Bir Sorun Olustu", "Error");
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

                    SqlCommand readData = new SqlCommand("SELECT * FROM Locations", connection);
                    SqlDataReader reader = readData.ExecuteReader();

                    while (reader.Read())
                    {
                        if (truckStart == reader["city_name"].ToString().TrimEnd())
                        {
                            startLat = Convert.ToDouble(reader["latitude"].ToString().TrimEnd());
                            startLng = Convert.ToDouble(reader["longitude"].ToString().TrimEnd());
                        }
                        if (truckEnd == reader["city_name"].ToString().TrimEnd())
                        {
                            endLat = Convert.ToDouble(reader["latitude"].ToString().TrimEnd());
                            endLng = Convert.ToDouble(reader["longitude"].ToString().TrimEnd());
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veritaban Kaynakli Bir Sorun Olustu", "Error");
                }
                finally
                {
                    if (connection != null)
                    {
                        connection.Close();
                    }
                }

                InitializeGMap(startLat, startLng, endLat, endLng);
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private int move;
        private int mouse_X;
        private int mouse_Y;

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

        private void topNavbar_MouseMove(object sender, MouseEventArgs e)
        {
            if (move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_X, MousePosition.Y - mouse_Y);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var route = GoogleMapProvider.Instance.GetRoute(_points[0], _points[1], false, false, 14);

            var r = new GMapRoute(route.Points, "Truck Route");

            var routes = new GMapOverlay("routes");
            routes.Routes.Add(r);

            gmap.Overlays.Add(routes);
        }
    }
}
