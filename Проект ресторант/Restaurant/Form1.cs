using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class Form1 : Form
    {
        string table = "";
        string cardBakshish = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            Form1 form1 = new Form1();
            if (radioButton1.Checked )
            {
                table = radioButton1.Text;
            }
            if (radioButton2.Checked)
            {
                table = radioButton2.Text;
            }
            if (radioButton3.Checked)
            {
                cardBakshish = radioButton3.Text;
                MessageBox.Show("Ще оставите ли бакшиш?", "Събиране на бакшиши", MessageBoxButtons.YesNo);
            }
            if (radioButton4.Checked)
            {
                cardBakshish = radioButton4.Text;
                MessageBox.Show("Ще вземем 0,05лв. над сметката");
            }
            if (cardBakshish == "")
            {
                MessageBox.Show("Не сте отбелязали как ще платите!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                groupBox2.Focus();

            }
            if (txt1.Text=="")
            {
                MessageBox.Show("Не сте въвели масата за колко души e!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt1.Focus();
                return;
            }
            int n = int.Parse(txt1.Text);
            if (n>3&&n<15)
            {
                form2.Show();
                form1.Close();
                return;
            }
            else
            {
                MessageBox.Show($"Няма маса за {n} човек/души.","Предупреждение",MessageBoxButtons.OK,MessageBoxIcon.Information);
                MessageBox.Show("Трябва да са от 4-14 души!");
                form2.Hide();
            }
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            int n = int.Parse(txt1.Text);
            if (radioButton1.Checked)
            {
                table = radioButton1.Text;
            }
            if (radioButton2.Checked)
            {
                table = radioButton2.Text;
            }
            if (radioButton3.Checked)
            {
                cardBakshish = radioButton3.Text;
            }
            if (radioButton4.Checked)
            {
                cardBakshish = radioButton4.Text;
            }
            if(cardBakshish=="")
            {
                MessageBox.Show("Не сте отбелязали как ще платите!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                groupBox2.Focus();
            }
            if (n==0)
            {
                MessageBox.Show("Не сте въвели масата за колко души e!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Избрахте маса за {table} като ще платите {cardBakshish} и искате места за {n} души");
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
