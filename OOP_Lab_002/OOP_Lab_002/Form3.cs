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
    /// <summary>
    /// Форма 3
    /// Создание новых и редактирование уже существующих банковских счетов
    /// 2 конструктора для 2 типов вызова
    /// если создаём новый счёт:
    ///     вызывается конструктор №1
    ///     логической переменной is_new присваевается значение TRUE
    ///     /дальнейшая обработка/
    /// если редактируем существующий объект:
    ///     вызывается конструктор №2
    ///     в него передаём требуемый экземпляр
    ///     логической переменной is_new присваевается значение FALSE
    ///     /дальнейшая обработка/
    /// </summary>
    public partial class Form3 : Form
    {
        //Переменные и свойства
        bool is_new;
        ushort index; // получаемый во 2-м конструкторе индекс объекта в списке
        uint S_counter; // получаемый в 1-м конструкторе 
        Form1 f1; // объект, который в будущем будет равен ссылке на объект, который вызывает конструктор текущего объекта
        bool is_object_saved = false; // для проверки ошибок
        Schet Buf_Schet; // объект, который буден возвращён в качестве созданного/изменённого


        // конструкторы
        #region kon
        public Form3(                               // Конструктор №1(создание)
            uint s,  // порядковый номер создаваемого счёта
            Form1 F1 // вызывающий объект
            )
        {
            is_new = true;
            F1.Disable_Form();
            f1 = F1;
            S_counter = s;
            InitializeComponent();
            Nakop_radio.Select();       // для уменьшения количества 
            Unblocked_radio.Select();   // возможных ошибок при 
            I_bank_ON_radio.Select();   // использовании формы
            SMS_ON_radio.Select();      //
        }
        public Form3(                               // Конструктор №2(изменение)
            Schet sc, // объект для изменения
            ushort ind, // его индекс в списке объектов
            Form1 F1 // вызывающий объект
            )
        {
            F1.Disable_Form();
            f1 = F1;
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
        #endregion
        //Используемые методы ЭУ
        #region IMEY
        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            f1.Enable_Form();
            if (is_object_saved)
            {
                f1.Schet_List.Add(Buf_Schet);
                f1.plus_counter();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            { 
            if (FName_textBox.Text != String.Empty && SName_texBox.Text != String.Empty && LName_textBox.Text != String.Empty && PSN_textBox.Text != String.Empty)
            { 
                // тип счёта
                uint t;
                if (Sber_radio.Checked)
                    t = 3;
                else if (Nakop_radio.Checked)
                    t = 1;
                else
                    t = 2;

                if (DateTime.Now - Birth_date_picker.Value < new TimeSpan(18 * 365 + 4, 0, 0, 0, 0))
                        throw new Exception("Нельзя открыть счёт на лицо, не достигшее 18 лет");
                Buf_Schet = new Schet(S_counter, FName_textBox.Text, SName_texBox.Text, LName_textBox.Text, PSN_textBox.Text, Birth_date_picker.Value, t);
                if (I_bank_ON_radio.Checked)
                    Buf_Schet.internet_banking = true;
                else
                    Buf_Schet.internet_banking = false;
                if (SMS_ON_radio.Checked)
                {
                    Buf_Schet.SMS_notifications = true;
                    if(Mobile_phone_textBox.Text != String.Empty)
                        Buf_Schet.notifications_phone = Mobile_phone_textBox.Text;
                    else
                        throw new Exception("Не все поля данных заполнены");
                }
                else
                {
                    Buf_Schet.SMS_notifications = false;
                    Buf_Schet.notifications_phone = String.Empty;
                }
                if (Blocked_radio.Checked)
                    Buf_Schet.is_blocked = true;
                else
                    Buf_Schet.is_blocked = false;
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
        #endregion
        //Неиспользуемые методы ЭУ(созданы случайно)
        #region NMEY
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
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        #endregion
    }
}
