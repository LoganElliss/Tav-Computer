/*
 * Logan Ellis
 * Feb 26 2019
 * Computer parts for MC.T to build a PC 
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

namespace _219016ComputerParts
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

        private void btnComputerPart_Click(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            if (b.Name == "btnCPU")
            {
                imgPicture.Source = new BitmapImage(new Uri("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRlodFwOPjz6a6bc7GWi_XScuXt9BWNbbmb0EV3Ga_dUGZQpSZ1"));
                lblPartName.Content = "CPU";
                txtPartInfo.Text = "This CPU uses i5 8th gen processors and is even faster then you will need to run the programs you want";

            }
            else if (b.Name == "btnMotherboard")
            {
                imgPicture.Source = new BitmapImage(new Uri("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSJNNfIpJtRPMUuISxn6FpnxUM3cO-kauOoGWo_nD1Ab_B38V1b"));
                lblPartName.Content = "Motherboard";
                txtPartInfo.Text = "This motherboad fits the case(because its the one for the case) and is easily modifyable";
            }
            else if (b.Name == "btnCase")
            {
                imgPicture.Source = new BitmapImage(new Uri("https://www.bhphotovideo.com/images/images1500x1500/dell_5fhc3_optiplex_3060_corei58_85004gb_1dimms_500gb_1429486.jpg"));
                lblPartName.Content = "Case";
                txtPartInfo.Text = "This is a Optiplex 3060 case it comes with 8 USB ports (4 front 4back) to fit your needs and it is not to flashy";
                //add info for case
            }//add more else if statements for the other parts
            else if (b.Name == "btnGraphicsCard")
            {
                imgPicture.Source = new BitmapImage(new Uri("https://tpucdn.com/gpu-specs/images/c/2963-front.jpg"));
                lblPartName.Content = "GraphicsCard";
                txtPartInfo.Text = "a standerd GC that fits with the processors and can run everything you need it to";
            }
            else if (b.Name == "btnOpticalDrive")
            {
                imgPicture.Source = new BitmapImage(new Uri("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQpjWxVO9XkmXHMcTK4t61iSUrXmVW6f5Xuqk8Gl6IWiusg3JF1HA"));
                lblPartName.Content = "OpticalDrive";
                txtPartInfo.Text = "A standerd DVD drive capable of watching and burning";
            }
            else if (b.Name == "btnRAM")
            {
                imgPicture.Source = new BitmapImage(new Uri("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTild70hS5Vpi56ru_GwNnQw5n1WMvVi5WaLicDfA2XzpSQVlC2"));
                lblPartName.Content = "RAM";
                txtPartInfo.Text = "8gb of RAM will let you run what you need and stay within price";
            }
            else if (b.Name == "btnHardDrive")
            {
                imgPicture.Source = new BitmapImage(new Uri("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTB1jsv493WOEar36IFYi-EJJrE0oJAcBPQISGBGKRdYpbyVsH1"));
                lblPartName.Content = "HardDrive";
                txtPartInfo.Text = "This solid state Hard Drive is faster then others and has lots of storage";
            }
            else if (b.Name == "btnFinalStatement")
            {
                lblPartName.Content = "FinalStatement";
                txtPartInfo.Text = "I think this computer is for you because it is under $1500 to buy the parts needed you get your extra usb ports (4 on the front 4 on the back) the fan is very quiet and it can run every program you asked it to run overall this should be a very good choice in the building process https://www.dell.com/en-ca";
        
            }

            }
        }
}