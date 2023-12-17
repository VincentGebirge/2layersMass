//Задайте двумерный массив. Напишите
// программу, которая поменяет местами первую и
// последнюю строку массива.


using System.Globalization;

int[,] array = new int[3, 3];

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

void ChangeArray()
{
  for (int i = 0; i < array.GetLength(1); i++)
  {
    int temp = array[array.GetLength(1) - 1, i];
    array[array.GetLength(1) - 1, i] = array[0, i];
    array[0, i] = temp;
  }

  Console.WriteLine("Измененный массив: ");
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
  }
}




CreateArray();
PrintArray();
ChangeArray();

