using Ferale.SistemaDeInformacionApp.SIFComun;
using Ferale.SistemaDeInformacionApp.UsuarioBrl;
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
    /// Lógica de interacción para EliminarUsuario.xaml
    /// </summary>
    public partial class EliminarUsuario : Window
    {
        /// <summary>
        /// Identificador del usuario a eliminar
        /// </summary>
        public int IdUser { get; set; }

        /// <summary>
        /// Login del usuario a eliminar
        /// </summary>
        public string Login { get; set; }

        public EliminarUsuario(string nombre, int id)
        {
            InitializeComponent();
            IdUser = id;
            Login = nombre;
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void btnConfirmar_Click(object sender, RoutedEventArgs e)
        {
            Operaciones.WriteLogsDebug("EliminarUsuario", "btnEliminar_Click", string.Format("{0} Info: {1}",
            DateTime.Now.ToString(),
            "Empezando a ejecutar el metodo de la capa de presentacion para eliminar un usuario"));

            try
            {
                UsuariosBrl.Eliminar(IdUser);
                this.Close();
            }
            catch (Exception ex)
            {
                Operaciones.WriteLogsRelease("EliminarUsuario", "btnEliminar_Click", string.Format("{0} Error: {1}",
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

            Operaciones.WriteLogsDebug("EliminarUsuario", "btnEliminar_Click", string.Format("{0} Info: {1}",
              DateTime.Now.ToString(),
              "Termino a ejecutar el metodo de la capa de presentacion para eliminar un usuario"));
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_ContentRendered(object sender, EventArgs e)
        {
            lblMensaje.Content = string.Format("¿Desea eliminar el usuario: {0}?", Login);
        }
    }
}
