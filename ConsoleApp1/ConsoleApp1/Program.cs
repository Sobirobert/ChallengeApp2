int[] someArray = new int[7] {1,4,2,8,11,3,0};
Console.WriteLine("Numbers before sort.");
List<int> intList = someArray.ToList();

foreach (int i in intList)
{
    Console.WriteLine(i);
}

List<int> sortList = intList.OrderBy(x =>x).ToList();


Console.WriteLine("Numbers after sort.");
foreach (int i in sortList)
{
    Console.WriteLine(i);
}
