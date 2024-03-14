using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;



namespace SendLocalMessage
{
    internal class QuestingWindow
    {
        public static Window window;


        public static void Main()
        {

            window = new Window
            {
                Content = new UserControl1(),
                Height = UserControl1.AppWindow.Height,
                Width = UserControl1.AppWindow.Width,
                WindowStartupLocation = WindowStartupLocation.CenterScreen,
                Topmost = true
            };
            window.ShowDialog();
        }
    }
}
