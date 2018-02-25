using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Lab1
{
    /*Приложение Калькулятор для вещественных Сложение, вычитание, деление,button4.Hide();
     * умножение двух вещественных чисел, извлечение корня, sin, cos, хранение значения в памяти.*/

    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
