//Запрашиваем трехзначное число
Console.Write("Введите трехзначное число: ");
int digit = Convert.ToInt32(Console.ReadLine());
int firstdigit = digit / 100;
int temp = digit / 10;
int seconddigit = temp % 10;
int thirddigit = digit % 10;
if (firstdigit > 10)
{
    Console.WriteLine("Я же просил трехзначное число!"); // Проверка, что не более 3-х знаков
    return;
}

if (firstdigit == 0) // Проверка, что не менее 2-х знаков
{
    Console.WriteLine("Я же просил трехзначное число!");
    return;
}

Console.WriteLine(seconddigit);