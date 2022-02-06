using Ferale.SistemaDeInformacionApp.ClienteBrl;
using Ferale.SistemaDeInformacionApp.SIFComun;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace SIF_Ferale.Clientes
{
    /// <summary>
    /// Lógica de interacción para InsertarCliente.xaml
    /// </summary>
    public partial class InsertarCliente : Window
    {
        public InsertarCliente()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, RoutedEventArgs e)
        {
            Cliente cliente = new Cliente();

            Domicilio casita = new Domicilio();
            casita.Descripcion = txtDescripcionDomicilio.Text;
            casita.Estado = 1;

            Provincia lugar = new Provincia();
            lugar.NombreProvincia = (cbxProvincia.SelectionBoxItem).ToString();
            lugar.IdProvincia = 2;

            TelefonosList lista = new TelefonosList();
            Telefono nuevo = new Telefono();
            nuevo.NroTelefono = txtTelefonoCliente.Text;
            lista.Add(nuevo);
            nuevo.NroTelefono = txtTelefonoCliente1.Text;
            lista.Add(nuevo);


            Usuario usuario = new Usuario();
            usuario.LoginUsuario = txtLoginCliente.Text;
            usuario.PasswordUsuario = txtPasswordCliente.Text;

            cliente.CedulaIdentidad = txtCedulaIdentidadCliente.Text;
            cliente.Domicilio = casita;
            cliente.Estado = 1;
            cliente.Nombre = txtNombreCliente.Text;
            cliente.PrimerApellido = txtPrimerApellidoCliente.Text;
            cliente.Provincia = lugar;
            cliente.RazonSocial = txtRazonSocial.Text;
            cliente.SegundoApellido = txtSegundoApellidoCliente.Text;
            cliente.Telefonos = lista;
            cliente.TipoPersona = 1;
            cliente.Usuario = usuario;
            ClienteBrl.Insertar(cliente);

            Clientes.VentanaMensaje form = new Clientes.VentanaMensaje(cliente.Nombre + " " + cliente.PrimerApellido);
            form.ShowDialog();
            Limpiar();
        }

        private void btnLimpiar_Click(object sender, RoutedEventArgs e)
        {
            Limpiar();
        }

        public void Limpiar()
        {
            txtNombreCliente.Clear();
            txtPrimerApellidoCliente.Clear();
            txtSegundoApellidoCliente.Clear();
            txtCedulaIdentidadCliente.Clear();
            txtRazonSocial.Clear();
            txtDescripcionDomicilio.Clear();
            cbxProvincia.Text = "Provincia";
            txtTelefonoCliente.Clear();
            txtTelefonoCliente1.Clear();
            txtLoginCliente.Clear();
            txtPasswordCliente.Clear();
        }

        private void Cancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void StackPanel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void cbxProvincia_Loaded(object sender, RoutedEventArgs e)
        {
            ComboBoxItem nuevo = new ComboBoxItem();
            nuevo.Content = "Cochabamba";
            nuevo.Name = "Cochabamba";

            cbxProvincia.Items.Add(nuevo);
        }
    }
}
