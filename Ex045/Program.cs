// 45

Console.Clear();
int[] array = {1, 2, 3, 4, 5};
int[] b = new int[array.Length];
for (int i =0; i< array.Length; i++)
    b[i] = array[i];

b[0] = -10;

Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
Console.WriteLine($"Скопированный массив: [{string.Join(", ", b)}]");
