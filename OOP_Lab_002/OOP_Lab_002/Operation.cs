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
    public enum Operation_type
    {
        Зачисление = 1,
        Снятие
    }
    public class Operation
    {
        public Operation_type type;
        public ulong sum;
        public DateTime date;
        public Operation(uint ot, ulong s)
        {
            type = (Operation_type)ot;
            sum = s;
            date = DateTime.Now;
        }
    }
}
