/* Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

Console.Clear();

int m = Number("Введите количество строк массива >> ");
int n = Number("Введите количество колонок массива >> ");
int[,] matrix = new int[m, n];
FillArray(matrix);
PrintArray(matrix);
SrArColumn(matrix);

int Number(string message) 
{
    Console.Write(message);
    int result = int.Parse(Console.ReadLine());
    return result;
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(100);
        }
    }
}

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
     Console.WriteLine();
}

void SrArColumn(int[,] matr)
{
Console.Write("Среднее арифметической каждого столбца: ");
double sum = 0;
     for (int j = 0; j < matr.GetLength(1); j++)
    {
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            sum = sum + matr[i,j];
        }
        double srar = sum / matr.GetLength(0);
        Console.Write($"{Math.Round(srar, 2)}; ");
        sum = 0;
    }
    Console.Write("\b\b.");
}
