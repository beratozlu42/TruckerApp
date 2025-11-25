using GMap.NET.WindowsForms;
using GMap.NET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruckerApp
{
    internal class TruckMarker : GMapMarker
    {
        public TruckMarker(PointLatLng position) : base(position)
        {
            Size = new Size(28, 28);
            Offset = new Point(-Size.Width / 2, -Size.Height / 2);
            ToolTipText = "Truck"; // Tooltip text for the marker
        }

        public override void OnRender(Graphics g)
        {
            g.FillEllipse(Brushes.Red, LocalPosition.X, LocalPosition.Y, Size.Width, Size.Height);
        }
    }
}
