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
    /// Lógica interna para Excluir_Agenda_Compart.xaml
    /// </summary>
    public partial class Excluir_Agenda_Compart : Window
    {
        public Excluir_Agenda_Compart()
        {
            InitializeComponent();
        }

        private void Button_Fechar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
