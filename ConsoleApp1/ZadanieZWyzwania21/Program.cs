using ZadanieZWyzwania21;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Xml.Linq;




Employee employee1 = new Employee("Robert", "Sam", 23);
Employee employee2 = new Employee("Marek", "Wick", 43);
Employee employee3 = new Employee("John", "Snow", 33);

employee1.AddGrade(2);
employee1.AddGrade(5);
employee1.AddGrade(8);

var statistic = employee1.GetStatistics();

Console.WriteLine($"Average: {statistic.Average:N2}");
Console.WriteLine($"Max: {statistic.Max}");
Console.WriteLine($"Min: {statistic.Min}");