// See https://aka.ms/new-console-template for more information

Console.ForegroundColor = ConsoleColor.DarkRed;

string input;
int intInput;
bool isValid(int n)
{
    if (n > 0)
    {
        return true;
    } else
    {
        return false;
    }
}

bool isEven(int num)
{
    if ((num % 2) == 0) { return true; } else { return false;}
}

void calculate(int n)
{
    if (n == 1)
    {
        Console.WriteLine("Completed!");
    }

    else if(isEven(n))
    {
        n = n / 2;

        Console.WriteLine($"{n} ");

        calculate(n);

    } else
    {
        n = (n * 3) + 1;

        Console.WriteLine($"{n} ");

        calculate(n);
    }
}

Console.Write("Please enter an integer (greater than zero): ");

input = Console.ReadLine();

intInput = (int)Convert.ToInt64(input);

if (isValid(intInput)) {

    calculate(intInput);
} else
{
    Console.WriteLine("Input not valid!");

}