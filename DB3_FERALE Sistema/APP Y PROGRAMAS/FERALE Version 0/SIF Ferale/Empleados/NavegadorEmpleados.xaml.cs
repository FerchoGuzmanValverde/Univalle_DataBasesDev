using System.Windows;
using System.Windows.Controls;
using Ferale.SistemaDeInformacionApp.EmpleadoBrl;
using Ferale.SistemaDeInformacionApp.SIFComun;

namespace SIF_Ferale.Empleados
{
    /// <summary>
    /// Lógica de interacción para NavegadorClientes.xaml
    /// </summary>
    public partial class NavegadorEmpleados : UserControl
    {
        public NavegadorEmpleados()
        {
            InitializeComponent();
        }

        private void btnBuscarEmpleado_Click(object sender, RoutedEventArgs e)
        {
            RefrescarEmpleados();
        }

        public void RefrescarEmpleados()
        {
            byte sexo; byte cargo = 1;
            string nombre = txtNombreEmpleado.Text;
            string apellido = txtApellidoEmpleado.Text;
            string crg = (cbxCargo.SelectionBoxItem).ToString();
            if(crg == "Administrador")
            { cargo = 1; }
            else
            { cargo = 2; }
            if(rbtMasculino.IsChecked == true)
            { sexo = 0; }
            else
            { sexo = 1; }
            lstListaEmpleados.ItemsSource = EmpleadoKeyValueListBrl.Obtener(nombre, apellido, cargo, sexo);
            lstListaEmpleados.DisplayMemberPath = "NombreCompleto";
            lstListaEmpleados.SelectedValuePath = "IdPersona";
        }

        private void btnCrearEmpleado_Click(object sender, RoutedEventArgs e)
        {
            Empleados.InsertarEmpleado nuevoCrear = new Empleados.InsertarEmpleado();
            nuevoCrear.ShowDialog();
            RefrescarEmpleados();
        }

        private void btnEditarEmpleado_Click(object sender, RoutedEventArgs e)
        {
            if (lstListaEmpleados.SelectedValue != null)
            {
                Empleados.EditarEmpleado form = new Empleados.EditarEmpleado((int)lstListaEmpleados.SelectedValue);
                form.ShowDialog();
                RefrescarEmpleados();
            }
        }

        private void btnVerEmpleado_Click(object sender, RoutedEventArgs e)
        {
            if (lstListaEmpleados.SelectedValue != null)
            {
                Empleados.VerEmpleado form = new Empleados.VerEmpleado((int)lstListaEmpleados.SelectedValue);
                form.ShowDialog();
            }
        }

        private void btnEliminarEmpleado_Click(object sender, RoutedEventArgs e)
        {
            if (lstListaEmpleados.SelectedValue != null)
            {
                Empleados.EliminarEmpleado form = new Empleados.EliminarEmpleado(((EmpleadoKeyValue)lstListaEmpleados.SelectedItem).NombreCompleto, (int)lstListaEmpleados.SelectedValue);
                form.ShowDialog();
                RefrescarEmpleados();
            }
        }
    }
}
