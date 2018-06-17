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

        private void button1_Click(object sender, EventArgs e)
        {
            //classname opjectname = new classname();
            Employee emp = new Employee();
            emp.ID = 1;
            emp.Name = "Yousef";
            emp.City = "Cairo";
            emp.Salary = 1200;
            var rprt=emp.Report();
            MessageBox.Show(rprt); 
        }
    }
}
