using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_Observer
{
    class Observer2
    {
        public void Do(object o)
        {
            //Console.WriteLine("Второй. Принял, что объект {0} побежал", o);
            Program.frm.textBox1.Text += $"\r\nВторой. Принял, что объект {o} побежал\r\n";
            
        }
    }
}
