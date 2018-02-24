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
    public partial class Form3 : Form
    {
        ushort index;
        uint S_counter;
        Form1 f1;
        bool is_object_saved = false;
        Schet schet;
        public Form3( uint s, Form1 F1)
        {
            
            F1.Disable_Form();
            f1 = F1;
            S_counter = s;
            InitializeComponent();
            Nakop_radio.Select();
            Unblocked_radio.Select();
            I_bank_ON_radio.Select();
            SMS_ON_radio.Select();
        }

        public Form3(Form1 F1)
        {
            F1.Disable_Form();
            f1 = F1;
            InitializeComponent();
            Nakop_radio.Select();
            Unblocked_radio.Select();
            I_bank_ON_radio.Select();
            SMS_ON_radio.Select();
        }



        public Form3(Schet sc, ushort ind, Form1 F1)
        {
            F1.Disable_Form();
            index = ind;
            if (sc.is_blocked)
                Blocked_radio.Select();
            else
                Unblocked_radio.Select();
            if (sc.SMS_notifications)
                SMS_ON_radio.Select();
            else
                SMS_OFF_radio.Select();
            if (sc.internet_banking)
                I_bank_ON_radio.Select();
            else
                I_bank_OFF_radio.Select();
            if (sc.type == (Schet_type)1)
                Nakop_radio.Select();
            else if (sc.type == (Schet_type)2)
                Rasschet_radio.Select();
            else
                Sber_radio.Select();
            Birth_date_picker.Value = sc.owner.birth_date;
            FName_textBox.Text = sc.owner.FName;
            SName_texBox.Text = sc.owner.SName;
            LName_textBox.Text = sc.owner.LName;
            PSN_textBox.Text = sc.owner.passport_serial_number;

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            f1.Enable_Form();
            if (is_object_saved)
            {
                f1.Schet_List.Add(schet);
                f1.plus_counter();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            { 
            if (FName_textBox.Text != String.Empty && SName_texBox.Text != String.Empty && LName_textBox.Text != String.Empty && PSN_textBox.Text != String.Empty)
            { // тип счёта
                uint t;
                if (Sber_radio.Checked)
                    t = 3;
                else if (Nakop_radio.Checked)
                    t = 1;
                else
                    t = 2;
                    if (DateTime.Now - Birth_date_picker.Value < new TimeSpan(18 * 365 + 4, 0, 0, 0, 0))
                        throw new Exception("Нельзя открыть счёт на лицо, не достигшее 18 лет");
                schet = new Schet(S_counter, FName_textBox.Text, SName_texBox.Text, LName_textBox.Text, PSN_textBox.Text, Birth_date_picker.Value, t);
                if (I_bank_ON_radio.Checked)
                    schet.internet_banking = true;
                else
                    schet.internet_banking = false;
                if (SMS_ON_radio.Checked)
                {
                    schet.SMS_notifications = true;
                    if(Mobile_phone_textBox.Text != String.Empty)
                        schet.notifications_phone = Mobile_phone_textBox.Text;
                    else
                        throw new Exception("Не все поля данных заполнены");
                }
                else
                {
                    schet.SMS_notifications = false;
                    schet.notifications_phone = String.Empty;
                }
                if (Blocked_radio.Checked)
                    schet.is_blocked = true;
                else
                    schet.is_blocked = false;
                f1.plus_counter();
                this.Close();
            }
            else
                MessageBox.Show("Не все поля данных заполнены", "Уведомление");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Уведомление");
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (SMS_OFF_radio.Checked)
            {
                label10.Hide();
                Mobile_phone_textBox.Hide();
            }
            else
            {
                label10.Show();
                Mobile_phone_textBox.Show();
            }
        }
    }
}
