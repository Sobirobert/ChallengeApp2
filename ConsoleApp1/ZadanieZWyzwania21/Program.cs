using ZadanieZWyzwania21;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Xml.Linq;

Console.WriteLine("Witamy w Programie UprzejmięDooszę do oceny Pracowników");
Console.WriteLine("========================================================");
Console.WriteLine();

var employee = new Employee("Adam", "Wick", 53);


while (true)
{
    Console.WriteLine("Podaj ocenę pracownika");
    var inPut = Console.ReadLine();
    if (inPut == "q")
    {
        break;
    }
    Console.WriteLine(@"Aby wyjść kliknij 'q', albo kontynuuj");

    try
    {
        employee.AddGrade(inPut);

    }
    catch (Exception e)
    {
        Console.WriteLine($"Exeption catched: {e.Message}");
    }
}

    var statistics = employee.GetStatisticsWhitForEach();
    Console.WriteLine($" Max {statistics.Max}");
    Console.WriteLine($" Min {statistics.Min}");
    Console.WriteLine($" Average {statistics.Average}");
