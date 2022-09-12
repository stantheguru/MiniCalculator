using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using  Calculation;

namespace MiniCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        calculate cal = new calculate();

        private void button1_Click(object sender, EventArgs e)
        {
            
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            Type type_a = a.GetType();
            Type type_b = b.GetType();

            if (type_a.Equals(typeof(int)) & type_b.Equals(typeof(int)))
            {
                int sum = cal.Add(a, b);
                Result.Text = sum.ToString();
            }else
            {
                string erro = "Please enter whole numbers";
                error.Text = erro;
            }

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            int sub = cal.Sub(a, b);
            Result.Text = sub.ToString();
        }
    }
}
