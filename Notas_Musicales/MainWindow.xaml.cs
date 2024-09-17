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

namespace Notas_Musicales{
    public partial class MainWindow : Window{
        double nota, octava, frecNota;
        public MainWindow() => InitializeComponent();
        private void btdo1_Click(object sender, RoutedEventArgs e){
            if (rBpiano.IsChecked == true){
                System.Media.SoundPlayer sp1 = new System.Media.SoundPlayer();
                sp1.SoundLocation = @"piano_do5.wav";
                sp1.Load();
                sp1.Play();
                nota = 1;
                octava = 4;
                frecNota = FormulaFrec(nota, octava);
                lBsalida.Items.Add(nota + "\t" + octava + "\t" + frecNota);
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e){
            if (rBpiano.IsChecked == true){
                System.Media.SoundPlayer sp1 = new System.Media.SoundPlayer();
                sp1.SoundLocation = @"piano_fa.wav";
                sp1.Load();
                sp1.Play();
                nota = 2;
                octava = 4;
                frecNota = FormulaFrec(nota, octava);
                lBsalida.Items.Add(nota + "\t" + octava + "\t" + frecNota);
            }
        }
        private void btre1_Click(object sender, RoutedEventArgs e) {
            if (rBpiano.IsChecked == true){
                System.Media.SoundPlayer sp1 = new System.Media.SoundPlayer();
                sp1.SoundLocation = @"piano_re.wav";
                sp1.Load();
                sp1.Play();
                nota = 3;
                octava = 4;
                frecNota = FormulaFrec(nota, octava);
                lBsalida.Items.Add(nota + "\t" + octava + "\t" + frecNota);
            }
        }
        private void btmi1_Click(object sender, RoutedEventArgs e){
            if (rBpiano.IsChecked == true){
                System.Media.SoundPlayer sp1 = new System.Media.SoundPlayer();
                sp1.SoundLocation = @"piano_mi.wav";
                sp1.Load();
                sp1.Play();
                nota = 5;
                octava = 4;
                frecNota = FormulaFrec(nota, octava);
                lBsalida.Items.Add(nota + "\t" + octava + "\t" + frecNota);
            }
        }
        private void btfa1_Click(object sender, RoutedEventArgs e){
            if (rBpiano.IsChecked == true){
                System.Media.SoundPlayer sp1 = new System.Media.SoundPlayer();
                sp1.SoundLocation = @"piano_fa.wav";
                sp1.Load();
                sp1.Play();
                nota = 6;
                octava = 4;
                frecNota = FormulaFrec(nota, octava);
                lBsalida.Items.Add(nota + "\t" + octava + "\t" + frecNota);
            }
        }
        private void btsol1_Click(object sender, RoutedEventArgs e){
            if (rBpiano.IsChecked == true){
                System.Media.SoundPlayer sp1 = new System.Media.SoundPlayer();
                sp1.SoundLocation = @"piano_sol.wav";
                sp1.Load();
                sp1.Play();
                nota = 8;
                octava = 4;
                frecNota = FormulaFrec(nota, octava);
                lBsalida.Items.Add(nota + "\t" + octava + "\t" + frecNota);
            }
        }

        private void btla1_Click(object sender, RoutedEventArgs e){
            if (rBpiano.IsChecked == true){
                System.Media.SoundPlayer sp1 = new System.Media.SoundPlayer();
                sp1.SoundLocation = @"piano_la.wav";
                sp1.Load();
                sp1.Play();
                nota = 10;
                octava = 4;
                frecNota = FormulaFrec(nota, octava);
                lBsalida.Items.Add(nota + "\t" + octava + "\t" + frecNota);
            }
        }

        private void btfirma_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("Firma_2.exe");
        }

        private void btsi1_Click(object sender, RoutedEventArgs e){
            if (rBpiano.IsChecked == true){
                System.Media.SoundPlayer sp1 = new System.Media.SoundPlayer();
                sp1.SoundLocation = @"piano_si.wav";
                sp1.Load();
                sp1.Play();
                nota = 12;
                octava = 4;
                frecNota = FormulaFrec(nota, octava);
                lBsalida.Items.Add(nota + "\t" + octava + "\t" + frecNota);
            }
        }

        

        public double FormulaFrec(double nota, double octava) {
            double f1;
            f1 = 440 * Math.Exp((octava - 4) + ((nota - 10) / 12) * Math.Log(2));
            return f1;
        }
    }
}
