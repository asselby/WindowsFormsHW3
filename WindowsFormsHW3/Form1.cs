/*Написать программу, которая по введенной дате определяет день
недели. Результат выводить в текстовое поле (желательно по-русски). */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsHW3
{
    public partial class Form1 : Form
    {
        DateTime date = new DateTime();
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                //  MessageBox.Show(String.Format("", dateTimePicker2))
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            date = dateTimePicker2.Value;
            MessageBox.Show(date.ToString("dddd", CultureInfo.GetCultureInfo("ru-ru")));
        }
    }
}

