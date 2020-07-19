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

namespace Procesor
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        string cellValue;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string aX, bX, cX, dX,endAX,endBX,endCX,endDX;
            
            aX = TextA.Text;
            bX = TextB.Text;
            cX = TextC.Text;
            dX = TextD.Text;
            
            if (AX.IsChecked==true)
            {
                cellValue = aX;
            }
            if (AXBox.IsChecked == true)
            {
                aX = cellValue;
            }
            if (BX.IsChecked == true)
            {
                cellValue = bX;
            }
            if (BXBox.IsChecked == true)
            {
                bX = cellValue;
            }
            if (CX.IsChecked == true)
            {
                cellValue = cX;
            }
            if (CXBox.IsChecked == true)
            {
                cX = cellValue;
            }
            if (DX.IsChecked == true)
            {
                cellValue = dX;
            }
            if (DXBox.IsChecked == true)
            {
                dX = cellValue;
            }
            TextA.Text = aX;
            TextB.Text = bX;
            TextC.Text = cX;
            TextD.Text = dX;
            
        }

        private void BX_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
