using Ferale.SistemaDeInformacionApp.EmpleadoBrl;
using Ferale.SistemaDeInformacionApp.SIFComun;
using System.Windows;
using System.Windows.Input;

namespace SIF_Ferale.Empleados
{
    /// <summary>
    /// Lógica de interacción para VerEmpleado.xaml
    /// </summary>
    public partial class VerEmpleado : Window
    {
        public Empleado Empleado { get; set; }
        int empleadoKey = 0;

        public VerEmpleado(int key)
        {
            InitializeComponent();
            DataContext = this;
            empleadoKey = key;
        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void StackPanel_Loaded(object sender, RoutedEventArgs e)
        {
            CargarEmpleado();
        }

        public void CargarEmpleado()
        {
            if (empleadoKey != 0)
            {
                Empleado = EmpleadoBrl.Obtener(empleadoKey);
                txtNombreEmpleado.Text = Empleado.Nombre;
                txtPrimerApellidoEmpleado.Text = Empleado.PrimerApellido;
                txtSegundoApellidoEmpleado.Text = Empleado.SegundoApellido;
                txtCedulaIdentidadEmpelado.Text = Empleado.CedulaIdentidad;
                dateFechaNacimientoEmpleado.Text = (Empleado.FechaNacimiento).ToString();
                txtNroCuentaBancariaEmpleado.Text = Empleado.NroCuentaBancaria;
                txtSexo.Text = determinarSexo(Empleado.Sexo);
                txtCargo.Text = determinarTipo(Empleado.Cargo.IdCargo);
                txtLoginEmpleado.Text = Empleado.Usuario.LoginUsuario;
                txtPasswordEmpleado.Text = Empleado.Usuario.PasswordUsuario;
                txtProvincia.Text = Empleado.Provincia.NombreProvincia;
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
    }
}
