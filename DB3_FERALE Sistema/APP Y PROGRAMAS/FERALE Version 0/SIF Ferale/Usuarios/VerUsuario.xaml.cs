using Ferale.SistemaDeInformacionApp.SIFComun;
using Ferale.SistemaDeInformacionApp.UsuarioBrl;
using System;
using System.Windows;
using System.Windows.Input;

namespace SIF_Ferale.Usuarios
{
    /// <summary>
    /// Lógica de interacción para VerUsuario.xaml
    /// </summary>
    public partial class VerUsuario : Window
    {
        public Usuario Usuario { get; set; }
        int usuarioKey = 0;

        public VerUsuario(int key)
        {
            InitializeComponent();
            DataContext = this;
            usuarioKey = key;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Cancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void StackPanel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        public void CargarUsuario()
        {
            if (usuarioKey != 0)
            {
                Usuario = UsuariosBrl.Obtener(usuarioKey);
                txtLogin.Text = Usuario.LoginUsuario;
                txtPassword.Text = Usuario.PasswordUsuario;
            }
        }

        private void StackPanel_Loaded(object sender, RoutedEventArgs e)
        {
            CargarUsuario();
        }
    }
}
