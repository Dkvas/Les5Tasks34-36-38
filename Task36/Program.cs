// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

using static System.Console;
Clear();
WriteLine($"Введите размер массива: ");
int size = Convert.ToInt32(ReadLine()); 
int randomNumber =  RandomNumbers(size, 1, 10);

WriteLine($"  Сумма элементов нечётных позиций: {randomNumber}");



int RandomNumbers(int size, int min, int max)
  {
  int[] randomNumber = new int[size];
  int sumElements = 0;
  Write("Массив: ");

    for (int i = 0; i <randomNumber.Length; i++ ){
      randomNumber[i] = new Random().Next(min, max);

      Write(randomNumber[i] + " ");

      if (i % 2 != 1)
      {
        sumElements = sumElements + randomNumber[i];
      }
    }
  return sumElements;
  }