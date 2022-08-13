// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2

Console.Clear();
Console.WriteLine($"В этом массиве:\n");
int[] numbers = new int[7];

void FillArray(int[] array, int min, int max)
{
  for (int i = 0; i<array.Length; i++ ){
    array[i] = new Random().Next(min, max);
  }
}

void WriteArray(int[] array)
{
    for (int i = 0; i<array.Length; i++ ){
    
  }
  Console.Write('['+string.Join(", ",array) + ']');
  Console.WriteLine();
}

int amounteven(int[] array){
    int even = 0;
    for (int i = 0; i<array.Length; i++ ){
    if (array[i] % 2 == 0)
    {
      even++;
    }
  }
  return even;
}

FillArray(numbers, 100, 1000);
WriteArray( numbers);
Console.WriteLine();

int even = amounteven(numbers);
Console.WriteLine($"количество чётных чисел равно: {even}");
Console.WriteLine();