using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROEKT2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "a-z" && textBox2.Text == "a-z,0-9" && textBox3.Text == "а-я" && textBox4.Text == "а-я" && textBox5.Text == "a-z,0-9" && textBox6.Text == "а-я" && textBox7.Text == "а-я") 
        
     {
          
        Form4 f4 = new Form4(); 
                f4.ShowDialog(); 
                 this.Hide(); 
                 Application.Exit();
            }
                
                 else
             
                   { 
                 textBox1.Text=" ";
                 textBox2.Text=" ";
                 textBox3.Text = " ";
                textBox4.Text = " ";
                textBox5.Text = " ";
                textBox6.Text = " ";
                textBox7.Text = " ";

                MessageBox.Show("Заполните все поля регистрационной анкеты!");
                    }

}
}

}