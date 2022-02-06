using Common;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GuzmanValverdeFernando02092019
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Lectura l;
        LecturasDAL dalLecturas;
        List<Lectura> lectures;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, RoutedEventArgs e)
        {
            Insertar nuevo = new Insertar();
            nuevo.ShowDialog();
            LoadDataGrid();
        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            l = new Lectura(txtEliminar.Text);
            dalLecturas = new LecturasDAL(l);
            Lectura buscar = dalLecturas.GetLectureByName(l.NombreLectura);
            if (buscar != null)
            {
                dalLecturas.Delete();
                LoadDataGrid();
                MessageBox.Show("Lectura Eliminada con éxito...!!");
            }
            else
            {
                MessageBox.Show("No existe la lectura con el nombre ingresado");
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                Config.CreateDBOO();
                LoadDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void LoadDataGrid()
        {
            try
            {
                dalLecturas = new LecturasDAL();
                lectures = dalLecturas.SelectAll();
                dgvLectures.ItemsSource = null;
                dgvLectures.ItemsSource = lectures;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
