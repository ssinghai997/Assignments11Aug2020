using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalcLib;

namespace WindowsFormCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        CalcClass obj;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            obj = new CalcClass();
            obj.num1 = Convert.ToInt32(txtNum1.Text);
            obj.num2 = Convert.ToInt32(txtNum2.Text);
            lblAddRes.Text = obj.Add().ToString();
            //obj = new CalcLib();

            //obj.Radius = Convert.ToInt32(txtHeight.Text);
            //obj.Height = int.Parse(txtHeight.Text);
            //lblAreaOfCylinder.Text = obj.AreaOfCylinder().ToString() + "cms.";
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            obj = new CalcClass();
            obj.num1 = Convert.ToInt32(txtNum1.Text);
            obj.num2 = Convert.ToInt32(txtNum2.Text);
            lblSubRes.Text = obj.Sub().ToString();
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            obj = new CalcClass();
            obj.num1 = Convert.ToInt32(txtNum1.Text);
            obj.num2 = Convert.ToInt32(txtNum2.Text);
            lblMulRes.Text = obj.Mul().ToString();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            obj = new CalcClass();
            obj.num1 = Convert.ToInt32(txtNum1.Text);
            obj.num2 = Convert.ToInt32(txtNum2.Text);
            lblDivRes.Text = obj.Div().ToString();
        }
    }
}
