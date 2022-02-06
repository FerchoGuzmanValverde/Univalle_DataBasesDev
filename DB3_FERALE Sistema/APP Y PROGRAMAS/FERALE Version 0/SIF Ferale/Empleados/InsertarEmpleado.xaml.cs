using Ferale.SistemaDeInformacionApp.EmpleadoBrl;
using Ferale.SistemaDeInformacionApp.SIFComun;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace SIF_Ferale.Empleados
{
    /// <summary>
    /// Lógica de interacción para InsertarEmpleado.xaml
    /// </summary>
    public partial class InsertarEmpleado : Window
    {
        public InsertarEmpleado()
        {
            InitializeComponent();
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void btnCrear_Click(object sender, RoutedEventArgs e)
        {
            Empleado empleado = new Empleado();

            Domicilio casita = new Domicilio();
            casita.Descripcion = txtDescripcionDomicilio.Text;
            casita.Estado = 1;

            Provincia lugar = new Provincia();
            lugar.NombreProvincia = (cbxProvincia.SelectionBoxItem).ToString();
            lugar.IdProvincia = 1;

            TelefonosList lista = new TelefonosList();
            Telefono nuevo = new Telefono();
            nuevo.NroTelefono = txtTelefonoEmpleado.Text;
            lista.Add(nuevo);
            nuevo.NroTelefono = txtTelefonoEmpleado1.Text;
            lista.Add(nuevo);


            Usuario usuario = new Usuario();
            usuario.LoginUsuario = txtLoginEmpleado.Text;
            usuario.PasswordUsuario = txtPasswordEmpleado.Text;

            Cargo cargo = new Cargo();
            cargo.NombreCargo = (cbxTipoEmpleado.SelectionBoxItem).ToString();
            if(cargo.NombreCargo == "Administrador")
            { cargo.IdCargo = 1; }
            else
            { cargo.IdCargo = 2; }

            empleado.CedulaIdentidad = txtCedulaIdentidadEmpelado.Text;
            empleado.Domicilio = casita;
            empleado.Estado = 1;
            empleado.Nombre = txtNombreEmpleado.Text;
            empleado.PrimerApellido = txtPrimerApellidoEmpleado.Text;
            empleado.Provincia = lugar;
            empleado.FechaNacimiento = DateTime.Parse((dateFechaNacimientoEmpleado.SelectedDate).ToString());
            empleado.Sexo = sexo();
            empleado.NroCuentaBancaria = txtNroCuentaBancariaEmpleado.Text;
            empleado.Cargo = cargo;
            empleado.SegundoApellido = txtSegundoApellidoEmpleado.Text;
            empleado.Telefonos = lista;
            empleado.TipoPersona = 2;
            empleado.Usuario = usuario;
            EmpleadoBrl.Insertar(empleado);

            Empleados.VentanaMensajes form = new Empleados.VentanaMensajes(empleado.Nombre + " " + empleado.PrimerApellido);
            form.ShowDialog();
            limpiar();
        }

        private byte sexo()
        {
            string sexo = (cbxSexoEmpleado.SelectionBoxItem).ToString();
            if(sexo == "Hombre")
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

        private void btnLimpiar_Click(object sender, RoutedEventArgs e)
        {
            limpiar();
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

        private void Cancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void cbxProvincia_Loaded(object sender, RoutedEventArgs e)
        {
            ComboBoxItem nuevo = new ComboBoxItem();
            nuevo.Name = "Comarapa";
            nuevo.Content = "Comarapa";
            cbxProvincia.Items.Add(nuevo);
        }
    }
}
