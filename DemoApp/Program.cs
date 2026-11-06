namespace DemoApp;

internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введіть ваше ім'я: ");
        string? userName = Console.ReadLine();

        Console.Write("Введіть ваш вік: ");
        if (int.TryParse(Console.ReadLine(), out int age))
        {
            Console.WriteLine($"Ім'я: {userName}, Вік: {age}");

            if (age >= 18)
            {
                Console.WriteLine("Статус: повнолітній (adult).");
            }
            else
            {
                Console.WriteLine("Статус: неповнолітній (underage).");
            }
        }
        else
        {
            Console.WriteLine($"Ім'я: {userName}");
            Console.WriteLine("Помилка: некоректно введено вік.");
        }
    }
}
