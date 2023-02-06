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
    /// Lógica interna para TabelaWindow.xaml
    /// </summary>
    public partial class TabelaWindow : Window
    {
        public TabelaWindow()
        {
            InitializeComponent();
        }

        private void listar_Click(object sender, RoutedEventArgs e)
        {
            list_Camps.ItemsSource = null;
            list_Camps.ItemsSource = NCampeonato.Listar();
        }

        private void visualizar_Click(object sender, RoutedEventArgs e)
        {
            if (list_Camps.SelectedItem != null)
            {
                Campeonato c = (Campeonato)list_Camps.SelectedItem;
                listTabela.ItemsSource = NTime.Listar(c);
            }
            else
            {
                MessageBox.Show("Selecione o campeonato");
            }
        }
    }
}
