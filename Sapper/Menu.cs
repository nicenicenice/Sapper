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
    public partial class MenuSapper : Form
    {
        public MenuSapper()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            int rows = 0, maxNumRows = 24;
            int colls = 0, maxNumColls = 54;
            byte percent = 0;

            foreach (Control radioButton in radioGroupBox.Controls)
            {
                RadioButton radioItem = radioButton as RadioButton;

                if (radioItem != null && radioItem.Checked == true)
                {
                    switch (radioItem.Name)
                    {
                        case "sizeRadio9x9":
                            rows = 9;
                            colls = 9;
                            break;
                        case "sizeRadio16x16":
                            rows = 16;
                            colls = 16;
                            break;
                        case "radioButton16x32":
                            rows = 16;
                            colls = 32;
                            break;
                        case "radioButtonCustomSize":

                            try {
                                rows = Convert.ToInt32(numRowsBox.Text);
                                colls = Convert.ToInt32(numCollsBox.Text);
                            } catch (Exception exc) {
                                MessageBox.Show(exc.StackTrace);
                                return;
                            }

                            break;
                        default: break;
                    }
                    break;
                }
            }

            try
            {
                percent = Convert.ToByte(percentage.Text);
            } catch (Exception exc) {
                MessageBox.Show(exc.StackTrace);
                return;
            }

            if (percent < 1 || percent > 100)
            {
                MessageBox.Show("invalid parameters");
                return;
            }

            if (rows < 1 || rows > maxNumRows)
            {
                MessageBox.Show("invalid parameters");
                return;
            }

            if (colls < 1 || colls > maxNumColls)
            {
                MessageBox.Show("invalid parameters");
                return;
            }

            Sapper sapper = new Sapper(rows, colls, percent);
   
            this.Hide();
            sapper.Owner = this;
            sapper.ShowDialog();
        }



        private void exitGame_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
