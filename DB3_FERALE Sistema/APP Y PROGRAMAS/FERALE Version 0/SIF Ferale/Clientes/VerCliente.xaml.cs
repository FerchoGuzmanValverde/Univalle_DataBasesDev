using Ferale.SistemaDeInformacionApp.ClienteBrl;
using Ferale.SistemaDeInformacionApp.SIFComun;
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

namespace SIF_Ferale.Clientes
{
    /// <summary>
    /// Lógica de interacción para VerCliente.xaml
    /// </summary>
    public partial class VerCliente : Window
    {
        public Cliente Cliente { get; set; }
        int clienteKey = 0;

        public VerCliente(int key)
        {
            InitializeComponent();
            DataContext = this;
            clienteKey = key;
        }

        private void StackPanel_Loaded(object sender, RoutedEventArgs e)
        {
            CargarCliente();
        }

        private void StackPanel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
