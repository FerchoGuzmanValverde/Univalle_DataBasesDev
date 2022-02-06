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
using System.Windows.Shapes;

namespace SIF_Ferale.Productos
{
    /// <summary>
    /// Lógica de interacción para EditarProducto.xaml
    /// </summary>
    public partial class EditarProducto : Window
    {
        public Producto Producto { get; set; }
        int productoKey = 0;

        public EditarProducto(int key)
        {
            InitializeComponent();
            DataContext = this;
            productoKey = key;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnEditar_Click(object sender, RoutedEventArgs e)
        {
            Operaciones.WriteLogsDebug("EditarProducto", "btnEditar_Click", string.Format("{0} Info: {1}",
                      DateTime.Now.ToString(),
                      "Empezando a ejecutar el metodo de la capa de presentacion para editar un producto"));

            try
            {
                Producto.IdProducto = productoKey;
                Producto.NombreProducto = txtNombreProducto.Text;
                Producto.PrecioBase = byte.Parse(txtPrecioBase.Text);
                Producto.Variedad = txtVariedad.Text;
                
                if((cbxAreaProducto.SelectionBoxItem).ToString() == "Viveros")
                { Producto.AreaProducto = 0; }
                else
                { Producto.AreaProducto = 1; }

                ProductoBrl.Actualizar(Producto);
                this.Close();
            }
            catch (Exception ex)
            {
                Operaciones.WriteLogsRelease("EditarProducto", "btnEditar_Click", string.Format("{0} Error: {1}",
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

            Operaciones.WriteLogsDebug("EditarProducto", "btnEditar_Click", string.Format("{0} Info: {1}",
              DateTime.Now.ToString(),
              "Termino a ejecutar el metodo de la capa de presentacion para editar un producto"));
        }

        private void btnLimpiar_Click(object sender, RoutedEventArgs e)
        {
            Limpiar();
        }

        public void Limpiar()
        {
            txtNombreProducto.Clear();
            txtPrecioBase.Clear();
            txtVariedad.Clear();
            cbxAreaProducto.Text = "Viveros";
        }

        private void Cancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void StackPanel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        public void CargarProducto()
        {
            if (productoKey != 0)
            {
                Producto = ProductoBrl.Obtener(productoKey);
                txtNombreProducto.Text = Producto.NombreProducto;
                txtPrecioBase.Text = Producto.PrecioBase.ToString();
                txtVariedad.Text = Producto.Variedad;
                if(Producto.AreaProducto == 0)
                { cbxAreaProducto.Text = "Viveros"; }
                else
                { cbxAreaProducto.Text = "Comercializacion"; }
            }
        }

        private void StackPanel_Loaded(object sender, RoutedEventArgs e)
        {
            CargarProducto();
        }
    }
}
