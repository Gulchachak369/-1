// Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.

// а=25, b=5 -> да
// а=2, b=10 -> нет
// а=9, b=-35 -> да
// а=-3, b=9 -> нет

Console.Write("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA == numberB * numberB )
{
    Console.Write("Первое число является квадратом второго");
}
else
{ 
    Console.WriteLine("Первое число не является квадратом второго");    
}