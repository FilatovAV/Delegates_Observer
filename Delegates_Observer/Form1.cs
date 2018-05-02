using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delegates_Observer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Source s = new Source();
            Observer1 o1 = new Observer1();
            Observer2 o2 = new Observer2();
            Source.MyDelegate d1 = new Source.MyDelegate(o1.Do);
            s.Add(d1);
            s.Add(o2.Do);
            s.Run();
            s.Remove(o1.Do);
            s.Run();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
