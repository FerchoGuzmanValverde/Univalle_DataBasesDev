using Ferale.SistemaDeInformacionApp.SIFComun;
using System;
using System.Windows;
using System.Windows.Input;
using Ferale.SistemaDeInformacionApp.UsuarioBrl;

namespace SIF_Ferale.Usuarios
{
    /// <summary>
    /// Lógica de interacción para EditarUsuario.xaml
    /// </summary>
    public partial class EditarUsuario : Window
    {
        public Usuario Usuario { get; set; }
        int usuarioKey = 0;

        public EditarUsuario(int key)
        {
            InitializeComponent();
            DataContext = this;
            usuarioKey = key;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnEditar_Click(object sender, RoutedEventArgs e)
        {
            Operaciones.WriteLogsDebug("EditarUsuario", "btnEditar_Click", string.Format("{0} Info: {1}",
                      DateTime.Now.ToString(),
                      "Empezando a ejecutar el metodo de la capa de presentacion para editar un usuario"));

            try
            {
                Usuario.IdUsuario = usuarioKey;
                Usuario.LoginUsuario = txtLogin.Text;
                Usuario.PasswordUsuario = txtPassword.Text;

                UsuariosBrl.Actualizar(Usuario);
                this.Close();
            }
            catch (Exception ex)
            {
                Operaciones.WriteLogsRelease("EditarUsuario", "btnEditar_Click", string.Format("{0} Error: {1}",
                    DateTime.Now.ToString(), ex.Message));
                MessageBoxResult result = MessageBox.Show("Existe un problema, por favor contactese con su administrador",
                                          "Confirmation",
                                          MessageBoxButton.OK,
                                          MessageBoxImage.Error);
                if (result == MessageBoxResult.OK)
                {
                    Application.Current.Shutdown();
                }
            }

            Operaciones.WriteLogsDebug("EditarUsuario", "btnEditar_Click", string.Format("{0} Info: {1}",
              DateTime.Now.ToString(),
              "Termino a ejecutar el metodo de la capa de presentacion para editar un usuario"));
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
