
using Biblioteka;

double PobierzLiczbe()
{
    if (!double.TryParse(Console.ReadLine(), out double input))
        throw new Exception("Podana wartość nie jest liczbą!\n");

    return input;
}

double Oblicz(double num1, double num2, char oper)
{
    switch (oper)
    {
        case '+':
            return num1 + num2;
        case '-':
            return num1 - num2;
        case '*':
            return num1 * num2;
        case '/':
            return num1 / num2;
        case '^':
            return Math.Pow(num1, num2);
        case '%':
            return num1 / 100 * num2;
        default:
            throw new Exception("Niepoprawna operacja!\n");
    }
}

Console.WriteLine("KALKULATOR\n");
for (; ; )
{
    try
    {
        Console.WriteLine("Wybierz opcję:\nA - kalkulator\nB-równanie kwadratowe");

        char opcja;
        try
        {
            opcja = char.ToUpper(Convert.ToChar(Console.ReadLine()));
            if (opcja == 'A')
            {
                Console.WriteLine("Podaj 1 liczbę:");
                double num1 = PobierzLiczbe();

                Console.WriteLine("Podaj operację.\nMożliwe operacje:\n'+' dodawanie,\n'-' odejmowanie,\n'*' mnożenie,\n'/' dzielenie,\n'^' potęgowanie,\n '%' procent liczby 1 z 2.");
                char operacja;
                try
                {
                    operacja = Convert.ToChar(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Niepoprawna operacja!");
                    Console.Clear();
                    continue;
                }

                Console.WriteLine("Podaj 2 liczbę:");
                double num2 = PobierzLiczbe();

                double wynik = Oblicz(num1, num2, operacja);

                Console.Clear();

                Console.WriteLine("KALKULATOR\n");
                Console.WriteLine(num1 + " " + operacja + " " + num2 + " = " + Math.Round(wynik, 2) + "\n");
            }
            else if (opcja == 'B')
            {
                
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Niepoprawna opcja!");
            continue;
        }
        
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}