using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32.TaskScheduler;


namespace SendLocalMessage
{
    internal class TaskScheduler
    {
        
        public static void Main()
        {
            //https://www.youtube.com/watch?v=d-R2xSW_CEA


            string taskName = "SendLocalMessage";
            string launchexefile = @"C:\Users\Admin\source\repos\DeuxEx\SendLocalMessage\SendLocalMessage\bin\Debug\SendLocalMessage.exe";
            TaskDefinition taskDefinition = TaskService.Instance.NewTask();

            taskDefinition.RegistrationInfo.Author = "MTG-IT";
            taskDefinition.RegistrationInfo.Description = "Sends localmessage to currently logged on user";

            // rubriktext=<rubrik> brodtext=<brod> kontakttext=<kontakt> telefontext=<telefon> action=generate

            taskDefinition.Actions.Add(new ExecAction(launchexefile, "rubriktext="+Program.rubriktext+"slutrubriktext brodtext="+Program.brodtext+"slutbrodtext kontakttext="+Program.kontakttext+"slutkontakttext telefontext="+Program.telefontext+"sluttelefontext action=show"));

            //Skapa tasken, kör tasken direkt genom att lägga .run() efteråt.
            TaskService.Instance.RootFolder.RegisterTaskDefinition(taskName, taskDefinition).Run();

            //delete task
            TaskService.Instance.RootFolder.DeleteTask(taskName, false);
        }


    }
}
