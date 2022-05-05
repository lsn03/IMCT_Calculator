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
        //Calculate calculate = new Calculate();

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

        private string memory = "";
        private  bool reverse = false;
        private  bool sqrt = false;
        private  bool percent = false;
        private string firstString = "",secondString = "";
        private string operand = "";
        double first,second;
        private void Button_Click( object sender, RoutedEventArgs e )
        {
            var str = (string)((Button)e.OriginalSource).Content;

            if ( fieldText.Text.Contains( "Error." ) )
            {
                fieldText.Text = "";
            }

            if ( str == "MC" )
            {

            }
            else if ( str == "MR" )
            {

            }
            else if ( str == "MS" ) // memory save
            {

            }
            else if ( str == "M+" )
            {

            }
            else if ( str == "M-" )
            {

            }
            else if ( str == "CE" ) // убюирает ласт ввод (число)
            {

            }
            else if ( str == "C" ) // убирает все
            {

            }
            else if ( str == "←" )
            {
                if ( fieldText.Text.Length != 0 )
                {
                    fieldText.Text = fieldText.Text.Remove( fieldText.Text.Length - 1 );
                }

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

            }
            else if ( str == "+" )
            {
                operand = "+";
                ParseFromInputToLog();
            }
            else if ( str == "-" )
            {
                operand = "-";
                ParseFromInputToLog();
            }
            else if ( str == "*" )
            {
                operand = "*";
                ParseFromInputToLog();
            }
            else if ( str == "/" )
            {
                operand = "/";
                ParseFromInputToLog();
            }
            else if ( str == "=" )
            {
                switch ( operand )
                {
                    case "+":
                        fieldText.Text = CalculateFunction.Add( double.Parse( firstString ), double.Parse( secondString ) );
                        break;
                    case "-":
                        fieldText.Text = CalculateFunction.Subtract( double.Parse( firstString ), double.Parse( secondString ) );
                        break;
                    case "*":
                        fieldText.Text = CalculateFunction.Mul( double.Parse( firstString ), double.Parse( secondString ) );
                        break;
                    case "/":
                        fieldText.Text = CalculateFunction.Divide( double.Parse( firstString ), double.Parse( secondString ) );
                        break;
                }
            }
            else
            {
                
                fieldText.Text += str;

                secondString = fieldText.Text;
                
                


            }
        }
        private void ParseFromInputToLog()
        {
            firstString = fieldText.Text;
            fieldText.Text = "";
            logText.Text += firstString + operand;
        }

    }
    class CalculateFunction
    {
        public static string Add(Int64 a,Int64 b)
        {
            return (a + b).ToString();
        }
        public static string Add( Int64 a, double b )
        {
            return ( a + b ).ToString();
        }
        public static string Add( double a, Int64 b )
        {
            return ( a + b ).ToString();
        }
        public static string Add( double a, double b )
        {
            return ( a + b ).ToString();
        }
        public static string Subtract( Int64 a, Int64 b )
        {
            return (a - b).ToString();
        }
        public static string Subtract( Int64 a, double b )
        {
            return ( a - b ).ToString();
        }
        public static string Subtract( double a, Int64 b )
        {
            return ( a - b ).ToString();
        }
        public static string Subtract( double a, double b )
        {
            return (a - b).ToString(); 
        }
        public static string Mul( double a, double b )
        {
            return ( a * b ).ToString();
        }
        public static string Divide( double a, double b )
        {
            return ( a / b ).ToString();
        }



    }
}
