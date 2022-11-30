class Program 
{
    static void Main()
    {
        int resultat;
        if (!int.TryParse(Console.ReadLine(), out resultat))
            Console.WriteLine("Skriv en siffra");
    }
    public static bool TryParse(string s, out int result)
    {
        
    }   
}