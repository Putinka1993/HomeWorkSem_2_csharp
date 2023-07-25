
Console.WriteLine("Введите число");
int inpDig = int.Parse(Console.ReadLine());

string digit = inpDig.ToString();

if (digit.Length >= 3)
{
    Console.WriteLine($"Третья цифра из числа {inpDig} : {digit[2]}");
}
else Console.WriteLine("Третьего числа нет");