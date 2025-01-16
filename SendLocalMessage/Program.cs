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



        /*
         Anrop exempel
        C:\Users\Admin\source\repos\DeuxEx\SendLocalMessage\SendLocalMessage\bin\Debug\SendLocalMessage.exe rubriktext=<Angående Net-ID som finns i din dator.> brodtext=<Programvaran kommer att avinstalleras den 30/6 och om du då har behov av att fortsatt använda det så ombeds du kontakta it-support så hjälper vi till att installera det nya E-id på din dator.> kontakttext=<Kontakt : itsupport@toreboda.se> telefontext=<Telefon : 0501-755070> action=generate 
         */



        [STAThread]
        public static void Main(string[] args)
        {
            if (args.Length == 0) 
            {
                MessageBox.Show("Syntax: rubriktext= slutrubriktext brodtext= slutbrodtext kontakttext= slutkontakttext telefontext= sluttelefontext action=generate action=show");
            }

            //ta fram hela syntaxen som en array
            string[] arguments = Environment.GetCommandLineArgs();

            //slå ihop alla strings och lägg space emellan
            string completearguments = string.Join(" ", arguments);

            //MessageBox.Show(completearguments);


            int rubriktextFrom = completearguments.IndexOf("rubriktext=") + "rubriktext=".Length;
            int rubriktextTo = completearguments.LastIndexOf("slutrubriktext");
            Program.rubriktext = completearguments.Substring(rubriktextFrom, rubriktextTo - rubriktextFrom);

            int brodtextFrom = completearguments.IndexOf("brodtext=") + "brodtext=".Length;
            int brodtextTo = completearguments.LastIndexOf("slutbrodtext");
            Program.brodtext = completearguments.Substring(brodtextFrom, brodtextTo - brodtextFrom);

            int kontakttextFrom = completearguments.IndexOf("kontakttext=") + "kontakttext=".Length;
            int kontakttextTo = completearguments.LastIndexOf("slutkontakttext");
            Program.kontakttext = completearguments.Substring(kontakttextFrom, kontakttextTo - kontakttextFrom);

            int telefontextFrom = completearguments.IndexOf("telefontext=") + "telefontext=".Length;
            int telefontextTo = completearguments.LastIndexOf("sluttelefontext");
            Program.telefontext = completearguments.Substring(telefontextFrom, telefontextTo - telefontextFrom);


            //MessageBox.Show(Program.rubriktext);
            //MessageBox.Show(Program.brodtext);
            //MessageBox.Show(Program.kontakttext);
            //MessageBox.Show(Program.telefontext);


            foreach (var arg in args)
            {
                //MessageBox.Show(arg);

                if (arg=="action=generate")
                {
                    //visa ingenting om inte alla variabler är uppfyllda
                    if ((Program.rubriktext.Length  > 0) && (Program.brodtext.Length > 0) && (Program.kontakttext.Length > 0) && (Program.telefontext.Length > 0))
                    {
                        TaskScheduler.Main();
                    }
                }
                if (arg=="action=show")
                {
                    //visa ingenting om inte alla variabler är uppfyllda
                    if ((Program.rubriktext.Length > 0) && (Program.brodtext.Length > 0) && (Program.kontakttext.Length > 0) && (Program.telefontext.Length > 0))
                    {
                        QuestingWindow.Main();
                    }
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
