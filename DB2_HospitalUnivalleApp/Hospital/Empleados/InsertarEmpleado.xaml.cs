using System;
using System.Data.SqlClient;
using System.Windows;
using Univalle.Fie.Sistemas.BaseDeDatos2.HospitalApp.Comun;

namespace Univalle.Fie.Sistemas.BaseDeDatos2.HospitalApp.Wpf.Hospital.Empleados
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class InsertarEmpleado : Window
    {
        public InsertarEmpleado()
        {
            InitializeComponent();
            DataContext = this;
            dtpFechaContratacion.SelectedDate = DateTime.Now;
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnCrear_Click(object sender, RoutedEventArgs e)
        {
            Operaciones.WriteLogsDebug("InsertarEmpleado", "btnCrear_Click", string.Format("{0} Info: {1}",
			DateTime.Now.ToString(),
           "Empezando a ejecutar el metodo de la capa de presentacion para crear un empleado"));

            try
            {

                Empleado empleado = new Empleado();
                empleado.IdPersona = Guid.NewGuid();
                empleado.Nombre = txtNombre.Text.Trim();
                empleado.PrimerApellido = txtPrimerApellido.Text.Trim();
                empleado.FechaContratacion = dtpFechaContratacion.SelectedDate.Value;
                empleado.SegundoApellido = txtSegundoApellido.Text.Trim();
                empleado.Usuario = new Usuario();
                empleado.Usuario.IdUsuario = Guid.NewGuid();
                empleado.Usuario.Nombre = txtNombreUsuario.Text.Trim();
                empleado.Usuario.Contrasenia = txtContrasenia.Text.Trim();

                empleado.Telefonos = new System.Collections.Generic.List<Telefono>();
                if (!string.IsNullOrEmpty(ucTelefono1.txtNumero.Text))
                {
                    Telefono telefono1 = new Telefono();
                    telefono1.IdTelefono = Guid.NewGuid();
                    telefono1.Numero = int.Parse(ucTelefono1.txtNumero.Text.Trim());
                    telefono1.TipoTelefono = new TipoTelefono();
                    telefono1.TipoTelefono.IdTipoTelefono = (ucTelefono1.cbxTipoTelefono.SelectedValue as TipoTelefono).IdTipoTelefono;
                    telefono1.Persona = empleado;
                    empleado.Telefonos.Add(telefono1);
                }

                if (!string.IsNullOrEmpty(ucTelefono2.txtNumero.Text))
                {
                    Telefono telefono1 = new Telefono();
                    telefono1.IdTelefono = Guid.NewGuid();
                    telefono1.Numero = int.Parse(ucTelefono2.txtNumero.Text.Trim());
                    telefono1.TipoTelefono = new TipoTelefono();
                    telefono1.TipoTelefono.IdTipoTelefono = (ucTelefono2.cbxTipoTelefono.SelectedValue as TipoTelefono).IdTipoTelefono;
                    telefono1.Persona = empleado;
                    empleado.Telefonos.Add(telefono1);
                }

                if (!string.IsNullOrEmpty(ucTelefono3.txtNumero.Text))
                {
                    Telefono telefono1 = new Telefono();
                    telefono1.IdTelefono = Guid.NewGuid();
                    telefono1.Numero = int.Parse(ucTelefono3.txtNumero.Text.Trim());
                    telefono1.TipoTelefono = new TipoTelefono();
                    telefono1.TipoTelefono.IdTipoTelefono = (ucTelefono3.cbxTipoTelefono.SelectedValue as TipoTelefono).IdTipoTelefono;
                    telefono1.Persona = empleado;
                    empleado.Telefonos.Add(telefono1);
                }


                EmpleadosBrl.EmpleadoBrl.Insertar(empleado);
                NavegadorEmpleado navegador = this.Owner as NavegadorEmpleado;
                navegador.RefrescarEmpleados();
                this.Close();
            }
            catch (Exception ex)
            {
                Operaciones.WriteLogsRelease("InsertarEmpleado", "btnCrear_Click", string.Format("{0} Error: {1}",
                    DateTime.Now.ToString(),  ex.Message));
                MessageBoxResult result = MessageBox.Show("Existe un problema, por favor contactese con su administrador",
                                          "Confirmation",
                                          MessageBoxButton.OK,
                                          MessageBoxImage.Error);
                if (result == MessageBoxResult.OK)
                {
                    Application.Current.Shutdown();
                }
            }

            Operaciones.WriteLogsDebug("InsertarEmpleado", "btnCrear_Click", string.Format("{0} Info: {1}",
              DateTime.Now.ToString(), 
              "Termino a ejecutar el metodo de la capa de presentacion para crear un empleado"));


        }
    }
}
