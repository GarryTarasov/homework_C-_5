// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2

Console.WriteLine($" Количество чётных чисел ");
int[] numbers = new int[10];

void FillArray(int[] array, int min, int max){
  for (int i = 0; i<array.Length; i++ ){
    array[i] = new Random().Next(min, max);
  }
}
void WriteArray(int[] array){
    for (int i = 0; i<array.Length; i++ ){
    Console.Write(array[i] + " ");
  }
  Console.WriteLine();
}
int QuantPositive(int[] array){
    int quant = 0;
    for (int i = 0; i<array.Length; i++ ){
    if (array[i] % 2 == 0)
    {
      quant++;
    }
  }
  return quant;
}

FillArray(numbers, 100, 1000);
Console.WriteLine(" В массиве [" + string.Join(", ",numbers) + "]");

int quant= QuantPositive(numbers);
Console.WriteLine($"==> {quant}");
//Console.WriteLine("вот, твой рандомный массив из восьми эллементов [" + string.Join(", ",array) + "]");