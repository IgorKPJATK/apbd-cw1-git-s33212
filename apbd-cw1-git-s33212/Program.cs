class Calculator
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- Kalkulator ---");
        Console.Write("Dodawanie 6 i 7: " + Add(7,6));
    }
    
    static int Add(int a, int b)
    {
        return a + b;
    }
}