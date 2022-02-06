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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Guzman_Valverde_Fernando
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnEstudiantes_Click(object sender, RoutedEventArgs e)
        {
            Estudiantes nuevo = new Estudiantes();
            nuevo.ShowDialog();
        }

        private void btnEpleados_Click(object sender, RoutedEventArgs e)
        {
            Empleados nuevo = new Empleados();
            nuevo.ShowDialog();
        }
    }
}
