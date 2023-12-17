// Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с
// наименьшей суммой элементов.

using System.Globalization;

int[,] array = new int[6, 6];

void CreateArray()
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(1, 10);
    }
  }
}

void PrintArray()
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      System.Console.Write(array[i, j] + " ");
    }
    System.Console.WriteLine();
  }
  System.Console.WriteLine();
}


void MathSumOfNumbsAtLine()
{
  int[] sumArr = new int[array.GetLength(0)];
  Console.WriteLine($"Сумма по строке:");
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      sumArr[i] += array[i, j];
    }
    Console.WriteLine($"Строка {i + 1} сумма = {sumArr[i]}");
  }
  int minSum = sumArr[0];
  int minLine = 1;
  for (int i = 0; i < array.GetLength(0); i++)
  {
    if (sumArr[i] < minSum)
    {
      minSum = sumArr[i];
      minLine = i + 1;
    }
  }
  Console.WriteLine($"Наименьшая сумма в {minLine} строке.");
}


CreateArray();
PrintArray();
MathSumOfNumbsAtLine();

