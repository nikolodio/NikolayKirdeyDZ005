// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] GetArray(int size, int min, int max) // Метод создания массива
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(100, 1000);
    }

    return result;
}

int evenNumber = 0;
int[] array = GetArray(10, 100, 1000);
for ( int i = 0; i < array.Length; i++)
{
    if(array[i] % 2 == 0)
    {
        evenNumber++;
    }
}

Console.WriteLine($"in massiv: [ {string.Join("; ",array)}] even number -> {evenNumber}");