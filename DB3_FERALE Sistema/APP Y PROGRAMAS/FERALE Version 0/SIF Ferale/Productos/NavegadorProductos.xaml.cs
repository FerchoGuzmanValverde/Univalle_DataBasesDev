using Ferale.SistemaDeInformacionApp.ProductosBrl;
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

namespace SIF_Ferale.Productos
{
    /// <summary>
    /// Lógica de interacción para NavegadorProductos.xaml
    /// </summary>
    public partial class NavegadorProductos : UserControl
    {
        public NavegadorProductos()
        {
            InitializeComponent();
        }

        private void btnBuscarProducto_Click(object sender, RoutedEventArgs e)
        {
            RefrescarProductos();
        }

        public void RefrescarProductos()
        {
            string nombre = txtNombreProducto.Text;
            string area = (cbxAreaProducto.SelectionBoxItem).ToString();
            byte areaP = 1;
            if (area == "Viveros")
            { areaP = 0; }
            lstListaProductos.ItemsSource = ProductoKeyValueListBrl.Obtener(nombre, areaP);
            lstListaProductos.DisplayMemberPath = "NombreCompleto";
            lstListaProductos.SelectedValuePath = "IdProducto";
        }

        private void btnCrearProducto_Click(object sender, RoutedEventArgs e)
        {
            Productos.InsertarProducto nuevoCrear = new Productos.InsertarProducto();
            nuevoCrear.ShowDialog();
            RefrescarProductos();
        }

        private void btnEditarProducto_Click(object sender, RoutedEventArgs e)
        {
            if (lstListaProductos.SelectedValue != null)
            {
                Productos.EditarProducto form = new Productos.EditarProducto((int)lstListaProductos.SelectedValue);
                form.ShowDialog();
                RefrescarProductos();
            }
        }

        private void btnVerProducto_Click(object sender, RoutedEventArgs e)
        {
            if (lstListaProductos.SelectedValue != null)
            {
                Productos.VerProducto form = new Productos.VerProducto((int)lstListaProductos.SelectedValue);
                form.ShowDialog();
            }
        }

        private void btnEliminarProducto_Click(object sender, RoutedEventArgs e)
        {
            if (lstListaProductos.SelectedValue != null)
            {
                Productos.EliminarProducto form = new Productos.EliminarProducto(((ProductoKeyValue)lstListaProductos.SelectedItem).NombreCompleto, (int)lstListaProductos.SelectedValue);
                form.ShowDialog();
                RefrescarProductos();
            }
        }
    }
}
