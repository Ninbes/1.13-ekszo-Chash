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

namespace Feladat_PBM
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

        private void Bemenet_TextChanged(object sender, TextChangedEventArgs e)
        {            
            output.Text = "Karaktererk száma: " + Bemenet.Text.Length.ToString();
            if (Bemenet.Text.Length % 2 == 0)
            {
                output2.Text = "A karakterek száma: Páros";
            }
            else
            {               
                output2.Text = "A karakterek száma: Páratlan";
            }
        }
    }
}
