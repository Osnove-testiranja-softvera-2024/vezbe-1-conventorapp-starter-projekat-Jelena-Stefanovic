using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OTS2023_ConventorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            lbl1.Text = "Mass in pounds: ";
            lbl2.Text = "Mass in kilograms: ";

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            lbl1.Text = "Length in feet: ";
            lbl2.Text = "Length in meters: ";
        }

    }
}
