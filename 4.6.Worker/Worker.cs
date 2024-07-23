using System;

namespace Worker
{

    public sealed class Worker
    {
        public int Rate;
        public int TotalHour;

        public Worker(int rate, int totalHour)
        {
            Rate = rate;
            TotalHour = totalHour;
        }

        public double CalculateSalary()
        {
            return Rate * TotalHour * 1.5; //1.5 - коэффициент
        }
    }
    public static class TopWorker
    {

        public static double CalculateSallaryWithBonus(this Worker worker)
        {
            return worker.CalculateSalary() * 2;
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Worker worker = new Worker(45, 210);


            double compensation;
            if (worker.Rate < 50 && worker.TotalHour > 200)
            {
                compensation = worker.CalculateSallaryWithBonus();
            }
            else
            {
                compensation = worker.CalculateSalary();
            }

            Console.WriteLine($"Compensation: {compensation}");
        }
    }
}
