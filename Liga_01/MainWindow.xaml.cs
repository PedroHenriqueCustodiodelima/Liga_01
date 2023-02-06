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

namespace Liga_01
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

        private void camp_Click(object sender, RoutedEventArgs e)
        {
            CampeonatoWindow w = new CampeonatoWindow();
            w.ShowDialog();
        }

        private void time_Click(object sender, RoutedEventArgs e)
        {
            TimeWindow w = new TimeWindow();
            w.ShowDialog();
        }

        private void jogador_Click(object sender, RoutedEventArgs e)
        {
            JogadorWindow w = new JogadorWindow();
            w.ShowDialog();
        }

        private void tabelas_Click(object sender, RoutedEventArgs e)
        {
            TabelaWindow w = new TabelaWindow();
            w.ShowDialog();
        }

        private void elencos_Click(object sender, RoutedEventArgs e)
        {
            ElencoWindow w = new ElencoWindow();
            w.ShowDialog();
        }
    }
}
