using Ferale.SistemaDeInformacionApp.ProductosBrl;
using Ferale.SistemaDeInformacionApp.SIFComun;
using System.Windows;
using System.Windows.Input;

namespace SIF_Ferale.Productos
{
    /// <summary>
    /// Lógica de interacción para InsertarProducto.xaml
    /// </summary>
    public partial class InsertarProducto : Window
    {
        public InsertarProducto()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void StackPanel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void btnCrear_Click(object sender, RoutedEventArgs e)
        {
            Producto producto = new Producto();

            producto.NombreProducto = txtNombreProducto.Text;
            producto.PrecioBase = byte.Parse(txtPrecioBase.Text);
            producto.Variedad = txtVariedad.Text;
            if((cbxAreaProducto.SelectionBoxItem).ToString() == "Viveros")
            { producto.AreaProducto = 0; }
            else
            { producto.AreaProducto = 1; }

            ProductoBrl.Insertar(producto);

            Productos.VentanaMensaje form = new Productos.VentanaMensaje(producto.NombreProducto);
            form.ShowDialog();
            Limpiar();
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
    }
}
