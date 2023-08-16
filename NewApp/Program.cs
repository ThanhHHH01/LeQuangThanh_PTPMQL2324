public class Program
{
    private static void Main(string[] args)
    {
        for(int i = 0; i < 10; i++)
        {
            if(i == 5) continue;
            System.Console.WriteLine("Vòng lặp thứ {0}", i);
        }
    }
}