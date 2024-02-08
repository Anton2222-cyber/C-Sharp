using System;
using MyClassLib;
using MyClassLib.WordOfTanks;
namespace DzAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            int point1 = 0, point2 = 0;
            System.Console.OutputEncoding = System.Text.Encoding.UTF8;
            Tank[] group1 = new Tank[5];
            Tank[] group2 = new Tank[5];
            for(int i=0;i<group1.Length;i++)
            {
                group1[i] = new Tank("T-64БВ");
            }

            for (int i = 0; i < group2.Length; i++)
            {
                group2[i] = new Tank("T-64AK");
            }
            for(int i=0; i<5;i++)
            {
                if (group1[i] * group2[i])
                    point1++;
                else
                    point2++;
            }
            Console.WriteLine(point1);
            Console.WriteLine(point2);
        }
    }
}
