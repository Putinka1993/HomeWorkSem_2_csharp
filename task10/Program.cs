
Console.WriteLine("Введите трехзначное число");
int inpDig = int.Parse(Console.ReadLine());

string digit = inpDig.ToString();

if (digit.Length == 3)
{
    Console.WriteLine($"вторая цифра из числа {inpDig} : {digit[1]}");
}
else Console.WriteLine("Некректное число");