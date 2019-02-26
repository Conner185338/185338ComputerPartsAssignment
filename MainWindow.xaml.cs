/* Conner Warboys
 * February 26th
 * Grade 11 Computer Parts Project
*/
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

namespace _185338ComputerParts
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ImageSource https;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnCPU_Click(object sender, RoutedEventArgs e)
        {
            txtInfo.Text = "ggggggggggggggggggggggggggggggggggggggg" + "\n" + "\r" + "gggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggg";
            BitmapImage bi = new BitmapImage(new Uri("https://c1.neweggimages.com/NeweggImage/ProductImageCompressAll1280/19-117-958-V03.jpg"));
            imageInfo.Source = bi;
        }

        private void BtnMother_Click(object sender, RoutedEventArgs e)
        {
            txtInfo.Text = "hi-";
            BitmapImage bi = new BitmapImage(new Uri("https://c1.neweggimages.com/NeweggImage/ProductImageCompressAll1280/13-145-089-V02.jpg"));
            imageInfo.Source = bi;
        }

        private void BtnMemory_Click(object sender, RoutedEventArgs e)
        {
            txtInfo.Text = "hi";
            BitmapImage bi = new BitmapImage(new Uri("https://c1.neweggimages.com/ProductImageCompressAll1280/20-231-888-01.jpg"));
            imageInfo.Source = bi;
        }

        private void BtnStorge_Click(object sender, RoutedEventArgs e)
        {
            txtInfo.Text = "hi";
            BitmapImage bi = new BitmapImage(new Uri("https://apod.nasa.gov/apod/image/1804/MilkyVlei_Liebermann_4000.jpg"));
            imageInfo.Source = bi;
        }

        private void BtnCasePower_Click(object sender, RoutedEventArgs e)
        {
            txtInfo.Text = "hi";
                 BitmapImage bi = new BitmapImage(new Uri("https://apod.nasa.gov/apod/image/1804/MilkyVlei_Liebermann_4000.jpg"));
            imageInfo.Source = bi; ;
        }

        private void BtnGraphics_Click(object sender, RoutedEventArgs e)
        {
            txtInfo.Text = "Info";
            BitmapImage bi = new BitmapImage(new Uri("https://apod.nasa.gov/apod/image/1804/MilkyVlei_Liebermann_4000.jpg"));
            imageInfo.Source = bi;
        }

        private void BtnOptical_Click(object sender, RoutedEventArgs e)
        {
            txtInfo.Text = "Info";
            BitmapImage bi = new BitmapImage(new Uri("https://apod.nasa.gov/apod/image/1804/MilkyVlei_Liebermann_4000.jpg"));
            imageInfo.Source = bi;
        }
    }
}
