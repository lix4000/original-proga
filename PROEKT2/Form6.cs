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
    public partial class Form6 : Form
    {
        Settings _settings = null;

        public static string past;
        public static string lio;
        public static string past2;
        public static string past3;
        public static string past4;
        public static string past5;
        public static string past6;
        public static string past7;
        public static string past8;
        
        
        
        public Form6()
    {
            InitializeComponent();

             _settings = Settings.GetSettings();
            _initControlls();
        }

        private void _initControlls()
        {
           textBox1.Text = _settings.Направление_Подготовки;
           textBox2.Text = _settings.Направленность;
           textBox3.Text = _settings.Форма_обучения;
           textBox4.Text = _settings.Тема_научно_квалификационной_работы;
           textBox5.Text = _settings.Научный_руководитель;
           textBox6.Text = _settings.Кафедра;
           textBox7.Text = _settings.Срок_обучения;
           textBox8.Text = _settings.Факультет;
           textBox9.Text = _settings.Приказ_о_зачислении;
        

        
        }     
  
            
      
        
             
             
             
             private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            _settings.Направление_Подготовки  = textBox1.Text;
            _settings.Направленность = textBox2.Text;
            _settings.Форма_обучения = textBox3.Text;
            _settings.Тема_научно_квалификационной_работы = textBox4.Text;
            _settings.Научный_руководитель = textBox5.Text;
            _settings.Кафедра = textBox6.Text;
            _settings.Срок_обучения = textBox7.Text;
            _settings.Факультет = textBox8.Text;
            _settings.Приказ_о_зачислении = textBox9.Text;
           // _settings.Направленность = lio;
          // _settings.Направление_Подготовки =past;
          // _settings.Форма_обучения = past2;
          // _settings.Тема_научно_квалификационной_работы = past3;
          // _settings.Научный_руководитель = past4;
          // _settings.Кафедра = past5;
          // _settings.Срок_обучения = past6;
          // _settings.Факультет = past7;
          // _settings.Приказ_о_зачислении = past8;
           
           _settings.Save();

            past = textBox1.Text;
            lio = textBox2.Text;
            past2 = textBox3.Text;
            past3 = textBox4.Text;
            past4 = textBox7.Text;
            past5 = textBox8.Text;
            past6 = textBox9.Text;
            past7 = textBox6.Text;
            past8 = textBox5.Text;
           
            Form4 f4 = new Form4();
            f4.ShowDialog();
        
        
        
        
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
