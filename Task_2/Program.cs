// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int SummNumber (int a)
{
    int number = Math.Abs(a);
    int result = 0;
    while (number>1)
    { 
      result = result+number%10;
      number = number/10;
    }
    return result;
}

try
{
    Console.Write("Введите число : ");
    int a = int.Parse(Console.ReadLine());
    int result = SummNumber(a);
    Console.WriteLine($"Cумма цифр в чилсле {a} = {result}");
}
catch (Exception ex)
{
    Console.WriteLine($"Входное значение имеет неверный формат. Ошибка: {ex.Message}");
}