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
                //starta upp fönstret
                QuestingWindow.Main();
                
                
                //fyll rutorna med formatterad text
                //SendLocalMessage.UserControl1.SetTextFieldData("testar");

            }
            catch (Exception e) 
            { 
                MessageBox.Show(e.ToString());
            }
        }






    }
}
