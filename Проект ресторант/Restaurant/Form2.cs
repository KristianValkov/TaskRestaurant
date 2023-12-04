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
            groupBox1.Hide();
            groupBox2.Hide();
            groupBox3.Hide();
            groupBox4.Hide();
            groupBox5.Hide();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Show();
            groupBox2.Hide();
            groupBox3.Hide();
            groupBox4.Hide();
            groupBox5.Hide();
            groupBox1.BringToFront();
        }
        private void userControl11_Load(object sender, EventArgs e)
        {
        }
        private void button6_Click(object sender, EventArgs e)
        { 
            if (listBox1.Text=="")
            {
                MessageBox.Show("Не сте въвели или маркирали какво искате", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Вашата поръчка е приета! ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void userControl21_Load(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            groupBox1.Hide();
            groupBox2.Show();
            groupBox3.Hide();
            groupBox4.Hide();
            groupBox5.Hide();
            groupBox2.BringToFront();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            groupBox1.Hide();
            groupBox2.Hide();
            groupBox3.Show();
            groupBox4.Hide();
            groupBox5.Hide();
            groupBox3.BringToFront();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox1.Hide();
            groupBox1.Hide();
            groupBox2.Hide();
            groupBox3.Hide();
            groupBox4.Show();
            groupBox5.Hide();
            groupBox4.BringToFront();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            groupBox1.Hide();
            groupBox2.Hide();
            groupBox3.Hide();
            groupBox4.Hide();
            groupBox5.Show();
            groupBox5.BringToFront();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (txtpH.Text != "0")
            {
                listBox1.Items.Add($"{lblpH.Text}- {txtpH.Text} бр.");
                //Application.Restart();
            }
            if (txtT.Text != "0")
            {
                listBox1.Items.Add($"{lblT.Text}- {txtT.Text} бр.");
            }
            if (txtpS.Text != "0")
            {
                listBox1.Items.Add($"{lblpS.Text}- {txtpS.Text} бр..");
            }
            if (textBox1.Text != "0")
            {
                listBox1.Items.Add($"{lblSB.Text}- {textBox1.TabIndex} бр.");
            }
            if (txtRB.Text != "0")
            {
                listBox1.Items.Add($"{lblSR.Text}- {txtRB.Text} бр.");
            }
            if (txtMus.Text != "0")
            {
                listBox1.Items.Add($"{lblMus.Text}- {txtMus.Text} бр.");
            }
            if (txtChK.Text != "0")
            {
                listBox1.Items.Add($"{lblChK.Text}- {txtChK.Text} бр.");
            }
            if (txtKB.Text != "0")
            {
                listBox1.Items.Add($"{lblKB.Text}- {txtKB.Text} бр.");
            }
            if (txtSchS.Text != "0")
            {
                listBox1.Items.Add($"{lblSchS.Text}- {txtSchS.Text} бр.");
            }
            if (txtBerr.Text != "0")
            {
                listBox1.Items.Add($"{lblBirr.Text}- {txtBerr.Text} бр.");
            }
            if (txtU.Text != "0")
            {
                listBox1.Items.Add($"{lblU.Text}- {txtU.Text} бр.");
            }
            if (txtVod.Text!= "0")
            {
                listBox1.Items.Add($"{lblVod.Text}- {txtVod.Text} бр.");
            }
            if (textBox2.Text != "0")
            {
                listBox1.Items.Add($"{lblSchveps.Text}- {textBox2.Text} бр.");
            }
            if (txtFst.Text != "0")
            {
                listBox1.Items.Add($"{lblFst.Text}- {txtFst.Text} бр.");
            }
            if (txtKaff.Text != "0")
            {
                listBox1.Items.Add($"{lblKaff.Text}- {txtKaff.Text} бр.");
            }
            if (txtMSch.Text != "0")
            {
                listBox1.Items.Add($"{lblMSch.Text}- {txtMSch.Text} бр.");
            }
            if (txtTee.Text != "0")
            {
                listBox1.Items.Add($"{lblTee.Text}- {txtTee.Text} бр.");
            }
            if (txtKol.Text != "0")
            {
                listBox1.Items.Add($"{lblKol.Text}- {txtKol.Text} бр.");
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           

            
        }
    }
}
