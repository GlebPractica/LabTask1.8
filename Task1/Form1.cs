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
        private Engineer engineer;
        private Leader leader;

        public Form1()
        {
            InitializeComponent();
            engineer = new Engineer();
            leader = new Leader();
        }

        private void BttnEnterNameLead_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                listBox1.ForeColor = Color.Snow;
                listBox1.Items.Add(leader.AddName(textBox1.Text));
            }
            else
            {
                listBox1.ForeColor = Color.Red;
                listBox1.Items.Add("Ошибка");
                listBox1.Items.Add("Похоже вы ничего не ввели в строку ФИО руководителя ");
            }
            listBox1.ForeColor = Color.Snow;
        }

        private void BttnEnterNameEng_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            if (!string.IsNullOrWhiteSpace(textBox2.Text))
            {
                listBox1.ForeColor = Color.Snow;
                listBox1.Items.Add(engineer.AddName(textBox2.Text));
            }
            else
            {
                listBox1.ForeColor = Color.Red;
                listBox1.Items.Add("Ошибка");
                listBox1.Items.Add("Похоже вы ничего не ввели в строку ФИО инженера");
            }
            listBox1.ForeColor = Color.Snow;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            if (!string.IsNullOrWhiteSpace(leader.Name))
            {
                listBox1.Items.Add(leader.Work() + "\t\t");
                listBox1.Items.Add(leader.ToString());
            }
            else
            {
                listBox1.Items.Add(leader.Work() + "\t\t");
                listBox1.Items.Add("Неизвестный руководитель");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            if (!string.IsNullOrWhiteSpace(engineer.Name))
            {
                listBox1.Items.Add(engineer.Work() + "\t\t");
                listBox1.Items.Add(engineer.ToString());
            }
            else
            {
                listBox1.Items.Add(engineer.Work() + "\t\t");
                listBox1.Items.Add("Неизвестный инженер");
            }
        }
    }
}
