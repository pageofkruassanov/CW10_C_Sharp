using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW10_C_Sharp
{
    internal class MyButton
    {
        public event Action MyClickButton;
        public string Color {  get; set; }

        public double Width { get; set; }
        public double Height { get; set; }

        public string Text { get; set; }

        public void ClickOnButton(bool isClick)
        {
            if(isClick)
            {
                MyClickButton?.Invoke();
            }
        }
    }
}
