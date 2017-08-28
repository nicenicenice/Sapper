using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


// 1. make own button, with fields
// 2. make refactoring
// 3. check input parameters
// 4. add meaning
// 5. fix a bug when bomb is exploded
// 6. to add counter is cleared bomb

namespace SapperGame
{
    public partial class Sapper : Form
    {
        private Game game;
        public static int Rows { get; private set; }
        public static int Colls { get; private set; }
        public static int NumCells { get; private set; }
        public static byte Percent { get; private set; }
        public static MenuSapper MenuForm { get; private set; }

        private static Button[,] cells = null;
        private static List<int[]> listProbablyBombs = null;
        private static int gap = 18;
        private static int sizeCell = 20;
        private static int x_start = 10;
        private static int y_start = 10;
        private static int numBombs = 0;
        private static int numMarkedCells = 0;

        public Sapper(int rows, int colls, byte percent)
        {
            InitializeComponent();

            game = new Game(rows, colls, percent);
            game.notificationAboutDisplayShowingCell += new EventHandler<CoordsEventArgs>(ToShowCell);
            game.notificationAboutExplosion += new EventHandler<CoordsEventArgs>(Boom);

            Rows = rows;
            Colls = colls;
            Percent = percent;
            NumCells = Rows * Colls;

            // TODO:
            //MenuForm = this.Owner as MenuSapper;

            Init();
        }

        #region handlers events

        private void anyButton_Click(object sender, MouseEventArgs e)
        {
            Button cell = sender as Button;
            if (cell == null)
                return;

            hideFocusButton.Focus();

            Point coords = (Point)cell.Tag;
            int i = coords.X;
            int j = coords.Y;

            // right mouse button
            if (e.Button == MouseButtons.Right)
            {
                TryTargedCell(coords);
            }
            // left mouse button
            else if (e.Button == MouseButtons.Left)
            {
                TryOpenCell(coords);
            }
        }

        private void ToShowCell(object sender, CoordsEventArgs e)
        {
            Point coords = e.Coords;
            ToShowCell(coords);
        }
        private void Boom(object sender, CoordsEventArgs e)
        {
            Point coords = e.Coords;
            Boom(coords);
        }

        #endregion

        #region private methods

        private void Init()
        {
            int x = x_start, y = y_start;

            cells = new Button[Rows, Colls];
            for (int i = 0; i < Rows; ++i)
            {
                x = x_start;
                for (int j = 0; j < Colls; j++)
                {
                    cells[i, j] = new System.Windows.Forms.Button();
                    cells[i, j].Location = new System.Drawing.Point(x, y);
                    cells[i, j].Name = "cell" + i.ToString();
                    cells[i, j].Size = new System.Drawing.Size(sizeCell, sizeCell);
                    cells[i, j].TabStop = true;
                    cells[i, j].TextAlign = ContentAlignment.MiddleCenter;
                    cells[i, j].TabIndex = 0;
                    cells[i, j].Font = new Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
                    cells[i, j].BackColor = ColorButtons.closeColor;
                    cells[i, j].Tag = new Point(i, j);
                    cells[i, j].FlatAppearance.BorderSize = 0;
                    cells[i, j].FlatStyle = FlatStyle.Popup;
                    cells[i, j].MouseUp += new MouseEventHandler(anyButton_Click);

                    Controls.Add(cells[i, j]);

                    x += gap;
                }
                y += gap;
            }
        }
        private void TryOpenCell(Point coords)
        {
            int numBombsAround = game.GetNumberBombAround(coords);

            switch (game.GetStateCell(coords))
            {

                case StateCell.State.Targed: break;
                case StateCell.State.Mined: Boom(coords); break;
                case StateCell.State.Open:
                    int numMarksAround = game.GetNumberFlagsAround(coords);
                    if (numBombsAround == numMarksAround)
                    {
                        
                        game.OpenJustAdjacentCells(coords.X, coords.Y, true);
                        game.ToExtinguishFires();
                    }
                    break;

                case StateCell.State.Closed:
                    if (numBombsAround == 0)
                    {
                        // открыть без возможностью взрыва
                        game.OpenAdjacentCellsRecursive(coords.X, coords.Y);
                        game.ToExtinguishFires();
                    }
                    else if (numBombsAround > 0)
                    {
                        ToShowCell(coords);
                    }
                    break;
                default: break;
            }
        }
        private void TryTargedCell(Point coords)
        {
            // не совсем логично, что у бомбы есть состояния "заминированна" и "пемечена флагом"
            // она должна иметь только два или три состояния: открыта, закрыта

            StateCell.State stateCell = game.GetStateCell(coords);

            if (stateCell != StateCell.State.Open)
            {
                if (stateCell != StateCell.State.Targed)
                {
                    game.SetStateCell(coords, StateCell.State.Targed);
                    cells[coords.X, coords.Y].Image = SapperGame.Properties.Resources.sssr_flag;
                    numMarkedCells++;
                }
                else
                {
                    game.SetStateCell(coords, StateCell.State.Closed);
                    cells[coords.X, coords.Y].Image = null;
                    numMarkedCells--;
                }
            }
        }

        private void Boom(Point coords)
        {
            cells[coords.X, coords.Y].Image = Properties.Resources.large_explosion;
            //isHappenedBoom = true;
            //this.Hide();
            //this.Enabled = false;
            Statement statement = new Statement(this);
            statement.Show();

        }
        private void ToShowCell(Point coords)
        {
            // model
            game.SetStateCell(coords, StateCell.State.Open);

            // view
            Button cell = cells[coords.X, coords.Y];
            cell.BackColor = ColorButtons.openColor;

            int numBombsAround = game.GetNumberBombAround(coords);
            if (numBombsAround <= 0)
                return;

            switch (numBombsAround)
            {
                case 1: cell.ForeColor = ColorButtons.colorOne; break;
                case 2: cell.ForeColor = ColorButtons.colorTwo; break;
                case 3: cell.ForeColor = ColorButtons.colorThree; break;
                case 4: cell.ForeColor = ColorButtons.colorFour; break;
                case 5: cell.ForeColor = ColorButtons.colorFive; break;
                case 6: cell.ForeColor = ColorButtons.colorSix; break;
                case 7: cell.ForeColor = ColorButtons.colorSeven; break;
                case 8: cell.ForeColor = ColorButtons.colorEight; break;
                case 9: cell.ForeColor = ColorButtons.colorNine; break;
                case 10: cell.ForeColor = ColorButtons.colorTen; break;
                default: cell.ForeColor = Color.Black; break;
            }

            cell.Text = numBombsAround.ToString();
        }
        #endregion

        #region public methods
        public void RestartGame()
        {
            if (cells.Length <= 0)
                return;

            for (int i = 0; i < Rows; ++i)
            {
                for (int j = 0; j < Colls; ++j)
                {
                    cells[i, j].Image = null;
                    cells[i, j].Text = "";
                    cells[i, j].BackColor = ColorButtons.closeColor;
                }
            }

            game.Rebuild();
        }
        public void EndGame()
        {
            this.Close();
            MenuForm.Close();
        }
        public void StartNewGame()
        {
            this.Close();
            MenuForm.Show();
        }
        #endregion
 
    }
}