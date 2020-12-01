using System;
using System.Text;
using Project_1_Viet_9713.Presentation;

namespace Project_1_Viet_9713
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            GUI_Chinh GUI = new GUI_Chinh();
            GUI.MENU();
        }
    }
}
