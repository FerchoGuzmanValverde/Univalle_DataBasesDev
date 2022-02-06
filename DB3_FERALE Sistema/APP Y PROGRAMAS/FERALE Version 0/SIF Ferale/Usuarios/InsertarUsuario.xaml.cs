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

namespace SIF_Ferale.Usuarios
{
    /// <summary>
    /// Lógica de interacción para InsertarUsuario.xaml
    /// </summary>
    public partial class InsertarUsuario : Window
    {
        public InsertarUsuario()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnCrear_Click(object sender, RoutedEventArgs e)
        {
            Usuario usuario = new Usuario();

            usuario.LoginUsuario = txtLogin.Text;
            usuario.PasswordUsuario = txtPassword.Text;

            Ferale.SistemaDeInformacionApp.UsuarioBrl.UsuariosBrl.Insertar(usuario);

            Usuarios.VentanaMensaje form = new Usuarios.VentanaMensaje();
            form.ShowDialog();
            Limpiar();
        }

        private void btnLimpiar_Click(object sender, RoutedEventArgs e)
        {
            Limpiar();
        }

        public void Limpiar()
        {
            txtLogin.Clear();
            txtPassword.Clear();
        }

        private void Cancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void StackPanel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
    }
}
