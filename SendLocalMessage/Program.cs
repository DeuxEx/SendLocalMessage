using System;
using System.Drawing;
using System.Drawing.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;



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

                CreateImage.DrawText("Hej hopp på dig!", new Font("Arial", 14), System.Drawing.Color.White, System.Drawing.Color.Black);
            }
            catch (Exception e) 
            { 
                MessageBox.Show(e.ToString());
            }
        }






    }
}
