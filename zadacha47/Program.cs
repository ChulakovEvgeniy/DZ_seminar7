// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
int InNumber(string nameSpace)
{
    System.Console.Write(nameSpace);
    int num = int.Parse(Console.ReadLine());
    return num;
}

void PrintArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}
void FillArray(double[,] matr, int min, int max)
{
    Random rand = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = Math.Round((rand.Next(min, max) + rand.NextDouble()),2);
        }
    }
}
Console.Clear();
int rows = InNumber("Введите количество строк");
int columns = InNumber("Введите количнство столбцов");
double[,] array = new double[rows,columns];
FillArray(array, 1, 10);
PrintArray(array);