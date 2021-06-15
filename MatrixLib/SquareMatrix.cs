using System;

namespace MatrixLib
{
    public class SquareMatrix
    {
        // Fields
        int[,] matrix;

        // Class constuctor
        public SquareMatrix(int matrixHeight, int matrixLenght)
        {
            if (matrixHeight > 0 || matrixLenght > 0)
            {
                matrix = new int[matrixHeight, matrixLenght];
                FillMatrix();
            }
            else
            {
                matrix = new int[0, 0];
            }
        }

        public int GetTrace()
        {
            // Variables
            int traceOfMatrix = 0;
            int counter = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                traceOfMatrix += matrix[i, counter];
                counter++;
            }

            return traceOfMatrix;
        }

        // Show the Matrix
        public string ShowMatrix()
        {
            // Variables
            string temp = null;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int k = 0; k < matrix.GetLength(1); k++)
                {
                    temp += matrix[i, k] + " ";
                    if (matrix[i, k] != 100)
                    {
                        temp += " ";
                        if (Convert.ToDouble(matrix[i, k]) / 10d < 1d)
                        {
                            temp += " ";
                        }
                    }
                }
                temp += "\n";
            }
            return temp;
        }
        
        // Function, returns tring containing a sequence of elements of a snake matrix        
        public string GetMatrixSnake()
        {
            string strResult = null;
            int rotation = 0;
            int[,] tempMass = matrix;

            for (int L = 0, i = 0, k = 0; L < tempMass.Length; L++)
            {
                switch (rotation)
                {
                    // Go right
                    case 0:
                        if (tempMass[i, k] != -1)
                        {
                            strResult += tempMass[i, k] + ", ";
                            tempMass[i, k] = -1;
                            if (k < tempMass.GetLength(1) - 1)
                            {
                                k++;
                                break;
                            }
                            else
                            {
                                rotation++;
                                i++;
                                break;
                            }
                        }
                        else
                        {
                            rotation++;
                            i++;
                            k--;
                            L--;
                            break;
                        }

                    // Go down
                    case 1:
                        if (tempMass[i, k] != -1)
                        {
                            strResult += tempMass[i, k] + ", ";
                            tempMass[i, k] = -1;
                            if (i < tempMass.GetLength(0) - 1)
                            {
                                i++;
                                break;
                            }
                            else
                            {
                                rotation++;
                                k--;
                                break;
                            }
                        }
                        else
                        {
                            rotation++;
                            k--;
                            i--;
                            L--;
                            break;
                        }

                    // Go left
                    case 2:
                        if (tempMass[i, k] != -1)
                        {
                            strResult += tempMass[i, k] + ", ";
                            tempMass[i, k] = -1;
                            if (k > 0)
                            {
                                k--;
                                break;
                            }
                            else
                            {
                                rotation++;
                                i--;
                                break;
                            }
                        }
                        else
                        {
                            rotation++;
                            i--;
                            k++;
                            L--;
                            break;
                        }

                    // Go top
                    case 3:
                        if (tempMass[i, k] != -1)
                        {
                            strResult += tempMass[i, k] + ", ";
                            tempMass[i, k] = -1;
                            if (i > 0)
                            {
                                i--;
                                break;
                            }
                            else
                            {
                                rotation = 0;
                                k++;
                                L--;
                                break;
                            }
                        }
                        else
                        {
                            rotation = 0;
                            i++;
                            k++;
                            L--;
                            break;
                        }
                }

            }

            return strResult.Remove(strResult.Length - 2);
        }

        // Fill that Matrix
        private void FillMatrix()
        {
            // Variables
            Random rnd = new Random();

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int k = 0; k < matrix.GetLength(1); k++)
                {
                    matrix[i, k] = rnd.Next(0, 100);
                }
            }
        }
    }
}
