using StackCalculator;

Console.WriteLine("I am a stack calculator.\nGive me an expression" +
    "written in reverse Polish notation, and I will calculate him.");
Console.Write("Enter your expression: ");
string? expression = Console.ReadLine();

while (expression == null || expression == "")
{
    Console.Write("The expression cannot be empty.\nTry again: ");
    expression = Console.ReadLine();
}

var stackOnArray = new StackOnArray();
var stackCalculator = new StackCalculator.StackCalculator(stackOnArray);
double result = 0;

result = stackCalculator.CalculateExpression(expression);
Console.WriteLine($"\nStack on array finished his calculations. Result is: {result}");

var stackOnList = new StackOnList();
stackCalculator = new StackCalculator.StackCalculator(stackOnList);

result = stackCalculator.CalculateExpression(expression);
Console.WriteLine($"\nStack on list finished his calculations. Result is: {result}");
Console.WriteLine("Au revoir!");

