// Задача 50. Напишите программу, которая на вход принимает элемент в двумерном массиве, 
// и возвращает его индексы первого найденого числа или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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

void SearchNumber(int[,] matr, int number, int i, int j)
{
    if (number == matr[i, j]) System.Console.WriteLine($"положение искомого числа в массиве:{i},{j}");
    else if (number != matr[i, j])
    {
        for (i = 0; i < matr.GetLength(0); i++)
        {
            for (j = 0; j < matr.GetLength(1); j++)
            {
                if (number == matr[i, j])
                {
                    System.Console.WriteLine($"положение искомого числа в массиве: {i},{j}");
                    return;
                }
            }
        }
        System.Console.WriteLine("такой цифры нет");
    }
}

Console.Clear();
int rows = InNumber("Введите количество строк");
int columns = InNumber("Введите количнство столбцов");
int[,] array = new int[rows, columns];
int chislo = InNumber("Введите число которое вы хотите найти в матрице: ");
FillArray(array, 5, 10);
PrintArray(array);
SearchNumber(array, chislo, 0, 0);
