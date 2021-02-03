using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReloadOperator
{
    public partial class Form1 : Form
    {
        class Counter
        {
            public int Value { get; set; }

            public static Counter operator >(Counter c1, Counter c2)
            {
                return c1.Value > c2.Value ? c1 : c2;
            }
            public static Counter operator <(Counter c1, Counter c2)
            {
                return c1.Value < c2.Value ? c2 : c1;
            }
            public static Counter operator +(Counter c1, Counter c2)
            {
                return new Counter { Value = c1.Value + c2.Value };
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Counter sosiska1 = new Counter { Value = Convert.ToInt32(textBox1.Text) };
            Counter sosiska2 = new Counter { Value = Convert.ToInt32(textBox2.Text) };


            label1.Text = (sosiska1 > sosiska2).Value.ToString() ;



        }

        private void button2_Click(object sender, EventArgs e)
        {
            Counter sosiska1 = new Counter { Value = Convert.ToInt32(textBox1.Text) };
            Counter sosiska2 = new Counter { Value = Convert.ToInt32(textBox2.Text) };

            Counter sosiska_summa = sosiska1 + sosiska2;
            label1.Text = sosiska_summa.Value.ToString();

        }
    }
}
