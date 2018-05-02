using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_Observer
{
    class Observer1
    {
        public void Do(object o)
        {
            //Console.WriteLine("Первый. Принял, что объект {0} побежал", o);
            Program.frm.textBox1.Text += $"\r\nПервый. Принял, что объект {o} побежал\r\n";
        }
    }
}
