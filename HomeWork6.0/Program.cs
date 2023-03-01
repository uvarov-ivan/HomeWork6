// Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int InputInt(string msg)
{
    System.Console.Write(msg + " > ");
    return Convert.ToInt32(Console.ReadLine());
}

int[] GenArray(int len)
{
    int[] result = new int[len];
    for (int i = 0; i < len; i++)
    {
        result[i] = InputInt($"Введите {i + 1}-й эллемент массива");
    }
    return result;
}

int CountingRealNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}, ");
    }
    System.Console.WriteLine();
}

void PrintArray2(int[] array)
{
    foreach (int item in array)
    {
        System.Console.Write($"{item}, ");
    }
    System.Console.WriteLine();
}

int size = InputInt("Введите длину массива");
int[] myArray = GenArray(size);
PrintArray(myArray);
PrintArray2(myArray);
System.Console.WriteLine($"В указанном массиве чисел больше нуля {CountingRealNumbers(myArray)}.");
