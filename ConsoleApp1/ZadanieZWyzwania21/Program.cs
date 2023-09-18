using ZadanieZWyzwania21;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Xml.Linq;




Employee employee1 = new Employee("Robert", "Sam", 23);
Employee employee2 = new Employee("Marek", "Wick", 43);
Employee employee3 = new Employee("John", "Snow", 33);

employee1.AddGrade(2.2f);
employee1.AddGradeString("5");
employee1.AddGradeDouble(82);

employee2.AddGradeShort(2);
employee2.AddGradeString("22");
employee2.AddGrade(8);

employee3.AddGrade(22);
employee3.AddGrade(15);
employee3.AddGradeString("6");

var statistic1 = employee1.GetStatisticsWhitFor();
var statistic2 = employee2.GetStatisticsWhitForEach();  
var statistic3 = employee3.GetStatisticsWhitDoWhile();
var statistic4 = employee2.GetStatisticsWhitWhile();

Console.WriteLine($"Average: {statistic1.Average:N2}");
Console.WriteLine($"Max: {statistic1.Max}");
Console.WriteLine($"Min: {statistic1.Min}");

Console.WriteLine($"Average: {statistic2.Average:N2}");
Console.WriteLine($"Max: {statistic2.Max}");
Console.WriteLine($"Min: {statistic2.Min}");

Console.WriteLine($"Average: {statistic3.Average:N2}");
Console.WriteLine($"Max: {statistic3.Max}");
Console.WriteLine($"Min: {statistic3.Min}");

Console.WriteLine($"Average: {statistic4.Average:N2}");
Console.WriteLine($"Max: {statistic4.Max}");
Console.WriteLine($"Min: {statistic4.Min}");
