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
using Univalle.Fie.Sistemas.BaseDeDatos2.HospitalApp.Comun;

namespace Univalle.Fie.Sistemas.BaseDeDatos2.HospitalApp.Wpf.Hospital.Empleados
{
    /// <summary>
    /// Lógica de interacción para EliminarEmpleado.xaml
    /// </summary>
    public partial class EliminarEmpleado : Window
    {
        /// <summary>
        /// Identificador del empleado a eliminar
        /// </summary>
        public Guid IdEmpleado { get; set; }

        /// <summary>
        /// Nombre completo del empleado a eliminar
        /// </summary>
        public string NombreCompleto { get; set; }

        public EliminarEmpleado()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            Operaciones.WriteLogsDebug("EliminarEmpleado", "btnCrear_Click", string.Format("{0} Info: {1}",
         DateTime.Now.ToString(),
         "Empezando a ejecutar el metodo de la capa de presentacion para eliminar un empleado"));

            try
            {

                EmpleadosBrl.EmpleadoBrl.Eliminar(IdEmpleado);
                NavegadorEmpleado navegador = this.Owner as NavegadorEmpleado;
                navegador.RefrescarEmpleados();
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
              "Termino a ejecutar el metodo de la capa de presentacion para crear un empleado"));

        }

        private void Window_ContentRendered(object sender, EventArgs e)
        {
            lblMensaje.Content = string.Format("¿Desea eliminar al empleado: {0}?", NombreCompleto);
        }
    }
}
