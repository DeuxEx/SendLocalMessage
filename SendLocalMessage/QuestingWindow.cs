using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;



namespace SendLocalMessage
{
    internal class QuestingWindow
    {
        public static Window window;


        public BitmapSource GetSourceForOnRender()
        {
            var assembly = System.Reflection.Assembly.GetExecutingAssembly();
            var bitmap = new BitmapImage();

            using (var stream =
                assembly.GetManifestResourceStream("KisserConsole.someImage.png"))
            {
                bitmap.BeginInit();
                bitmap.StreamSource = stream;
                bitmap.CacheOption = BitmapCacheOption.OnLoad;
                bitmap.EndInit();
            }

            return bitmap;
        }



        public static void Main()
        {

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();


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
