﻿using System;
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

        private void button1_Click(object sender, EventArgs e)
        {
            //classname opjectname = new classname();

            Managr m = new Managr()
            {
                ID = 1,
                Name = "Ahmed",
                City = "cairo",
                Salary = 1200,
                bones = 10
            };
            MessageBox.Show(m.Reportmanagr()); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int slry = int.Parse(textBox1.Text);
            Managr m = new Managr()
            {
                ID = 1,
                Name = "Ahmed",
                City = "cairo",
                Salary = slry,
                bones = 10
            };
                        MessageBox.Show(m.Reportmanagr()); 

        }
    }
}
