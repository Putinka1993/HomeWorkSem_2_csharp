
Console.WriteLine("Enter a three-digit number");
int inpDig = int.Parse(Console.ReadLine());

string digit = inpDig.ToString();

if (digit.Length == 3)
{
    Console.WriteLine($"The second digit of {inpDig} : {digit[1]}");
}
else Console.WriteLine("Invalid number");