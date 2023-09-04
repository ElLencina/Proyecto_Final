namespace LengthHouse
{
    public class SizeHouse : ISizeHouse
    {
        public int GetSizeMatrixRow(int[,] array)
        {
            int VALID = 255;
            int SIZEMATRIX = 256;
            /////el primero y el último indice de la matriz
            int MIN = 0;
            int MAX = SIZEMATRIX - 1;

            int min = 99999999;
            int max = 0;
            bool foundMin = false;
            bool foundMax = false;
            int row = 0;
            int col = 0;

            while (row < SIZEMATRIX && (!foundMin || !foundMax))
            {
                while (col < SIZEMATRIX && (!foundMin || !foundMax))
                {
                    if (array[row, col] == VALID)
                    {
                        if (col < min && !foundMin)
                        {
                            if (col == MIN)
                            {
                                foundMin = true;
                            }

                            min = col;
                        }

                        if (col > max && !foundMax)
                        {
                            if (col == MAX)
                            {
                                foundMax = true;
                            }

                            max = col;
                        }

                    }
                    col++;
                }
                col = 0;
                row++;
            }

            return (max - min) + 1;
        }

        public int GetSizeMatrixCol(int[,] array)
        {
            int VALID = 255;
            int SIZEMATRIX = 256;
            /////el primero y el último indice de la matriz
            int MIN = 0;
            int MAX = SIZEMATRIX - 1;

            int min = 99999999;
            int max = 0;
            bool foundMin = false;
            bool foundMax = false;
            int row = 0;
            int col = 0;


            while (col < SIZEMATRIX && (!foundMin || !foundMax))
            {
                while (row < SIZEMATRIX && (!foundMin || !foundMax))
                {
                    if (array[row, col] == VALID)
                    {
                        if (row < min && !foundMin)
                        {
                            if (row == MIN)
                            {
                                foundMin = true;
                            }
                            min = row;
                        }

                        if (row > max && !foundMax)
                        {
                            if (row == MAX)
                            {
                                foundMax = true;
                            }

                            max = row;
                        }
                    }
                    row++;
                }
                row = 0;
                col++;
            }

            return (max - min) + 1;
        }
    }
}

