/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/

int consoleInput(string massage)
{
    int result = 0;
    while (true)
    {
        Console.WriteLine(massage);
        if (int.TryParse(Console.ReadLine(), out result))
        {
            return result;
        }
        else
        {
            Console.WriteLine("Ввели не число.");
        }
    }
}
int[,] arrayPadding(int line, int column)
{
    int[,] result = new int[line, column];
    Random random = new Random();
    for (int i = 0; i < line; i++)
        for (int j = 0; j < column; j++)
        {
            {
                result[i, j] = random.Next(0, 9);
            }
        }
    return result;
}
void index(int x, int y, int[,] arr)
{
    if (x < arr.GetLength(0) && y < arr.GetLength(1))
    {
        Console.Write($"Значение на позиции [{y},{x}] ровно {arr[x, y]}");
    }
    else
    {
        Console.Write($"[{x},{y}] такой позиции нет");
    }
}
void printArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
int arryaLine = consoleInput("Введите количество строк");
int arryaColumn = consoleInput("Введите количество столбцов");
int indexLine = consoleInput("Введите позицию строк");
int indexColumn = consoleInput("Введите позицию столбца");
int[,] arr = arrayPadding(arryaLine, arryaColumn);
printArray(arr);
index(indexColumn, indexLine, arr);
