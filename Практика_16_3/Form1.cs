using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Практика_16_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BtnDo.Width = 58;
            BtnExit.Width = 58;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnDo_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                MessageBox.Show("Введите значение");
            else if (int.TryParse(textBox1.Text, out int x))
            {
                if (Btn2.Checked == true)
                    textBox2.Text = Convert.ToString(x, 2);
                else if (Btn8.Checked == true)
                    textBox2.Text = Convert.ToString(x, 8);
                else if (Btn16.Checked == true)
                    textBox2.Text = Convert.ToString(x, 16);
                else
                    textBox2.Text = "Выберите систему счисления";
            }
            else
                MessageBox.Show("Неверное значение");
        }
    }
}
