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
    /// Lógica de interacción para Estudiantes_Operar.xaml
    /// </summary>
    public partial class Estudiantes_Operar : Window
    {
        DataRowView dr;
        Estudiante estudiante;
        EstudianteBRL brl;
        public Estudiantes_Operar(DataRowView dt)
        {
            InitializeComponent();
            dr = dt;
            Cargar();
        }

        void Cargar()
        {
            try
            {
                if (dr != null)
                {
                    int id = int.Parse(dr.Row.ItemArray[0].ToString());
                    brl = new EstudianteBRL();
                    estudiante = brl.GetFigura(id);
                    if (estudiante != null)
                    {
                        txtCarrera.Text = estudiante.Carrera;
                        txtCI.Text = estudiante.Persona.Ci.ToString();
                        txtNombre.Text = estudiante.Persona.Nombres.ToString();
                        txtApellido1.Text = estudiante.Persona.PrimerApellido.ToString();
                        txtApellido2.Text = estudiante.Persona.SegundoApellido.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                estudiante.IdEstudiante = int.Parse(dr.Row.ItemArray[0].ToString());
                estudiante.Carrera = txtCarrera.Text;
                /*estudiante.Persona = new Persona(int.Parse(txtBase.Text), int.Parse(txtAltura.Text));*/
                brl = new EstudianteBRL(estudiante);
                brl.Update();
                MessageBox.Show("El estudiante se ha modificado correctamente..", "MODIFICÓ UNA FIGURA", MessageBoxButton.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Cargar();
        }

        private void btnEiminar_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Esta segur@ de eliminar el registro?", "Eliminando Registro", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    brl = new EstudianteBRL(estudiante);
                    brl.HardDelete();
                    MessageBox.Show("Se ha eliminado el registro con éxito...!!", "Registro Eliminado", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            this.Close();
        }
    }
}
