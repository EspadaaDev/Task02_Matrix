using System;
using MatrixLib;

namespace Task02_Matrix
{
    class Program
    {
        static void Main()
        {
            // Fields
            int height;
            int lenght;
            string textField;

            // Set height
            SetMassHeight:
            Console.Write("Enter the height of the matrix: ");
            textField = Console.ReadLine();
            while (!int.TryParse(textField, out height))
            {
                Console.WriteLine("Error value!");

                Console.Write("Enter the height of the matrix: ");
                textField = Console.ReadLine();
            }
            if (height > 100 || height < 0)
            {
                Console.WriteLine("Error! Min. value - 0, max. value - 100.");
                goto SetMassHeight;
            }

            // Set lenght
            SetMassLenght:
            Console.Write("Enter the lenght of the matrix: ");
            textField = Console.ReadLine();
            while (!int.TryParse(textField, out lenght))
            {
                Console.WriteLine("Error value!");

                Console.Write("Enter the lenght of the matrix: ");
                textField = Console.ReadLine();
            }
            if (lenght > 100 || lenght < 0)
            {
                Console.WriteLine("Error! Min. value - 0, max. value - 100.");
                goto SetMassLenght;
            }

            SquareMatrix sqMatrix = new SquareMatrix(height, lenght);

            Console.WriteLine("\nMatrix:\n" + sqMatrix.ShowMatrix());
            Console.WriteLine("Trace: " + sqMatrix.GetTrace());
            Console.WriteLine("\nSnake output:\n" + sqMatrix.GetMatrixSnake());
        }
    }
}
