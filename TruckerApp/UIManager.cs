using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruckerApp
{
    internal class UIManager
    {
        private Label label;
        private Control navbar;
        private Control screen;
        private Button driver;
        private Button truck;
        private Button trailer;
        private Button track;

        public UIManager(Label label1 , Control navbar1 , Control screen1 , Button driver1 , Button truck1 , Button trailer1 , Button track1) 
        {
            label = label1;
            navbar = navbar1;
            screen = screen1;
            driver = driver1;
            truck = truck1;
            trailer = trailer1;
            track = track1;
        }

        public void AdminInterface(string v_name)
        {
            label.Text = "- " + v_name;
            navbar.Enabled = true;
            screen.Controls.Clear();
        }

        public void UserInterface(string v_name)
        {
            label.Text = "- " + v_name;
            navbar.Enabled = true;
            driver.Enabled = false;
            driver.Cursor = Cursors.No;
            truck.Enabled = false;
            truck.Cursor = Cursors.No;
            trailer.Enabled = false;
            trailer.Cursor = Cursors.No;
            track.Enabled = false;
            track.Cursor = Cursors.No;
            screen.Controls.Clear();
        }
    }
}
