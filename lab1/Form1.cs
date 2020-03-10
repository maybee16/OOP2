using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Time
{
    public partial class Form1 : Form
    {
        TimeClass t1 = new TimeClass();
        TimeClass t2 = new TimeClass();
        string s;
        int h1, m1, s1, add;
        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox_minutes_TextChanged(object sender, EventArgs e)
        {
            s = textBox_minutes.Text;
            m1 = Convert.ToInt32(s);
            t1.set_minutes(m1);
        }

        private void TextBox_seconds_TextChanged(object sender, EventArgs e)
        {
            s = textBox_seconds.Text;
            s1 = Convert.ToInt32(s);
            t1.set_seconds(s1);
        }

        private void Button_plus_Click(object sender, EventArgs e)
        {
            TimeClass sum = new TimeClass();
            sum = t1 + t2;
            label_str.Text = sum.convert_to_string();
        }

        private void TextBox_hours2_TextChanged(object sender, EventArgs e)
        {
            s = textBox_hours2.Text;
            h1 = Convert.ToInt32(s);
            t2.set_hours(h1);
        }

        private void TextBox_minutes2_TextChanged(object sender, EventArgs e)
        {
            s = textBox_minutes2.Text;
            m1 = Convert.ToInt32(s);
            t2.set_minutes(m1);
        }

        private void TextBox_seconds2_TextChanged(object sender, EventArgs e)
        {
            s = textBox_seconds2.Text;
            s1 = Convert.ToInt32(s);
            t2.set_seconds(s1);
        }

        private void Button_sub_Click(object sender, EventArgs e)
        {
            TimeClass sub = new TimeClass();
            sub = t1 - t2;
            label_str.Text = sub.convert_to_string();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            label_str.Text = t1.to_seconds().ToString();
        }

        private void Button_min_Click(object sender, EventArgs e)
        {
            label_str.Text = t1.to_minutes().ToString();
        }

        private void Button_h_Click(object sender, EventArgs e)
        {
            label_str.Text = t1.to_hours().ToString();
        }

        private void Button_addsec_Click(object sender, EventArgs e)
        {
            t1.add_seconds(add);
            label_str.Text = t1.convert_to_string();
        }

        private void Button_addmin_Click(object sender, EventArgs e)
        {
            t1.add_minutes(add);
            label_str.Text = t1.convert_to_string();
        }

        private void Button_addhour_Click(object sender, EventArgs e)
        {
            t1.add_hours(add);
            label_str.Text = t1.convert_to_string();
        }

        private void TextBox_add_TextChanged(object sender, EventArgs e)
        {
            s = textBox_add.Text;
            add = Convert.ToInt32(s);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            label_str.Text = t1.convert_to_string();
            //textBox_hours.Clear();
            //textBox_minutes.Clear();
            //textBox_seconds.Clear();
        }

        private void TextBox_hours_TextChanged(object sender, EventArgs e)
        {
            s = textBox_hours.Text;
            h1 = Convert.ToInt32(s);
            t1.set_hours(h1);
        }
    }
}
