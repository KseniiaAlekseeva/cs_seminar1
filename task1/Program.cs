// If first number is a square of second?

Console.WriteLine("Enter first number: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Enter second number: ");
int b = int.Parse(Console.ReadLine());

Console.WriteLine("If first number is a square of second?");

if (a == b * b) Console.WriteLine("Yes");
else Console.WriteLine("No");