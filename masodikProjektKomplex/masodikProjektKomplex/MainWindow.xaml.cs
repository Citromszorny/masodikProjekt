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
        int valami = 1;
        List<Brush> helyezesek123 = new List<Brush>();
        List<string> csiganevHelyezesek = new List<string>() { "", "", "" };
        int[,] hanyszorMilyenHelyezes = new int[3, 3];
        bool elso = false;
        bool masodik = false;
        bool harmadik = false;

        public MainWindow()
        {
            InitializeComponent();
            ujFutam.IsEnabled = false;
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
            Random rnd = new Random();
            int szam = rnd.Next(0, 10);
            int szam2 = rnd.Next(0, 10);
            int szam3 = rnd.Next(0, 10);
            double szam4 = csiga1.Margin.Left + szam;
            double szam5 = csiga2.Margin.Left + szam2;
            double szam6 = csiga3.Margin.Left + szam3;
            helyezesek123.Add(Brushes.Gold);
            helyezesek123.Add(Brushes.Silver);
            helyezesek123.Add(Brushes.SandyBrown);
            if (csiga1.Margin.Left >= 525)
            {
                if (csiga1.Margin.Left > 525)
                {
                    if (elso == false)
                    {
                        elso = true;
                        csiganevHelyezesek[0] = csiga1.Name;
                        hanyszorMilyenHelyezes[0, 0]++;

                    }
                    else
                    {
                        if (elso == true && masodik == false)
                        {
                            masodik = true;
                            csiganevHelyezesek[1] = csiga1.Name;
                            hanyszorMilyenHelyezes[0, 1]++;
                        }
                        else
                        {
                            if (elso == true && masodik == true && harmadik == false)
                            {

                                hanyszorMilyenHelyezes[0, 2]++;
                                csiganevHelyezesek[2] = csiga1.Name;
                                MessageBox.Show(csiganevHelyezesek[0] + " " + csiganevHelyezesek[1] + " " + csiganevHelyezesek[2]);
                                MessageBox.Show(Convert.ToString(hanyszorMilyenHelyezes[0, 0] + " " + hanyszorMilyenHelyezes[0, 1] + " " + hanyszorMilyenHelyezes[0, 2]));
                                MessageBox.Show(Convert.ToString(hanyszorMilyenHelyezes[1, 0] + " " + hanyszorMilyenHelyezes[1, 1] + " " + hanyszorMilyenHelyezes[1, 2]));
                                MessageBox.Show(Convert.ToString(hanyszorMilyenHelyezes[2, 0] + " " + hanyszorMilyenHelyezes[2, 1] + " " + hanyszorMilyenHelyezes[2, 2]));
                            }
                        }
                    }
                    csiga1.Margin = new Thickness(525, 79, 0, 0);
                    ujFutam.IsEnabled = true;
                    ujBajnoksag.IsEnabled = true;
                    Start.IsEnabled = true;
                    helyezes.Content = valami++;
                    elsoPalya.Fill = helyezesek123[valami + 1];

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
                    if (elso == false)
                    {
                        elso = true;
                        hanyszorMilyenHelyezes[1, 0]++;
                        csiganevHelyezesek[0] = csiga2.Name;
                    }
                    else
                    {
                        if (elso == true && masodik == false)
                        {
                            masodik = true;
                            hanyszorMilyenHelyezes[1, 1]++;
                            csiganevHelyezesek[1] = csiga2.Name;
                        }
                        else
                        {
                            if (elso == true && masodik == true && harmadik == false)
                            {
                                hanyszorMilyenHelyezes[1, 2]++;
                                csiganevHelyezesek[2] = csiga2.Name;
                                MessageBox.Show(csiganevHelyezesek[0] + " " + csiganevHelyezesek[1] + " " + csiganevHelyezesek[2]);
                                MessageBox.Show(Convert.ToString(hanyszorMilyenHelyezes[0, 0] + " " + hanyszorMilyenHelyezes[0, 1] + " " + hanyszorMilyenHelyezes[0, 2]));
                                MessageBox.Show(Convert.ToString(hanyszorMilyenHelyezes[1, 0] + " " + hanyszorMilyenHelyezes[1, 1] + " " + hanyszorMilyenHelyezes[1, 2]));
                                MessageBox.Show(Convert.ToString(hanyszorMilyenHelyezes[2, 0] + " " + hanyszorMilyenHelyezes[2, 1] + " " + hanyszorMilyenHelyezes[2, 2]));
                            }
                        }
                    }
                    csiga2.Margin = new Thickness(525, 163, 0, 0);
                    helyezes2.Content = valami++;
                    masodikPalya.Fill = helyezesek123[valami + 1];
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
                    if (elso == false)
                    {
                        hanyszorMilyenHelyezes[2, 0]++;
                        elso = true;
                        csiganevHelyezesek[0] = csiga3.Name;
                    }
                    else
                    {
                        if (elso == true && masodik == false)
                        {
                            hanyszorMilyenHelyezes[2, 1]++;
                            masodik = true;
                            csiganevHelyezesek[1] = csiga3.Name;
                        }
                        else
                        {
                            if (elso == true && masodik == true && harmadik == false)
                            {

                                csiganevHelyezesek[2] = csiga3.Name;
                                hanyszorMilyenHelyezes[2, 2]++;
                                MessageBox.Show(csiganevHelyezesek[0] + " " + csiganevHelyezesek[1] + " " + csiganevHelyezesek[2]);
                                MessageBox.Show(Convert.ToString(hanyszorMilyenHelyezes[0, 0] + " " + hanyszorMilyenHelyezes[0, 1] + " " + hanyszorMilyenHelyezes[0, 2]));
                                MessageBox.Show(Convert.ToString(hanyszorMilyenHelyezes[1, 0] + " " + hanyszorMilyenHelyezes[1, 1] + " " + hanyszorMilyenHelyezes[1, 2]));
                                MessageBox.Show(Convert.ToString(hanyszorMilyenHelyezes[2, 0] + " " + hanyszorMilyenHelyezes[2, 1] + " " + hanyszorMilyenHelyezes[2, 2]));
                            }
                        }
                    }
                    csiga3.Margin = new Thickness(525, 247, 0, 0);
                    helyezes3.Content = valami++;
                    harmadikPalya.Fill = helyezesek123[valami + 1];

                }
            }
            else
            {
                csiga3.Margin = new Thickness(szam6 += szam3, 247, 0, 0);
            }
        }
        private void ujFutam_Click(object sender, RoutedEventArgs e)
        {
            csiga1.Margin = new Thickness(10, 79, 0, 0);
            csiga2.Margin = new Thickness(10, 163, 0, 0);
            csiga3.Margin = new Thickness(10, 247, 0, 0);
            helyezes.Content = "";
            helyezes2.Content = "";
            helyezes3.Content = "";
            elso = false;
            masodik = false;
            harmadik = false;
            csiganevHelyezesek[0] = "";
            csiganevHelyezesek[1] = "";
            csiganevHelyezesek[2] = "";

            valami = 1;
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

            csigaMozgasa1.Stop();

        }
        private void ujBajnoksag_Click(object sender, RoutedEventArgs e)
        {
            ujFutam_Click(null, null);
            bajnoksag.Content = "";
            MessageBox.Show("xd", "állás");
        }
    }
}
