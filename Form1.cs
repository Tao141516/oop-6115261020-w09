using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop_6115261020_w09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCaleulate_Click(object sender, EventArgs e)
        {
            double height = double.Parse(txtHeight.Text.ToString()) / 100;
            double weight = double.Parse(txtWeight.Text.ToString());
            double bmi = BM.calculate(weight, height);
            lblBMI.Text = bmi.ToString();
        }

        private void taxCalculate_Click(object sender, EventArgs e)
        {
            double salary = double.Parse(txtSalary.Text.ToString());
            double tax = Tax.getTax(salary * 12);
            this.lblTax.Text = tax.ToString();
        }
    }
}
