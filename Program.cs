// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Введите  2(два) числа ");
int x=int.Parse(Console.ReadLine());
int y=int.Parse(Console.ReadLine());
if (x>y) {
    Console.Write("Max = " +x);
}
else Console.Write("Max = " +y);
// ##############################################################################
// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
Console.Write("Введите 3(три) числа ");
int x=int.Parse(Console.ReadLine());
int y=int.Parse(Console.ReadLine());
int z=int.Parse(Console.ReadLine());
if (x > y)
{
    if (x > z)
    {
        Console.WriteLine("{0} - наибольшее число", x);
    }
    else
    {
        Console.WriteLine("{0} - наибольшее число", z);
    }
}
else
{
    if (y > z)
    {
        Console.WriteLine("{0} - наибольшее число", y);
    }
    else
    {
        Console.WriteLine("{0} - наибольшее число", z);
    }
}

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет
Console.Write("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());
if ((x % 2) == 0)
{
    Console.WriteLine("chentoe");
}
else
{
    Console.WriteLine("nechentoe");
}

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine());
for (int i = 2; i <= n; i += 2)
    Console.WriteLine(i);