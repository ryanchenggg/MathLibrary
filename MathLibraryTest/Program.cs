using System;
using MathLibrary;

namespace MathLibraryTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("數學庫測試程式");
            Console.WriteLine("---------------");

            MathOperations math = new MathOperations();

            // 測試加法
            int sum = math.Add(10, 5);
            Console.WriteLine($"10 + 5 = {sum}");

            // 測試減法
            int difference = math.Subtract(10, 5);
            Console.WriteLine($"10 - 5 = {difference}");

            // 測試正常除法
            double quotient1 = math.Divide(10, 5);
            Console.WriteLine($"10 / 5 = {quotient1}");

            // 測試除以零
            double quotient2 = math.Divide(10, 0);
            Console.WriteLine($"10 / 0 = {quotient2} (應該是NaN)");

            Console.WriteLine("\n請檢查log.txt查看錯誤日誌");
            Console.WriteLine("\n按任意鍵結束...");
            Console.ReadKey();
        }
    }
}