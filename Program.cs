
bool anyMore;
int numberChoice;
double number1, number2;

Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-GB");
do
{
    Console.WriteLine("===================================================");
    Console.WriteLine("Welcome to the calculater, Enter your option (1-4) ");
    Console.WriteLine("1. Add");
    Console.WriteLine("2. Sub");
    Console.WriteLine("3. Multiply");
    Console.WriteLine("4. Divide");
    Console.Write("Enter your option : ");
    string received = Console.ReadLine();

    while (!Int32.TryParse(received, out numberChoice) || numberChoice>4 || numberChoice<1)
    {
        Console.Write("Invalid input, Enter your option : ");
        received = Console.ReadLine();
    }
    
    Console.Write("Enter 1st No : ");
    received = Console.ReadLine();
    while (!Double.TryParse(received, out number1))
    {
        Console.Write("Invalid input, Enter 1st No : ");
        received = Console.ReadLine();
    }

    Console.Write("Enter 2nd No : ");
    received = Console.ReadLine();
    while (!Double.TryParse(received, out number2) || (number2 == 0 && numberChoice == 4))
    {
        Console.Write("Invalid input, Enter 2nd No : ");
        received = Console.ReadLine();
    }

    switch (numberChoice)
    {
        case 1:
            double add = number1 + number2;
            Console.WriteLine($"Add : {add:F2}");
            break;
        case 2:
            double sub = number1 - number2;
            Console.WriteLine($"Sub : {sub:F2}");
            break;
        case 3:
            double mult = number1 * number2;
            Console.WriteLine($"Multiply : {mult:F2}");
            break;
        case 4:
            double divi = number1 / number2;
            Console.WriteLine($"Divide : {divi:F2}");
            break;
        default:
            Console.WriteLine("Invalid input");
            break;
    }

    Console.Write("More numbers to calculate (Y/N) :");
    string choice = Console.ReadLine().ToUpper();
 
    if (choice.StartsWith("Y"))
        anyMore = true;
    else
        anyMore = false;

} while (anyMore);