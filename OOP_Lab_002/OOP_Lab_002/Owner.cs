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
    public class Owner
    {
        public Owner(string fn, string sn, string ln, string psn, DateTime bd)
        {
            FName = fn;
            SName = sn;
            LName = ln;
            passport_serial_number = psn;
            birth_date = bd;
        }

        public DateTime birth_date;
        public string FName;
        public string SName;
        public string LName;
        public string passport_serial_number;

        public override string ToString()
        {
            return $"\n\t\tИмя: {FName}\n\t\tФамилия: {SName}\n\t\tОтчество: {LName}";
        }
    }
}
