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

namespace SIF_Ferale.Inicios
{
    /// <summary>
    /// Lógica de interacción para InicioAdministrador.xaml
    /// </summary>
    public partial class InicioAdministrador : Window
    {
        public InicioAdministrador()
        {
            InitializeComponent();
        }

        private void ButtonFechar_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void ListViewMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int index = ListViewMenu.SelectedIndex;
            MoveCursorMenu(index);

            switch (index)
            {
                case 1:
                    GridPrincipal.Children.Clear();
                    GridPrincipal.Children.Add(new Empleados.NavegadorEmpleados());
                    break;
                case 2:
                    GridPrincipal.Children.Clear();
                    GridPrincipal.Children.Add(new Clientes.NvegadorClientes());
                    break;
                case 3:
                    GridPrincipal.Children.Clear();
                    GridPrincipal.Children.Add(new Usuarios.NavegadorUsuarios());
                    break;
                case 4:
                    GridPrincipal.Children.Clear();
                    GridPrincipal.Children.Add(new Ventas.NavegadorVentas());
                    break;
                case 5:
                    GridPrincipal.Children.Clear();
                    GridPrincipal.Children.Add(new Productos.NavegadorProductos());
                    break;
                default:
                    break;
            }
        }

        private void MoveCursorMenu(int index)
        {
            /*TrainsitionigContentSlide.OnApplyTemplate();
            GridCursor.Margin = new Thickness(0, (100 + (60 * index)), 0, 0);*/
        }

        private void btnhide_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
