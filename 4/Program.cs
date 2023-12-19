// Задайте двумерный массив
// из целых чисел. Напишите программу, которая удалит
// строку и столбец, на пересечении которых расположен
// наименьший элемент массива. Под удалением
// понимается создание нового двумерного массива без
// строки и столбца


using System.Globalization;

int[,] array = new int[6, 6];
int min = array[0, 0];
int minRow = 0;
int minCol = 0;


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

//Находим наименьший элекмент в массиве и его индекс
void MinElInMassive()
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i, j] < min)
      {
        minCol = array[i, j];
        minRow = i;
        minCol = j;
      }
    }
  }
}

//переносим элементы массива в новый массив

void CreateNewMassive()
{

  int[,] result = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
  int rowIndex = 0;
  int colIndex = 0;


  for (int i = 0; i < array.GetLength(0); i++)
  {
    if (i != minRow)
    {
      for (int j = 0; j < array.GetLength(1); j++)
      {
        if (j != minCol)
        {
          result[rowIndex, colIndex] = array[i, j];
          colIndex++;
        }
      }
      rowIndex++;
      colIndex = 0;
    }
  }
  for (int i = 0; i < result.GetLength(0); i++)
  {
    for (int j = 0; j < result.GetLength(1); j++)
    {
      System.Console.Write(result[i, j] + " ");
    }
    System.Console.WriteLine();
  }
}









CreateArray();
PrintArray();
MinElInMassive();
CreateNewMassive();



