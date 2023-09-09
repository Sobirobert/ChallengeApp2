using ConsoleApp1;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Xml.Linq;

Employee employee1 = new Employee("Robert", "Sam", 23);
Employee employee2 = new Employee("Marek", "Wick", 43);
Employee employee3 = new Employee("John", "Snow", 33);

employee1.AddScore(8);
employee1.AddScore(7);
employee1.AddScore(5);
employee1.AddScore(8);
employee1.AddScore(7);

employee2.AddScore(1);
employee2.AddScore(4);
employee2.AddScore(2);
employee2.AddScore(7);
employee2.AddScore(4);

employee3.AddScore(5);
employee3.AddScore(1);
employee3.AddScore(2);
employee3.AddScore(6);
employee3.AddScore(9);

List<Employee> users = new List<Employee>()
{
    employee1, employee2, employee3
};
var maxScore = users.Max(e =>e.pointsOfEmployee);

var maxScore2 = 0;
Employee userMaxScore = null;

foreach (var user in users)
{
    if(user.pointsOfEmployee > maxScore2)
    {
        maxScore2 = user.pointsOfEmployee;
        userMaxScore = user;
    }
}

Console.WriteLine($" Employee with max score is {userMaxScore.name}, {userMaxScore.lastName}, {userMaxScore.age} yers old, and his score is {maxScore2}");
Console.WriteLine($" {maxScore}");



