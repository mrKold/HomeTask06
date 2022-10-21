// Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


Console.Clear();
Console.WriteLine("Введите размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите массива: ");
int[] array = new int[n];
for (int i = 0; i < array.Length; i++)
array[i] = Convert.ToInt32(Console.ReadLine());
int result = 0;
for (int i = 0; i< array.Length; i++)
{
    if (array[i]> 0)
        result = result + 1;
}

Console.WriteLine($"[{string.Join(", ", array)}]");
Console.WriteLine($"Колличество чисел > 0: {result}");
