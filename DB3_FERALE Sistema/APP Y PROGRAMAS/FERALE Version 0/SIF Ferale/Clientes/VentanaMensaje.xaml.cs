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

namespace SIF_Ferale.Clientes
{
    /// <summary>
    /// Lógica de interacción para VentanaMensaje.xaml
    /// </summary>
    public partial class VentanaMensaje : Window
    {
        /// <summary>
        /// Nombre del cliente que se inserto
        /// </summary>
        string clienteNombre;

        public VentanaMensaje(string cliente)
        {
            InitializeComponent();
            clienteNombre = cliente;
        }

        private void btnConfirmar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void Window_ContentRendered(object sender, EventArgs e)
        {
            lblMensaje.Content = string.Format("Se ha insertado el cliente: {0}.", clienteNombre);
        }
    }
}
