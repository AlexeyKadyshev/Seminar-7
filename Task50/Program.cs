/* Задача 50. Напишите программу, которая на вход принимает элемент 
в двумерном массиве, и возвращает его индексы первого найденого числа 
или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */

Console.Clear();

int m = Number("Введите количество строк массива >> ");
int n = Number("Введите количество колонок массива >> ");
int[,] matrix = new int[m, n];
FillArray(matrix);
PrintArray(matrix);
PrintNum(matrix);

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
}

void PrintNum(int[,] matr)
{
    Console.Write("Введите искомое число >> ");
    int number = int.Parse(Console.ReadLine());
    bool index = false;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matr [i,j] == number)
            {
                Console.WriteLine($"Искомому числу соответствует элемент массива с индексом {i}, {j} ");
                index = true;
                goto Found;
            }
        } 
    }
    if (index == false)
    {
        Console.Write($"{number} -> такого числа в массиве нет");
    }
    Found:
    Console.WriteLine();
}   
  