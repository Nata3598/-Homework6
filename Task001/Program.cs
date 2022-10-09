// Задача 41: Пользователь вводит с клавиатуры число M, потом вводит M чисел ЧЕРЕЗ ENTER. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 5: 0, 7, 8, -2, -2 -> 2
// 5: 1, -7, 567, 89, 223 -> 4

void EnteringNumbers(int[] ArrayNum)
{
    for (int i = 0; i < ArrayNum.Length; i++)
    {
        Console.Write($"Введи {i+1} число: ");
        ArrayNum[i]= int.Parse(Console.ReadLine()!);
    }
}

int ArrayCounter(int[] ArrayNum)
{
    int count = 0;
    for (int i = 0; i < ArrayNum.Length; i++)
    {
        if(ArrayNum[i] > 0 ) 
        {
            count += 1; 
        }
    }
    return count;
}



Console.Write("Введите число M: ");
int m = int.Parse(Console.ReadLine()!);
int[] ArrayNum = new int[m];

EnteringNumbers(ArrayNum);
Console.WriteLine($"Введено чисел больше 0: {ArrayCounter(ArrayNum)} ");







