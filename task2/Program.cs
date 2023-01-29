// Print name of the day of the week by the specified number
bool corr = false;
int dayNumber;
string dayName = "";

while (corr == false)
{
    Console.WriteLine("Print the number of the day of the week (from 1 to 7): ");
    dayNumber = int.Parse(Console.ReadLine());
    if (dayNumber > 0 && dayNumber < 8)
    {
        corr = true;
        if (dayNumber == 1) dayName = "Monday";
        if (dayNumber == 2) dayName = "Tuesday";
        if (dayNumber == 3) dayName = "Wednesday";
        if (dayNumber == 4) dayName = "Thursday";
        if (dayNumber == 5) dayName = "Friday";
        if (dayNumber == 6) dayName = "Saturday";
        if (dayNumber == 7) dayName = "Sunday";
        Console.WriteLine(dayName);
    }
    else Console.WriteLine("Wrong number!");


}