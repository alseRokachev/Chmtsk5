// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


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
            if (number > 0)
            {
                break;
            }
        }
        System.Console.WriteLine("Некорректное число");
        System.Console.WriteLine();
    }
    return number;
}

int[] arrayFillRandomNumb(int lim, int leftRange, int rightRange)
{
    int[] array = new int[lim];
    Random rand = new Random();
    for (int i = 0; i < lim; i++)
    {
        array[i] = rand.Next(leftRange, rightRange + 1);
    }
    return array;
}

void printArray(int[] array)
{
    System.Console.WriteLine("Исходный массив: [ " + String.Join(", ", array) + " ]");
}

void checkEvenNumber(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count += 1;
        }
    }
    System.Console.WriteLine($"Кол-во четных чисел равно: {count}");
}




int arrayLength = textCheck("Введите длину массива: ");
int[] array = arrayFillRandomNumb(arrayLength, 100, 999);
printArray(array);
checkEvenNumber(array);