using Ferale.SistemaDeInformacionApp.ProductosBrl;
using Ferale.SistemaDeInformacionApp.SIFComun;
using System.Windows;
using System.Windows.Input;

namespace SIF_Ferale.Productos
{
    /// <summary>
    /// Lógica de interacción para VerProducto.xaml
    /// </summary>
    public partial class VerProducto : Window
    {
        public Producto Producto { get; set; }
        int productoKey = 0;

        public VerProducto(int key)
        {
            InitializeComponent();
            DataContext = this;
            productoKey = key;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void StackPanel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        public void CargarProducto()
        {
            if (productoKey != 0)
            {
                Producto = ProductoBrl.Obtener(productoKey);
                txtNombreProducto.Text = Producto.NombreProducto;
                txtPrecioBase.Text = Producto.PrecioBase.ToString();
                txtVariedad.Text = Producto.Variedad;
                if (Producto.AreaProducto == 0)
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
