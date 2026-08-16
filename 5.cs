using System;
enum Season
{
    sp,su,au,wi
}
class Program
{
    static void Main()
    {
        var s = new char[] {'春','夏','秋','冬'};//型推論　var
        //char[] s = new char[]{'春','夏','秋','冬'}; 型推論なし


        
        Console.WriteLine(s[(int)Season.sp]);
    }
}