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
using System.Diagnostics;
using System.Windows.Navigation;

namespace _185338ComputerParts
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //private ImageSource https;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnCPU_Click(object sender, RoutedEventArgs e)
        {
            txtInfo.Text = "-Intel Core i7 9700k" + "\n" + "\r" + "-9th Gen Intel Processor" + "\n" + "\r" + "-4.9GHz" + "\n" + "\r" + "-Socket LGA 1151 (300 Series)" + "\n" + "\r" + "-$579";
            lnkWeb.NavigateUri = new Uri("https://www.newegg.ca/Product/Product.aspx?Item=N82E16819117958");
            BitmapImage bi = new BitmapImage(new Uri("https://c1.neweggimages.com/NeweggImage/ProductImageCompressAll1280/19-117-958-V03.jpg"));
            imageInfo.Source = bi;
        }

        private void BtnMother_Click(object sender, RoutedEventArgs e)
        {
            txtInfo.Text = "-Intel GIGABYTE Z390 AORUS MASTER" + "\n" + "\r" + "-Front Facing USB and Audio Ports" + "\n" + "\r" + "-64GB Maximum Memory" + "\n" + "\r" + "-$377.08";
            lnkWeb.NavigateUri = new Uri("https://www.newegg.ca/Product/Product.aspx?Item=N82E16813145089");
            BitmapImage bi = new BitmapImage(new Uri("https://c1.neweggimages.com/NeweggImage/ProductImageCompressAll1280/13-145-089-V02.jpg"));
            imageInfo.Source = bi;
        }

        private void BtnMemory_Click(object sender, RoutedEventArgs e)
        {
            txtInfo.Text = "-G.SKILL Ripjaws V Series 16GB (2 x 8GB)" + "\n" + "\r" + "-DDR4 2400" + "\n" + "\r" + "-Voltage 1.2V" + "\n" + "\r" + "-$120.99";
            lnkWeb.NavigateUri = new Uri("https://www.newegg.ca/Product/Product.aspx?item=N82E16820231888");
            BitmapImage bi = new BitmapImage(new Uri("https://c1.neweggimages.com/ProductImageCompressAll1280/20-231-888-01.jpg"));
            imageInfo.Source = bi;
        }

        private void BtnStorge_Click(object sender, RoutedEventArgs e)
        {
            txtInfo.Text = "-Seagate BarraCuda ST3000DM008" + "\n" + "\r" + "-3TB" + "\n" + "\r" + "-64MB Cache" + "\n" + "\r" + "109.99";
            lnkWeb.NavigateUri = new Uri("https://www.newegg.ca/Product/Product.aspx?Item=N82E16822178994&Description=Seagate%20BarraCuda%20ST3000DM008%203TB&cm_re=Seagate_BarraCuda_ST3000DM008_3TB-_-22-178-994-_-Product");
            BitmapImage bi = new BitmapImage(new Uri("https://c1.neweggimages.com/ProductImageCompressAll1280/22-178-994-V01.jpg"));
            imageInfo.Source = bi;
        }

        private void BtnCasePower_Click(object sender, RoutedEventArgs e)
        {
            txtInfo.Text = "-DIYPC Skyline-06-WR Black/Red Dual USB 3.0 ATX" + "\n" + "\r" + "-2 x USB3.0 + 2 x USB2.0" + "\n" + "\r" + "-Pre-Installed Fans" + "\n" + "\r" + "-$119.99";
            lnkWeb.NavigateUri = new Uri("https://www.newegg.ca/Product/Product.aspx?Item=N82E16811353100");
            BitmapImage bi = new BitmapImage(new Uri("https://c1.neweggimages.com/NeweggImage/ProductImageCompressAll1280/11-353-100-01.jpg"));
            imageInfo.Source = bi; ;
        }

        private void BtnGraphics_Click(object sender, RoutedEventArgs e)
        {
            txtInfo.Text = "-MSI 131207 GeForce" + "\n" + "\r" + "-4GB" + "\n" + "\r" + "-Single Fan" + "\n" + "\r" + "-3 Monitor Capability" + "\n" + "\r" + "-$287.89";
            lnkWeb.NavigateUri = new Uri("https://www.newegg.ca/Product/Product.aspx?item=N82E16814137056");
            BitmapImage bi = new BitmapImage(new Uri("https://c1.neweggimages.com/ProductImage/14-137-056-08.jpg"));
            imageInfo.Source = bi;
        }

        private void BtnOptical_Click(object sender, RoutedEventArgs e)
        {
            txtInfo.Text = "-LG BluRay and DVD" + "\n" + "\r" + "-Silent & jamless play" + "\n" + "\r" + "-SATA interface" + "\n" + "\r" + "-170.23";
            lnkWeb.NavigateUri = new Uri("https://www.newegg.ca/Product/Product.aspx?Item=9SIA8X036X6867");
            BitmapImage bi = new BitmapImage(new Uri("https://c1.neweggimages.com/productimage/27-136-252-02.jpg"));
            imageInfo.Source = bi;
        }

        private void BtnPower_Click(object sender, RoutedEventArgs e)
        {
            txtInfo.Text = "-CORSAIR CX Series CX450 450W" + "\n" + "\r" + "-5-year warranty" + "\n" + "\r" + "-Quiet Thermally Controlled 120mm Fan" + "\n" + "\r" + "-$59.99";
            lnkWeb.NavigateUri = new Uri("https://www.newegg.ca/Product/Product.aspx?Item=N82E16817139201");
            BitmapImage bi = new BitmapImage(new Uri("https://c1.neweggimages.com/NeweggImage/ProductImageCompressAll1280/17-139-201-V01.jpg"));
            imageInfo.Source = bi;
        }

        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri));
            e.Handled = true;
        }
    }
}
