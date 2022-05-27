using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Проект_заказ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 myForm = new Form3(); 
            myForm.Show();
            this.Hide();
            myForm.FormClosed += MyForm_FormClosed;


        }

        private void MyForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //this.Show();
            Application.Exit();
        }

        private void recepts_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
            form5.FormClosed += Form5_FormClosed;
        }

        private void Form5_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void pravila_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
            this.Hide();
            form6.FormClosed += Form6_FormClosed;

        }

        private void Form6_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();
            form8.Show();
            this.Hide();
            form8.FormClosed += Form8_FormClosed;
        }

        private void Form8_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
