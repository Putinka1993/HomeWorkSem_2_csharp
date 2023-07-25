var week = new Dictionary<int, string>()
{
    { 1, "Monday" }, { 2, "Tuesday" }, { 3, "Wednesday" }, { 4, "Thursday" }, 
    { 5,  "Friday" }, { 6, "Saturday" }, { 7, "Sunday" }
};

Console.WriteLine("Enter number the day of the week");
int dayNum = int.Parse(Console.ReadLine());

if (dayNum >= 1 && dayNum <= 7)
{
    Console.WriteLine($"Your day of the week - {week[dayNum]}");
}
else Console.WriteLine("Invalid number, the range of the number must be at least 1 and at most 7");
