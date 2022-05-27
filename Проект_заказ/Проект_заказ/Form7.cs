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
    public partial class Form7 : Form
    {
        Timer timer = new Timer();

        public Form7()
        {
            InitializeComponent();
            timer.Interval = 5000;
            timer.Tick += Timer_Tick;
            timer.Start();

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            Form1 myForm = new Form1();
            myForm.Show();
            this.Hide();
            myForm.FormClosed += MyForm_FormClosed;

        }

        private void MyForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }
    }
}
