using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SapperGame
{
    class Cell
    {
        #region Properties
        public StateCell.State State { get; set; }
        public int NumBombAround { get; set; }
        public Point Coords { get; private set; }
        public bool IsBurning { get; set; }
        #endregion

        public Cell(Point coords)
        {
            this.State = StateCell.State.Closed;
            this.IsBurning = false;
            this.NumBombAround = 0;
            this.Coords = coords;
        }

        public void Clean()
        {
            this.State = StateCell.State.Closed;
            this.IsBurning = false;
            this.NumBombAround = 0;
        }
    }
}
