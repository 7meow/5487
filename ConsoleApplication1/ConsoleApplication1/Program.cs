using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            // 顏色
            Console.ForegroundColor = ConsoleColor.Blue;

            // 輸入
            Console.Write("身高(公分):");
            string height = Console.ReadLine();
            Console.Write("體重(公斤):");
            string weight = Console.ReadLine();

            // 變數                  
            double BMI = double.Parse(weight) / ((double.Parse(height) / 100) * (double.Parse(height) / 100));

            // 計算
            Console.Write("BMI=" + BMI);

            // 判斷 BMI 
            if (BMI < 16.5)
                Console.WriteLine(" 免役 & 輕 ");

            else if (BMI >= 16.5 && BMI < 17)
                Console.WriteLine(" 替代役 & 輕 ");

            else if (BMI >= 17 && BMI < 18.5)
                Console.WriteLine(" 常備役 & 輕 ");

            else if (BMI >= 18.5 && BMI < 24)
                Console.WriteLine(" 常備役 & 正常 ");

            else if (BMI >= 24 && BMI < 27)
                Console.WriteLine(" 常備役 & 重 ");

            else if (BMI >= 27 && BMI < 30)
                Console.WriteLine(" 常備役 & 輕肥 ");

            else if (BMI >= 30 && BMI < 31)
                Console.WriteLine(" 常備役 & 中肥 ");

            else if (BMI >= 31 && BMI < 31.5)
                Console.WriteLine(" 替代役 & 中肥 ");

            else if (BMI >= 31.5 && BMI < 35)
                Console.WriteLine(" 免役 & 中肥 ");

            else if (BMI >= 35)
                Console.WriteLine(" 免役 & 重肥 ");

            // 結束
            Console.ReadLine();
        }
    }
}
