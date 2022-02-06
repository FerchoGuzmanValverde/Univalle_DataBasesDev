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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SIF_Ferale.Clientes
{
    /// <summary>
    /// Lógica de interacción para NvegadorClientes.xaml
    /// </summary>
    public partial class NvegadorClientes : UserControl
    {
        public NvegadorClientes()
        {
            InitializeComponent();
        }

        private void btnBuscarCliente_Click(object sender, RoutedEventArgs e)
        {
            RefrescarClientes();
        }

        public void RefrescarClientes()
        {
            ComboBoxItem provincia = new ComboBoxItem(); //Poner en el lugar correcto
            provincia.Content = "Cochabamba";
            provincia.Name = "Cochabamba";
            cbxProvincia.Items.Add(provincia);

            string nombre = txtNombreCliente.Text;
            string apellido = txtApellidoCliente.Text;
            string pro = (cbxProvincia.SelectionBoxItem).ToString();
            byte Provincia = 1;
            if(pro == "Cochabamba")
            { Provincia = 2; }
            lstListaClientes.ItemsSource = ClienteKeyValueListBrl.Obtener(nombre, apellido, Provincia);
            lstListaClientes.DisplayMemberPath = "NombreCompleto";
            lstListaClientes.SelectedValuePath = "IdPersona";
        }

        private void btnCrearCliente_Click(object sender, RoutedEventArgs e)
        {
            Clientes.InsertarCliente nuevoCrear = new Clientes.InsertarCliente();
            nuevoCrear.ShowDialog();
            RefrescarClientes();
        }

        private void btnEditarCliente_Click(object sender, RoutedEventArgs e)
        {
            if (lstListaClientes.SelectedValue != null)
            {
                Clientes.EditarCliente form = new Clientes.EditarCliente((int)lstListaClientes.SelectedValue);
                form.ShowDialog();
                RefrescarClientes();
            }
        }

        private void btnVerCliente_Click(object sender, RoutedEventArgs e)
        {
            if (lstListaClientes.SelectedValue != null)
            {
                Clientes.VerCliente form = new Clientes.VerCliente((int)lstListaClientes.SelectedValue);
                form.ShowDialog();
            }
        }

        private void btnEliminarCliente_Click(object sender, RoutedEventArgs e)
        {
            if (lstListaClientes.SelectedValue != null)
            {
                Clientes.EliminarCliente form = new Clientes.EliminarCliente(((ClienteKeyValue)lstListaClientes.SelectedItem).NombreCompleto, (int)lstListaClientes.SelectedValue);
                form.ShowDialog();
                RefrescarClientes();
            }
        }

        private void btnReportes_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
