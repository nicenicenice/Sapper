using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SapperGame
{
    public partial class Statement: Form
    {
        private static Sapper _calledForm = null;

        public Statement(Form calledForm)
        {
            _calledForm = calledForm as Sapper;

            if (_calledForm == null)
                return;

            InitializeComponent();
        }

        private void restartGame_Click(object sender, EventArgs e)
        {
            _calledForm.RestartGame();
            this.Close();
        }

        private void startNewGame_Click(object sender, EventArgs e)
        {
            _calledForm.StartNewGame();
            this.Close();
        }

        private void exitGame_Click(object sender, EventArgs e)
        {
            _calledForm.EndGame();
            this.Close();
        }
    }
}
