internal class Program
{
    private static void Main(string[] args)
    {
        int a, b;
        do
        {
            Console.Write("Wprowadź liczbę a: ");
            a = int.Parse(Console.ReadLine());
            if (a<0)
            {
                Console.WriteLine("Liczba nie może być ujemna!");
            }
        } while (a <= 0);
        do
        {
            Console.Write("Wprowadź liczbę b: ");
            b = int.Parse(Console.ReadLine());
            if (b < 0)
            {
                Console.WriteLine("Liczba nie może być ujemna!");
            }
        } while (b <= 0);

        Console.Write($"NWD({a}, {b}) = {NWD(a, b)}");
    }
    /**********************************************
    nazwa funkcji: NWD
    opis funkcji: funkcja szuka największego wspólnego dzielnika z dwóch liczb
    parametry: a - przechowuje pierwszą wartość od obliczenia NWD
               b - przechowuje drugą wartość od obliczenia NWD
    zwracany typ i opis: wynik - wyznaczona wartość NWD 
    autor: Miłosz Kaczmarek
    ***********************************************/
    public static int NWD(int a, int b)
    {
        while (a != b)
        {
            if (a>b)
            {
                a = a - b;
            }
            else
            {
                b = b - a;
            }
        }
        int wynik = a;
        return wynik;
    }
}