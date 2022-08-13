//Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

Console.Clear();
 Console.WriteLine();
Console.Write($"Введи количество элементов массива: ");
int numberElements = Convert.ToInt32(Console.ReadLine()); 

int RandomNumb(int numberElements, int min, int max)
  {
  int[] randomNumb = new int[numberElements];
  int sumElements = 0;
  Console.Write("Получившийся массив: ");
 Console.WriteLine();
    for (int i = 0; i <randomNumb.Length; i++ ){
      randomNumb[i] = new Random().Next(min, max);

      if (i % 2 != 1)
      {
        sumElements = sumElements + randomNumb[i];
      }
    }Console.Write ('[' + string.Join(", ",randomNumb)+ ']');
  return sumElements;
  } 
 
int randomNumb =  RandomNumb(numberElements, -100, 100);
 Console.WriteLine();
Console.WriteLine($"\nСумма элементов, стоящих на нечётных позициях:=="+randomNumb);
 Console.WriteLine();