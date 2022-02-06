using Ferale.SistemaDeInformacionApp.SIFComun;
using Ferale.SistemaDeInformacionApp.UsuarioBrl;
using System.Windows;
using System.Windows.Controls;

namespace SIF_Ferale.Usuarios
{
    /// <summary>
    /// Lógica de interacción para NavegadorUsuarios.xaml
    /// </summary>
    public partial class NavegadorUsuarios : UserControl
    {
        public NavegadorUsuarios()
        {
            InitializeComponent();
        }

        private void btnBuscarUsuario_Click(object sender, RoutedEventArgs e)
        {
            RefrescarUsuarios();
        }

        public void RefrescarUsuarios()
        {
            string usuario = txtNombreUsuario.Text;
            lstListaUsuarios.ItemsSource = UsuarioKeyValueListBrl.Obtener(usuario);
            lstListaUsuarios.DisplayMemberPath = "Login";
            lstListaUsuarios.SelectedValuePath = "IdUsuario";
        }

        private void btnCrearUsuario_Click(object sender, RoutedEventArgs e)
        {
            Usuarios.InsertarUsuario nuevoCrear = new Usuarios.InsertarUsuario();
            nuevoCrear.ShowDialog();
            RefrescarUsuarios();
        }

        private void btnEditarUsuario_Click(object sender, RoutedEventArgs e)
        {
            if (lstListaUsuarios.SelectedValue != null)
            {
                Usuarios.EditarUsuario form = new Usuarios.EditarUsuario((int)lstListaUsuarios.SelectedValue);
                form.ShowDialog();
                RefrescarUsuarios();
            }
        }

        private void btnVerUsuario_Click(object sender, RoutedEventArgs e)
        {
            if (lstListaUsuarios.SelectedValue != null)
            {
                Usuarios.VerUsuario form = new Usuarios.VerUsuario((int)lstListaUsuarios.SelectedValue);
                form.ShowDialog();
            }
        }

        private void btnEliminarUsuario_Click(object sender, RoutedEventArgs e)
        {
            if (lstListaUsuarios.SelectedValue != null)
            {
                Usuarios.EliminarUsuario form = new Usuarios.EliminarUsuario(((UsuarioKeyValue)lstListaUsuarios.SelectedItem).Login, (int)lstListaUsuarios.SelectedValue);
                form.ShowDialog();
                RefrescarUsuarios();
            }
        }
    }
}
