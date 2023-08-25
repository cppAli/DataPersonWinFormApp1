using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();//Form1 конструктор


        }

        private void Form1_Load(object sender, EventArgs e) //конструктор
        {

        }



        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            
                string fio, date, city;
                fio = textBox1.Text;
                date = textBox2.Text;
                city = textBox3.Text;

                MessageBox.Show($"Сохранено");

                label4.Text = $"{fio} \n {date}\n {city}";
            
        }
    }
}

//Написать приложение которое дает пользователю возможность ввести ФИО, год рождения, город в котором живет.
///После нажатия на кнопочку вывести все данные в виде текста в label(без даннх ее не должно быть видно)