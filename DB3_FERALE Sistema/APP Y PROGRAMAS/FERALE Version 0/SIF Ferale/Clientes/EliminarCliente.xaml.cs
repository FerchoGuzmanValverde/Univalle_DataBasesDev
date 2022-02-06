using Ferale.SistemaDeInformacionApp.ClienteBrl;
using Ferale.SistemaDeInformacionApp.SIFComun;
using System;
using System.Windows;
using System.Windows.Input;

namespace SIF_Ferale.Clientes
{
    /// <summary>
    /// Lógica de interacción para EliminarCliente.xaml
    /// </summary>
    public partial class EliminarCliente : Window
    {
        /// <summary>
        /// Identificador del cliente a eliminar
        /// </summary>
        public int IdCliente { get; set; }

        /// <summary>
        /// Nombre completo del cliente a eliminar
        /// </summary>
        public string nombreCompleto { get; set; }

        public EliminarCliente(string nombre, int id)
        {
            InitializeComponent();
            IdCliente = id;
            nombreCompleto = nombre;
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void btnConfirmar_Click(object sender, RoutedEventArgs e)
        {
            Operaciones.WriteLogsDebug("EliminarCliente", "btnEliminar_Click", string.Format("{0} Info: {1}",
            DateTime.Now.ToString(),
            "Empezando a ejecutar el metodo de la capa de presentacion para eliminar un cliente"));

            try
            {
                ClienteBrl.Eliminar(IdCliente);
                this.Close();
            }
            catch (Exception ex)
            {
                Operaciones.WriteLogsRelease("EliminarCliente", "btnEliminar_Click", string.Format("{0} Error: {1}",
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

            Operaciones.WriteLogsDebug("EliminarCliente", "btnEliminar_Click", string.Format("{0} Info: {1}",
              DateTime.Now.ToString(),
              "Termino a ejecutar el metodo de la capa de presentacion para eliminar un cliente"));
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_ContentRendered(object sender, EventArgs e)
        {
            lblMensaje.Content = string.Format("¿Desea eliminar al cliente: {0}?", nombreCompleto);
        }
    }
}
