using Calculation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MiniCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Calc cal = new Calc();
        calculate cal = new calculate();

        private void button1_Click(object sender, EventArgs e)
        {
            string erro;
            try
            {
                int a = int.Parse(textBox1.Text);
                int b = int.Parse(textBox2.Text);
                Type type_a = a.GetType();
                Type type_b = b.GetType();

                if (type_a.Equals(typeof(int)) & type_b.Equals(typeof(int)))
                {
                    erro = "";
                    error.Text = erro;
                    int sub = cal.Sub(a, b);
                    Result.Text = sub.ToString();
                    int sum = cal.Add(a, b);
                    Result.Text = sum.ToString();
                }
                else
                {
                    erro = "Please enter whole numbers";
                    error.Text = erro;
                }
            }
            catch(Exception)
            {
                erro = "Please enter integers";
                error.Text = erro;
            }
                  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string erro;
            try
            {
                int a = int.Parse(textBox1.Text);
                int b = int.Parse(textBox2.Text);
                Type type_a = a.GetType();
                Type type_b = b.GetType();

                if (type_a.Equals(typeof(int)) & type_b.Equals(typeof(int)))
                {
                    erro = "";
                    error.Text = erro;
                    int sub = cal.Sub(a, b);
                    Result.Text = sub.ToString();
                }
                else
                {
                    erro = "Please enter whole numbers";
                    error.Text = erro;
                }
            }
            catch (Exception)
            {
                erro = "Please enter integers";
                error.Text = erro;
            }
            
        }
    }
}
