using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Lab_002
{
    public partial class Form1 : Form
    {
        public List<Schet> Schet_List = new List<Schet>();
        public void Add_Schet(Schet s)
        {
            Schet_List.Add(s);
        }

        public static uint Schet_numbers_counter = 1;
        public Form1()
        {
            InitializeComponent();
            Text = "Банк";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        public void Enable_Form()
        {
            this.Enabled = true;
        }

        public void Disable_Form()
        {
            this.Enabled = false;
        }

        public void plus_counter()
        {
            Schet_numbers_counter+=1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 newForm = new Form3(Schet_numbers_counter,this);
            newForm.Text = $"Создание счёта № {Schet_numbers_counter}";
            newForm.Show();
        }
    }
}
