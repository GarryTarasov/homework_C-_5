// Задача 35: Задайте одномерный массив из 123 случайных чисел. 
//Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
//Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
//[5, 18, 123, 6, 2] -> 1
//[1, 2, 3, 6, 2] -> 0
//[10, 11, 12, 13, 14] -> 5

Console.Clear();
Console.WriteLine($"В этом массиве из 123 случайных чисел:\n");
int[] array = new int[123];

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
    if (array[i] >=10&&array[i]<=99)
    {
      even++;
    }
  }
  return even;
}

FillArray(array, 1, 124);
WriteArray( array);
Console.WriteLine();

int even = amounteven(array);
Console.WriteLine($"количество элементов массива, значения которых лежат в отрезке [10,99], равно: {even}");
Console.WriteLine();