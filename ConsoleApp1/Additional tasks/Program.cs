using Additional_tasks;

List<int> intList = new List<int>();   


Console.WriteLine("Hello user");
Console.WriteLine("Choose option");
Console.WriteLine("Pess 1 to Add numbers");
Console.WriteLine("Pess 2 to Subtraction numbers");
Console.WriteLine("Pess 3 to Multiplication numbers");
Console.WriteLine("Pess 4 to Division numbers");
Console.WriteLine("To exit insert 'x' ");
Console.WriteLine("Choose option again.");

var userInPut = Console.ReadLine();
var numbers = new MathematicalOperation();


while (true)
{
    switch (userInPut)
    {
        case "1":
            Console.WriteLine("Enter first number");
            var number1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter secound number");
            var number2 = double.Parse(Console.ReadLine());
            numbers.AddOperation(number1, number2);
            break;

        case "2":
            Console.WriteLine("Enter first number");
            var number3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter secound number");
            var number4 = double.Parse(Console.ReadLine());
            numbers.SubtractionOperation(number3, number4);
            break;

        case "3":
            Console.WriteLine("Enter first number");
            var number5 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter secound number");
            var number6 = double.Parse(Console.ReadLine());
            numbers.MultiplicationOperation(number5, number6);
            break;
            
        case "4":
            Console.WriteLine("Enter first number");
            var number7 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter secound number");
            var number8 = double.Parse(Console.ReadLine());
            numbers.DivisionOperation(number7, number8);
            break;

        case "x":
            return;

        default:
            Console.WriteLine("Invalid operation");
            break;
    }
    Console.WriteLine("Select operation");
    userInPut = Console.ReadLine();

}

