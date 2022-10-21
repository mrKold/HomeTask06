// Напишите программу, которая будет преобразовывать десятичное число в двоичное.


Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
string result = string.Empty;
while (n > 0)
{
int x = n % 2;
result = Convert.ToString(x) + result; //Переворот
n = n / 2;
}
Console.WriteLine(result);
