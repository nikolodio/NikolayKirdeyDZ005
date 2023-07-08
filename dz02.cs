// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
int[] GetArray(int size, int min, int max) // Метод создания массива
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(-10, 10);
    }

    return result;
}

int[] array = GetArray(10, 0, 10);

int sumNumber = 0;
for (int i = 1; i < array.Length; i = i + 2)
{
    sumNumber += array[i];
}

Console.WriteLine($"in massiv: [ {string.Join("; ",array)}] sum of elements in odd positions -> {sumNumber}");