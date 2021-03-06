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
using Sistema.Comun;
using Sistema.ClienteBrl;

namespace FernandoGuzman_Diagnostico2BD
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, RoutedEventArgs e)
        {
            Cliente cliente = ClienteBrl.Obtener(int.Parse(txtIdCliente.Text));

            lblNombreCliente.Content = cliente.NombreCliente;
            lblDireccion.Content = cliente.Direccion;
            lblCantidadCompras.Content = cliente.Compras.Count();

            int total = 0;
            foreach (var item in cliente.Compras)
            {
                total = total + item.TotalCompra;
            }

            lblMontoTotal.Content = total;
        }
    }
}
