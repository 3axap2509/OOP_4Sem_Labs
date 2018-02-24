using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab_002
{
     //Банк.Объект –«Счет». Поля: номер, тип вклада, баланс, дата открытия, владелец,
     //подключение смс оповещения, подключение интернет-банкинга и т.д.Агрегируемый
     //объект –«Владелец». Поля: ФИО, дата рождения, паспортные данныеи т.д.Дополнительно:
     //Агрегируемый объект –«История операций». Поля: тип операции, сумма, дата и т.д
    public enum Schet_type
    {
        Накопительный = 1,
        Рассчётный,
        Сберегательный
    }
    public class Schet
    {
        public Schet(uint n, string owner_f_name, string owner_s_name, string owner_l_name, string owner_psn, DateTime owner_bd, uint _type = 3, // 1 - накопительный, 2 - рассчётный, 3 - сберегательный
                                                                                                                                long _balance = 0)
        {
            number = n.ToString();
            open_date = DateTime.Now;
            is_blocked = false;
            Owner s_owner = new Owner(owner_f_name, owner_s_name, owner_l_name, owner_psn, owner_bd);
            balance = _balance;
            type = (Schet_type)_type;
            SMS_notifications = false;
            notifications_phone = String.Empty;
            internet_banking = false;
            operation_list = new List<Operation>();
        }
        public string number;
        public Schet_type type;
        public long balance;
        public DateTime open_date;
        public Owner owner;
        public bool is_blocked;
        public bool SMS_notifications;
        public bool internet_banking;
        public string notifications_phone;
        public List<Operation> operation_list;

        public override string ToString()
        {
            string sms;
            string ib;
            string blocked;
            if (SMS_notifications)
                sms = "подключено";
            else
                sms = "не поделючено";
            if (internet_banking)
                ib = "подключен";
            else
                ib = "не подключен";
            if (is_blocked)
                blocked = "да";
            else
                blocked = "нет";
            StringBuilder sb = new StringBuilder();
            sb.Insert(sb.Length,"Информация о банковском счёте:\n");
            sb.Insert(sb.Length, "\tНомер: " + number + '\n');
            sb.Insert(sb.Length, "\tТип: " + type.ToString() + '\n');
            sb.Insert(sb.Length, "\tДата создания: " + open_date.ToString() + '\n');
            sb.Insert(sb.Length, "\tВладелец:" + owner.ToString());
            sb.Insert(sb.Length, "\tБаланс: " + balance.ToString() + '\n');
            sb.Insert(sb.Length, "\tЗаблокирован?: " + blocked + '\n');
            sb.Insert(sb.Length, "\tСМС-оповещения: " + sms + '\n');
            if(SMS_notifications)
                sb.Insert(sb.Length, "\t\tНомер для оповещения: " + notifications_phone + '\n');
            sb.Insert(sb.Length, "\tИнтернет-банкинг: " + ib + '\n');

            return sb.ToString();
        }
        public void Add_operation(uint _type, // 1 - зачисление, 2 - снятие
                                    uint _sum)
        {
            Operation o = new Operation(_type, _sum);
            operation_list.Insert(0, o);
        }

        public void Add_SMS_notifications(string phone_number)
        {
            SMS_notifications = true;
            notifications_phone = phone_number;
        }
        public void Remove_SMS_notifications(string phone_number)
        {
            SMS_notifications = false;
            notifications_phone = String.Empty;
        }

        public void Add_Internet_banking()
        {
            internet_banking = true;
        }
        public void Remove_Internet_banking()
        {
            internet_banking = false;
        }
    }
}
