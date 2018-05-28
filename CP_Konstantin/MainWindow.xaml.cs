using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace CP_Konstantin
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
        }
        byte[] pixelInformation = new byte[4];
        private string imagePath = "images\\Colors.png";
        public string ImagePath
        {
            get { return imagePath; }
            set { imagePath = value; }
        }

        private BindingInformation bindingInfo = new BindingInformation();
        public BindingInformation BindingInfo
        {
            get { return bindingInfo; }
            set { bindingInfo = value; }
        }

        private void Colors_MouseOver(object sender, MouseEventArgs e)
        {
            try
            {
                BitmapImage image = new BitmapImage(new Uri(Colors.Source.ToString()));
                CroppedBitmap pixel = new CroppedBitmap(image, new Int32Rect((int)e.GetPosition(Colors).X,
                    (int)e.GetPosition(Colors).Y, 1, 1));
                pixel.CopyPixels(pixelInformation, 4, 0);
                bindingInfo.MouseOverColor = new SolidColorBrush(Color.FromArgb(pixelInformation[3],
                    pixelInformation[2], pixelInformation[1], pixelInformation[0]));
                DataContext = null;
                DataContext = this;
            }
            catch (ArgumentException)
            {
                // Do nothing ;
            }
            catch (Exception)
            {
                Console.WriteLine("Something went wrong!");
            }
        }

        private void Colors_Click(object sender, MouseButtonEventArgs e)
        {
            bindingInfo.SelectedColor = new SolidColorBrush(Color.FromArgb(pixelInformation[3],
                pixelInformation[2], pixelInformation[1], pixelInformation[0]));
            bindingInfo.MakeColorReport();
            Brightness.Value = 0;
            Lumia.Value = 0;
            DataContext = null;
            DataContext = this;
        }

        private void Colors_MouseLeave(object sender, MouseEventArgs e)
        {
            bindingInfo.MouseOverColor.Color = bindingInfo.SelectedColor.Color;
            DataContext = null;
            DataContext = this;
        }

        private void GlobalMouseMove(object sender, MouseEventArgs e)
        {
            bindingInfo.MouseOverColor.Color = Color.FromArgb((byte)AlphaSlider.Value,
               (byte)RedSlider.Value, (byte)GreenSlider.Value, (byte)BlueSlider.Value);
            DataContext = null;
            DataContext = this;
        }

        private void Grid3MouseLeave(object sender, MouseEventArgs e)
        {
            bindingInfo.SelectedColor.Color = bindingInfo.MouseOverColor.Color;
            bindingInfo.MakeColorReport();
        }

        private void SetBrightness(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            bindingInfo.SetBrightness(Brightness.Value);
            DataContext = null;
            DataContext = this;
        }

        private void SetLumia(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            bindingInfo.SetLumia(Lumia.Value);
            DataContext = null;
            DataContext = this;
        }

        private void MouseLeaveBrightness(object sender, MouseEventArgs e)
        {
            bindingInfo.SelectedColor.Color = bindingInfo.MouseOverColor.Color;
            bindingInfo.MakeColorReport();
        }

        private void MouseLeaveLumia(object sender, MouseEventArgs e)
        {
            bindingInfo.SelectedColor.Color = bindingInfo.MouseOverColor.Color;
            bindingInfo.MakeColorReport();
        }

        private void RandomColor_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            bindingInfo.MouseOverColor.Color = Color.FromRgb(
                (byte)random.Next(0, 255), (byte)random.Next(0, 255), (byte)random.Next(0, 255));
            bindingInfo.SelectedColor.Color = bindingInfo.MouseOverColor.Color;
            bindingInfo.MakeColorReport();
            Brightness.Value = 0;
            Lumia.Value = 0;
            DataContext = null;
            DataContext = this;
        }

        private void GetColorReport_Click(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText(bindingInfo.ColorReport);
        }
    }
}
