using BRL;
using Common;
using System;
using System.Collections.Generic;
using System.Data;
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

namespace Guzman_Valverde_Fernando
{
    /// <summary>
    /// Lógica de interacción para Estudiantes.xaml
    /// </summary>
    public partial class Estudiantes : Window
    {
        Estudiante estudiante;
        EstudianteBRL brl;
        public Estudiantes()
        {
            InitializeComponent();
            Load();
        }

        private void btnInsertar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                estudiante = new Estudiante(txtCarrera.Text, new Persona(txtCi.Text, txtNombres.Text, txtApellido1.Text, txtApellido2.Text, DateTime.Parse(dateFechaNacimiento.SelectedDate.ToString())));
                brl = new EstudianteBRL(estudiante);
                brl.Insertar();
                Load();
                MessageBox.Show("Estudiante Insertado Correctamente...");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void Load()
        {
            try
            {
                brl = new EstudianteBRL();
                dgvDatos.ItemsSource = null;
                dgvDatos.ItemsSource = brl.SelectAll().DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvDatos_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            try
            {
                if (dgvDatos.Items.Count > 0 && dgvDatos.SelectedItem != null)
                {
                    DataRowView dataRow = (DataRowView)dgvDatos.SelectedItem;

                    Estudiantes_Operar mostrar = new Estudiantes_Operar(dataRow);
                    mostrar.ShowDialog();
                    Load();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
