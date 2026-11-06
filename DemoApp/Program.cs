namespace DemoApp;

internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введіть ваше ім'я: ");
        string? userName = Console.ReadLine();

        Console.WriteLine($"Вітаю {userName}!");
    }
}
