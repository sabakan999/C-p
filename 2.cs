using System;

enum Day
{
    Sun, Mon, Tue = 10,
    Wed, Thu, Fri = Sun,
    Sat
}

class Program
{
    static void Main()
    {
        Console.WriteLine((int)Day.Wed);
    }
}
