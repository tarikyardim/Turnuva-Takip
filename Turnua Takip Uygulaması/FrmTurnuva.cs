using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Turnua_Takip_Uygulaması
{
    public partial class FrmTurnuva : Form
    {
        public FrmTurnuva()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count < 8)
            {
                listBox1.Items.Add(textBox1.Text);
                textBox1.Text = "";
                textBox1.Focus();
            }
            else
            {
                groupBox1.Enabled = false;
                textBox1.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random resgele = new Random();
            int secilen = resgele.Next(listBox1.Items.Count);
            radioButton1.Text = listBox1.Items[secilen].ToString();
            listBox1.Items.Remove(listBox1.Items[secilen]);

            secilen = resgele.Next(listBox1.Items.Count);
            radioButton2.Text = listBox1.Items[secilen].ToString();
            listBox1.Items.Remove(listBox1.Items[secilen]);

            secilen = resgele.Next(listBox1.Items.Count);
            radioButton3.Text = listBox1.Items[secilen].ToString();
            listBox1.Items.Remove(listBox1.Items[secilen]);


            secilen = resgele.Next(listBox1.Items.Count);
            radioButton4.Text = listBox1.Items[secilen].ToString();
            listBox1.Items.Remove(listBox1.Items[secilen]);


            secilen = resgele.Next(listBox1.Items.Count);
            radioButton5.Text = listBox1.Items[secilen].ToString();
            listBox1.Items.Remove(listBox1.Items[secilen]);



            secilen = resgele.Next(listBox1.Items.Count);
            radioButton6.Text = listBox1.Items[secilen].ToString();
            listBox1.Items.Remove(listBox1.Items[secilen]);



            secilen = resgele.Next(listBox1.Items.Count);
            radioButton7.Text = listBox1.Items[secilen].ToString();
            listBox1.Items.Remove(listBox1.Items[secilen]);



            secilen = resgele.Next(listBox1.Items.Count);
            radioButton8.Text = listBox1.Items[secilen].ToString();
            listBox1.Items.Remove(listBox1.Items[secilen]);

            button2.Enabled = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                listBox2.Items.Add(radioButton1.Text);

            }
            else
            {
                listBox2.Items.Add(radioButton2.Text);
            }
            if (radioButton3.Checked)
            {
                listBox2.Items.Add(radioButton3.Text);

            }
            else
            {
                listBox2.Items.Add(radioButton4.Text);
            }
            if (radioButton5.Checked)
            {
                listBox2.Items.Add(radioButton5.Text);

            }
            else
            {
                listBox2.Items.Add(radioButton6.Text);
            }
            if (radioButton7.Checked)
            {
                listBox2.Items.Add(radioButton8.Text);

            }


            Random resgele = new Random();
            int secilen = resgele.Next(listBox1.Items.Count);
            radioButton9.Text = listBox2.Items[secilen].ToString();
            listBox2.Items.Remove(listBox2.Items[secilen]);

            secilen = resgele.Next(listBox1.Items.Count);
            radioButton10.Text = listBox2.Items[secilen].ToString();
            listBox2.Items.Remove(listBox2.Items[secilen]);

            secilen = resgele.Next(listBox1.Items.Count);
            radioButton11.Text = listBox2.Items[secilen].ToString();
            listBox2.Items.Remove(listBox2.Items[secilen]);

            secilen = resgele.Next(listBox1.Items.Count);
            radioButton12.Text = listBox2.Items[secilen].ToString();
            listBox2.Items.Remove(listBox2.Items[secilen]);

            groupBox6.Enabled = false;
            button3.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (radioButton9.Checked)
            {
                radioButton13.Text = radioButton9.Text;

            }
            else
            {
                radioButton13.Text = radioButton10.Text;
            }
            if (radioButton11.Checked)
            {
                radioButton14.Text = radioButton11.Text;

            }
            else
            {
                radioButton14.Text = radioButton10.Text;

            }

            groupBox9.Enabled = false;
            button2.Enabled = false;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string galip;
            if (radioButton13.Checked)
                galip = radioButton13.Text;
            else
                galip = radioButton14.Text;

            textBox2.Text = "Turnuvanın Şanpiyonu:" + galip;

        }
    }
}