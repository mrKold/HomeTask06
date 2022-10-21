// SНе используя рекурсию, введите перые N чисел Фибоничи. 
// Первые два числа Фибоначчи 0 и 1.

Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int a0 =0, a1 = 1;
for (int i = 0; i<n; i++)
{
    Console.Write($"{a0} ");
    int x = a0 + a1;
    a0 = a1;
    a1= x;
}
