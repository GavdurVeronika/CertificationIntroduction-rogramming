// Урок 7. Рекурсия

// Задача 1: Задайте значения M и N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

void Main()
{
    int M = ReadInt("Input number M: ");
    int N = ReadInt("Input number N: ");
    PrintNumbersBetweenMN(N, M);
}
void PrintNumbersBetweenMN(int numberN, int numberM)
{
    if (numberN < numberM) return;

    PrintNumbersBetweenMN(numberN - 1, numberM);
    System.Console.Write(numberN + " ");
}

int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

Main();



