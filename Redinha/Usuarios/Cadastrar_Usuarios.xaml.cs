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
    /// Lógica interna para Cadastrar_Usuarios.xaml
    /// </summary>
    public partial class Cadastrar_Usuarios : Window
    {
        public Cadastrar_Usuarios()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            Redinha.RedinhaDataSet redinhaDataSet = ((Redinha.RedinhaDataSet)(this.FindResource("redinhaDataSet")));
            // Carregue dados na tabela UsuarioSistema. Você pode modificar este código conforme necessário.
            Redinha.RedinhaDataSetTableAdapters.UsuarioSistemaTableAdapter redinhaDataSetUsuarioSistemaTableAdapter = new Redinha.RedinhaDataSetTableAdapters.UsuarioSistemaTableAdapter();
            redinhaDataSetUsuarioSistemaTableAdapter.Fill(redinhaDataSet.UsuarioSistema);
            System.Windows.Data.CollectionViewSource usuarioSistemaViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("usuarioSistemaViewSource")));
            usuarioSistemaViewSource.View.MoveCurrentToFirst();
        }
    }
}
