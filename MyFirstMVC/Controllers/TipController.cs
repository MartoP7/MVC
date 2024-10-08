using MyFirstMVC.Models;
using MyFirstMVC.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMVC.Controllers
{
    public class TipController
    {
        Display display = new Display();
        Tip tip = new Tip();

        public TipController()
        {
            display.Input();

            tip.Amount = display.Amount;
            tip.Percent = display.Percent;
            display.TotalSum = tip.CalculateTotal();
            display.TipSum = tip.CalculateTip();

            display.Output();
        }
    }
}
