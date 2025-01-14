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


            string taskName = "Open Notepad++";
            TaskDefinition taskDefinition = TaskService.Instance.NewTask();

            taskDefinition.RegistrationInfo.Author = "BlueHippo";
            taskDefinition.RegistrationInfo.Description = "Sample task opening notepad++";
            
            taskDefinition.Actions.Add(new ExecAction(@"c:\Program Files (x86)\Notepad++\notepad++.exe"));

            //Skapa tasken, kör tasken direkt genom att lägga .run() efteråt.
            TaskService.Instance.RootFolder.RegisterTaskDefinition(taskName, taskDefinition);//.Run();

            //TaskService.Instance.RootFolder.DeleteTask(taskName, false);
        }


    }
}
