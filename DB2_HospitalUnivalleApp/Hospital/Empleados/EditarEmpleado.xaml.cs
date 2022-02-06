using System;
using System.Data.SqlClient;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using Univalle.Fie.Sistemas.BaseDeDatos2.HospitalApp.Comun;

namespace Univalle.Fie.Sistemas.BaseDeDatos2.HospitalApp.Wpf.Hospital.Empleados
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class EditarEmpleado : Window
    {
        /// <summary>
        /// Objeto empleado para actualizar
        /// </summary>
        public Empleado Empleado { get; set; }

        public EditarEmpleado()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void EditarEmpleado_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            CargarEmpleado();
        }

        private void btnActualizar_Click(object sender, RoutedEventArgs e)
        {
            Operaciones.WriteLogsDebug("InsertarEmpleado", "btnCrear_Click", string.Format("{0} Info: {1}",
                      DateTime.Now.ToString(),
                      "Empezando a ejecutar el metodo de la capa de presentacion para crear un empleado"));

            try
            {

                Empleado.Nombre = txtNombre.Text.Trim();
                Empleado.PrimerApellido = txtPrimerApellido.Text.Trim();
                Empleado.FechaContratacion = dtpFechaContratacion.SelectedDate.Value;
                Empleado.SegundoApellido = txtSegundoApellido.Text.Trim();
                Empleado.Usuario.Nombre = txtNombreUsuario.Text.Trim();
                Empleado.Usuario.Contrasenia = txtContrasenia.Text.Trim();

                if (!string.IsNullOrEmpty(ucTelefono1.txtNumero.Text))
                {
                    Telefono telefono1 = Empleado.Telefonos[0];
                    telefono1.Numero = int.Parse(ucTelefono1.txtNumero.Text.Trim());
                    telefono1.TipoTelefono.IdTipoTelefono = (ucTelefono1.cbxTipoTelefono.SelectedValue as TipoTelefono).IdTipoTelefono;
                    telefono1.Persona = Empleado;
                }

                if (!string.IsNullOrEmpty(ucTelefono2.txtNumero.Text))
                {
                    Telefono telefono1 = Empleado.Telefonos[1];
                    telefono1.Numero = int.Parse(ucTelefono2.txtNumero.Text.Trim());
                    telefono1.TipoTelefono.IdTipoTelefono = (ucTelefono2.cbxTipoTelefono.SelectedValue as TipoTelefono).IdTipoTelefono;
                    telefono1.Persona = Empleado;
                }

                if (!string.IsNullOrEmpty(ucTelefono3.txtNumero.Text))
                {
                    Telefono telefono1 = Empleado.Telefonos[2];
                    telefono1.Numero = int.Parse(ucTelefono3.txtNumero.Text.Trim());
                    telefono1.TipoTelefono.IdTipoTelefono = (ucTelefono3.cbxTipoTelefono.SelectedValue as TipoTelefono).IdTipoTelefono;
                    telefono1.Persona = Empleado;
                }


                EmpleadosBrl.EmpleadoBrl.Actualizar(Empleado);
                NavegadorEmpleado navegador = this.Owner as NavegadorEmpleado;
                navegador.RefrescarEmpleados();
                this.Close();
            }
            catch (Exception ex)
            {
                Operaciones.WriteLogsRelease("InsertarEmpleado", "btnCrear_Click", string.Format("{0} Error: {1}",
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

            Operaciones.WriteLogsDebug("InsertarEmpleado", "btnCrear_Click", string.Format("{0} Info: {1}",
              DateTime.Now.ToString(),
              "Termino a ejecutar el metodo de la capa de presentacion para crear un empleado"));
        }

        public void CargarEmpleado()
        {
            NavegadorEmpleado navegador = this.Owner as NavegadorEmpleado;
            if (navegador.lbxEmpleados.SelectedValue != null)
            {
                Empleado = EmpleadosBrl.EmpleadoBrl.Obtener((Guid)navegador.lbxEmpleados.SelectedValue);
                txtNombre.Text = Empleado.Nombre;
                txtPrimerApellido.Text = Empleado.PrimerApellido;
                txtSegundoApellido.Text = Empleado.SegundoApellido;
                txtNombreUsuario.Text = Empleado.Usuario.Nombre;
                dtpFechaContratacion.SelectedDate = Empleado.FechaContratacion;
                if (Empleado.Telefonos.Count == 1)
                {
                    ucTelefono1.IdTelefono = Empleado.Telefonos[0].IdTelefono;
                    ucTelefono1.txtNumero.Text = Empleado.Telefonos[0].Numero.ToString();
                    ucTelefono1.cbxTipoTelefono.SelectedIndex = Empleado.Telefonos[0].TipoTelefono.IdTipoTelefono-1;
                }

                if (Empleado.Telefonos.Count == 2)
                {
                    //Telefono 1
                    ucTelefono1.IdTelefono = Empleado.Telefonos[0].IdTelefono;
                    ucTelefono1.txtNumero.Text = Empleado.Telefonos[0].Numero.ToString();
                    ucTelefono1.cbxTipoTelefono.SelectedIndex = Empleado.Telefonos[0].TipoTelefono.IdTipoTelefono - 1;

                    //Telefono 2
                    ucTelefono2.IdTelefono = Empleado.Telefonos[1].IdTelefono;
                    ucTelefono2.txtNumero.Text = Empleado.Telefonos[1].Numero.ToString();
                    ucTelefono2.cbxTipoTelefono.SelectedIndex = Empleado.Telefonos[1].TipoTelefono.IdTipoTelefono - 1;
                }

                if (Empleado.Telefonos.Count == 3)
                {
                    //Telefono 1
                    ucTelefono1.IdTelefono = Empleado.Telefonos[0].IdTelefono;
                    ucTelefono1.txtNumero.Text = Empleado.Telefonos[0].Numero.ToString();
                    ucTelefono1.cbxTipoTelefono.SelectedIndex = 2;
                    ucTelefono1.cbxTipoTelefono.SelectedIndex = Empleado.Telefonos[0].TipoTelefono.IdTipoTelefono - 1;

                    //Telefono 2
                    ucTelefono2.IdTelefono = Empleado.Telefonos[1].IdTelefono;
                    ucTelefono2.txtNumero.Text = Empleado.Telefonos[1].Numero.ToString();
                    ucTelefono2.cbxTipoTelefono.SelectedIndex = Empleado.Telefonos[1].TipoTelefono.IdTipoTelefono - 1;

                    //Telefono 3
                    ucTelefono3.IdTelefono = Empleado.Telefonos[2].IdTelefono;
                    ucTelefono3.txtNumero.Text = Empleado.Telefonos[2].Numero.ToString();
                    ucTelefono3.cbxTipoTelefono.SelectedIndex = Empleado.Telefonos[2].TipoTelefono.IdTipoTelefono - 1;
                }
            }
        }

        private void Window_ContentRendered(object sender, EventArgs e)
        {
            CargarEmpleado();
        }
    }
}
