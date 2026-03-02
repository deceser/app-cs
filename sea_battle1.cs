int size = 9;
string letters = "ABCDEFGHI";
int shipCells = 0;

// Крок 1: Створити двовимірний масив field розміром size x size
char[,] field = new char[size, size];

// Крок 2: Заповнити всі клітинки символом "~" (вода) — два вкладені цикли for

for (int i = 0; i < size; i++)
    for (int j = 0; j < size; j++)
        field[i, j] = '~';

// Крок 3: Розмістити горизонтальний корабель з 4 клітинок у рядку 2 (індекс 8) — цикл for по j від 1 до 4
for (int j = 1; j < 5; j++)
    field[j, 1] = 'B';

// Крок 4: Розмістити вертикальний корабель з 3 клітинок у стовпці H (індекс 7) — цикл for по i від 2 до 4
for (int j = size - 2; j > size - 5; j--)
    field[size - 2, j] = 'M';

// Крок 5: Поставити два однопалубні кораблі вручну — два рядки field[i, j] = "x"
field[1, 4] = 'x';
field[3, 7] = 'x';

// Крок 6: Вивести поле — два вкладені цикли for, нумерація рядків зліва від 10 до 1
//         всередині рахувати shipCells якщо клітинка == "x"

for (int i = 0; i < size; i++)
{
    Console.Write($"{i + 1} ");
    for (int j = 0; j < size; j++)
    {
        Console.Write($" {field[i, j]} ");
    }
    Console.WriteLine();
}

// Крок 7: Вивести букви A–J знизу — foreach по рядку letters

Console.Write("  ");

foreach (var letter in letters)
    Console.Write($" {letter} ");

// Крок 8: Вивести підсумок — кількість клітинок з кораблями
for (int i = 0; i < size; i++)
    for (int j = 0; j < size; j++)
        if (field[i, j] != '~')
            shipCells++;

Console.WriteLine($"\nКоличество клеток с кораблями: {shipCells}");