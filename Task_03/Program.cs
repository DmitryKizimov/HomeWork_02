//Запрашиваем произвольное число
Console.Write("Введите число, проверим кратно ли оно, одновременно 7 и 23: ");
int digit = Convert.ToInt32(Console.ReadLine());

int n1 = digit % 7;
int n2 = digit % 23;

//Console.WriteLine(n1);  // для отладки выводил значения, для работы программы эти строки не нужны
//Console.WriteLine(n2);

if (n1 == 0 && n2 == 0)
{
    Console.WriteLine("Да");
    return;
}

Console.WriteLine("Нет");