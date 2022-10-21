// Напишите программу, которая принимает на вход три числа и проверяет, может
// ли существовать треугольник с сторонами такой длины.

Console.Clear();
Console.Write("Введите 1-ую сторону треугольника: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ую сторону треугольника: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 3-ю сторону треугольника: ");
int c = Convert.ToInt32(Console.ReadLine());
if (a + b > c && b + c > a && a + c > b)
Console.WriteLine("yes");
else
Console.WriteLine("no");
