class Program 
{
    static void Main()
    {
        Console.WriteLine("Skriv ett heltal");
        Console.WriteLine(minTryParse());
    }

    public static bool minTryParse()
    {
        string numkanske = Console.ReadLine();
        try
        {
            int num = Int32.Parse(numkanske);
            return true;
        }
        catch
        {
            return false;
        }
    }
}