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

namespace Redinha
{
    /// <summary>
    /// Lógica interna para Incluir_Agenda_Compart.xaml
    /// </summary>
    public partial class Incluir_Agenda_Compart : Window
    {
        public Incluir_Agenda_Compart()
        {
            InitializeComponent();
        }

        private void Button_Pesquisar_Cliente_Click(object sender, RoutedEventArgs e)
        {
            Pesquisar_Cliente incluirCliente = new Pesquisar_Cliente();
            incluirCliente.ShowDialog();
        }

        private void Button_Pesquisar_Servisos_Click(object sender, RoutedEventArgs e)
        {
            Pesquisar_Servicos buscarServicos = new Pesquisar_Servicos();
            buscarServicos.ShowDialog();
        }

        private void Button_Consultar_Onibus_Click(object sender, RoutedEventArgs e)
        {
            Consultar_Onibus buscarOnibus = new Consultar_Onibus();
            buscarOnibus.ShowDialog();
        }

        private void Button_Incluir_Agenda_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
