string[] values = { "12.3", "45", "ABC", "11", "DEF" };

double total = 0;
string message = "";

foreach (var value in values)
{
    if (double.TryParse(value, out double number))
    {
        total += number;
    }
    else
    {
        message += value;
    }
}

Console.WriteLine($"Total: {total}");
Console.WriteLine($"Message: {message}");