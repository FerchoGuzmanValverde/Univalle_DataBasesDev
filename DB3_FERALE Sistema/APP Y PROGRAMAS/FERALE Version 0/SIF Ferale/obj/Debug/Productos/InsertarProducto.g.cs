﻿#pragma checksum "..\..\..\Productos\InsertarProducto.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4C901E993DCC3AC29F8D5A3B55F194D8293DABA7E756DE64064A69D0080C7217"
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


namespace SIF_Ferale.Productos {
    
    
    /// <summary>
    /// InsertarProducto
    /// </summary>
    public partial class InsertarProducto : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 38 "..\..\..\Productos\InsertarProducto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtNombreProducto;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\Productos\InsertarProducto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtPrecioBase;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\Productos\InsertarProducto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtVariedad;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\Productos\InsertarProducto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbxAreaProducto;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\Productos\InsertarProducto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBoxItem Viveros;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\Productos\InsertarProducto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBoxItem Comercializacion;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\Productos\InsertarProducto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCrear;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\Productos\InsertarProducto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnLimpiar;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\Productos\InsertarProducto.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Cancelar;
        
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
            System.Uri resourceLocater = new System.Uri("/SIF Ferale;component/productos/insertarproducto.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Productos\InsertarProducto.xaml"
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
            
            #line 8 "..\..\..\Productos\InsertarProducto.xaml"
            ((System.Windows.Controls.StackPanel)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.StackPanel_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 11 "..\..\..\Productos\InsertarProducto.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.txtNombreProducto = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txtPrecioBase = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txtVariedad = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.cbxAreaProducto = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            this.Viveros = ((System.Windows.Controls.ComboBoxItem)(target));
            return;
            case 8:
            this.Comercializacion = ((System.Windows.Controls.ComboBoxItem)(target));
            return;
            case 9:
            this.btnCrear = ((System.Windows.Controls.Button)(target));
            
            #line 49 "..\..\..\Productos\InsertarProducto.xaml"
            this.btnCrear.Click += new System.Windows.RoutedEventHandler(this.btnCrear_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.btnLimpiar = ((System.Windows.Controls.Button)(target));
            
            #line 50 "..\..\..\Productos\InsertarProducto.xaml"
            this.btnLimpiar.Click += new System.Windows.RoutedEventHandler(this.btnLimpiar_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.Cancelar = ((System.Windows.Controls.Button)(target));
            
            #line 51 "..\..\..\Productos\InsertarProducto.xaml"
            this.Cancelar.Click += new System.Windows.RoutedEventHandler(this.Cancelar_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
