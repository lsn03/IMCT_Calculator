using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
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

namespace Calculator
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ButtonBruteForce();
        }
        private void ButtonBruteForce()
        {
            foreach(var element in MainGrid.Children )
            {
               if( element is Button ) 
                    ( ( Button )element ).Click += Button_Click;
            }
        }

        private void Button_Click( object sender, RoutedEventArgs e )
        {
            var str = (string)((Button)e.OriginalSource).Content;
            if ( str == "MC" )
            {

            }
            else if ( str == "MR" )
            {

            }
            else if ( str == "MS" )
            {

            }
            else if ( str == "M+" )
            {

            }
            else if ( str == "M-" )
            {

            }
            else if ( str == "CE" )
            {

            }
            else if ( str == "C" )
            {

            }
            else if ( str == "±" )
            {

            }
            else if ( str == "√" )
            {

            }
            else if ( str == "%" )
            {

            }
            else if ( str == "1/x" )
            {

            }else if(str == "←" )
            {

            }
            else if ( str == "=" )
            {
                string value;
                try
                {
                    value = new DataTable().Compute( fieldText.Text, null ).ToString();
                    fieldText.Text = value;
                }

                catch
                {
                    fieldText.Text = "Error.";
                }

            }
            else if(fieldText.Text.Contains("Error."))
            {
                fieldText.Text = "";
            }
            else
            {
                fieldText.Text += str;
            }
        }
    }
}
