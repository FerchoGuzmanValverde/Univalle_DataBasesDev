using System.Windows;

namespace Univalle.Fie.Sistemas.BaseDeDatos2.HospitalApp.Wpf.Hospital
{
    /// <summary>
    /// Lógica de interacción para Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
            txtNombre.Focus();
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, RoutedEventArgs e)
        {
            if (EmpleadosBrl.UsuarioBrl.ValidarContrsena(txtNombre.Text, pwbContrasenia.Password))
            {
                //Asignar permisos
                this.Close();
            }
        }
    }
}
