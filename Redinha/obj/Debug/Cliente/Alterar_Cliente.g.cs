﻿#pragma checksum "..\..\..\Cliente\Alterar_Cliente.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "01E6BE277A5212DC0C034F4084C9DB8069DD0D60"
//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

using Redinha;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace Redinha {
    
    
    /// <summary>
    /// Alterar_Cliente
    /// </summary>
    public partial class Alterar_Cliente : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\Cliente\Alterar_Cliente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnPesquisar;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\Cliente\Alterar_Cliente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LbPesquisar;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\Cliente\Alterar_Cliente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CBPesquisar;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\Cliente\Alterar_Cliente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LbNum;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\Cliente\Alterar_Cliente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LbFA;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\Cliente\Alterar_Cliente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbNome;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Cliente\Alterar_Cliente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LbBairro;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Redinha;component/cliente/alterar_cliente.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Cliente\Alterar_Cliente.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.BtnPesquisar = ((System.Windows.Controls.Button)(target));
            return;
            case 2:
            this.LbPesquisar = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.CBPesquisar = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.LbNum = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.LbFA = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.lbNome = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.LbBairro = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            
            #line 31 "..\..\..\Cliente\Alterar_Cliente.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

