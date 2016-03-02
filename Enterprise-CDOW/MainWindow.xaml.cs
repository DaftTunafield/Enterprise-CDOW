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

            string strpercent11 = percentbox1x1.AcceptsReturn.ToString();
            int intpercent11 = Convert.ToInt32(strpercent11);

            string strpercent12 = percentbox1x2.AcceptsReturn.ToString();
            int intpercent12 = Convert.ToInt32(strpercent12);

            string strpercent13 = percentbox1x1.AcceptsReturn.ToString();
            int intpercent13 = Convert.ToInt32(strpercent13);


            string fabric21 = fabricsx2x1.SelectedValue.ToString();
            if (fabric21 == "Cashmere")
            {
                int b = 40;
            }
            else if (fabric21 == "Coduroy")
            {
                int b = 75;
            }
            else if (fabric21 == "Cotton")
            {
                int b = 70;
            }
            else if (fabric21 == "Denim")
            {
                int b = 75;
            }
            else if (fabric21 == "Flannel")
            {
                int b = 80;
            }
            else if (fabric21 == "Fleece")
            {
                int b = 65;
            }
            else if (fabric21 == "Gossamer")
            {
                int b = 35;
            }
            else if (fabric21 == "Hemp")
            {
                int b = 80;
            }
            else if (fabric21 == "Leather")
            {
                int b = 80;
            }
            else if (fabric21 == "Linen")
            {
                int b = 30;
            }
            else if (fabric21 == "Nylon")
            {
                int b = 80;
            }
            else if (fabric21 == "Polyester")
            {
                int b = 80;
            }
            else if (fabric21 == "Satin")
            {
                int b = 25;
            }
            else if (fabric21 == "Seersucker")
            {
                int b = 30;
            }
            else if (fabric21 == "Sheer")
            {
                int b = 15;
            }
            else if (fabric21 == "Silk")
            {
                int b = 30;
            }
            else if (fabric21 == "Spandex")
            {
                int b = 45;
            }
            else if (fabric21 == "Terrycloth")
            {
                int b = 70;
            }
            else if (fabric21 == "Velvet")
            {
                int b = 65;
            }
            else if (fabric21 == "Wool")
            {
                int b = 75;
            }

            string fabric22 = fabricsx2x2.SelectedValue.ToString();
            if (fabric22 == "Cashmere")
            {
                int b2 = 40;
            }
            else if (fabric22 == "Coduroy")
            {
                int b2 = 75;
            }
            else if (fabric22 == "Cotton")
            {
                int b2 = 70;
            }
            else if (fabric22 == "Denim")
            {
                int b2 = 75;
            }
            else if (fabric22 == "Flannel")
            {
                int b2 = 80;
            }
            else if (fabric22 == "Fleece")
            {
                int b2 = 65;
            }
            else if (fabric22 == "Gossamer")
            {
                int b2 = 35;
            }
            else if (fabric22 == "Hemp")
            {
                int b2 = 80;
            }
            else if (fabric22 == "Leather")
            {
                int b2 = 80;
            }
            else if (fabric22 == "Linen")
            {
                int b2 = 30;
            }
            else if (fabric22 == "Nylon")
            {
                int b2 = 80;
            }
            else if (fabric22 == "Polyester")
            {
                int b2 = 80;
            }
            else if (fabric22 == "Satin")
            {
                int b2 = 25;
            }
            else if (fabric22 == "Seersucker")
            {
                int b2 = 30;
            }
            else if (fabric22 == "Sheer")
            {
                int b2 = 15;
            }
            else if (fabric22 == "Silk")
            {
                int b2 = 30;
            }
            else if (fabric22 == "Spandex")
            {
                int b2 = 45;
            }
            else if (fabric22 == "Terrycloth")
            {
                int b2 = 70;
            }
            else if (fabric22 == "Velvet")
            {
                int b2 = 65;
            }
            else if (fabric22 == "Wool")
            {
                int b2 = 75;
            }

            string fabric23 = fabricsx2x3.SelectedValue.ToString();
            if (fabric23 == "Cashmere")
            {
                int b3 = 40;
            }
            else if (fabric23 == "Coduroy")
            {
                int b3 = 75;
            }
            else if (fabric23 == "Cotton")
            {
                int b3 = 70;
            }
            else if (fabric23 == "Denim")
            {
                int b3 = 75;
            }
            else if (fabric23 == "Flannel")
            {
                int b3 = 80;
            }
            else if (fabric23 == "Fleece")
            {
                int b3 = 65;
            }
            else if (fabric23 == "Gossamer")
            {
                int b3 = 35;
            }
            else if (fabric23 == "Hemp")
            {
                int b3 = 80;
            }
            else if (fabric23 == "Leather")
            {
                int b3 = 80;
            }
            else if (fabric23 == "Linen")
            {
                int b3 = 30;
            }
            else if (fabric23 == "Nylon")
            {
                int b3 = 80;
            }
            else if (fabric23 == "Polyester")
            {
                int b3 = 80;
            }
            else if (fabric23 == "Satin")
            {
                int b3 = 25;
            }
            else if (fabric23 == "Seersucker")
            {
                int b3 = 30;
            }
            else if (fabric23 == "Sheer")
            {
                int b3 = 15;
            }
            else if (fabric23 == "Silk")
            {
                int b3 = 30;
            }
            else if (fabric23 == "Spandex")
            {
                int b3 = 45;
            }
            else if (fabric23 == "Terrycloth")
            {
                int b3 = 70;
            }
            else if (fabric23 == "Velvet")
            {
                int b3 = 65;
            }
            else if (fabric23 == "Wool")
            {
                int b3 = 75;
            }

            string strpercent21 = percentbox2x1.AcceptsReturn.ToString();
            int intpercent21 = Convert.ToInt32(strpercent21);

            string strpercent22 = percentbox2x2.AcceptsReturn.ToString();
            int intpercent22 = Convert.ToInt32(strpercent22);

            string strpercent23 = percentbox2x3.AcceptsReturn.ToString();
            int intpercent23 = Convert.ToInt32(strpercent23);


            string strtemp1 = temp1.AcceptsReturn.ToString();
            int inttemp1 = Convert.ToInt32(strtemp1);

            string strtemp2 = temp2.AcceptsReturn.ToString();
            int inttemp2 = Convert.ToInt32(strtemp2);

            string strtemp3 = temp3.AcceptsReturn.ToString();
            int inttemp3 = Convert.ToInt32(strtemp3);

            string strtemp4 = temp4.AcceptsReturn.ToString();
            int inttemp4 = Convert.ToInt32(strtemp4);




        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
