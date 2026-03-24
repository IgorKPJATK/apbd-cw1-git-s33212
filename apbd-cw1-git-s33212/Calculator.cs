class Calculator
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("--- Balbulator ---");
        Console.Write("podaj liczbe: ");
        int a =Int32.Parse(Console.ReadLine());
        Console.Write("podaj  drugą liczbe: ");
        int b =Int32.Parse(Console.ReadLine());
        Console.Write("Dodawanie " + a + " i " + b + ": " + Add(a,b) + '\n');
        Console.Write("Odejmowanie " + a + " i " + b + ": "  + Subtract(a,b) + '\n');
        Console.Write("Mnożenie " + a + " i " + b + ": "  + Multiply(a,b) + '\n');
        Console.Write("Dzielenie " + a + " i " + b + ": "  + Divide(a,b) + '\n');
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
