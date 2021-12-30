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
using System.Timers;


namespace masodikProjektKomplex
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            csiga1.Fill = new ImageBrush
            {
                ImageSource = new BitmapImage(new Uri(@"csiga1.png", UriKind.Relative))
            };
            csiga2.Fill = new ImageBrush
            {
                ImageSource = new BitmapImage(new Uri(@"csiga2.png", UriKind.Relative))
            };
            csiga3.Fill = new ImageBrush
            {
                ImageSource = new BitmapImage(new Uri(@"csiga3.png", UriKind.Relative))
            };
            elsoPalya.Fill = new ImageBrush
            {
                ImageSource = new BitmapImage(new Uri(@"elsoPalya.png", UriKind.Relative))
            };
            masodikPalya.Fill = new ImageBrush
            {
                ImageSource = new BitmapImage(new Uri(@"masodikPalya.png", UriKind.Relative))
            };
            harmadikPalya.Fill = new ImageBrush
            {
                ImageSource = new BitmapImage(new Uri(@"harmadikPalya.png", UriKind.Relative))
            };
        }
    }
}