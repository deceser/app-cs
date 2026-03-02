using System;
class Program
{
    static void Main()
    {
        int size = 10; // (або якщо 10х10 викорстати метод  Console.Write((size - i).ToString().PadLeft(2) + " ");)
        string letters = "ABCDEFGHIJ"; // Букви для підпису стовпців знизу поля
        int shipCells = 0; // Лічильник клітинок з кораблями.

        // Крок 1: Створити двовимірний масив field розміром size x size
        string[,] field = new string[size, size];
        // Крок 2: Заповнити всі клітинки символом "~" (вода) — два вкладені цикли for
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                field[i, j] = "~"; // Заповнюємо кожну клітинку символом "~"
            }
        }

        // Крок 3: Розмістити горизонтальний корабель з 4 клітинок у рядку 2 (індекс 8) — цикл for по j від 1 до 4
        for (int j = 1; j <= 4; j++)
        {
            field[8, j] = "x"; 
        }

        // Крок 4: Розмістити вертикальний корабель з 3 клітинок у стовпці H (індекс 7) — цикл for по i від 2 до 4
        for (int i = 2; i <= 4; i++)
        {
            field[i, 7] = "x"; 
        }

        // Крок 5: Поставити два однопалубні кораблі вручну — два рядки field[i, j] = "x"
        field[1, 0] = "x"; 
        field[5, 5] = "x"; 

        // Крок 6: Вивести поле — два вкладені цикли for, нумерація рядків зліва від 10 до 1
        //         всередині рахувати shipCells якщо клітинка == "x"

        for (int i = 0; i < size; i++)
        {
            Console.Write((size - i).ToString().PadLeft(2) + " "); // Виводимо нумерацію
            for (int j = 0; j < size; j++)
            {
                Console.Write(field[i, j] + " "); // Виводимо вміст клітинки з пробілом
                if (field[i, j] == "x") 
                {
                    shipCells++; 
                }
            }
            Console.WriteLine();
        }
        // Крок 7: Вивести букви A–J знизу — foreach по рядку letters
        Console.Write("   "); 
        foreach (char letter in letters)
        {
            Console.Write(letter.ToString().PadLeft(1) + " "); // Виводимо позначення стовпців внизу поля
        }

        // Крок 8: Вивести підсумок — кількість клітинок з кораблями
        Console.WriteLine(); 
        Console.WriteLine($"Кількість клітинок з кораблями: {shipCells}"); 


    }
}