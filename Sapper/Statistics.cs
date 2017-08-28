using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SapperGame
{
    class Statistics
    {
        #region Properties
        public long IdUser { get; private set; }
        public long IdGame { get; private set; }
        public int NumVictory { get; private set; }
        public int NumDefeat { get; private set; }
        public int NumSeconds { get; private set; }
        #endregion

        #region Construtors
        public Statistics() { }
        #endregion

        #region Methods
        // ...
        #endregion
    }
}
