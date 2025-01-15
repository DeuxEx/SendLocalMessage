using System;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using static System.Net.Mime.MediaTypeNames;



namespace SendLocalMessage
{
    class Program
    {
        public static string rubriktext;
        public static string brodtext;
        public static string kontakttext;
        public static string telefontext;


        [STAThread]
        public static void Main(string[] args)
        {

            foreach (var arg in args)
            {
                if (arg.StartsWith("rubriktext="))
                {
                    string test = arg.Substring(arg.IndexOf("<") + "<".Length, arg.IndexOf(">") - arg.IndexOf("<") - ">".Length);
                    //läs det som är mellan situationstecknen
                    Program.rubriktext = test;
                    MessageBox.Show(Program.rubriktext);
                }
                if (arg=="action=generate")
                {
                    //rubrik, brödtext, kontakt, telefon

                    TaskScheduler.Main();
                }
                if (arg=="action=show")
                {
                    //visa ingenting om inte alla variabler är uppfyllda
                    QuestingWindow.Main();
                }
            }


            try
            {
                //starta upp fönstret som en scheduled task så att usern ser den!
                //TaskScheduler.Main();

                //starta upp fönstret som launchar en usercontrol
                //QuestingWindow.Main();

                //CreateImage.DrawText("Hej hopp på dig!", new Font("Arial", 14), System.Drawing.Color.White, System.Drawing.Color.Black);
            }
            catch (Exception e) 
            { 
                //MessageBox.Show(e.ToString());
            }
        }






    }
}
