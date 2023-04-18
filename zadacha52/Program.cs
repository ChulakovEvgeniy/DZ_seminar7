// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void PrintArray(int[,] matr)
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

void FillArray(int[,] matr, int min, int max)
{
    Random rand = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = rand.Next(min, max);
        }
    }
}

int InNumber(string nameSpace)
{
    System.Console.Write(nameSpace);
    int num = int.Parse(Console.ReadLine());
    return num;
}

void ArifSumInColumns(int[,] matr)
{
    double sum = 0;
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            sum += matr[i,j];
        }
        double arif = sum/matr.GetLength(1);
        Console.WriteLine($"{j+1} столбец = {arif}");
        sum = 0;
    }
}

Console.Clear();
int rows = InNumber("Введите количество строк: ");
int columns = InNumber("Введите количнство столбцов: ");
int[,] array = new int[rows, columns];
FillArray(array, 5, 10);
PrintArray(array);
System.Console.WriteLine();
ArifSumInColumns(array);