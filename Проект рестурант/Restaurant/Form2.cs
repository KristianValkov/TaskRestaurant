using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Restaurant
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Hide();
            userControl11.Hide();
            userControl21.Hide();
            userControl31.Hide();
            userControl41.Hide();
            userControl51.Hide();
            //List<UserControl1> list = new List<UserControl1>();
            //foreach (var item in list)
            //{
            //    listBox1.Items.Add($"{userControl11}");
            //}

        }
        private void button1_Click(object sender, EventArgs e)
        {
            userControl11.Show();
            userControl21.Hide();
            userControl31.Hide();
            userControl41.Hide();
            userControl51.Hide();
            userControl11.BringToFront();
        }
        private void userControl11_Load(object sender, EventArgs e)
        {
        }
        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вашата поръчка е приета!","",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        private void userControl21_Load(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            userControl11.Hide();
            userControl21.Show();
            userControl31.Hide();
            userControl41.Hide();
            userControl51.Hide();
            userControl21.BringToFront();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            userControl11.Hide();
            userControl21.Hide();
            userControl31.Show();
            userControl41.Hide();
            userControl51.Hide();
            userControl31.BringToFront();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            userControl11.Hide();
            userControl21.Hide();
            userControl31.Hide();
            userControl41.Show();
            userControl51.Hide();
            userControl41.BringToFront();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            userControl11.Hide();
            userControl21.Hide();
            userControl31.Hide();
            userControl41.Hide();
            userControl51.Show();
            userControl51.BringToFront();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            //Form2 r = new Form2();

            //r = userControl11_Load(UserControl1.ControlCollection.Equals);
            //string m = ;
            //var b = userControl31;
            //var v = userControl41;
            //var c = userControl51;

            //List<Form2> list = new List<Form2>();
            //list.Add(n);

            // //int v = .Text.Length;
            // var n = Console.ReadLine();
            // var r = userControl11.ToString();
            // var g =userControl21.ToString();
            // var t = userControl31.ToString();
            //var v = userControl41.ToString();
            // n = userControl51.ToString();
            // List<UserControl1> list = new List<UserControl1>();
            // //foreach(var item in list)
            // //{
            // //    listBox1.Items.Add($"{userControl11}");
            // //}
            // if(userControl11.ResetText()!="")
            // {
            //     foreach (var item in list)
            //     {
            //         listBox1.Items.Add($"{userControl11}");
            //     }
            // }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }
    }
}
