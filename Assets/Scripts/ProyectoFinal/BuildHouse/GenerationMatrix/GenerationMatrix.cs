using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GeneratorMatrix
{
    public class GenerationMatrix : IGenerationMatrix
    {
        public int[,] GetMatrixRow(int[,] matrix)
        {
            int SIZEMATRIX = 256;
            bool foundValid = false;
            bool foundInvalidBetweenValid = false;
            int[,] returnMatrix = new int[SIZEMATRIX, SIZEMATRIX];

            for (int i = 0; i < SIZEMATRIX; i++)
            {
                foundValid = false;
                foundInvalidBetweenValid = false;
                for (int j = 0; j < SIZEMATRIX; j++)
                {

                    if (matrix[i, j] == 255)
                    {
                        if (foundInvalidBetweenValid)
                        {
                            if (matrix[i, j] == 255)
                            {

                                returnMatrix[j, i] = 255;
                            }
                            foundInvalidBetweenValid = false;
                            foundValid = false;

                        }
                        else
                            foundValid = true;
                    }
                    else
                    {

                        if (foundValid)
                        {
                            foundInvalidBetweenValid = true;
                        }
                        else
                        {
                            foundInvalidBetweenValid = false;
                        }

                    }
                }
            }

            return returnMatrix;
        }


        public int[,] GetMatrixCol(int[,] matrix)
        {
            int SIZEMATRIX = 256;
            bool foundValid = false;
            bool foundInvalidBetweenValid = false;
            int[,] returnMatrix = new int[SIZEMATRIX, SIZEMATRIX];

            for (int j = 0; j < SIZEMATRIX; j++)
            {
                foundValid = false;
                foundInvalidBetweenValid = false;

                for (int i = 0; i < SIZEMATRIX; i++)
                {
                    if (matrix[i, j] == 255)
                    {
                        if (foundInvalidBetweenValid)
                        {
                            if (matrix[i, j] == 255)
                            {
                                returnMatrix[j, i] = 255;
                            }
                            foundInvalidBetweenValid = false;
                            foundValid = false;
                        }
                        else
                            foundValid = true;
                    }
                    else
                    {

                        if (foundValid)
                        {
                            foundInvalidBetweenValid = true;
                        }
                        else
                        {
                            foundInvalidBetweenValid = false;
                        }

                    }
                }
            }
            return returnMatrix;
        }
    }
}
