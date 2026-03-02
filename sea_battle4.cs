using System;
 
class Program
{
    static void Main()
    {
        int size = 9; 
        string letters = "ABCDEFGHI"; 
        int shipCells = 0;
 
        string[,] field = new string[size, size];
 
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                field[i, j] = "~";
            }
        }
 
        for (int j = 1; j <= 4; j++)
        {
            field[7, j] = "x";
        }
 
        for (int i = 2; i <= 4; i++)
        {
            field[i, 7] = "x";
        }
 
        field[0, 0] = "x";
        field[5, 5] = "x";
 
        for (int i = 0; i < size; i++)
        {
            Console.Write((size - i).ToString().PadLeft(2) + " ");
 
            for (int j = 0; j < size; j++)
            {
                Console.Write(field[i, j] + " ");
 
                if (field[i, j] == "x")
                {
                    shipCells++;
                }
            }
            Console.WriteLine();
        }
 
        Console.Write("   ");
        foreach (char letter in letters)
        {
            Console.Write(letter + " ");
        }
 
        Console.WriteLine();
        Console.WriteLine("\nКількість клітинок з кораблями: " + shipCells);
    }
}