/*
Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
*/

int InputInt(string message)
{
    Console.Write($"{message} -> ");
    return Convert.ToInt32(Console.ReadLine());
}

int[] GettingArrayOfNumbers(int ammount)
{
    int[] array = new int[ammount];
    for (int i = 0; i < ammount; i++)
    {
        Console.Write("Введите число -> ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void OutputMassive(int[] array)
{ 
    foreach (int item in array)
    { 
        Console.Write($"{item}\t "); // \t - табуляция
    }
    Console.WriteLine();
}

int PositiveCounter(int[] array)
{
    int counter = 0;
    foreach(int num in array)
    {
        if (num > 0) counter++;
    }
    return counter;
}
int ammount = -1;    // Защита, от ввода отрицательного количества цифр
while (ammount < 0)
{
    ammount = InputInt("Введите количество цифр, которые будут вводиться");
}
int[] array = GettingArrayOfNumbers(ammount);
Console.Write("Массив введёных числе:  ");
OutputMassive(array);
Console.WriteLine($"Количество положительных чисел в массиве = {PositiveCounter(array)}");