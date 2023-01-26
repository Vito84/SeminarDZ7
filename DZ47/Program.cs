/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

int keyboardInput(string message)
{
    int result = 0;
    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число.");
        }
    }

    return result;
}

int[,] arrayPadding(int line, int column)
{
    int[,] result = new int[line, column];
    Random random = new Random();
    for (int i = 0; i < line; i++)
        for (int j = 0; j < column; j++)
        {
            {
                result[i, j] = random.Next(-10, 10);
            }
        }
    return result;
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

int arryaLine = keyboardInput("Введите количество строк");
int arryaColumn = keyboardInput("Введите количество столбцов");
int[,] arr = arrayPadding(arryaLine, arryaColumn);
printArray(arr);

