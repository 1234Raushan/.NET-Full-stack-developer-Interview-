public class Program
{
    static void Main(string[] args)
    {
        List<string> names = new List<string>()
        {
            "Raushan","AMIT","Shubham","Saurabh","Nisha"
        };

        var results = names.Select(x => x.ToUpper());
        foreach (var d in results)
        {
            Console.WriteLine(d);
        }
        Console.ReadLine();


    }
}