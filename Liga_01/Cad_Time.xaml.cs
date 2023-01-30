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
    /// Lógica interna para Cad_Time.xaml
    /// </summary>
    public partial class Cad_Time : Window
    {
        public Cad_Time()
        {
            InitializeComponent();
        }

        private void ListarClick(object sender, RoutedEventArgs e)
        {
            listTimes.ItemsSource = null;
            listTimes.ItemsSource = NTime.Listar();
            listCampeonato.ItemsSource = null;
            listCampeonato.ItemsSource = NCampeonato.Listar();
        }

        private void CadastrarClick(object sender, RoutedEventArgs e)
        {
            if (listTimes.SelectedItem != null &&
                listCampeonato.SelectedItem != null)
            {
                Time t = (Time)listTimes.SelectedItem;
                Campeonato c = (Campeonato)listCampeonato.SelectedItem;
                NTime.Cadastrar(t, c);
                ListarClick(sender, e);
            }
            else
            {
                MessageBox.Show("É preciso selecionar o time e um campeonato");
            }
        }
    }
}
