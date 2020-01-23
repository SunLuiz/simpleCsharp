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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Redinha
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //Chamando Janelas
        //CADASTROS
        private void Cadastro_de_Cliente_Click(object sender, RoutedEventArgs e)
        {
            Cadastro_Cliente cadastroDeCliente = new Cadastro_Cliente();
            cadastroDeCliente.ShowDialog();
        }
        private void Cadastro_Linha_de_onibus_Click(object sender, RoutedEventArgs e)
        {
            Linha_de_onibus CadastroLinhaDeOnibus = new Linha_de_onibus();
            CadastroLinhaDeOnibus.ShowDialog();
        }
        private void Cadastro_Inst_Encamim_Click(object sender, RoutedEventArgs e)
        {
            Cadastro_Inst_Encaminhadora CadastroEncaminhadora = new Cadastro_Inst_Encaminhadora();
            CadastroEncaminhadora.ShowDialog();
        }

        private void Cadastro_Inst_Servico_Click(object sender, RoutedEventArgs e)
        {
            Cadastro_Inst_Servico CadastroInstServico = new Cadastro_Inst_Servico();
            CadastroInstServico.ShowDialog();
        }
        private void Cadastro_Servicos_Click(object sender, RoutedEventArgs e)
        {
            Cadastro_Servicos_Ofertados CadastrarServicos = new Cadastro_Servicos_Ofertados();
            CadastrarServicos.ShowDialog();
        }
        private void Cadastro_Usuario_Click(object sender, RoutedEventArgs e)
        {
            Cadastrar_Usuarios CadastroUsuarios = new Cadastrar_Usuarios();
            CadastroUsuarios.ShowDialog();
        }
        private void Cadastrar_Usuario_Click(object sender, RoutedEventArgs e)
        {
            Cadastrar_Usuarios registrarUsuario = new Cadastrar_Usuarios();
            registrarUsuario.ShowDialog();
        }
        private void Registrar_Agenda_Compart_Click(object sender, RoutedEventArgs e)
        {
            Incluir_Agenda_Compart RegistrarAgenda = new Incluir_Agenda_Compart();
            RegistrarAgenda.ShowDialog();
        }
        //ALTERACAO DE REGISTROS

        private void Alterar_Cliente_Click(object sender, RoutedEventArgs e)
        {
            Alterar_Cliente alterarCliente = new Alterar_Cliente();
            alterarCliente.ShowDialog();
        }
        private void Alterar_Inst_Encaminhadora_Click(object sender, RoutedEventArgs e)
        {
            Alterar_Inst_Encaminhadora alterarEncaminhadora = new Alterar_Inst_Encaminhadora();
            alterarEncaminhadora.ShowDialog();
        }
        private void Alterar_Inst_Servico_Click(object sender, RoutedEventArgs e)
        {
            Alterar_Inst_Servico alterarInstServico = new Alterar_Inst_Servico();
            alterarInstServico.ShowDialog();
        }
        private void Alterar_Onibus_Click(object sender, RoutedEventArgs e)
        {
            Alterar_Onibus alterarOnibus = new Alterar_Onibus();
            alterarOnibus.ShowDialog();
        }
        private void Alterar_Servicos_Click(object sender, RoutedEventArgs e)
        {
            Alterar_Servicos alterarServicos = new Alterar_Servicos();
            alterarServicos.ShowDialog();
        }
        private void Alterar_Agenda_Compart_Click(object sennder, RoutedEventArgs e)
        {
            Alterar_Agenda_Compart alterarAgenda = new Alterar_Agenda_Compart();
            alterarAgenda.ShowDialog();
        }
        //EXCLUSAO DE REGISTROS
        private void Excluir_Cliente_Click(object sender, RoutedEventArgs e)
        {
            Excluir_cliente excluirCliente = new Excluir_cliente();
            excluirCliente.ShowDialog();
        }

        private void Excluir_Inst_Encaminhadora_Click(object sender, RoutedEventArgs e)
        {
            Excluir_Inst_Encaminhadora excluirInstEncaminhadora = new Excluir_Inst_Encaminhadora();
            excluirInstEncaminhadora.ShowDialog();
        }

        private void Excluir_Inst_Servico_Click(object sender, RoutedEventArgs e)
        {
            Excluir_Inst_Servico excluirInsServico = new Excluir_Inst_Servico();
            excluirInsServico.ShowDialog();
        }

        private void Excluir_Servicos_Click(object sender, RoutedEventArgs e)
        {
            Excluir_Servico excluirServico = new Excluir_Servico();
            excluirServico.ShowDialog();
        }
        private void Excluir_Onibus_Click(object sender, RoutedEventArgs e)
        {
            Excluir_Onibus excluirOnibus = new Excluir_Onibus();
            excluirOnibus.ShowDialog();
        }
        private void Excluir_Atgenda_Compart_Click(object sender, RoutedEventArgs e)
        {
            Excluir_Agenda_Compart excluirAgenda = new Excluir_Agenda_Compart();
            excluirAgenda.ShowDialog();
        }

        //PESQUISAS

        private void Consultar_Agenda_Compart_Click(object sender, RoutedEventArgs e)
        {
            Consultar_Agenda_Compart consultarAgenda = new Consultar_Agenda_Compart();
            consultarAgenda.ShowDialog();
        }
        private void Pesquisar_Inst_Servico_Click(object sender, RoutedEventArgs e)
        {
            Pesquisar_Inst_Servico pesquisarEvento = new Pesquisar_Inst_Servico();
            pesquisarEvento.ShowDialog();
        }
        private void Pesquisar_Cliente_Click(object sender,RoutedEventArgs e)
        {
            Pesquisar_Cliente pesquisarCliente = new Pesquisar_Cliente();
            pesquisarCliente.ShowDialog();
        }
        private void Pesquisar_Onibus_Click(object sender, RoutedEventArgs e)
        {
            Consultar_Onibus pesquisarOnibus = new Consultar_Onibus();
            pesquisarOnibus.ShowDialog();
        }
        private void Pesquisar_Encaminhadora_Click(object sender, RoutedEventArgs e)
        {
            Pesquisar_Inst_Encaminhadora pesquisarEncaminhadora = new Pesquisar_Inst_Encaminhadora();
            pesquisarEncaminhadora.ShowDialog();
        }
        private void Pesquisar_Servico_Click(object sender, RoutedEventArgs e)
        {
            Pesquisar_Servicos pesquisarServico = new Pesquisar_Servicos();
            pesquisarServico.ShowDialog();
        }
        //ARQUIVO
        private void Info_click(object sender, RoutedEventArgs e)
        {
            Info informacao = new Info();
            informacao.ShowDialog();
        }
        private void LogOut_Click(object sender, RoutedEventArgs e)
        {
            Log_Sistema logIn = new Log_Sistema();
            logIn.ShowDialog();
        }
        private void Sair_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }


    }
}
