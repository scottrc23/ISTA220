using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyRate
{
    class Program
    {
        static void Main(string[] args)
        {
            (new Program()).run();
        }

        void run()
        {
            double dailyRate = (double)readDouble("Enter your daily rate: ");
            int noOfDays = readInt("Enter the number of days: ");
            //writeFee(calculateFee(dailyRate, noOfDays));
            double fee = (dailyRate * noOfDays);
            double totalfee = fee * 1.1;
            Console.WriteLine($"The fee is {totalfee }");
        }

        private void writeFee(double fee)
        {
            Console.WriteLine($"The consultant's fee is: {fee * 1.1}");
        }

        private double calculateFee(double dailyRate, int noOfDays)
        {
            return dailyRate * noOfDays;
        }

        private int readInt(string prompt)
        {
            Console.Write(prompt);
            string line = Console.ReadLine();
            return int.Parse(line);
        }

        private object readDouble(string prompt)
        {
                Console.Write(prompt);
                string line = Console.ReadLine();
                return double.Parse(line);

        }
    }
}
