﻿#pragma checksum "..\..\..\Clientes\NvegadorClientes.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "07F5D69C6596E362E0907E4E90F75142ACEA965BDC6AD8C3A4E4926F36C5583E"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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


namespace SIF_Ferale.Clientes {
    
    
    /// <summary>
    /// NvegadorClientes
    /// </summary>
    public partial class NvegadorClientes : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\..\Clientes\NvegadorClientes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtApellidoCliente;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\Clientes\NvegadorClientes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnBuscarCliente;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\Clientes\NvegadorClientes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCrearCliente;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\Clientes\NvegadorClientes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnEditarCliente;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\Clientes\NvegadorClientes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnVerCliente;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\Clientes\NvegadorClientes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnEliminarCliente;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\Clientes\NvegadorClientes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lstListaClientes;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Clientes\NvegadorClientes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtNombreCliente;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\Clientes\NvegadorClientes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbxProvincia;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\Clientes\NvegadorClientes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnReportes;
        
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
            System.Uri resourceLocater = new System.Uri("/SIF Ferale;component/clientes/nvegadorclientes.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Clientes\NvegadorClientes.xaml"
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
            this.txtApellidoCliente = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.btnBuscarCliente = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\..\Clientes\NvegadorClientes.xaml"
            this.btnBuscarCliente.Click += new System.Windows.RoutedEventHandler(this.btnBuscarCliente_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnCrearCliente = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\..\Clientes\NvegadorClientes.xaml"
            this.btnCrearCliente.Click += new System.Windows.RoutedEventHandler(this.btnCrearCliente_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnEditarCliente = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\..\Clientes\NvegadorClientes.xaml"
            this.btnEditarCliente.Click += new System.Windows.RoutedEventHandler(this.btnEditarCliente_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnVerCliente = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\..\Clientes\NvegadorClientes.xaml"
            this.btnVerCliente.Click += new System.Windows.RoutedEventHandler(this.btnVerCliente_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnEliminarCliente = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\..\Clientes\NvegadorClientes.xaml"
            this.btnEliminarCliente.Click += new System.Windows.RoutedEventHandler(this.btnEliminarCliente_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.lstListaClientes = ((System.Windows.Controls.ListBox)(target));
            return;
            case 8:
            this.txtNombreCliente = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.cbxProvincia = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 10:
            this.btnReportes = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\..\Clientes\NvegadorClientes.xaml"
            this.btnReportes.Click += new System.Windows.RoutedEventHandler(this.btnReportes_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
