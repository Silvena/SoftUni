using System;


namespace T8MetricConverter
{
    public class Program
    {

        public static void Main(string[] args)
        {


            var num = double.Parse(Console.ReadLine());
            var entryMetric = Console.ReadLine();
            var exitMetric = Console.ReadLine();
            var baseMetricValue = num;
            double finalMetric = baseMetricValue;

            if (entryMetric == "m")
            {
                baseMetricValue = baseMetricValue / 1;
            }
            if (entryMetric == "mm")
            {
                baseMetricValue = baseMetricValue / 1000;
            }
            else if (entryMetric == "cm")
            {
                baseMetricValue = baseMetricValue / 100;
            }
            else if (entryMetric == "mi")
            {
                baseMetricValue = baseMetricValue / 0.000621371192;
            }
            else if (entryMetric == "in")
            {
                baseMetricValue = baseMetricValue / 39.3700787;
            }
            else if (entryMetric == "km")
            {
                baseMetricValue = baseMetricValue / 0.001;
            }
            else if (entryMetric == "ft")
            {
                baseMetricValue = baseMetricValue / 3.2808399;
            }
            else if (entryMetric == "yd")
            {
                baseMetricValue = baseMetricValue / 1.0936133;
            }

            if (exitMetric == "m")
            {
                finalMetric = baseMetricValue * 1;
            }
            if (exitMetric == "mm")
            {
                finalMetric = baseMetricValue * 1000;
            }
            else if (exitMetric == "cm")
            {
                finalMetric = baseMetricValue * 100;
            }
            else if (exitMetric == "mi")
            {
                finalMetric = baseMetricValue * 0.000621371192;
            }
            else if (exitMetric == "in")
            {
                finalMetric = baseMetricValue * 39.3700787;
            }
            else if (exitMetric == "km")
            {
                finalMetric = baseMetricValue * 0.001;
            }
            else if (exitMetric == "ft")
            {
                finalMetric = baseMetricValue * 3.2808399;
            }
            else if (exitMetric == "yd")
            {
                finalMetric = baseMetricValue * 1.0936133;
            }
            Console.Write(finalMetric);
            Console.WriteLine(" " + exitMetric);

        }
    }

}
