using System;
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
                

            }
            catch (Exception e) 
            { 
                MessageBox.Show(e.ToString());
            }
        }






    }
}
