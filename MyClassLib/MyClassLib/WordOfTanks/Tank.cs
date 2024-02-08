using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLib.WordOfTanks
{
    public class Tank
    {
        string name;
        int ammunition;
        int armor;
        int maneuverabulity;
        public Tank(string name)
        {
            this.name = name;
            ammunition = (new Random()).Next(3, 101);
            armor = (new Random()).Next(3, 101);
            maneuverabulity= (new Random()).Next(3, 101);
        }
        public void Set_Name(string name)
        {
            this.name = name;
        }
        public void Set_Ammunition(int ammunition)
        {
            this.ammunition = ammunition;
        }
        public void Set_Armor(int armor)
        {
            this.armor = armor;
        }
        public void Set_Maneuverabulityr(int maneuverabulity)
        {
            this.maneuverabulity = maneuverabulity;
        }
        public void Show()
        {
            Console.WriteLine(name + " Броня: " + armor + " Боєприпаси: " + ammunition + " Маневренiсть " + maneuverabulity);
        }
        public static bool operator *(Tank t1,Tank t2)
        {
            t1.Show();
            t2.Show();
            System.Threading.Thread.Sleep(2000);
            Console.Clear();
            t1.armor -= t2.ammunition;
            t2.armor -= t1.ammunition;
            t1.armor += (new Random()).Next(0, t1.maneuverabulity);
            t2.armor += (new Random()).Next(0, t2.maneuverabulity);
            Console.WriteLine("\t\tВиграв:");
            if (t1.armor > t2.armor)
            {
                Console.WriteLine("\t\t"+t1.name);
                System.Threading.Thread.Sleep(2000);
                Console.Clear();
                return true;
            }
            Console.WriteLine("\t\t" + t2.name);
            System.Threading.Thread.Sleep(2000);
            Console.Clear();
            return false;
        }

    }
}
