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
    public partial class Form7 : Form
    {
        Settings _settings = null;
        OpenFileDialog openFileDialog1 = new OpenFileDialog() ;
      
   
        public Form7()
        {
            InitializeComponent();
            _settings = Settings.GetSettings();
            _initControlls();
             
            SuspendLayout();
            button1.Text = "Открыть";
            button1.Click += new EventHandler(button1_Click);

            openFileDialog1.Title = "Выберите файл";
            openFileDialog1.Filter = "Изображения|*.jpg";
                //,|Текстовые файлы|*.txt";
            
            this.Controls.Add(button1);
            ResumeLayout();
           
        
        
        
        
        }

        private void _initControlls()
        {
/*
            Form6.past = _settings.Направление_Подготовки;

            Form6.lio = _settings.Направленность;
            Form6.past2 = _settings.Форма_обучения;
            Form6.past3 = _settings.Тема_научно_квалификационной_работы;

            Form6.past4 = _settings.Научный_руководитель;

            Form6.past5 = _settings.Кафедра;
            Form6.past6 = _settings.Срок_обучения;
            Form6.past7 = _settings.Факультет;
            Form6.past8 = _settings.Приказ_о_зачислении;
            */
            
            

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
           
       }
      
       private void button1_Click(object sender, EventArgs e)
       {
           // выход, если была нажата кнопка Отмена и прочие (кроме ОК)
           if (openFileDialog1.ShowDialog() != DialogResult.OK) return;
           // всё. имя файла теперь хранится в openFileDialog1.FileName
           // MessageBox.Show("Выбран файл: "+openFileDialog1);
           pictureBox1.ImageLocation = openFileDialog1.FileName;
           
           //string g = System.IO.Path.GetFileName(openFileDialog1.FileName);
             
       
        //   PictureBox pb = new PictureBox();

          // PictureBox lemp = new PictureBox();
           
          // lemp.Width = pb.Width;
          //Размещаем ее правее (на 10px) кнопки, на которую мы нажали
          // lemp.Location = new Point(pb.Location.X + pb.Width + 600, pb.Location.Y + pb.Width + 800);
           //Добавляем событие нажатия на новую кнопку 
           //(то же что и при нажатии на исходную)
           //lemp.Click += new EventHandler(button1_Click);
           //Добавляем элемент на форму
           //this.Controls.Add(lemp);
       
            //MessageBox.Show("Выбран файл: " + openFileDialog1.FileName);
      
           
           //получаем ссылку на кнопку, на которую мы нажали
           Button b = (Button)sender;
           //Создаем новую кнопку
           Button temp = new Button();
           temp.Text = "Открыть";
           temp.Width = b.Width;
           //Размещаем ее правее (на 10px) кнопки, на которую мы нажали
           temp.Location = new Point(b.Location.X, b.Location.Y + b.Width + 10);
           //Добавляем событие нажатия на новую кнопку 
           //(то же что и при нажатии на исходную)
           temp.Click += new EventHandler(button1_Click);
           //Добавляем элемент на форму
           this.Controls.Add(temp);

          


           //  + b.Width + 10,
       }

       private void button6_Click(object sender, EventArgs e)
       {
           Form4 f4 = new Form4();
           f4.ShowDialog();
       }

       private void button4_Click(object sender, EventArgs e)
       {
           Form9 f9 = new Form9();
           f9.ShowDialog();
       }

       private void button3_Click(object sender, EventArgs e)
       {
           Form8 f8 = new Form8();
           f8.ShowDialog();
       }

       private void pictureBox1_Click(object sender, EventArgs e)
       {
           //pictureBox1.ImageLocation = openFileDialog1.FileName;


       }

    
       
       }
    
    }

