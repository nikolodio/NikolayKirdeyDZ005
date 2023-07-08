// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

// double[] GetArray(double size, double min, double max) // Метод создания массива
double[] GetArray(int size, int min, int max)
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().NextDouble() * 100;
    }
    return array;
}

double[] array = GetArray(5, 0, 10);
double res = 0;
double maxNumber = 0;
double minNumber = 0;
for (int i = 0; i < array.Length; i++)
{
    if (i > maxNumber)
    {
        maxNumber = array[i];
    }
    else
    {
        minNumber = array[i];
    }
    array[i] = Math.Round(array[i], 2);
    res = maxNumber - minNumber;
}
Console.WriteLine($"in massiv: [ {string.Join("; ", array)}] difference {Math.Round(maxNumber, 2)} and {Math.Round(minNumber, 2)} -> {Math.Round(res, 2)}");