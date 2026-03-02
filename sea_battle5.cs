using System;
    class Program{
        static void Main(){
            int size = 9;
            string letters = "ABCDEFGHI";
            
            int[] shipstart = { 1, 0 };
            int[] shipend = { 1, 3 };
            
            int[] shipstart2 = { 2, 2 };
            int[] shipend2 = { 4, 2 };
            
            int[] ship3 = { 6, 5 };
            int[] ship4 = { 0, 4 };
            
            int[] lettersstart = { 0, 8 };
            int[] lettersend = { 8, 8 };
            
            int[,] field = new int [size, size];
                for(int i = 0; i < field.GetLength(0) ; i++){
                    for(int j = 0; j < field.GetLength(1); j++){
                        if (i >= shipstart[0] && i <= shipend[0] && j >= shipstart[1] && j <= shipend[1]){
                            Console.Write("8 ");
                        }
                        else if (i >= shipstart2[0] && i <= shipend2[0] && j >= shipstart2[1] && j <= shipend2[1]){
                            Console.Write("H ");
                        }
                        else if (i == ship3[0] && j == ship3[1]){
                            Console.Write("@ ");
                        }
                        else if (i == ship4[0] && j == ship4[1]){
                            Console.Write("A ");
                        }
                        else if (i >= lettersstart[0] && i <= lettersend[0] && j >= lettersstart[1] && j <= lettersend[1]){
                            foreach (char letter in letters){
                                Console.Write(letter + " ");
                            }
                        }
                        
                        else {
                        Console.Write("~ ");
                        }
                    }
                Console.WriteLine(" ");
            }
            // Крок 1: Створити двовимірний масив field розміром size x size
 
            // Крок 2: Заповнити всі клітинки символом "~" (вода) — два вкладені цикли for
 
            // Крок 3: Розмістити горизонтальний корабель з 4 клітинок у рядку 2 (індекс 8) — цикл for по j від 1 до 4
 
            // Крок 4: Розмістити вертикальний корабель з 3 клітинок у стовпці H (індекс 7) — цикл for по i від 2 до 4
 
            // Крок 5: Поставити два однопалубні кораблі вручну — два рядки field[i, j] = "x"
 
            // Крок 6: Вивести поле — два вкладені цикли for, нумерація рядків зліва від 10 до 1
            //         всередині рахувати shipCells якщо клітинка == "x"
 
            // Крок 7: Вивести букви A–J знизу — foreach по рядку letters
 
            // Крок 8: Вивести підсумок — кількість клітинок з кораблями
        
    }
    }