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
                //starta upp fönstret som launchar en usercontrol
                //QuestingWindow.Main();

                //starta upp fönstret som en scheduled task så att usern ser den!
                TaskScheduler.Main();
            }
            catch (Exception e) 
            { 
                MessageBox.Show(e.ToString());
            }
        }






    }
}
