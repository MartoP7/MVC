using MyFirstMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMVC.Views
{
    public class Display
    {

        public double Amount { get; set; }
        public double Percent { get; set; }
        public double TipSum { get; set; }
        public double TotalSum { get; set; }

        public void Input()
        {
            Console.Write("Въведете сумата на сметката: ");
            double sum = double.Parse(Console.ReadLine());
            this.Amount = sum;
            Console.Write("Въведете процент: ");
            double percent = double.Parse(Console.ReadLine());
            this.Percent = percent;
        }
        public void Output()
        {
            Console.WriteLine($"Бакшишът за сервитьора е {this.TipSum}лв.");
            Console.WriteLine($"Сумата за плащане е {this.TotalSum}лв.");
        }
    }
}
