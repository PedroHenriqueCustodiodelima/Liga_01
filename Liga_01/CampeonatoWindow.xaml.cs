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
    /// Lógica interna para Cad_campeonato.xaml
    /// </summary>
    public partial class CampeonatoWindow : Window
    {
        public CampeonatoWindow()
        {
            InitializeComponent();
        }
        private void InserirClick(object sender, RoutedEventArgs e)
        {
            string Nome = txtNome.Text;
            string Temporada = txtTemporada.Text;
            Campeonato c = new Campeonato
            {
                Nome = Nome,
                Temporada = Temporada
            };
            NCampeonato.Inserir(c);
            ListarClick(sender, e);
        }
        private void ListarClick(object sender, RoutedEventArgs e)
        {
            listcampeonato.ItemsSource = null;
            listcampeonato.ItemsSource = NCampeonato.Listar();
        }

        private void AtualizarClick(object sender, RoutedEventArgs e)
        {
            string Nome = txtNome.Text;
            string Temporada = txtTemporada.Text;
            int Id = ((Campeonato)listcampeonato.SelectedItem).Id;
            Campeonato c = new Campeonato
            {
                Id = Id,
                Nome = Nome,
                Temporada = Temporada
            };
            NCampeonato.Atualizar(c);
            ListarClick(sender, e);
        }

        private void ExcluirClick(object sender, RoutedEventArgs e)
        {
            if (listcampeonato.SelectedItem != null)
            {
                NCampeonato.Excluir((Campeonato)listcampeonato.SelectedItem);
                ListarClick(sender, e);
            }
            else
                MessageBox.Show("Selecione o campeonato a ser excluído");
        }

        private void listcampeonato_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (listcampeonato.SelectedItem != null)
            {
                Campeonato obj = (Campeonato)listcampeonato.SelectedItem;
                txtNome.Text = obj.Nome;
                txtTemporada.Text = obj.Temporada;
            }
        }
    }
}
