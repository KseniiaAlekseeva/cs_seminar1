// Print all integer number in the range (-N, N)

Console.WriteLine("Enter an integer number: ");

int N = int.Parse(Console.ReadLine());
Console.WriteLine("!!! " + N);

int count = 0;
int currNum;

if (N > 0) currNum = -N;
else currNum = N;

Console.WriteLine("&& " + currNum);


while (count < Math.Abs(N) * 2 + 1)
{
    Console.Write(currNum + ", ");
    currNum = currNum + 1;
    count++;
}
