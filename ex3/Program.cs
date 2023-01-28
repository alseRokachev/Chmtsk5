// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


int textCheck(string str)
{
    int number;
    string? text;
    while (true)
    {
        System.Console.Write(str);
        text = Console.ReadLine();
        if (int.TryParse(text, out number))
        {
            if (number > 1)
            {
                break;
            }
        }
        System.Console.WriteLine("Некорректное число");
        System.Console.WriteLine();
    }
    return number;
}

double[] arrayFillWithRandNumbs(int arrayLength)
{
    double[] array = new double[arrayLength];
    Random rand = new Random();
    for (int i = 0; i < arrayLength; i++)
    {
        array[i] = Math.Round(rand.Next(-100, 100) + rand.NextDouble(), 3);
    }
    return array;
}

void printArray(double[] array)
{
    System.Console.WriteLine("Исходный массив: [ " + String.Join(", ", array) + " ]");
}

double numberComparison(double[] array)
{
    double max = array[0];
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        if (array[i] < min)
        {
            min = array[i];
        }
    }

    double defMaxMin = max - min;
    System.Console.WriteLine($"Разность между максимальным и минимальным элементами массива, равна: {Math.Round(defMaxMin, 3)}");
    return defMaxMin;
}




int arrayLength = textCheck("Введите длину массива: ");
double[] array = arrayFillWithRandNumbs(arrayLength);
printArray(array);
numberComparison(array);