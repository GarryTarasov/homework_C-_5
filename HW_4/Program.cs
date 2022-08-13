// Задача 38: Задайте с клавиатуры массив вещественных (double) чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//Задать размер (int) массива с клавиатуры
//[3 7 22 2 78] -> 76

Console.Clear();
Console.WriteLine("Ввидите желаемое количество элиментов");
int Q = Convert.ToInt32(Console.ReadLine());
double[] arrayRealNumbers = new double[Q];
  for (int i = 0; i < arrayRealNumbers.Length; i++ )
  {
    arrayRealNumbers[i] = new Random().Next(1, Q+1);
    }
  Console.Write("В массиве :");
Console.Write('[' + string.Join(", ",arrayRealNumbers)+ ']');
double maxNumber = arrayRealNumbers[0];
double minNumber = arrayRealNumbers[0];

  for (int i = 1; i < arrayRealNumbers.Length; i++)
  {
    if (maxNumber < arrayRealNumbers[i])
    {
      maxNumber = arrayRealNumbers[i];
    }
        if (minNumber > arrayRealNumbers[i])
    {
      minNumber = arrayRealNumbers[i];
    }
  }

  double decision = maxNumber - minNumber;

  Console.WriteLine($"\nразница между между максимальным ({maxNumber}) и минимальным({minNumber}) элементами: {decision}");
