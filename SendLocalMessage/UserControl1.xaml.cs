using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml;
using static System.Net.Mime.MediaTypeNames;



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

            string message = "Angående Net-ID som finns i din dator." + Environment.NewLine + 
                             "Programvaran kommer att avinstalleras den 30/6 och om du då har behov av att fortsatt använda det så ombeds du " +
                             "kontakta it-support så hjälper vi till att installera det nya E-id på din dator." + Environment.NewLine;
            string kontakt1 = Environment.NewLine + Environment.NewLine + "Kontakt : itsupport@toreboda.se";
            string kontakt2 = Environment.NewLine + "Telefon : 0501-755070";

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
