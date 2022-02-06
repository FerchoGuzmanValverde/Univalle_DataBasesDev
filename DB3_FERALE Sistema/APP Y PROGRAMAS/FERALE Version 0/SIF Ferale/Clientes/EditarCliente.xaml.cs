using Ferale.SistemaDeInformacionApp.ClienteBrl;
using Ferale.SistemaDeInformacionApp.SIFComun;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace SIF_Ferale.Clientes
{
    /// <summary>
    /// Lógica de interacción para EditarCliente.xaml
    /// </summary>
    public partial class EditarCliente : Window
    {
        public Cliente Cliente { get; set; }
        int clienteKey = 0;

        public EditarCliente(int key)
        {
            InitializeComponent();
            DataContext = this;
            clienteKey = key;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnEditar_Click(object sender, RoutedEventArgs e)
        {
            Operaciones.WriteLogsDebug("EditarCliente", "btnEditar_Click", string.Format("{0} Info: {1}",
                      DateTime.Now.ToString(),
                      "Empezando a ejecutar el metodo de la capa de presentacion para editar un cliente"));

            try
            {
                Cliente.IdCliente = clienteKey;
                Cliente.Nombre = txtNombreCliente.Text;
                Cliente.PrimerApellido = txtPrimerApellidoCliente.Text;
                Cliente.SegundoApellido = txtSegundoApellidoCliente.Text;
                Cliente.CedulaIdentidad = txtCedulaIdentidadCliente.Text;
                Cliente.RazonSocial = txtRazonSocial.Text;

                Telefono telefono;
                if (!string.IsNullOrEmpty(txtTelefonoCliente.Text))
                {
                    telefono = Cliente.Telefonos[0];
                    telefono.NroTelefono = txtTelefonoCliente.Text.Trim();
                    telefono.Persona = Cliente;
                }
                if (!string.IsNullOrEmpty(txtTelefonoCliente1.Text))
                {
                    telefono = Cliente.Telefonos[1];
                    telefono.NroTelefono = txtTelefonoCliente1.Text.Trim();
                    telefono.Persona = Cliente;
                }

                ClienteBrl.Actualizar(Cliente);
                this.Close();
            }
            catch (Exception ex)
            {
                Operaciones.WriteLogsRelease("EditarCliente", "btnEditar_Click", string.Format("{0} Error: {1}",
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

            Operaciones.WriteLogsDebug("EditarCliente", "btnEditar_Click", string.Format("{0} Info: {1}",
              DateTime.Now.ToString(),
              "Termino a ejecutar el metodo de la capa de presentacion para editar un cliente"));
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

        public void CargarCliente()
        {
            ComboBoxItem lugares = new ComboBoxItem();
            lugares.Content = "Cochabamba";
            cbxProvincia.Items.Add(lugares);

            if (clienteKey != 0)
            {
                Cliente = ClienteBrl.Obtener(clienteKey);
                txtNombreCliente.Text = Cliente.Nombre;
                txtPrimerApellidoCliente.Text = Cliente.PrimerApellido;
                txtSegundoApellidoCliente.Text = Cliente.SegundoApellido;
                txtCedulaIdentidadCliente.Text = Cliente.CedulaIdentidad;
                txtRazonSocial.Text = Cliente.RazonSocial;
                txtLoginCliente.Text = Cliente.Usuario.LoginUsuario;
                txtPasswordCliente.Text = Cliente.Usuario.PasswordUsuario;
                cbxProvincia.Text = Cliente.Provincia.NombreProvincia;
                txtDescripcionDomicilio.Text = Cliente.Domicilio.Descripcion;
                if (Cliente.Telefonos.Count >= 1)
                {
                    txtTelefonoCliente.Text = Cliente.Telefonos[0].NroTelefono.ToString();
                }
                if (Cliente.Telefonos.Count >= 2)
                {
                    txtTelefonoCliente1.Text = Cliente.Telefonos[1].NroTelefono.ToString();
                }
            }
        }

        private void Cancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void StackPanel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void StackPanel_Loaded(object sender, RoutedEventArgs e)
        {
            CargarCliente();
        }
    }
}
