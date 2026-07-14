public class Program
{
    static void Main(string[] args)
    {
        List<string> names = new List<string>()
        {
            "Raushan","Amit","Shubham","Saurabh","Nisha"
        };

        var results = names.Where(x=>(x.Contains("ra") || x.Contains("Ra")));
        foreach (var d in results)
        {
            Console.WriteLine(d);
        }
        Console.ReadLine();


    }
}