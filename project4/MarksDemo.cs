using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project4
{
    internal class MarksDemo
    {
        public void marks()
        {
            int maths;
            Console.WriteLine("enter your marks obtained in maths");
            maths = Convert.ToInt32(Console.ReadLine());
            int phy;
            Console.WriteLine("enter your marks obtained in phy");
            phy = Convert.ToInt32(Console.ReadLine());
            int chem;
            Console.WriteLine("enter your marks obtained in chem");
            chem = Convert.ToInt32(Console.ReadLine());
            if ((maths >= 65 && phy >= 55 && chem >= 50) && (maths + phy + chem >= 180 || maths + phy >= 140))
            {
                Console.WriteLine("your eligible");
            }
            else
            {
                Console.WriteLine("your not eligible");
            }
    }
    }
}
