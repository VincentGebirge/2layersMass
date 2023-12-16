//Напишите программу, которая на вход
//принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание,
// что такого элемента нет.


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

System.Console.WriteLine("Введите количество строк в массиве");
int str = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов в массиве");
int col = Convert.ToInt32(Console.ReadLine());


void FindEl()
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (i == str && j == col)
      {
        System.Console.WriteLine(array[str, col]);
      }
      if (i != str && j != col)
      {
        System.Console.WriteLine("Такого элемента массиве внет");
      }

    }
    System.Console.WriteLine();
  }
}



CreateArray();
PrintArray();
FindEl();
