// Print the last symbol of three-digit number
string s = "";
bool corr = false;
int num = 0;

while (corr == false)
{
    Console.WriteLine("Enter a three-digit number: ");
    s = Console.ReadLine();
    if (s.Length > 0)
        if (s[0] == '-') num = 4;
        else num = 3;

    if (s.Length == num) corr = true;

    if (corr == true) Console.WriteLine("The third symbol is: " + s[num - 1]);
}

