using System;
using System.IO;

namespace MathLibrary
{
    public class MathOperations
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public double Divide(int a, int b)
        {
            if (b == 0)
            {
                LogError("嘗試除以零");
                return double.NaN;
            }

            return (double)a / b;
        }

        private void LogError(string message)
        {
            string logPath = "log.txt";
            string logMessage = $"{DateTime.Now}: {message}";

            try
            {
                // 追加模式寫入日誌
                File.AppendAllText(logPath, logMessage + Environment.NewLine);
            }
            catch (Exception ex)
            {
                // 日誌寫入失敗的情況處理
                Console.WriteLine($"日誌寫入失敗: {ex.Message}");
            }
        }
    }
}