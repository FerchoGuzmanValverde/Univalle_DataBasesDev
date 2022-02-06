using System.Windows;
using Univalle.Fie.Sistemas.BaseDeDatos2.HospitalApp.Wpf.Hospital.Empleados;
using Univalle.Fie.Sistemas.BaseDeDatos2.HospitalApp.Wpf.Hospital.Empleados.Reportes;

namespace Univalle.Fie.Sistemas.BaseDeDatos2.HospitalApp.Wpf.Hospital
{
    /// <summary>
    /// Lógica de interacción para Principal.xaml
    /// </summary>
    public partial class Principal : Window
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void wpfPrincipal_Loaded(object sender, RoutedEventArgs e)
        {
            Login modalWindow = new Login();
            modalWindow.Owner = this;
            modalWindow.ShowDialog();
        }

        private void mnuEmpleadosMostrar_Click(object sender, RoutedEventArgs e)
        {
            NavegadorEmpleado form = new NavegadorEmpleado();
            form.Owner = this;
            form.ShowDialog();
        }

        private void mnuUsuariosLogin_Click(object sender, RoutedEventArgs e)
        {
            Login form = new Login();
            form.Owner = this;
            form.ShowDialog();
        }

        private void mnuReportesEmpelados_Click(object sender, RoutedEventArgs e)
        {
            VerReporte verReporte = new VerReporte();
            verReporte.ShowDialog();
        }
    }
}
