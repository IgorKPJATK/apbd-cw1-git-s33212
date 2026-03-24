class Calculator
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("--- Kalkulator ---");
        Console.Write("podaj liczbe: ");
        int a =Int32.Parse(Console.ReadLine());
        Console.Write("Dodawanie 6 i 7: " + Add(a,6) + '\n');
        Console.Write("Odejmowanie 6 i 7: " + Subtract(a,7) + '\n');
        Console.Write("Mnożenie 6 i 7: " + Multiply(a,7) + '\n');
        Console.Write("Dzielenie 6 i 7: " + Divide(a,7) + '\n');
    }
    
    static int Add(int a, int b)
    {
        //a niech bedzie tutaj komentarzyk
        return a + b;
    }
    
    static int Subtract(int a, int b)
    {
        return a - b;
    }
    
    static int Multiply(int a, int b)
    {
        return a * b;
    }

    static int Divide(int a, int b)
    {
        return a / b;
    }
}
