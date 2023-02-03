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
    /// Lógica interna para Inscrever_jogador.xaml
    /// </summary>
    public partial class JogadorWindow : Window
    {
        public JogadorWindow()
        {
            InitializeComponent();
        }
        private void InserirClick(object sender, RoutedEventArgs e)
        {
            int id = int.Parse(txtId.Text);
            int idTime = int.Parse(txtIdtime.Text);
            int Idade = int.Parse(txtIdade.Text);
            int Numero = int.Parse(txtNumero.Text);
            string Nome = txtNome.Text;
            string  Posicao = txtPosicao.Text;
            Jogador t = new Jogador()
            {
                Id = id,
                IdTime = idTime,
                Nome = Nome,
                Idade = Idade,
                Numero = Numero,
                Posicao = Posicao,
            };
            NJogador.Inserir(t);
            ListarClick(sender, e);
        }
        private void ListarClick(object sender, RoutedEventArgs e)
        {
            listJogador.ItemsSource = null;
            listJogador.ItemsSource = NJogador.Listar();
        }

        private void AtualizarClick(object sender, RoutedEventArgs e)
        {
            int id = int.Parse(txtId.Text);
            int idTime = int.Parse(txtIdtime.Text);
            int Idade = int.Parse(txtIdade.Text);
            int Numero = int.Parse(txtNumero.Text);
            string Nome = txtNome.Text;
            string Posicao = txtPosicao.Text;
            Jogador t = new Jogador()
            {
                Id = id,
                IdTime = idTime,
                Nome = Nome,
                Idade = Idade,
                Numero = Numero,
                Posicao = Posicao,
            };
            NJogador.Atualizar(t);
            ListarClick(sender, e);
        }

        private void ExcluirClick(object sender, RoutedEventArgs e)
        {
            if (listJogador.SelectedItem != null)
            {

                NJogador.Excluir((Jogador)listJogador.SelectedItem);
                ListarClick(sender, e);
            }
            else
                MessageBox.Show("Selecione o jogador a ser excluido");
        }

        private void listJogador_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (listJogador.SelectedItem != null)
            {
                Jogador obj = (Jogador)listJogador.SelectedItem;
                txtId.Text = obj.Id.ToString();
                txtIdtime.Text = obj.IdTime.ToString();
                txtNumero.Text = obj.Numero.ToString();
                txtIdade.Text = obj.Idade.ToString();
                txtNome.Text = obj.Nome;
                txtPosicao.Text = obj.Posicao;
            }
        }

        private void CadastrarClick(object sender, RoutedEventArgs e)
        {
            Cad_Jogador w = new Cad_Jogador();
            w.ShowDialog();
        }
    }
}
