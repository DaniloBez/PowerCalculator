internal class Program
{
    private static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Введiть число:");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("Введiть степiнь:");
            int power = int.Parse(Console.ReadLine());

            double result = Pow(number, power);
            Console.WriteLine($"{number} у степенi {power} = {result}");

            Console.WriteLine("Бажаєте продовжити? (y/n):");
            string continueInput = Console.ReadLine();

            if (continueInput.ToLower() == "n")
                break;
        }
    }

    /// <summary>
    /// Підносить число до цілого степеня.
    /// </summary>
    /// <param name="number">Основа — число, яке потрібно піднести до степеня.</param>
    /// <param name="power">Степінь, до якого підноситься число. Може бути додатнім, від'ємним або нульовим.</param>
    /// <returns>Результат піднесення числа до цілого степеня. Якщо степінь додатний — повертається результат множення, 
    /// якщо від'ємний — повертається обернене число, якщо степінь дорівнює 0 — повертається 1.</returns>
    static public double Pow(int number, int power)
    { 
        if (power == 0)
            return 1;

        double result = 1;
        int absPower = (power > 0) ? power : -power;

        for (int i = 0; i < absPower; i++)
            result *= number;

        if (power < 0)
            return 1 / result;

        return result;
    }
}