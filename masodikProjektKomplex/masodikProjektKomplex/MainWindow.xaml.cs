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
using System.Windows.Threading;
using System.Windows.Media.Media3D;

namespace masodikProjektKomplex
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        DispatcherTimer csigaMozgasa1 = new DispatcherTimer();
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

            
            csigaMozgasa1.Tick += timer_Tick;
            csigaMozgasa1.Interval = TimeSpan.FromMilliseconds(100);
            
        }

        private void Start_Click(object sender, RoutedEventArgs e)
        {
            
            csigaMozgasa1.Start();
            ujFutam.IsEnabled = false;
            ujBajnoksag.IsEnabled = false;
            Start.IsEnabled = false;

        }

        void timer_Tick(object sender, EventArgs e)
        {
            DispatcherTimer csigaMozgasa1 = new DispatcherTimer();
            Random rnd = new Random();
            int szam = rnd.Next(0, 10);
            int szam2 = rnd.Next(0, 10);
            int szam3 = rnd.Next(0, 10);
            double szam4 = csiga1.Margin.Left + szam;
            double szam5 = csiga2.Margin.Left + szam2;
            double szam6 = csiga3.Margin.Left + szam3;
            double szam7 = csiga3.Margin.Left;
            
            if (csiga1.Margin.Left >= 525)
            {

                if (csiga1.Margin.Left > 525)
                {
                    csiga1.Margin = new Thickness(525, 79, 0, 0);
                    ujFutam.IsEnabled = true;
                    ujBajnoksag.IsEnabled = true;
                    Start.IsEnabled = true;

                }
               

            }
            else
            {
                csiga1.Margin = new Thickness(szam4 += szam, 79, 0, 0);
            }

            if (csiga2.Margin.Left >= 525)
            {

                if (csiga2.Margin.Left > 525)
                {
                    csiga2.Margin = new Thickness(525, 163, 0, 0);
                    ujFutam.IsEnabled = true;
                    ujBajnoksag.IsEnabled = true;
                    Start.IsEnabled = true;
                }


               
            }
            else
            {
                csiga2.Margin = new Thickness(szam5 += szam2, 163, 0, 0);
            }

            if (csiga3.Margin.Left >= 525)
            {

                if (csiga3.Margin.Left > 525)
                {
                    csiga3.Margin = new Thickness(525, 247, 0, 0);
                    ujFutam.IsEnabled = true;
                    ujBajnoksag.IsEnabled = true;
                    Start.IsEnabled = true;
                }

                
            }
            else
            {
                csiga3.Margin = new Thickness(szam6 += szam3, 247, 0, 0);
            }

            csigaMozgasa1.Stop();
            
        }

        private void ujFutam_Click(object sender, RoutedEventArgs e)
        {
            csiga1.Margin = new Thickness(10, 79, 0, 0);
            csiga2.Margin = new Thickness(10, 163, 0, 0);
            csiga3.Margin = new Thickness(10, 247, 0, 0);
            csigaMozgasa1.Stop();
        }

        private void ujBajnoksag_Click(object sender, RoutedEventArgs e)
        {
            elsoNev.Content = "";
            elsoHelyezese.Content = "";
            masodikHelyezese.Content = "";
            harmadikHelyezese.Content = "";
            masodikNeve.Content = "";
            harmadikNeve.Content = "";
            masodikHarmadikHelyezes.Content = "";
            elsoHarmadikHelyezes.Content = "";
            masodikHarmadikHelyezes.Content = "";
            harmadikHarmadikHelyezes.Content = "";
            harmadikMasodikHelyezes.Content = "";
            masodikHelyezes.Content = "";
            masodkMasodikHelyezes.Content = "";
            elsoPont.Content = "";
            masodikPont.Content = "";
            harmadikPont.Content = "";
        }
    }
}
