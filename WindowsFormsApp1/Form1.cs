﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            float[] a = new float[25];
            int x = 0;
            int y = 0;
            Random name = new Random();
            for (int i = 0; i < 25; i++)
            {
                a[i] = name.Next(-10, 10);
                textBox1.Text += a[i] + "\t";
                if (a[i] < 0)
                    x++;
                if (a[i] >= 1 && a[i] <= 2)
                    y++;

            }
            textBox1.Text += Environment.NewLine + "Количество отричательных элементов: "+ x.ToString();
            textBox1.Text += Environment.NewLine + "Количество элементов от 1 до 2: " + y.ToString();
        }
    }
}
