using System;
class Program
{
    static void Main()
    {
        //エスケープシーケンス
        string s = @"\1,000";
        string t = @"\20,000";

        Console.WriteLine(s);
        Console.WriteLine(t);

    }
}