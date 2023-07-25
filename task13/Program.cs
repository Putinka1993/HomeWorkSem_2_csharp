
Console.WriteLine("Enter the number");
int inpDig = int.Parse(Console.ReadLine());

string digit = inpDig.ToString();

if (digit.Length >= 3)
{
    Console.WriteLine($"The third digit of {inpDig} : {digit[2]}");
}
else Console.WriteLine("There is no third digit");