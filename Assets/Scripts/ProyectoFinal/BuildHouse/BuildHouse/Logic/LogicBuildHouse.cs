using System.Collections.Generic;

namespace CreateHouse.Logic
{
    public class LogicBuildHouse : ILogicBuildHouse
    {
        private const int VALID = 255;
        private const int ROW = 256;
        private const int COL = 256;
        private const int MYZERO = -128;

        public List<int> TraverseRow(int[,] arrayHouse, int row)
        {
            List<int> positions = new List<int>();
            int length = 0;
            int aux = 0;

            bool startValid = false;

            for (int j = 0; j < COL; j++)
            {

                if (arrayHouse[row, j] == VALID)
                {
                    if (!startValid)
                    {
                        aux = MYZERO + j;
                    }
                    startValid = true;
                    length++;
                }
                else
                {
                    if (startValid)
                    {
                        if (length >= 1)
                        {
                            positions.Add(MYZERO + row);
                            positions.Add(aux);
                            positions.Add(length);

                        }
                        startValid = false;

                        length = 0;
                        aux = 0;
                    }
                }

            }
            return positions;
        }


        public List<int> TraverseCol(int[,] arrayHouse, int col)
        {
            List<int> positions = new List<int>();
            int length = 0;
            int aux = 0;

            bool startValid = false;


            for (int i = 0; i < ROW; i++)
            {

                if (arrayHouse[i, col] == VALID)
                {
                    if (!startValid)
                    {
                        aux = MYZERO + i;
                    }
                    startValid = true;
                    length++;
                }
                else
                {
                    if (startValid)
                    {
                        if (length >= 1)
                        {
                            positions.Add(MYZERO + col);
                            positions.Add(aux);
                            positions.Add(length);

                        }
                        startValid = false;

                        length = 0;
                        aux = 0;
                    }
                }

            }
            return positions;
        }
    }
}