﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCong_Click(object sender, EventArgs e)
        {
            int a, b, kq;
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);
            Calculation cal = new Calculation(a, b);
            kq = cal.Execute("+");

            textBox3.Text = kq.ToString();

        }

        private void btTru_Click(object sender, EventArgs e)
        {
            int a, b, kq;
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);
            Calculation cal = new Calculation(a, b);
            kq = cal.Execute("-");

            textBox3.Text = kq.ToString();
        }

        private void btNhan_Click(object sender, EventArgs e)
        {
            int a, b, kq;
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);
            Calculation cal = new Calculation(a, b);
            kq = cal.Execute("*");

            textBox3.Text = kq.ToString();
        }

        private void btChia_Click(object sender, EventArgs e)
        {
            int a, b, kq;
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);
            Calculation cal = new Calculation(a, b);
            kq = cal.Execute("/");

            textBox3.Text = kq.ToString();
        }
    }
}
