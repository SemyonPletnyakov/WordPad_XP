using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordPad_XP
{
    public partial class dateAndTimeForm : Form
    {
        public dateAndTimeForm()
        {
            InitializeComponent();
            listBox1.Items.Clear();
            DateTime date1 = DateTime.Now;

            //06.05.2021
            if (date1.Day >= 10 && date1.Month >= 10)
            {
                listBox1.Items.Add(date1.Day.ToString() + "." + date1.Month.ToString() + "." + date1.Year.ToString());
            }
            else if (date1.Day < 10 && date1.Month >= 10)
            {
                listBox1.Items.Add("0" + date1.Day.ToString() + "." + date1.Month.ToString() + "." + date1.Year.ToString());
            }
            else if (date1.Day >= 10 && date1.Month < 10)
            {
                listBox1.Items.Add(date1.Day.ToString() + ".0" + date1.Month.ToString() + "." + date1.Year.ToString());
            }
            else
            {
                listBox1.Items.Add("0" + date1.Day.ToString() + ".0" + date1.Month.ToString() + "." + date1.Year.ToString());
            }

            //06.05.21
            if (date1.Day >= 10 && date1.Month >= 10)
            {
                listBox1.Items.Add(date1.Day.ToString() + "." + date1.Month.ToString() + "." + (date1.Year%100).ToString());
            }
            else if (date1.Day < 10 && date1.Month >= 10)
            {
                listBox1.Items.Add("0" + date1.Day.ToString() + "." + date1.Month.ToString() + "." + (date1.Year % 100).ToString());
            }
            else if (date1.Day >= 10 && date1.Month < 10)
            {
                listBox1.Items.Add(date1.Day.ToString() + ".0" + date1.Month.ToString() + "." + (date1.Year % 100).ToString());
            }
            else
            {
                listBox1.Items.Add("0" + date1.Day.ToString() + ".0" + date1.Month.ToString() + "." + (date1.Year % 100).ToString());
            }

            //6.5.21
            listBox1.Items.Add(date1.Day.ToString() + "." + date1.Month.ToString() + "." + (date1.Year % 100).ToString());

            //06-05-2021
            if (date1.Day >= 10 && date1.Month >= 10)
            {
                listBox1.Items.Add(date1.Day.ToString() + "-" + date1.Month.ToString() + "-" + date1.Year.ToString());
            }
            else if (date1.Day < 10 && date1.Month >= 10)
            {
                listBox1.Items.Add("0" + date1.Day.ToString() + "-" + date1.Month.ToString() + "-" + date1.Year.ToString());
            }
            else if (date1.Day >= 10 && date1.Month < 10)
            {
                listBox1.Items.Add(date1.Day.ToString() + "-0" + date1.Month.ToString() + "-" + date1.Year.ToString());
            }
            else
            {
                listBox1.Items.Add("0" + date1.Day.ToString() + "-0" + date1.Month.ToString() + "-" + date1.Year.ToString());
            }

            //06/05/21
            if (date1.Day >= 10 && date1.Month >= 10)
            {
                listBox1.Items.Add(date1.Day.ToString() + "/" + date1.Month.ToString() + "/" + (date1.Year % 100).ToString());
            }
            else if (date1.Day < 10 && date1.Month >= 10)
            {
                listBox1.Items.Add("0" + date1.Day.ToString() + "/" + date1.Month.ToString() + "/" + (date1.Year % 100).ToString());
            }
            else if (date1.Day >= 10 && date1.Month < 10)
            {
                listBox1.Items.Add(date1.Day.ToString() + "/0" + date1.Month.ToString() + "/" + (date1.Year % 100).ToString());
            }
            else
            {
                listBox1.Items.Add("0" + date1.Day.ToString() + "/0" + date1.Month.ToString() + "/" + (date1.Year % 100).ToString());
            }

            string mounthName = "";
            switch (date1.Month)
            {
                case (1): mounthName = "января"; break;
                case (2): mounthName = "февраля"; break;
                case (3): mounthName = "марта"; break;
                case (4): mounthName = "апреля"; break;
                case (5): mounthName = "мая"; break;
                case (6): mounthName = "июня"; break;
                case (7): mounthName = "июля"; break;
                case (8): mounthName = "августа"; break;
                case (9): mounthName = "сентября"; break;
                case (10): mounthName = "октября"; break;
                case (11): mounthName = "ноября"; break;
                case (12): mounthName = "декабря"; break;
            }
            //6 мая 2021 г.
            listBox1.Items.Add(date1.Day.ToString() + " " + mounthName + " " + date1.Year.ToString() + "г.");

            //06 мая 2021г.
            if (date1.Day >= 10)
            {
                listBox1.Items.Add(date1.Day.ToString() + " " + mounthName + " " + date1.Year.ToString() + "г.");
            }
            else
            {
                listBox1.Items.Add("0" + date1.Day.ToString() + " " + mounthName + " " + date1.Year.ToString() + "г.");
            }

            string dayOfWeakName = "";
            switch (date1.DayOfWeek)
            {
                case (DayOfWeek.Monday): dayOfWeakName = "понедельник"; break;
                case (DayOfWeek.Tuesday): dayOfWeakName = "вторник"; break;
                case (DayOfWeek.Wednesday): dayOfWeakName = "среда"; break;
                case (DayOfWeek.Thursday): dayOfWeakName = "четверг"; break;
                case (DayOfWeek.Friday): dayOfWeakName = "пятника"; break;
                case (DayOfWeek.Saturday): dayOfWeakName = "суббота"; break;
                case (DayOfWeek.Sunday): dayOfWeakName = "воскресенье"; break;
            }
            listBox1.Items.Add(dayOfWeakName + ", " + date1.Day.ToString() + " " + mounthName + " " + date1.Year.ToString() + "г.");

            //4:04:05
            if(date1.Minute >= 10 && date1.Second >= 10)
            {
                listBox1.Items.Add(date1.Hour.ToString() + ":" + date1.Minute.ToString() + ":" + date1.Second.ToString());
            }
            else if(date1.Minute < 10 && date1.Second >= 10)
            {
                listBox1.Items.Add(date1.Hour.ToString() + ":0" + date1.Minute.ToString() + ":" + date1.Second.ToString());
            }
            else if (date1.Minute >= 10 && date1.Second < 10)
            {
                listBox1.Items.Add(date1.Hour.ToString() + ":" + date1.Minute.ToString() + ":0" + date1.Second.ToString());
            }
            else
            {
                listBox1.Items.Add(date1.Hour.ToString() + ":0" + date1.Minute.ToString() + ":0" + date1.Second.ToString());
            }

            //04:04:05
            string hourZero = "";
            if (date1.Hour >= 10) hourZero = date1.Hour.ToString();
            else hourZero = "0" + date1.Hour.ToString();

            if (date1.Minute >= 10 && date1.Second >= 10)
            {
                listBox1.Items.Add(hourZero + ":" + date1.Minute.ToString() + ":" + date1.Second.ToString());
            }
            else if (date1.Minute < 10 && date1.Second >= 10)
            {
                listBox1.Items.Add(hourZero + ":0" + date1.Minute.ToString() + ":" + date1.Second.ToString());
            }
            else if (date1.Minute >= 10 && date1.Second < 10)
            {
                listBox1.Items.Add(hourZero + ":" + date1.Minute.ToString() + ":0" + date1.Second.ToString());
            }
            else
            {
                listBox1.Items.Add(hourZero + ":0" + date1.Minute.ToString() + ":0" + date1.Second.ToString());
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            datfResult.a = listBox1.SelectedItem.ToString();
        }
    }
}
