

string[] names = new string[] { "name1", "name2", "name3" };

bool isValid;

string? nameNumberText;

int.TryParse("1.2", out var number);

Console.WriteLine(number);

do
{
    Console.Write("Choose a number between 1 and 3 (or type exit to exit): ");

    nameNumberText = Console.ReadLine();

    isValid = int.TryParse(nameNumberText, out int nameNumber);

    if (nameNumber >= 1 && nameNumber <= 3)
    {
        Console.WriteLine($"The name is {names[nameNumber - 1]}");
    }
    else if (nameNumberText != "exit" || nameNumber > 3 || nameNumber < 1 || !isValid)
    {
        Console.WriteLine("Please choose a valid number");
    }

} while (nameNumberText != "exit");

