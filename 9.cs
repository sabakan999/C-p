using System;
class Program
{
    //3と3の倍数で出力するナベアツプログラム
    static void Main()
    {
        for(int i = 0;i <= 50;i++)
        {
            if(i % 3 == 0)
            {
                Console.WriteLine(i);
            }
            else
            if(i % 10 == 3)
            {
                Console.WriteLine(i);
            }
            else
            if(i / 10 == 3)
            {
                Console.WriteLine(i);
            }
        }
    }
}