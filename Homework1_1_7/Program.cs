using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1_1_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int oldWoman;
            int waitingOneMan = 10;
            int waitingFull;
            int waitingHour;
            int waitingMinute;
            int convertTimeValue=60;


            Console.Write("Введите количество старушек перед Вами в очереди: ");
            oldWoman = Convert.ToInt32 (Console.ReadLine ());
            waitingFull = oldWoman * waitingOneMan;
            waitingHour = waitingFull / convertTimeValue;
            waitingMinute = waitingFull % convertTimeValue;
            Console.WriteLine("Вам осталось ждать в очереди " + waitingHour + " ч " + waitingMinute + " минут.");
        }
    }
}