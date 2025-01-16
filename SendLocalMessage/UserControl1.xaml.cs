using System;
using System.IO;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;



namespace SendLocalMessage
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        public static UserControl AppWindow; // lägg till denna för att kunna prata mellan classerna



        public UserControl1()
        {
            AppWindow = this;
            InitializeComponent();
            
            string message = Program.rubriktext + Environment.NewLine + 
                             Program.brodtext + Environment.NewLine;
            string kontakt1 = Environment.NewLine + Environment.NewLine + Program.kontakttext;
            string kontakt2 = Environment.NewLine + Program.telefontext;

            //test
            this.textfield.Text = message + kontakt1 + kontakt2;

            //kommunlogo

            Assembly Myassembly = Assembly.GetExecutingAssembly();
            Stream Mystreem = Myassembly.GetManifestResourceStream("SendLocalMessage.mtg-logo.jpg");
            BitmapImage Myimage = new BitmapImage();
        }



        private void Okbutton_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("Stäng");
            Environment.Exit(0);
        }



    }
}
