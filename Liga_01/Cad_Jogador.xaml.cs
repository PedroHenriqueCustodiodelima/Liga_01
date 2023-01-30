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
    /// Lógica interna para Cad_Jogador.xaml
    /// </summary>
    public partial class Cad_Jogador : Window
    {
        public Cad_Jogador()
        {
            InitializeComponent();
        }

        private void ListarClick(object sender, RoutedEventArgs e)
        {
            listJogador.ItemsSource = null;
            listJogador.ItemsSource = NJogador.Listar();
            listTimes.ItemsSource = null;
            listTimes.ItemsSource = NTime.Listar();
        }

        private void CadastrarClick(object sender, RoutedEventArgs e)
        {
            if (listTimes.SelectedItem != null &&
                listJogador.SelectedItem != null)
            {
                Jogador j = (Jogador)listJogador.SelectedItem;
                Time t = (Time)listTimes.SelectedItem;
                NJogador.Cadastrar(j, t);
                ListarClick(sender, e);
            }
            else
            {
                MessageBox.Show("É preciso selecionar um jogador e um time");
            }
        }
    }
}
