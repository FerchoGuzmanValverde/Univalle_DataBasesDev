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

namespace DBOObjetsCrud
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Persona p;
        PersonaDAL dalPersona;
        List<Persona> people;
        List<string> reporte;

        public MainWindow()
        {
            InitializeComponent();
        }


        void FillListBox()
        {
            lbxReportes.Items.Clear();
            foreach (string item in reporte)
            {
                lbxReportes.Items.Add(item);
            }
        }

        void LoaddataGrid()
        {
            try
            {
                dalPersona = new PersonaDAL();
                people = dalPersona.SelectAll();
                dvgDatos.ItemsSource = null;
                dvgDatos.ItemsSource = people;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void BtnCrear_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                Config.CreateDBOO();
                MessageBox.Show("BDOO creada con exito....:");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                p = new Persona(txtci.Text,txtnombres.Text,txtapellidos.Text,txtfechanacimiento.SelectedDate.Value);
                dalPersona = new PersonaDAL(p);
                dalPersona.Insert();
                LoaddataGrid();
                MessageBox.Show("Persona Creada con exito...");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dataGrid_Loaded(object sender, RoutedEventArgs e)
        {
            LoaddataGrid();
        }

        private void BtnEliminar_Click(object sender, RoutedEventArgs e)
        {
            p = new Persona(txtci.Text);
            dalPersona = new PersonaDAL(p);
            try
            {
                Persona buscar = dalPersona.GetPeopleByCi(p.Ci);
                if (buscar != null)
                {
                    dalPersona.Delete();
                    LoaddataGrid();
                    MessageBox.Show("Persona Eliminada con exito...:");
                }
                else
                {
                    MessageBox.Show("El Ci ingresado NO existe en la BDOO");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnModificar_Click(object sender, RoutedEventArgs e)
        {
            p = new Persona(txtci.Text);
            dalPersona = new PersonaDAL(p);
            try
            {
                Persona buscar = dalPersona.GetPeopleByCi(p.Ci);
                if (buscar != null)
                {
                    Persona update = new Persona(txtnombres.Text,txtapellidos.Text,txtfechanacimiento.SelectedDate.Value);
                    dalPersona.Update(update);
                    LoaddataGrid();
                    MessageBox.Show("Persona Modicada con exito...:");
                }
                else
                {
                    MessageBox.Show("El Ci ingresado NO existe en la BDOO");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void BtnMostrarTodo_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                dalPersona = new PersonaDAL();
                reporte = dalPersona.Select();
                FillListBox();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                dalPersona = new PersonaDAL();
                reporte = dalPersona.Iniciales(txtinicial.Text);
                FillListBox();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                dalPersona = new PersonaDAL();
                reporte = dalPersona.Grupos(txtinicial.Text);
                FillListBox();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
