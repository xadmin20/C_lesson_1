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