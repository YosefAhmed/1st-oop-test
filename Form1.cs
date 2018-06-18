using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop_demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.DrawRectangle(Pens.Yellow, 20, 30, 50, 50);
        }*/
        private void button1_Click(object sender, EventArgs e)
        {
            //classname opjectname = new classname();
            Managr.bones = 500; //static field
            Managr m = new Managr()
            {
                ID = 1,
                Name = "Ahmed",
                City = "cairo",
                Salary = 1200
            };
            MessageBox.Show(m.Reportmanagr()); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Managr.bones = 500;

            int slry = int.Parse(textBox1.Text);
            Managr m = new Managr()
            {
                ID = 1,
                Name = "Ahmed",
                City = "cairo",
                Salary = slry
            };
                        MessageBox.Show(m.Reportmanagr()); 

        }

        private void button3_Click(object sender, EventArgs e)
        {
           // Animal A =new Animal; (class Animal mesh kamla 3ashan feha abstrakt)
            Animal A = new Lion()
            {ID=2015777,Name="Semba"};
            MessageBox.Show(A.Eat());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Ipayment P = new ATM();
            MessageBox.Show(P.calc(10, 9).ToString());
            MessageBox.Show(P.pay(P.calc(10,9)));
        }
    }
}
