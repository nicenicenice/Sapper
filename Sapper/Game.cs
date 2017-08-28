using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SapperGame
{
    class Game
    {
        #region Events

        public event EventHandler<CoordsEventArgs> notificationAboutDisplayShowingCell;
        public event EventHandler<CoordsEventArgs> notificationAboutExplosion;

        #endregion

        #region Construtors
        public Game(int rows, int colls, byte percent)
        {
            Rows = rows;
            Colls = colls;
            NumCells = Rows * Colls;

            if (NumCells <= 0)
                throw new ArgumentOutOfRangeException();

            Percent = percent;
            if (Percent > 100 || Percent < 1)
                throw new ArgumentOutOfRangeException();

            Cells = new Cell[Rows, Colls];
            for (int i = 0; i < Rows; ++i)
                for (int j = 0; j < Colls; ++j)
                    Cells[i, j] = new Cell(new Point(i, j));

            GenerateRandomBombs();
            CalculateNumberBombsAroundEachCell();
        }
        #endregion

        #region Properties

        private Cell[,] Cells;

        public string UserName { get; private set; }
        public int Rows { get; private set; }
        public int Colls { get; private set; }
        
        public byte Percent { get; private set; }
        public int NumCells { get; private set; }
        public bool IsHappenedBoom { get; private set; }

        #endregion

        #region Methods

        #region private methods
        
        private int GetNumberBombs()
        {
            if (NumCells <= 0)
                return 0;
            if (Percent < 1 || Percent > 100)
                return 0;
            return NumCells * Percent / 100;
        }

        private int[] GetRandomSequence()
        {
            List<int> result = null;
            if (NumCells > 0)
            {
                int numBombs = GetNumberBombs();
                result = new List<int>(numBombs);
                Random rnd = new Random((int)DateTime.Now.Ticks);

                while (true)
                {
                    int rndNext = rnd.Next(0, NumCells);

                    if (result.Contains(rndNext))
                        continue;
                    result.Add(rndNext);

                    if (numBombs == result.Count)
                        break;
                }
            }
            return result.ToArray<int>();
        }

        private void GenerateRandomBombs()
        {
            if (Cells.Length <= 0)
                return;

            int[] listBombIndexs = GetRandomSequence();
            int i = 0, j = 0;

            for (int k = 0; k < listBombIndexs.Length; ++k)
            {
                int bombIndex = listBombIndexs[k];
                i = bombIndex / Colls;
                j = bombIndex - i * Colls;
                Cells[i, j].State = StateCell.State.Mined;
            }
        }

        private void CalculateNumberBombsAroundEachCell()
        {
            if (Cells.Length <= 0)
                return;

            int numBombsAroundCell = 0;

            for (int i = 0; i < Rows; ++i)
            {
                for (int j = 0; j < Colls; ++j)
                {
                    if (!IsBomb(i, j))
                    {
                        numBombsAroundCell = 0;

                        // север
                        if (IsContainInSetRestrictedArea(i - 1, j) && IsBomb(i - 1, j))
                            numBombsAroundCell++;

                        // северо-запад
                        if (IsContainInSetRestrictedArea(i - 1, j - 1) && IsBomb(i - 1, j - 1))
                            numBombsAroundCell++;

                        // северо-восток
                        if (IsContainInSetRestrictedArea(i - 1, j + 1) && IsBomb(i - 1, j + 1))
                            numBombsAroundCell++;

                        // запад
                        if (IsContainInSetRestrictedArea(i, j - 1) && IsBomb(i, j - 1))
                            numBombsAroundCell++;

                        // восток
                        if (IsContainInSetRestrictedArea(i, j + 1) && IsBomb(i, j + 1))
                            numBombsAroundCell++;

                        // юго-восток
                        if (IsContainInSetRestrictedArea(i + 1, j + 1) && IsBomb(i + 1, j + 1))
                            numBombsAroundCell++;

                        // юго-запад
                        if (IsContainInSetRestrictedArea(i + 1, j - 1) && IsBomb(i + 1, j - 1))
                            numBombsAroundCell++;

                        // юг
                        if (IsContainInSetRestrictedArea(i + 1, j) && IsBomb(i + 1, j))
                            numBombsAroundCell++;

                        Cells[i, j].NumBombAround = numBombsAroundCell;
                    }
                }
            }
        }

        private bool IsContainInSetRestrictedArea(int i, int j)
        {
            if (i >= 0 && // top
                    j <= Colls - 1 && // right
                    i <= Rows - 1 && // bottom
                    j >= 0 // left
            )
                return true;

            return false;
        }
        private void Clean()
        {
            for (int i = 0; i < Rows; ++i)
                for (int j = 0; j < Colls; ++j)
                    Cells[i, j].Clean();
        }
        private void Save() { }
        private void Exit() { }
        #endregion

        #region public methods
        public void Rebuild()
        {
            Clean();
            GenerateRandomBombs();
            CalculateNumberBombsAroundEachCell();

            // why?
        }

        public bool IsBomb(int i, int j)
        {
            return Cells[i, j].State == StateCell.State.Mined;
        }

        public bool IsBomb(Point coords)
        {
            return Cells[coords.X, coords.Y].State == StateCell.State.Mined;
        }

        public bool IsTarget(int i, int j)
        {
            return Cells[i, j].State == StateCell.State.Targed;
        }

        public bool IsBurning(Point coords)
        {
            return Cells[coords.X, coords.Y].IsBurning;
        }

        public bool SetBurning(Point coords, bool isBurning)
        {
            return Cells[coords.X, coords.Y].IsBurning = isBurning;
        }

        public StateCell.State GetStateCell(Point coord)
        {
            return Cells[coord.X, coord.Y].State;
        }

        public StateCell.State GetStateCell(int i, int j)
        {
            return Cells[i, j].State;
        }

        public void SetStateCell(Point coord, StateCell.State state)
        {
            Cells[coord.X, coord.Y].State = state;
        }

        public void SetStateCell(int i, int j, StateCell.State state)
        {
            Cells[i, j].State = state;
        }

        public int GetNumberBombAround(Point coord)
        {
            return Cells[coord.X, coord.Y].NumBombAround;
        }

        public int GetNumberFlagsAround(Point coords)
        {
            int i = coords.X;
            int j = coords.Y;
            if (IsBomb(i, j))
                return -1;

            int numFlagsAround = 0;

            // север
            if (IsContainInSetRestrictedArea(i - 1, j) && IsTarget(i - 1, j))
                numFlagsAround++;

            // северо-запад
            if (IsContainInSetRestrictedArea(i - 1, j - 1) && IsTarget(i - 1, j - 1))
                numFlagsAround++;

            // северо-восток
            if (IsContainInSetRestrictedArea(i - 1, j + 1) && IsTarget(i - 1, j + 1))
                numFlagsAround++;

            // запад
            if (IsContainInSetRestrictedArea(i, j - 1) && IsTarget(i, j - 1))
                numFlagsAround++;

            // восток
            if (IsContainInSetRestrictedArea(i, j + 1) && IsTarget(i, j + 1))
                numFlagsAround++;

            // юго-восток
            if (IsContainInSetRestrictedArea(i + 1, j + 1) && IsTarget(i + 1, j + 1))
                numFlagsAround++;

            // юго-запад
            if (IsContainInSetRestrictedArea(i + 1, j - 1) && IsTarget(i + 1, j - 1))
                numFlagsAround++;

            // юг
            if (IsContainInSetRestrictedArea(i + 1, j) && IsTarget(i + 1, j))
                numFlagsAround++;

            return numFlagsAround;
        }

        public void ToExtinguishFires()
        {
            for (int i = 0; i < Rows; ++i)
                for (int j = 0; j < Colls; ++j)
                    Cells[i, j].IsBurning = false;
        }

        public void OpenAdjacentCellsRecursive(int i, int j)
        {
            Point coords = new Point(i, j);

            if (IsBurning(coords))
                return;
            
            // смотри на состояния ячеек
            switch (GetStateCell(coords))
            {
                case StateCell.State.Targed: return;
                case StateCell.State.Open: SetBurning(coords, true); return;
                case StateCell.State.Mined:
                    throw new IndexOutOfRangeException();
                    //IsHappenedBoom = true;
                    //MessageBox.Show("this should not be!");
                    //return;
                case StateCell.State.Closed:
                    ToShowCell(coords);
                    SetBurning(coords, true);

                    // здесь обрабатывается граничный случай, 
                    // когда мы рекурсивно открываем пустые ячейки и подходим к ячейкам, вокруг которых есть бомбы
                    if (GetNumberBombAround(coords) > 0)
                        return;

                    // иначе, рекурсивно открываем окружные ячейки
                    break;
                default: break;
            }

            // север
            if (IsContainInSetRestrictedArea(i - 1, j))
                OpenAdjacentCellsRecursive(i - 1, j);

            // северо-запад
            if (IsContainInSetRestrictedArea(i - 1, j - 1))
                OpenAdjacentCellsRecursive(i - 1, j - 1);

            // северо-восток
            if (IsContainInSetRestrictedArea(i - 1, j + 1))
                OpenAdjacentCellsRecursive(i - 1, j + 1);

            // запад
            if (IsContainInSetRestrictedArea(i, j - 1))
                OpenAdjacentCellsRecursive(i, j - 1);

            // восток
            if (IsContainInSetRestrictedArea(i, j + 1))
                OpenAdjacentCellsRecursive(i, j + 1);

            // юго-восток
            if (IsContainInSetRestrictedArea(i + 1, j + 1))
                OpenAdjacentCellsRecursive(i + 1, j + 1);

            // юго-запад
            if (IsContainInSetRestrictedArea(i + 1, j - 1))
                OpenAdjacentCellsRecursive(i + 1, j - 1);

            // юг
            if (IsContainInSetRestrictedArea(i + 1, j))
                OpenAdjacentCellsRecursive(i + 1, j);
        }


        public void OpenJustAdjacentCells(int i, int j, bool isFirstRun = false)
        {
            // открыть с возможностью взрыва
            if (IsHappenedBoom)
                return;

            // смотри на состояния ячеек
            switch (GetStateCell(i, j))
            {
                // рекурсивно открываем ячейки
                // в следующем случае, мы обрабатываем тот случай, коогда нужно рекурсивно открыть очевидные ячейки
                case StateCell.State.Open:
                    if (!isFirstRun)
                        return;
                      break;
                case StateCell.State.Targed:
                    return;
                case StateCell.State.Mined:
                    IsHappenedBoom = true;
                    Boom(new Point(i, j));
                    return;
                case StateCell.State.Closed:
                    ToShowCell(new Point(i - 1, j));
                    break;
                default: return;
            }

            // север
            if (IsContainInSetRestrictedArea(i - 1, j))
            {
                OpenJustAdjacentCells(i - 1, j);
            }

            // северо-запад
            if (IsContainInSetRestrictedArea(i - 1, j - 1))
            {
                OpenJustAdjacentCells(i - 1, j - 1);
            }

            // северо-восток
            if (IsContainInSetRestrictedArea(i - 1, j + 1))
            {
                OpenJustAdjacentCells(i - 1, j + 1);
            }

            // запад
            if (IsContainInSetRestrictedArea(i, j - 1))
            {
                OpenJustAdjacentCells(i, j - 1);
            }

            // восток
            if (IsContainInSetRestrictedArea(i, j + 1))
            {
                OpenJustAdjacentCells(i, j + 1);
            }

            // юго-восток
            if (IsContainInSetRestrictedArea(i + 1, j + 1))
            {
                OpenJustAdjacentCells(i + 1, j + 1);
            }

            // юго-запад
            if (IsContainInSetRestrictedArea(i + 1, j - 1))
            {
                OpenJustAdjacentCells(i + 1, j - 1);
            }

            // юг
            if (IsContainInSetRestrictedArea(i + 1, j))
            {
                OpenJustAdjacentCells(i + 1, j);
            }
        }

        #endregion

        #region communication with form
        private void ToShowCell(Point coords)
        {
            if (notificationAboutDisplayShowingCell != null)
                notificationAboutDisplayShowingCell(this, new CoordsEventArgs(coords));
        }

        private void Boom(Point coords)
        {
            if (notificationAboutExplosion != null)
                notificationAboutExplosion(this, new CoordsEventArgs(coords));
        }
        #endregion

        #endregion
    }
}
