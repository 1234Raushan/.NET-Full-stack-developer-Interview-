
public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public float Salary { get; set; }
}
public class Program
{
    static void Main(string[] args)
    {
        List<Employee> employees = new()
        {
            new Employee { Id=1, Name="Rahul", Salary=30000 },
            new Employee { Id=2, Name="Amit", Salary=70000 },
            new Employee { Id=3, Name="Rohit", Salary=90000 }
        };

        //var results = employees.Where(x=>x.Salary >30000);
        //foreach (var result in results)
        //{
        //    Console.WriteLine(result.Id +","+result.Name +","+result.Salary);
        //}

        var results = from emp in employees where emp.Salary>30000 select emp;
        foreach (var result in results)
        {
            Console.WriteLine(result.Id + "," + result.Name + "," + result.Salary);
        }
        Console.ReadLine();

    }
}