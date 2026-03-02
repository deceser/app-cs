using System.Text;
Console.OutputEncoding = Encoding.UTF8;
Console.InputEncoding = Encoding.UTF8;

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
            field[8, j] = "x";
        }

        for (int i = 5; i <= 7; i++)
        {
            field[i, 7] = "x";
        }

        field[2, 2] = "x";
        field[4, 5] = "x";

        for (int i = 0; i < size; i++)
        {
            Console.Write((size - i).ToString().PadLeft(2) + " "); 
            for (int j = 0; j < size; j++)
            {
                Console.Write(field[i, j] + " ");
                if (field[i, j] == "x") shipCells++;
            }
            Console.WriteLine();
        }

        Console.Write("   ");
        foreach (char c in letters)
        {
            Console.Write(c + " ");
        }
        Console.WriteLine();

        Console.WriteLine($"Кількість клітинок з кораблями: {shipCells}");