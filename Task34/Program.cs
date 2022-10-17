// Задача 34: 
// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

using static System.Console;
Clear();
WriteLine("Введите размер массива");
int size = Convert.ToInt32(ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
WriteLine("Случайный массив: ");
PrintArray(numbers);
int count = 0;

for (int z = 0; z < numbers.Length; z++)
if (numbers[z] % 2 == 0)
count++;

WriteLine($"Количество чётных чисел: {numbers.Length}");

void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100,1000);
    }
}
void PrintArray(int[] numbers)
{
    Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
    {
        Write(numbers[i] + " ");
    }
    Write("]");
    WriteLine();
}