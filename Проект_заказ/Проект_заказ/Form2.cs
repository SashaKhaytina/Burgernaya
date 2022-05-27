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
    public partial class Form2 : Form
    {
        int p1 = 0;
        int p2 = 0;
        int p3 = 0;
        int p4 = 0;
        int summ = 50;
        public Form2()
        {
            InitializeComponent();
            this.Size = new System.Drawing.Size(870, 570);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.Кетчуп;
            p1 = 10;
            summ = p1 + p2 + p3 + p4 + 50;
            label11.Text = summ.ToString();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton16_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox8.Image = Properties.Resources.Кетчуп;
            p2 = 10;
            summ = p1 + p2 + p3 + p4 + 50;
            label11.Text = summ.ToString();
        }

        private void radioButton24_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox9.Image = Properties.Resources.Кетчуп;
            p3 = 10;
            summ = p1 + p2 + p3 + p4 + 50;
            label11.Text = summ.ToString();
        }

        private void radioButton32_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox10.Image = Properties.Resources.Кетчуп;
            p4 = 10;
            summ = p1 + p2 + p3 + p4 + 50;
            label11.Text = summ.ToString();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.Майонез;
            p1 = 10;
            summ = p1 + p2 + p3 + p4 + 50;
            label11.Text = summ.ToString();
        }

        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox8.Image = Properties.Resources.Майонез;
            p2 = 10;
            summ = p1 + p2 + p3 + p4 + 50;
            label11.Text = summ.ToString();
        }

        private void radioButton23_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox9.Image = Properties.Resources.Майонез;
            p3 = 10;
            summ = p1 + p2 + p3 + p4 + 50;
            label11.Text = summ.ToString();
        }

        private void radioButton31_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox10.Image = Properties.Resources.Майонез;
            p4 = 10;
            summ = p1 + p2 + p3 + p4 + 50;
            label11.Text = summ.ToString();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.Лук;
            p1 = 20;
            summ = p1 + p2 + p3 + p4 + 50;
            label11.Text = summ.ToString();
        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox8.Image = Properties.Resources.Лук;
            p2 = 20;
            summ = p1 + p2 + p3 + p4 + 50;
            label11.Text = summ.ToString();
        }

        private void radioButton22_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox9.Image = Properties.Resources.Лук;
            p3 = 20;
            summ = p1 + p2 + p3 + p4 + 50;
            label11.Text = summ.ToString();
        }

        private void radioButton30_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox10.Image = Properties.Resources.Лук;
            p4 = 20;
            summ = p1 + p2 + p3 + p4 + 50;
            label11.Text = summ.ToString();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.Помидор;
            p1 = 30;
            summ = p1 + p2 + p3 + p4 + 50;
            label11.Text = summ.ToString();
        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox8.Image = Properties.Resources.Помидор;
            p2 = 30;
            summ = p1 + p2 + p3 + p4 + 50;
            label11.Text = summ.ToString();
        }

        private void radioButton21_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox9.Image = Properties.Resources.Помидор;
            p3 = 30;
            summ = p1 + p2 + p3 + p4 + 50;
            label11.Text = summ.ToString();
        }

        private void radioButton29_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox10.Image = Properties.Resources.Помидор;
            p4 = 30;
            summ = p1 + p2 + p3 + p4 + 50;
            label11.Text = summ.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3  form3 = new Form3();
            form3.Show();
            form3.FormClosed += Form3_FormClosed;
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.Салат;
            p1 = 20;
            summ = p1 + p2 + p3 + p4 + 50;
            label11.Text = summ.ToString();
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox8.Image = Properties.Resources.Салат;
            p2 = 20;
            summ = p1 + p2 + p3 + p4 + 50;
            label11.Text = summ.ToString();
        }

        private void radioButton20_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox9.Image = Properties.Resources.Салат;
            p3 = 20;
            summ = p1 + p2 + p3 + p4 + 50;
            label11.Text = summ.ToString();
        }

        private void radioButton28_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox10.Image = Properties.Resources.Салат;
            p4 = 20;
            summ = p1 + p2 + p3 + p4 + 50;
            label11.Text = summ.ToString();
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.Соленый_огурец;
            p1 = 30;
            summ = p1 + p2 + p3 + p4 + 50;
            label11.Text = summ.ToString();
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox8.Image = Properties.Resources.Соленый_огурец;
            p2 = 30;
            summ = p1 + p2 + p3 + p4 + 50;
            label11.Text = summ.ToString();
        }

        private void radioButton19_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox9.Image = Properties.Resources.Соленый_огурец;
            p3 = 30;
            summ = p1 + p2 + p3 + p4 + 50;
            label11.Text = summ.ToString();
        }

        private void radioButton27_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox10.Image = Properties.Resources.Соленый_огурец;
            p4 = 30;
            summ = p1 + p2 + p3 + p4 + 50;
            label11.Text = summ.ToString();
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.Котлета;
            p1 = 70;
            summ = p1 + p2 + p3 + p4 + 50;
            label11.Text = summ.ToString();
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox8.Image = Properties.Resources.Котлета;
            p2 = 70;
            summ = p1 + p2 + p3 + p4 + 50;
            label11.Text = summ.ToString();
        }

        private void radioButton18_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox9.Image = Properties.Resources.Котлета;
            p3 = 70;
            summ = p1 + p2 + p3 + p4 + 50;
            label11.Text = summ.ToString();
        }

        private void radioButton26_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox10.Image = Properties.Resources.Котлета;
            p4 = 70;
            summ = p1 + p2 + p3 + p4 + 50;
            label11.Text = summ.ToString();
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.Котлета_с_сыром;
            p1 = 85;
            summ = p1 + p2 + p3 + p4 + 50;
            label11.Text = summ.ToString();
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox8.Image = Properties.Resources.Котлета_с_сыром;
            p2 = 85;
            summ = p1 + p2 + p3 + p4 + 50;
            label11.Text = summ.ToString();
        }

        private void radioButton17_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox9.Image = Properties.Resources.Котлета_с_сыром;
            p3 = 85;
            summ = p1 + p2 + p3 + p4 + 50;
            label11.Text = summ.ToString();
        }

        private void radioButton25_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox10.Image = Properties.Resources.Котлета_с_сыром;
            p4 = 85;
            summ = p1 + p2 + p3 + p4 + 50;
            label11.Text = summ.ToString();
        }

        private void radioButton33_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox2.Image = null;
            p1 = 0;
            summ = p1 + p2 + p3 + p4 + 50;
            label11.Text = summ.ToString();
        }

        private void radioButton36_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox8.Image = null;
            p2 = 0;
            summ = p1 + p2 + p3 + p4 + 50;
            label11.Text = summ.ToString();
        }

        private void radioButton34_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox9.Image = null;
            p3 = 0;
            summ = p1 + p2 + p3 + p4 + 50;
            label11.Text = summ.ToString();
        }

        private void radioButton35_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox10.Image = null;
            p4 = 0;
            summ = p1 + p2 + p3 + p4 + 50;
            label11.Text = summ.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.Show();
            this.Hide();
            form7.FormClosed += Form7_FormClosed;
        }

        private void Form7_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
