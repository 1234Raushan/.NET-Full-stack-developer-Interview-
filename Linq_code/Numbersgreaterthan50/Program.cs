public class Program
{
    static void Main(string[] args)
    {
        List<int> nums = new List<int>()
        {
            10,50,60,80,1000,2000,3000,400,60,70,90,80,89,67,74,88
        };

        var results = nums.Where(x => x > 50);
        foreach (var d in results)
        {
            Console.WriteLine(d);
        }
        Console.ReadLine();


    }
}