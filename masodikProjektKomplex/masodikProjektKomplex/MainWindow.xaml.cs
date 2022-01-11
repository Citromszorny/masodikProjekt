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
        Brush sav1;
        Brush sav2;
        Brush sav3;
        public MainWindow()
        {
            InitializeComponent();
            sav1 = elsoPalya.Fill;
            sav2 = masodikPalya.Fill;
            sav3 = harmadikPalya.Fill;
            ujFutam.IsEnabled = false;
            csigaMozgasa1.Tick += timer_Tick;
            csigaMozgasa1.Interval = TimeSpan.FromMilliseconds(25);
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
                                harmadik = true;
                                hanyszorMilyenHelyezes[0, 2]++;
                                csiganevHelyezesek[2] = csiga1.Name;

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
                                harmadik = true;
                                hanyszorMilyenHelyezes[1, 2]++;
                                csiganevHelyezesek[2] = csiga2.Name;

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
                                harmadik = true;
                                csiganevHelyezesek[2] = csiga3.Name;
                                hanyszorMilyenHelyezes[2, 2]++;

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
            if (harmadik == true)
            {
                elsoHanyszorElso.Content = hanyszorMilyenHelyezes[0, 0];
                elsoHanyadikMasodik.Content = hanyszorMilyenHelyezes[0, 1];
                elsoHanyadikHarmadik.Content = hanyszorMilyenHelyezes[0, 2];
                masodikHanyadikElso.Content = hanyszorMilyenHelyezes[1, 0];
                masodikHanyadikMasodik.Content = hanyszorMilyenHelyezes[1, 1];
                masodikHanyadikHarmadik.Content = hanyszorMilyenHelyezes[1, 2];
                harmadikHanyadikElso.Content = hanyszorMilyenHelyezes[2, 0];
                HarmadikHanyadikMasodik.Content = hanyszorMilyenHelyezes[2, 1];
                HarmadikHanyadikHarmadik.Content = hanyszorMilyenHelyezes[2, 2];
                masodikPont.Content = hanyszorMilyenHelyezes[1, 0] * 3 + hanyszorMilyenHelyezes[1, 1] * 2 + hanyszorMilyenHelyezes[1, 2];
                harmadikPont.Content = hanyszorMilyenHelyezes[2, 0] * 3 + hanyszorMilyenHelyezes[2, 1] * 2 + hanyszorMilyenHelyezes[2, 2];
                pontElso.Content = hanyszorMilyenHelyezes[0, 0] * 3 + hanyszorMilyenHelyezes[0, 1] * 2 + hanyszorMilyenHelyezes[0, 2];

            }

        }
        private void PontKiiro()
        {

            MessageBox.Show($"Hely \t Név \t 1.\t2.\t 3. \t Pont \n 1. \t csiga1 \t {elsoHanyszorElso.Content} \t {elsoHanyadikMasodik.Content} \t {elsoHanyadikHarmadik.Content} \t {pontElso.Content} \n 2. \t csiga2 \t {masodikHanyadikElso.Content} \t {masodikHanyadikMasodik.Content} \t {masodikHanyadikHarmadik.Content} \t {masodikPont.Content} \n 3. \t csiga3 \t {harmadikHanyadikElso.Content} \t {HarmadikHanyadikMasodik.Content} \t {HarmadikHanyadikMasodik.Content} \t {harmadikPont.Content}");
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
            elsoPalya.Fill = sav1;
            masodikPalya.Fill = sav2;
            harmadikPalya.Fill = sav3;
            csigaMozgasa1.Stop();

        }
        private void ujBajnoksag_Click(object sender, RoutedEventArgs e)
        {
            ujFutam_Click(null, null);
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    hanyszorMilyenHelyezes[i, j] = 0;
                }
            }
            PontKiiro();
            elsoHanyszorElso.Content = "";
            elsoHanyadikMasodik.Content = "";
            elsoHanyadikHarmadik.Content = "";
            masodikHanyadikElso.Content = "";
            masodikHanyadikMasodik.Content = "";
            masodikHanyadikHarmadik.Content = "";
            harmadikHanyadikElso.Content = "";
            HarmadikHanyadikMasodik.Content = "";
            HarmadikHanyadikHarmadik.Content = "";
            pontElso.Content = "";
            masodikPont.Content = "";
            harmadikPont.Content = "";
            
            InitializeComponent();
        }

    }
}
