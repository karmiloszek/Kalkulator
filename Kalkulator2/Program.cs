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