class Calculator
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- Kalkulator ---");
        Console.Write("Dodawanie 6 i 7: " + Add(7,6) + '\n');
        Console.Write("Odejmowanie 6 i 7: " + Subtract(6,7) + '\n');
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
