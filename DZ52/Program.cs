/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
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
            result[i, j] = random.Next(1, 9);
        }
    return result;
}

void decision(int[,] arr)
{
    double sum = 0;
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            sum += arr[i, j];
        }
    Console.Write($"{Math.Round((double)sum / arr.GetLength(1), 1)} ");
    sum =0;
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
int[,] arr = arrayPadding(arryaLine, arryaColumn);
printArray(arr);
decision(arr);


