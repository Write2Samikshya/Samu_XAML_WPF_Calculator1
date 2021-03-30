using System;
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

namespace MyCalculatorProjSamuWpfMyapp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            TxtSpaceBig.Text = TxtSpaceBig.Text + "0";
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            TxtSpaceBig.Text = TxtSpaceBig.Text + "1";
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            TxtSpaceBig.Text = TxtSpaceBig.Text + "2";
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            TxtSpaceBig.Text = TxtSpaceBig.Text + "3";
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            TxtSpaceBig.Text = TxtSpaceBig.Text + "4";
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            TxtSpaceBig.Text = TxtSpaceBig.Text + "5";
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            TxtSpaceBig.Text = TxtSpaceBig.Text + "6";
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            TxtSpaceBig.Text = TxtSpaceBig.Text + "7";
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            TxtSpaceBig.Text = TxtSpaceBig.Text + "9";
        }

        private void btncancel_Click(object sender, RoutedEventArgs e)
        {
            TxtSpaceBig.Text = "";
        }

        private void btnadd_Click(object sender, RoutedEventArgs e)
        {
            TxtSpaceBig.Text = TxtSpaceBig.Text + "+";
        }

        private void btnminus_Click(object sender, RoutedEventArgs e)
        {
            TxtSpaceBig.Text = TxtSpaceBig.Text + "-";
        }

        private void btnresult_Click(object sender, RoutedEventArgs e)
        {
            if (TxtSpaceBig.Text != "" )
            {

                Type scriptType = Type.GetTypeFromCLSID(Guid.Parse("0E59F1D5-1FBE-11D0-8FF2-00A0D10038BC"));

                dynamic obj = Activator.CreateInstance(scriptType, false);
                obj.Language = "javascript";
                string str = null;
                try
                {
                    var res = obj.Eval(TxtSpaceBig.Text);
                    str = Convert.ToString(res);
                    TxtSpaceBig.Text = TxtSpaceBig.Text + "=" + str;
                }
                catch (SystemException)
                {
                    TxtSpaceBig.Text = "Syntax Error";
                }

            }




        }
    }
}
