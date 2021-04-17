using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Insertion_Sorting_Algorithm
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

        int[] sayilar = new int[] { 5, 6, 8, 1, 88, 99, 78, 45, 36, 25, 12, 9, 7 };
        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < sayilar.Count(); i++)
            {
                int deger = sayilar[i];
                int j = i - 1;
                while (j >= 0 && sayilar[j] > deger)
                {
                    sayilar[j + 1] = sayilar[j];
                    j -= 1;
                }
                sayilar[j + 1] = deger;
                textBox1.Text += string.Join(",", sayilar) + Environment.NewLine;
            }
        }
    }
}
