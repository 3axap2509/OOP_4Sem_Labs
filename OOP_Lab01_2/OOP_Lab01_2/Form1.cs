using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Lab01_2
{
    public partial class Form1 : Form
    {
        char[] charMass = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        string[] Color_Mass = { "Красная", "Зелёная", "Синяя", "Фиолетовая", "Оранжевая" };
        public Form1()
        {
            InitializeComponent();
        }
        public Random r = new Random();
        public List<keyVal> keyVal_list = new List<keyVal>();
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                foreach (char a1 in textBox1.Text)
                {
                    if (!charMass.Contains(a1))
                        throw new Exception("Неверно задан размер коллекции");
                }
                if (textBox1.Text == String.Empty)
                    throw new Exception("Введите размер коллекции");
                keyVal_list.Clear();
                int list_count = Convert.ToInt32(textBox1.Text);
                for (int counter = 0; counter < list_count; counter++)
                {
                    keyVal_list.Add(new keyVal((double)r.Next(100, 5000) / 1000, Color_Mass[r.Next(0, 5)]));
                }
                listBox3.Items.Clear();
                listBox2.Items.Clear();
                listBox1.Items.Clear();

                foreach (keyVal a in keyVal_list)
                {
                    listBox1.Items.Add(a.message());
                }
            }
            catch(Exception ex1)
            {
                MessageBox.Show(ex1.Message, "Обработано исключение:");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (char a1 in textBox1.Text)
                {
                    if (!charMass.Contains(a1))
                        throw new Exception("Коллекция отсутствует");
                }
                if (textBox1.Text == String.Empty)
                    throw new Exception("Коллекция не создана");
                listBox2.Items.Clear();
                List<keyVal> keyVal_list2 = new List<keyVal>();
                keyVal_list2 = keyVal_list;
                keyVal_list2.Sort();
                foreach (keyVal a in keyVal_list2)
                {
                    listBox2.Items.Add(a.message());
                }
            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message, "Обработано исключение:");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (char a1 in textBox1.Text)
                {
                    if (!charMass.Contains(a1))
                        throw new Exception("Коллекция отсутствует");
                }
                if (textBox1.Text == String.Empty)
                    throw new Exception("Коллекция не создана");
                listBox2.Items.Clear();
                List<keyVal> keyVal_list2 = new List<keyVal>();
                keyVal_list2 = keyVal_list;
                var ui = from t in keyVal_list2
                         orderby t.a.объём descending
                         select t;
                foreach (keyVal a in ui)
                {
                    listBox2.Items.Add(a.message());
                }
            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message, "Обработано исключение:");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (char a1 in textBox1.Text)
                {
                    if (!charMass.Contains(a1))
                        throw new Exception("Коллекция отсутствует");
                }
                if (textBox1.Text == String.Empty)
                    throw new Exception("Коллекция не создана");
                listBox3.Items.Clear();
                var z1 = from t in keyVal_list orderby t.a.объём ascending where t.a.объём > 3 && t.a.объём < 4.5 select t;
                listBox3.Items.Add("Отсортировано объектов: " + z1.Count());
                foreach (keyVal a in z1)
                {
                    listBox3.Items.Add(a.message());
                }
            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message, "Обработано исключение:");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (char a1 in textBox1.Text)
                {
                    if (!charMass.Contains(a1))
                        throw new Exception("Коллекция отсутствует");
                }
                if (textBox1.Text == String.Empty)
                    throw new Exception("Коллекция не создана");
                listBox3.Items.Clear();
                listBox3.Items.Add("С. мал.: " +keyVal_list.Min().message());
                listBox3.Items.Add("С. бол.: " + keyVal_list.Max().message());
            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message, "Обработано исключение:");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (char a1 in textBox1.Text)
                {
                    if (!charMass.Contains(a1))
                        throw new Exception("Коллекция отсутствует");
                }
                if (textBox1.Text == String.Empty)
                    throw new Exception("Коллекция не создана");
                listBox3.Items.Clear();
                var z3 = from t in keyVal_list orderby t.a.объём ascending where t.a.color == "Фиолетовая" && t.a.объём < 2 select t;
                listBox3.Items.Add("Отсортировано объектов: " + z3.Count());
                foreach (keyVal a in z3)
                {
                    listBox3.Items.Add(a.message());
                }
            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message, "Обработано исключение:");
            }
            }
    }
    public class Cup
    {
        public double объём;
        public string color;
        public Cup(double o, string c)
        {
            объём = o;
            color = c;
        }
    }

    public class keyVal : IComparable<keyVal>
    {
        public static string v = " кружка на ";
        public Cup a;
        public keyVal(double av, string c)
        {
            a = new Cup(av, c);
        }
        public string message()
        {
            string b = a.color + v + Convert.ToString(a.объём) + " л.";
            return (b);
        }

        public int CompareTo(keyVal obj)
        {
            return a.объём.CompareTo(obj.a.объём);
        }
    }
}
