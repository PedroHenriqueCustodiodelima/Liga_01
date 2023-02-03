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
    /// Lógica interna para Cad_time.xaml
    /// </summary>
    public partial class TimeWindow : Window
    {
        public TimeWindow()
        {
            InitializeComponent();
        }
        private void InserirClick(object sender, RoutedEventArgs e)
        {
            int id = int.Parse(txtId.Text);
            int idCampeonato = int.Parse(txtIdcampeonato.Text);
            string Nome = txtNome.Text;
            string Sigla = txtSigla.Text;
            string Estado = txtEstado.Text;
            Time t = new Time()
            {
                Id = id,
                IdCampeonato = idCampeonato,
                Nome = Nome,
                Sigla = Sigla,
                Estado = Estado
            };
            NTime.Inserir(t);
            ListarClick(sender, e);
        }
        private void ListarClick(object sender, RoutedEventArgs e)
        {
            listTimes.ItemsSource = null;
            listTimes.ItemsSource = NTime.Listar();
        }

        private void AtualizarClick(object sender, RoutedEventArgs e)
        {
            int id = int.Parse(txtId.Text);
            int idCampeonato = int.Parse(txtIdcampeonato.Text);
            string Nome = txtNome.Text;
            string Sigla = txtSigla.Text;
            string Estado = txtEstado.Text;
            Time t = new Time()
            {
                Id = id,
                IdCampeonato = idCampeonato,
                Nome = Nome,
                Sigla = Sigla,
                Estado = Estado
            };
            NTime.Atualizar(t);
            ListarClick(sender, e);
        }

        private void ExcluirClick(object sender, RoutedEventArgs e)
        {
            if (listTimes.SelectedItem != null)
            {
                NTime.Excluir((Time)listTimes.SelectedItem);
                ListarClick(sender, e);
            }
            else
                MessageBox.Show("Selecione o time a ser excluído");
        }

        private void listTimes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (listTimes.SelectedItem != null)
            {
                Time obj = (Time)listTimes.SelectedItem;
                txtId.Text = obj.Id.ToString();
                txtIdcampeonato.Text = obj.IdCampeonato.ToString();
                txtNome.Text = obj.Nome;
                txtSigla.Text = obj.Sigla;
                txtEstado.Text = obj.Estado.ToString();
            }
        }

        private void CadastrarClick(object sender, RoutedEventArgs e)
        {
            Cad_Time w = new Cad_Time();
            w.ShowDialog();
        }
    }
}
