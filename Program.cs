// Задача 47. Задайте двумерный массив размером m×n,
//  заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

void PrintArray2D(double[,] massive)
{
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            Console.Write($"{massive[i,j]}\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
void FillArray2D(double[,] massive)
{
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            massive[i, j] = new Random().Next(-99, 99) / 10.0;
        }
    }
}
int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
int rows = GetInput("Введите количество столбцов m: ");
int colums = GetInput("Введите количество строк  n: ");
double[,] massive = new double[rows, colums];
FillArray2D(massive);
PrintArray2D(massive);





 

