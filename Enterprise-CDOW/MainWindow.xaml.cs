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

namespace Enterprise_CDOW
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            string fabric11 = fabricsx1x1.SelectedValue.ToString();
            if (fabric11 == "Cashmere")
            {
                int a = 40;
            }
            else if (fabric11 == "Coduroy")
            {
                int a = 75;
            }
            else if (fabric11 == "Cotton")
            {
                int a = 70;
            }
            else if (fabric11 == "Denim")
            {
                int a = 75;
            }
            else if (fabric11 == "Flannel")
            {
                int a = 80;
            }
            else if (fabric11 == "Fleece")
            {
                int a = 65;
            }
            else if (fabric11 == "Gossamer")
            {
                int a = 35;
            }
            else if (fabric11 == "Hemp")
            {
                int a = 80;
            }
            else if (fabric11 == "Leather")
            {
                int a = 80;
            }
            else if (fabric11 == "Linen")
            {
                int a = 30;
            }
            else if (fabric11 == "Nylon")
            {
                int a = 80;
            }
            else if (fabric11 == "Polyester")
            {
                int a = 80;
            }
            else if (fabric11 == "Satin")
            {
                int a = 25;
            }
            else if (fabric11 == "Seersucker")
            {
                int a = 30;
            }
            else if (fabric11 == "Sheer")
            {
                int a = 15;
            }
            else if (fabric11 == "Silk")
            {
                int a = 30;
            }
            else if (fabric11 == "Spandex")
            {
                int a = 45;
            }
            else if (fabric11 == "Terrycloth")
            {
                int a = 70;
            }
            else if (fabric11 == "Velvet")
            {
                int a = 65;
            }
            else if (fabric11 == "Wool")
            {
                int a = 75;
            }

            string fabric12 = fabricsx1x2.SelectedValue.ToString();
            if (fabric12 == "Cashmere")
            {
                int a2 = 40;
            }
            else if (fabric12 == "Coduroy")
            {
                int a2 = 75;
            }
            else if (fabric12 == "Cotton")
            {
                int a2 = 70;
            }
            else if (fabric12 == "Denim")
            {
                int a2 = 75;
            }
            else if (fabric12 == "Flannel")
            {
                int a2 = 80;
            }
            else if (fabric12 == "Fleece")
            {
                int a2 = 65;
            }
            else if (fabric12 == "Gossamer")
            {
                int a2 = 35;
            }
            else if (fabric12 == "Hemp")
            {
                int a2 = 80;
            }
            else if (fabric12 == "Leather")
            {
                int a2 = 80;
            }
            else if (fabric12 == "Linen")
            {
                int a2 = 30;
            }
            else if (fabric12 == "Nylon")
            {
                int a2 = 80;
            }
            else if (fabric12 == "Polyester")
            {
                int a2 = 80;
            }
            else if (fabric12 == "Satin")
            {
                int a2 = 25;
            }
            else if (fabric12 == "Seersucker")
            {
                int a2 = 30;
            }
            else if (fabric12 == "Sheer")
            {
                int a2 = 15;
            }
            else if (fabric12 == "Silk")
            {
                int a2 = 30;
            }
            else if (fabric12 == "Spandex")
            {
                int a2 = 45;
            }
            else if (fabric12 == "Terrycloth")
            {
                int a2 = 70;
            }
            else if (fabric12 == "Velvet")
            {
                int a2 = 65;
            }
            else if (fabric12 == "Wool")
            {
                int a2 = 75;
            }

            string fabric13 = fabricsx1x3.SelectedValue.ToString();
            if (fabric13 == "Cashmere")
            {
                int a3 = 40;
            }
            else if (fabric13 == "Coduroy")
            {
                int a3 = 75;
            }
            else if (fabric13 == "Cotton")
            {
                int a3 = 70;
            }
            else if (fabric13 == "Denim")
            {
                int a3 = 75;
            }
            else if (fabric13 == "Flannel")
            {
                int a3 = 80;
            }
            else if (fabric13 == "Fleece")
            {
                int a3 = 65;
            }
            else if (fabric13 == "Gossamer")
            {
                int a3 = 35;
            }
            else if (fabric13 == "Hemp")
            {
                int a3 = 80;
            }
            else if (fabric13 == "Leather")
            {
                int a3 = 80;
            }
            else if (fabric13 == "Linen")
            {
                int a3 = 30;
            }
            else if (fabric13 == "Nylon")
            {
                int a3 = 80;
            }
            else if (fabric13 == "Polyester")
            {
                int a3 = 80;
            }
            else if (fabric13 == "Satin")
            {
                int a3 = 25;
            }
            else if (fabric13 == "Seersucker")
            {
                int a3 = 30;
            }
            else if (fabric13 == "Sheer")
            {
                int a3 = 15;
            }
            else if (fabric13 == "Silk")
            {
                int a3 = 30;
            }
            else if (fabric13 == "Spandex")
            {
                int a3 = 45;
            }
            else if (fabric13 == "Terrycloth")
            {
                int a3 = 70;
            }
            else if (fabric13 == "Velvet")
            {
                int a3 = 65;
            }
            else if (fabric13 == "Wool")
            {
                int a3 = 75;
            }

            string percent11 = percentbox1x3.Text.ToString();
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
