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
    /// Lógica interna para Pesquisar_Cliente.xaml
    /// </summary>
    public partial class Pesquisar_Cliente : Window
    {
        public Pesquisar_Cliente()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            Redinha.RedinhaDataSet redinhaDataSet = ((Redinha.RedinhaDataSet)(this.FindResource("redinhaDataSet")));
            // Carregue dados na tabela Cliente. Você pode modificar este código conforme necessário.
            Redinha.RedinhaDataSetTableAdapters.ClienteTableAdapter redinhaDataSetClienteTableAdapter = new Redinha.RedinhaDataSetTableAdapters.ClienteTableAdapter();
            redinhaDataSetClienteTableAdapter.Fill(redinhaDataSet.Cliente);
            System.Windows.Data.CollectionViewSource clienteViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("clienteViewSource")));
            clienteViewSource.View.MoveCurrentToFirst();
        }
    }
}
