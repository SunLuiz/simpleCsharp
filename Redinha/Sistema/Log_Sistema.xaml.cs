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
    /// Lógica interna para Log_Sistema.xaml
    /// </summary>
    public partial class Log_Sistema : Window
    {
        public Log_Sistema()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow principal = new MainWindow();
            principal.ShowDialog();
        }
    }
}
