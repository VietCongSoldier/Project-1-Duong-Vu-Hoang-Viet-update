using System;
using System.Collections.Generic;
using System.Text;
using Project_1_Viet_9713.Presentation;

namespace Project_1_Viet_9713
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            GUI_Chinh GUIChinh = new GUI_Chinh();
            GUIChinh.MENU();
        }
    }
}
