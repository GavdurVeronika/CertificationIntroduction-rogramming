// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N.
// Указание
// Использовать рекурсию. Не использовать цикл.
// Пример
// N=5 => 1 2 3 4 5

void Main()
{
int N = ReadInt("Введите число: ");
PrintNumbers(N);
}

void PrintNumbers(int number)
{
if(number < 1) return;
PrintNumbers(number - 1);
System.Console.Write(number + " ");
}

int ReadInt(string msg)
{
System.Console.Write(msg);
return Convert.ToInt32(Console.ReadLine());
}

Main();