using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_Observer
{
    class Source
    {
        string str;
        static int i;

        MyDelegate functions;
        public delegate void MyDelegate(object o);
        public void Add(MyDelegate f)
        {
            functions += f;
        }
        public void Remove(MyDelegate f)
        {
            functions -= f;
        }
        public void Run()
        {
            //Console.WriteLine("RUNS!");
            Program.frm.listBox1.Items.Add("RUNS!\r\n");

            i += 1;

            str = "11111" + i;

            functions?.Invoke(this);
        }


        }
}
