using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Lab1
{
    public partial class Form1 : Form
    {
        public delegate void Del1();
        public event Del1 Ev1;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "+";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "-";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = "*";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "/";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = "sin";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text = "cos";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text = "sqrt";
        }

        public void Meth1()
        {
            MessageBox.Show("Успешно обработано событие нажатия на кнопку '='", "Обработано событие");
        }
        bool event_is_called = false;
        private void button8_Click(object sender, EventArgs e)
        {
            Ev1 += Meth1;
            try
            {
                char[] charMass = { '-', '+', ',', '.', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

                foreach (char a1 in textBox1.Text)
                {
                    if (!charMass.Contains(a1))
                        throw new Exception("Неверно задан(ы) операнд(ы)");
                }
                foreach (char a2 in textBox2.Text)
                {
                    if (!charMass.Contains(a2))
                        throw new Exception("Неверно задан(ы) операнд(ы)");
                }

                label2.ResetText();
                string a = label1.Text;
                if (a == "+")
                {
                    if (textBox2.Text == String.Empty || textBox1.Text == String.Empty)
                        throw new Exception("Отсутствует(ют) операнд(ы)");
                    label2.Text = Convert.ToString(Calculator.Plus(textBox1.Text, textBox2.Text));
                }
                else if (a == "-")
                {
                    if (textBox2.Text == String.Empty || textBox1.Text == String.Empty)
                        throw new Exception("Отсутствует(ют) операнд(ы)");
                    label2.Text = Convert.ToString(Calculator.Minus(textBox1.Text, textBox2.Text));
                }
                else if (a == "*")
                {
                    if (textBox2.Text == String.Empty || textBox1.Text == String.Empty)
                        throw new Exception("Отсутствует(ют) операнд(ы)");
                    label2.Text = Convert.ToString(Math.Round(Convert.ToDouble(Calculator.Mult(textBox1.Text, textBox2.Text)), 2));
                }
                else if (a == "/")
                {
                    if (textBox2.Text == String.Empty || textBox1.Text == String.Empty)
                        throw new Exception("Отсутствует(ют) операнд(ы)");
                    if (Convert.ToDouble(textBox2.Text) == 0)
                        throw new Exception("Деление на 0");
                    if (Convert.ToDouble(textBox2.Text) != 0)
                        label2.Text = Convert.ToString(Math.Round(Convert.ToDouble(Calculator.Div(textBox1.Text, textBox2.Text)), 2));
                }
                else if (a == "cos")
                {
                    if (textBox2.Text == String.Empty)
                        throw new Exception("Отсутствует операнд");
                    label2.Text = Convert.ToString(Math.Round(Calculator.Cos(textBox2.Text), 2));
                }
                else if (a == "sin")
                {
                    if (textBox2.Text == String.Empty)
                        throw new Exception("Отсутствует операнд");
                    label2.Text = Convert.ToString(Math.Round(Calculator.Sin(textBox2.Text), 2));
                }
                else if (a == "sqrt")
                {
                    if (textBox2.Text == String.Empty)
                        throw new Exception("Отсутствует операнд");
                    label2.Text = Convert.ToString(Math.Round(Calculator.Sqrt(textBox2.Text), 2));
                }
                else
                {
                    throw new Exception("Отстутствует оператор");
                }
                if (textBox1.Text != String.Empty)
                    listBox1.Items.Insert(0, textBox1.Text + ' ' + a + ' ' + textBox2.Text + ' ' + '=' + ' ' + label2.Text);
                else
                    listBox1.Items.Insert(0, a + ' ' + Convert.ToString(textBox2.Text + ' ' + '=' + ' ' + label2.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Вызвано исключение");
            }
            if (!event_is_called)
            {
                Ev1();
                event_is_called = true;
            }

        Ev1 -= Meth1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                groupBox1.Hide();
                textBox1.ResetText();
                textBox2.ResetText();
                label2.ResetText();
                label1.ResetText();
                button4.Hide();
                button6.Hide();
                button7.Hide();
                button1.Show();
                button3.Show();
                button5.Show();
                button2.Show();
                textBox1.Show();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                groupBox1.Show();
                Point new_p = new Point(2, 113);
                groupBox1.Location = new_p;
                textBox1.ResetText();
                textBox2.ResetText();
                label2.ResetText();
                label1.ResetText();
                button1.Hide();
                button3.Hide();
                button5.Hide();
                button2.Hide();
                textBox1.Hide();
                textBox2.Show();
                label2.Show();
                button8.Show();
                button4.Show();
                button6.Show();
                button7.Show();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.ResetText();
            textBox2.ResetText();
            label2.ResetText();
            label1.ResetText();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
