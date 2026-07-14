public class Employees
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Salary { get; set; }
    public string Location { get; set; }
    public float Bonus { get; set; }
    public int DepartmentId { get; set; }
}
public class Departments
{
    public int DepartmentId { get; set; }
    public string DepartmentName { get; set; }
}

public class Program
{
    static void Main(string[] args)
    {
        
        List<Employees> employees = new()
        {
            new Employees{Id=1,Name="Ramesh",Salary=20000,Location="Mumbai",DepartmentId=1},
            new Employees{Id=2,Name="Raushan",Salary=80000 ,Location="Pune",DepartmentId=2},
            new Employees{Id=3,Name="Raushan",Salary=80000 ,Location="Pune",DepartmentId=3},
            new Employees{Id=4,Name="Amit",Salary=90000 ,Location="Delhi",DepartmentId=4},
            new Employees{Id=5,Name="Nisha",Salary=50000 ,Location="Gurugram",DepartmentId=5}
        };

        List<Departments> departments = new()
        {
            new Departments{DepartmentId=1,DepartmentName="IT"},
            new Departments{DepartmentId=2,DepartmentName="Trnas"},
            new Departments{DepartmentId=3,DepartmentName="QA"},
            new Departments{DepartmentId=4,DepartmentName="HR"},
            new Departments{DepartmentId=5,DepartmentName="Fin"},
            new Departments{DepartmentId=6,DepartmentName="Support"}
        };
        var results = from emp in employees
                      join dpt in departments
                      on emp.DepartmentId equals dpt.DepartmentId
                      select new
                      { emp.Name,
                      dpt.DepartmentName};

            foreach (var em in results)
            {
             Console.WriteLine(em.Name+" :"+em.DepartmentName);
            }
            Console.ReadLine();


    }
}