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
            for (int i = 0; i < group1.Length; i++)
            {
                group1[i] = new Tank("T-64БВ");
            }
            group1[1].Set_Armor(2);
            for (int i = 0; i < group2.Length; i++)
            {
                group2[i] = new Tank("T-64AK");
            }
            try
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("\t\t"+(i+1)+" битва");
                    if (group1[i] * group2[i])
                        point1++;
                    else
                        point2++;
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("\t\t"+"Рахунок");
            Console.WriteLine("\t\t  "+point1+":"+ point2);
            
        }
    }
}
