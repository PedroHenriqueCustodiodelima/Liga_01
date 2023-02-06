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
using System.Windows.Shapes;

namespace Liga_01
{
    /// <summary>
    /// Lógica interna para ElencoWindow.xaml
    /// </summary>
    public partial class ElencoWindow : Window
    {
        public ElencoWindow()
        {
            InitializeComponent();
        }

        private void listar_Click(object sender, RoutedEventArgs e)
        {
            list_Times.ItemsSource = null;
            list_Times.ItemsSource = NTime.Listar();
        }

        private void Elenco_Click(object sender, RoutedEventArgs e)
        {
            if (list_Times.SelectedItem != null)
            {
                Time t = (Time)list_Times.SelectedItem;
                listElenco.ItemsSource = NJogador.Listar(t.Id);
            }
            else
            {
                MessageBox.Show("Selecione o time");
            }
        }
    }
}
