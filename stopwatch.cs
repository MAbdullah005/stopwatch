using System;
using System.Diagnostics;
namespace FundamentalOfC_
{
    class program
    {
        static void Main(string[] args)
        {
            Stopwatch watch= new Stopwatch();
            Console.WriteLine("Enter the timer of stop Watch");
            var time=(Console.ReadLine());
            var Timer=time.Split(":");
            int count = 0;
            

            int times= (Convert.ToInt32(Timer[0])*60*60+Convert.ToInt32(Timer[1])*60+Convert.ToInt32(Timer[2]));
            watch.Start();
            while(true)
            {
                count++; 
                
                Thread.Sleep(1000);
                Console.WriteLine(watch);
                if (count == times)
                {
                    Console.WriteLine("Stop Watch Timer is Complete Now .");

                    break;
                }
            
            }
            
        }
    }
}
