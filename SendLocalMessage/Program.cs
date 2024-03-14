using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SendLocalMessage
{
    class Program
    {



        [STAThread]
        public static void Main(string[] args)
        {
            try
            {
                QuestingWindow.Main();

                //UserControl1 userControl1 = new UserControl1();

            }
            catch (Exception e) 
            { 
                MessageBox.Show(e.ToString());
            }
        }






    }
}
