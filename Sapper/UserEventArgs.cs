using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SapperGame
{
    public class CoordsEventArgs : EventArgs
    {
        public Point Coords { get; private set; }
        
        public CoordsEventArgs(Point coords)
        {
            Coords = coords;
        }
    }
}
