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
    public partial class Form4 : Form
    {
        Settings _settings = null;
        public Form4()
        {
            InitializeComponent();
            _settings = Settings.GetSettings();
            _initControlls();
        }

        private void _initControlls()
        {

            Form6.past = _settings.Направление_Подготовки;

            Form6.lio = _settings.Направленность;
            Form6.past2 = _settings.Форма_обучения;
            Form6.past3 = _settings.Тема_научно_квалификационной_работы;

            Form6.past4 = _settings.Научный_руководитель;

            Form6.past5 = _settings.Кафедра;
            Form6.past6 = _settings.Срок_обучения;
            Form6.past7 = _settings.Факультет;
            Form6.past8 = _settings.Приказ_о_зачислении;




        }

        

        private void фаилToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

       private void помошьToolStripMenuItem_Click(object sender, EventArgs e)
       {
           MessageBox.Show("Если у вас возникли вопросы о программе обращайтесь к Летвинову Владимиру Николаевичу");
       }

       private void разработчикиToolStripMenuItem_Click(object sender, EventArgs e)
       {
           Form5 f5 = new Form5();
           f5.ShowDialog(); 
       }

       private void Form4_Load(object sender, EventArgs e)
       {

           label13.Text = Form6.past;
           label5.Text = Form6.lio;
           label14.Text = Form6.past2;
           label15.Text = Form6.past3;
           label18.Text = Form6.past4;
           label17.Text = Form6.past5;
           label16.Text = Form6.past6;
           label19.Text = Form6.past7;
           label20.Text = Form6.past8;
           
       }

       private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
       {

       }

       private void toolStripButton3_Click(object sender, EventArgs e)
       {

       }

       private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
       {

       }

       private void toolStripComboBox1_Click(object sender, EventArgs e)
       {

       }

       private void toolStripComboBox1_Click_1(object sender, EventArgs e)
       {

       }

       private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
       {

       }

       private void label1_Click(object sender, EventArgs e)
       {

       }

       private void panel1_Paint(object sender, PaintEventArgs e)
       {

       }

       private void button1_Click(object sender, EventArgs e)
       {
           Form6 f6 = new Form6();
           f6.ShowDialog();

       }
       private void воВесьЭкранToolStripMenuItem_Click(object sender, EventArgs e)
       {
          FormBorderStyle = FormBorderStyle.None;

        
           }

       private void свернутьToolStripMenuItem_Click(object sender, EventArgs e)
       {
           FormBorderStyle = FormBorderStyle.Sizable;
       }

       private void label5_Click(object sender, EventArgs e)
       {

       }

       private void button5_Click(object sender, EventArgs e)
       {
           Form3 f3 = new Form3();
           f3.ShowDialog();
       }

       private void button2_Click(object sender, EventArgs e)
       {
           Form7 f7 = new Form7();
           f7.ShowDialog();
       }

       private void button3_Click(object sender, EventArgs e)
       {
           Form8 f8 = new Form8();
           f8.ShowDialog();
       }

       private void button6_Click(object sender, EventArgs e)
       {
     
       }

       private void button4_Click(object sender, EventArgs e)
       {
           Form9 f9 = new Form9();
           f9.ShowDialog();
       }

       
    
    }
}
