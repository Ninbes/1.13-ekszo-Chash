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

namespace elso
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int a = int.Parse(szam.Text);
                int b = int.Parse(szam2.Text);
                string s = muv.Text;

                int c = 0;
                if (s== "+")
                {
                    c = a+b;
                }
                else if (s== "-")
                {
                    c = a-b;
                }
                else if (s== "*")
                {
                    c = a*b;
                }
                else if (s== "/")
                {
                    c = a/b;
                }
                else if (s== "%")
                {
                    c = a%b;
                }
                e1.Text = c+"";
                szam.Text = "";
                szam2.Text = "";

            }
            catch
            {
                MessageBox.Show("rosszul adtad meg a számot!");
                szam.Text = "";
                szam2.Text = "";
                e1.Text = "...";
            }
        }
    }
}
