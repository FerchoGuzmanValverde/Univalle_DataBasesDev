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
using DAL;
using Common;


namespace DB4ObjectsCRUDS
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Persona p;
        PersonaDAL dalPersona;
        List<Persona> people;
        public MainWindow()
        {
            InitializeComponent();
        }

        void LoadDataGrid()
        {
            try
            {
                dalPersona = new PersonaDAL();
                people = dalPersona.SelectAll();
                dgvDatos.ItemsSource = null;
                dgvDatos.ItemsSource = people;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnCrear_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Config.CreateDBOO();
                MessageBox.Show("BDOO creada con éxito.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnInsertar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                p = new Persona(txtCi.Text, txtNombres.Text, txtApellidos.Text, dtpFechaNacimiento.SelectedDate.Value);
                dalPersona = new PersonaDAL(p);
                dalPersona.Insert();
                LoadDataGrid();
                MessageBox.Show("Persona creada con éxito.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoadDataGrid();
        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            p = new Persona(txtCi.Text);
            dalPersona = new PersonaDAL(p);
            Persona buscar = dalPersona.GetPeopleByCi(p.Ci);
            if(buscar!=null)
            {
                dalPersona.Delete();
                LoadDataGrid();
                MessageBox.Show("Persona eliminada con éxito.");
            }
            else
            {
                MessageBox.Show("El C.I. ingresado no existe en la base de datos.");
            }
        }
    }
}
