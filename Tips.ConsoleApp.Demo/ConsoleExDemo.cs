using System;

namespace Tips.ConsoleApp.Demo
{
    static class ConsoleExDemo
    {
        public static void Timeout()
        {
            Console.WriteLine("以下、ConsoleEx.Timeout メソッドのデモをお送り致します。");
            Console.WriteLine();

            ConsoleEx.Timeout(milliseconds: 5000L);
            ConsoleEx.Timeout(TimeSpan.FromSeconds(722));
        }
    }
}
