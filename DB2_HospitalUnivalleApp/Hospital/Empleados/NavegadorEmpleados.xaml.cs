using System;
using System.Windows;
using Univalle.Fie.Sistemas.BaseDeDatos2.HospitalApp.Comun;

namespace Univalle.Fie.Sistemas.BaseDeDatos2.HospitalApp.Wpf.Hospital.Empleados
{
    /// <summary>
    /// Lógica de interacción para NavegadorEmpleado.xaml
    /// </summary>
    public partial class NavegadorEmpleado : Window
    {
        public NavegadorEmpleado()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, RoutedEventArgs e)
        {
            RefrescarEmpleados();
        }

        public void RefrescarEmpleados()
        {
            lbxEmpleados.ItemsSource = EmpleadosBrl.EmpleadoKeyValueListBrl.Obtener(txtApellido.Text.ToString());
            lbxEmpleados.DisplayMemberPath = "NombreCompleto";
            lbxEmpleados.SelectedValuePath = "IdPersona";
        }


        private void btnCrear_Click(object sender, RoutedEventArgs e)
        {
            InsertarEmpleado form = new InsertarEmpleado();
            form.Owner = this;
            form.ShowDialog();
        }

        private void btnEditar_Click(object sender, RoutedEventArgs e)
        {
            if (lbxEmpleados.SelectedValue != null)
            {
                EditarEmpleado form = new EditarEmpleado();
                form.Owner = this;
                form.ShowDialog();
            }
            
        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            if (lbxEmpleados.SelectedValue != null)
            {
                EliminarEmpleado form = new EliminarEmpleado();
                form.IdEmpleado = (Guid)lbxEmpleados.SelectedValue;
                form.NombreCompleto = ((EmpleadoKeyValue)lbxEmpleados.SelectedItem).NombreCompleto;
                form.Owner = this;
                form.ShowDialog();
            }

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
