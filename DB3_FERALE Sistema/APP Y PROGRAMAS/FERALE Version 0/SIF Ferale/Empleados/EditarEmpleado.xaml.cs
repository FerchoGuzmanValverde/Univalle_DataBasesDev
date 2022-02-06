using Ferale.SistemaDeInformacionApp.EmpleadoBrl;
using Ferale.SistemaDeInformacionApp.SIFComun;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace SIF_Ferale.Empleados
{
    /// <summary>
    /// Lógica de interacción para EditarEmpleado.xaml
    /// </summary>
    public partial class EditarEmpleado : Window
    {
        public Empleado Empleado { get; set; }
        int empleadoKey = 0;

        public EditarEmpleado(int key)
        {
            InitializeComponent();
            DataContext = this;
            empleadoKey = key;
        }

        private void btnEditar_Click(object sender, RoutedEventArgs e)
        {
            Operaciones.WriteLogsDebug("EditarEmpleado", "btnEditar_Click", string.Format("{0} Info: {1}",
                      DateTime.Now.ToString(),
                      "Empezando a ejecutar el metodo de la capa de presentacion para editar un empleado"));

            try
            {
                Empleado.IdEmpleado = empleadoKey;
                Empleado.Nombre = txtNombreEmpleado.Text;
                Empleado.PrimerApellido = txtPrimerApellidoEmpleado.Text;
                Empleado.SegundoApellido = txtSegundoApellidoEmpleado.Text;
                Empleado.CedulaIdentidad = txtCedulaIdentidadEmpelado.Text;
                Empleado.FechaNacimiento = dateFechaNacimientoEmpleado.SelectedDate.Value;
                Empleado.NroCuentaBancaria = txtNroCuentaBancariaEmpleado.Text;
                Empleado.Sexo = determinarSexo1((cbxSexoEmpleado.SelectionBoxItem).ToString());
                Empleado.Cargo = determinarTipo1((cbxTipoEmpleado.SelectionBoxItem).ToString());

                Telefono telefono;
                if (!string.IsNullOrEmpty(txtTelefonoEmpleado.Text))
                {
                    telefono = Empleado.Telefonos[0];
                    telefono.NroTelefono = txtTelefonoEmpleado.Text.Trim();
                    telefono.Persona = Empleado;
                }
                if (!string.IsNullOrEmpty(txtTelefonoEmpleado1.Text))
                {
                    telefono = Empleado.Telefonos[1];
                    telefono.NroTelefono = txtTelefonoEmpleado.Text.Trim();
                    telefono.Persona = Empleado;
                }

                EmpleadoBrl.Actualizar(Empleado);
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

            Operaciones.WriteLogsDebug("EditarEmpleado", "btnEditar_Click", string.Format("{0} Info: {1}",
              DateTime.Now.ToString(),
              "Termino a ejecutar el metodo de la capa de presentacion para editar un empleado"));
        }

        private void btnLimpiar_Click(object sender, RoutedEventArgs e)
        {
            limpiar();
        }

        private void Cancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void limpiar()
        {
            txtNombreEmpleado.Clear();
            txtPrimerApellidoEmpleado.Clear();
            txtSegundoApellidoEmpleado.Clear();
            txtCedulaIdentidadEmpelado.Clear();
            dateFechaNacimientoEmpleado.Text = "";
            txtNroCuentaBancariaEmpleado.Clear();
            cbxSexoEmpleado.SelectedItem = "Sexo";
            cbxTipoEmpleado.SelectedItem = "Cargo";
            txtTelefonoEmpleado.Clear();
            txtTelefonoEmpleado1.Clear();
            txtLoginEmpleado.Clear();
            txtPasswordEmpleado.Clear();
            cbxProvincia.SelectedItem = "Provincia";
            txtDescripcionDomicilio.Clear();
        }

        public void CargarEmpleado()
        {
            ComboBoxItem lugares = new ComboBoxItem();
            lugares.Content = "Manuel Maria Caballero";
            cbxProvincia.Items.Add(lugares);

            if (empleadoKey != 0)
            {
                Empleado = EmpleadoBrl.Obtener(empleadoKey);
                txtNombreEmpleado.Text = Empleado.Nombre;
                txtPrimerApellidoEmpleado.Text = Empleado.PrimerApellido;
                txtSegundoApellidoEmpleado.Text = Empleado.SegundoApellido;
                txtCedulaIdentidadEmpelado.Text = Empleado.CedulaIdentidad;
                dateFechaNacimientoEmpleado.Text = (Empleado.FechaNacimiento).ToString();
                txtNroCuentaBancariaEmpleado.Text = Empleado.NroCuentaBancaria;
                cbxSexoEmpleado.Text = determinarSexo(Empleado.Sexo);
                cbxTipoEmpleado.Text = determinarTipo(Empleado.Cargo.IdCargo);
                txtLoginEmpleado.Text = Empleado.Usuario.LoginUsuario;
                txtPasswordEmpleado.Text = Empleado.Usuario.PasswordUsuario;
                cbxProvincia.Text = Empleado.Provincia.NombreProvincia;
                txtDescripcionDomicilio.Text = Empleado.Domicilio.Descripcion;
                if (Empleado.Telefonos.Count >= 1)
                {
                    txtTelefonoEmpleado.Text = Empleado.Telefonos[0].NroTelefono.ToString();
                }
                if (Empleado.Telefonos.Count >= 2)
                {
                    txtTelefonoEmpleado1.Text = Empleado.Telefonos[1].NroTelefono.ToString();
                }
            }
        }

        private void StackPanel_Loaded(object sender, RoutedEventArgs e)
        {
            CargarEmpleado();
        }

        private string determinarSexo(byte sexo)
        {
            if (sexo == 0)
                return "Hombre";
            else
                return "Mujer";
        }

        private string determinarTipo(byte tipo)
        {
            if (tipo == 1)
                return "Administrador";
            else
                return "Operador";
        }

        private byte determinarSexo1(string sexo)
        {
            if (sexo == "Hombre")
                return 0;
            else
                return 1;
        }

        private Cargo determinarTipo1(string tipo)
        {
            Cargo cargo = new Cargo();
            if (tipo == "Administrador")
            {
                cargo.IdCargo = 1;
                cargo.NombreCargo = "Administrador";
                return cargo;
            }
            else
            {
                cargo.IdCargo = 2;
                cargo.NombreCargo = "Operador";
                return cargo;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
