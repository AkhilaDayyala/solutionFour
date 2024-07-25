using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project4
{
    internal class UnitDemo
    {
        public void unit()
        {
            int units;
            double amount = 0, surcharge = 0, netAmount = 0;

            // User input
            Console.WriteLine("Enter your units:");
            units = Convert.ToInt32(Console.ReadLine());

            // Calculate amount based on unit consumption
            if (units < 200)
            {
                amount = units * 1.20;
            }
            else if (units >= 200 && units < 400)
            {
                amount = units * 1.50;
            }
            else if (units >= 400 && units < 600)
            {
                amount = units * 1.80;
            }
            else if (units >= 600)
            {
                amount = units * 2.00;
            }

            // Print amount
            Console.WriteLine("Amount: " + amount);

            // Calculate surcharge
            if (amount > 400)
            {
                surcharge = (amount * 15 / 100) + 100;
            }

            // Print surcharge amount
            Console.WriteLine("Surcharge amount: " + surcharge);

            // Calculate net amount
            netAmount = amount + surcharge;

            // Print net amount
            Console.WriteLine("Net amount: " + netAmount);

        }
    }
}
