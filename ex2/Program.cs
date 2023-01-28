// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0




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


int[] arrayFillWithRandNumb(int massLength)
{
    int[] array = new int[massLength];
    Random rand = new Random();
    for (int i = 0; i < massLength; i++)
    {
        array[i] = rand.Next(-10, 11);
    }
    return array;
}


void printArray(int[] array)
{
    System.Console.WriteLine("Исходный массив: [ " + String.Join(", ", array) + " ]");
}


int sumOddPosElements(int[] array, int massLength)
{
    int result = 0;
    // Считаю сумму чисел относительно index'а
    for (int i = 1; i < massLength; i++)
    {
        if (i % 2 != 0)
        {
            result = result + array[i];
            i += 1;
        }
    }
    System.Console.WriteLine($"Сумма элементов на нечетных позициях равна: {result}");
    return result;
}



int massLength = textCheck("Введите длину массива: ");
int[] array = arrayFillWithRandNumb(massLength);
printArray(array);
sumOddPosElements(array, massLength);