using System;


namespace Money
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double bitCoin = double.Parse(Console.ReadLine());
            double chinaYuan = double.Parse(Console.ReadLine());
            double commission = double.Parse(Console.ReadLine());
            int oneBitcoin = 1168; // to bgn
            double oneChinaYUan = 0.15; //to usd
            double oneUSD = 1.76; // to bgn
            double oneEUR = 1.95; // to bgn


            bitCoin = bitCoin * oneBitcoin;
            chinaYuan =oneChinaYUan * chinaYuan;
            chinaYuan = chinaYuan * oneUSD;
            bitCoin = bitCoin + chinaYuan;
            bitCoin = bitCoin / oneEUR;

            commission = bitCoin * commission / 100;
            double result = bitCoin - commission;
            Console.WriteLine(result);

        }
    }
}
