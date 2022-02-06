using Ferale.SistemaDeInformacionApp.ProductosBrl;
using Ferale.SistemaDeInformacionApp.SIFComun;
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

namespace SIF_Ferale.Productos
{
    /// <summary>
    /// Lógica de interacción para EliminarProducto.xaml
    /// </summary>
    public partial class EliminarProducto : Window
    {
        /// <summary>
        /// Identificador del producto a eliminar
        /// </summary>
        public int IdProducto { get; set; }

        /// <summary>
        /// Nombre completo del producto a eliminar
        /// </summary>
        public string nombreCompleto { get; set; }

        public EliminarProducto(string nombre, int id)
        {
            InitializeComponent();
            IdProducto = id;
            nombreCompleto = nombre;
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void btnConfirmar_Click(object sender, RoutedEventArgs e)
        {
            Operaciones.WriteLogsDebug("EliminarProducto", "btnEliminar_Click", string.Format("{0} Info: {1}",
            DateTime.Now.ToString(),
            "Empezando a ejecutar el metodo de la capa de presentacion para eliminar un producto"));

            try
            {
                ProductoBrl.Eliminar(IdProducto);
                this.Close();
            }
            catch (Exception ex)
            {
                Operaciones.WriteLogsRelease("EliminarProducto", "btnEliminar_Click", string.Format("{0} Error: {1}",
                    DateTime.Now.ToString(), ex.Message));
                MessageBoxResult result = MessageBox.Show("Existe un problema, por favor contactese con su administrador",
                                          "Confirmation",
                                          MessageBoxButton.OK,
                                          MessageBoxImage.Error);
                if (result == MessageBoxResult.OK)
                {
                    Application.Current.Shutdown();
                }
            }

            Operaciones.WriteLogsDebug("EliminarProducto", "btnEliminar_Click", string.Format("{0} Info: {1}",
              DateTime.Now.ToString(),
              "Termino a ejecutar el metodo de la capa de presentacion para eliminar un producto"));
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_ContentRendered(object sender, EventArgs e)
        {
            lblMensaje.Content = string.Format("¿Desea eliminar el producto: {0}?", nombreCompleto);
        }
    }
}
