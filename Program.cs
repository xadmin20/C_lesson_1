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