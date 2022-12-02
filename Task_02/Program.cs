//Запрашиваем произвольное число
Console.Write("Введите любое число: ");
int digit = Convert.ToInt32(Console.ReadLine());

int digit1 = digit % 10; // Раскладываем число на три цифры, начиная с последней
int temp1 = digit % 100;
int digit2 = temp1 / 10;
int temp2 = digit % 1000;
int digit3 = temp2 / 100;

if (temp2 < 100)
{
    Console.WriteLine("Третьей цифры нет");
    return;
}
Console.WriteLine(digit3);