﻿using System;
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
    /// Lógica interna para Cadastro_Inst_Encaminhadora.xaml
    /// </summary>
    public partial class Cadastro_Inst_Encaminhadora : Window
    {
        public Cadastro_Inst_Encaminhadora()
        {
            InitializeComponent();
        }

        private void BtnFechar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
