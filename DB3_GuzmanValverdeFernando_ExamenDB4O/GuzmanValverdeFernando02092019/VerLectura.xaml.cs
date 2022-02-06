using Common;
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

namespace GuzmanValverdeFernando02092019
{
    /// <summary>
    /// Lógica de interacción para VerLectura.xaml
    /// </summary>
    public partial class VerLectura : Window
    {
        Lectura recibido;
        List<Registro> registros;
        public VerLectura(Lectura lecture)
        {
            InitializeComponent();
            recibido = new Lectura();
            recibido = lecture;
            registros = recibido.Registros;
            Cargar();
        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {

            this.Close();
        }

        void Cargar()
        {
            lblNombre.Content = recibido.NombreLectura;
            lblMotivo.Content = recibido.MotivoLectura;
            lblResponsable.Content = recibido.NombreResponsable;
            lblInicio.Content = recibido.InicioLectura;
            lblFin.Content = recibido.FinLectura;

            dgvRegistros.ItemsSource = null;
            dgvRegistros.ItemsSource = registros;
        }
    }
}
