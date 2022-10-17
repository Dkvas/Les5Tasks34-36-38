// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

using static System.Console;
Clear();

WriteLine("Введите длину массива  ");
int size = Convert.ToInt32(ReadLine());
double[] number = new double[size];
FillArrayRandomNumbers(number);
WriteLine("Массив: ");
PrintArray(number);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int a = 0; a < number.Length; a++)
{
    if (number[a] > max)
        {
            max = number[a];
        }
    if (number[a] < min)
        {
            min = number[a];
        }
}

WriteLine($"Разница между максимальным и минимальным = {max - min}");

void FillArrayRandomNumbers(double[] number)
{
    for(int i = 0; i < number.Length; i++)
        {
            number[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        }
}
void PrintArray(double[] number)
{
    Write("[ ");
    for(int i = 0; i < number.Length; i++)
        {
            Write(number[i] + " ");
        }
    Write("]");
    WriteLine();
}