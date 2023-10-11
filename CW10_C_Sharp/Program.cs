using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW10_C_Sharp
{
    internal class Program
    {
        public static void ClickOnButton()
        {
            Console.WriteLine($"Кнопка нажата {DateTime.Now.ToString()}");
        }
        static void Main(string[] args)
        {
            MyButton start = new MyButton() { Color = "White", Height = 5.5, Width = 10.5, Text = "START" };
            start.MyClickButton += ClickOnButton;
            start.ClickOnButton(true);
            Console.ReadLine();

        }
    }
}
