using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddAndSubtract
{
    public partial class Form1 : Form
    {
        private Size p = new Size();
        private Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
            timer1.Tick += new EventHandler(Count);
        }

        private void Count(object sender, EventArgs e)
        {
            int number = int.Parse(button1.Text);
            number--;
            if (number >= 0)
            {
                button1.Text = number.ToString();
            }
            else
            {
                for (int i = 0; i < 100; i++)
                {
                    p.Width = rand.Next(200);
                    p.Height = rand.Next(200);
                    //                    button1.Size = new Point(rand.Next(100), rand.Next(100));
                    button1.Size = p;
                    
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            
        }
    }
}
