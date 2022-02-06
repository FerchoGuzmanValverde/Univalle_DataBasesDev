using Ferale.SistemaDeInformacionApp.EmpleadoBrl;
using Ferale.SistemaDeInformacionApp.SIFComun;
using System;
using System.Windows;

namespace SIF_Ferale.Empleados
{
    /// <summary>
    /// Lógica de interacción para EliminarEmpleado.xaml
    /// </summary>
    public partial class EliminarEmpleado : Window
    {
        /// <summary>
        /// Identificador del empleado a eliminar
        /// </summary>
        public int IdEmpleado { get; set; }

        /// <summary>
        /// Nombre completo del empleado a eliminar
        /// </summary>
        public string nombreCompleto { get; set; }

        public EliminarEmpleado(string nombre, int id)
        {
            InitializeComponent();
            nombreCompleto = nombre;
            IdEmpleado = id;
        }

        private void btnConfirmar_Click(object sender, RoutedEventArgs e)
        {
            Operaciones.WriteLogsDebug("EliminarEmpleado", "btnEliminar_Click", string.Format("{0} Info: {1}",
            DateTime.Now.ToString(),
            "Empezando a ejecutar el metodo de la capa de presentacion para eliminar un empleado"));

            try
            {
                EmpleadoBrl.Eliminar(IdEmpleado);
                this.Close();
            }
            catch (Exception ex)
            {
                Operaciones.WriteLogsRelease("EliminarEmpleado", "btnEliminar_Click", string.Format("{0} Error: {1}",
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

            Operaciones.WriteLogsDebug("EliminarEmpleado", "btnEliminar_Click", string.Format("{0} Info: {1}",
              DateTime.Now.ToString(),
              "Termino a ejecutar el metodo de la capa de presentacion para eliminar un empleado"));
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_ContentRendered(object sender, EventArgs e)
        {
            lblMensaje.Content = string.Format("¿Desea eliminar al empleado: {0}?", nombreCompleto);
        }

        private void Grid_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            DragMove();
        }
    }
}
