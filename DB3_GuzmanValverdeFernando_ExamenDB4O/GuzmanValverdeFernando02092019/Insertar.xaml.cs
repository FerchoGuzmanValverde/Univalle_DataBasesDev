using Common;
using DAL;
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
    /// Lógica de interacción para Insertar.xaml
    /// </summary>
    public partial class Insertar : Window
    {
        DateTime inicio;
        DateTime fin;
        List<Registro> registros = new List<Registro>();
        Lectura l;
        LecturasDAL dalLecturas;
        List<Lectura> lectures;
        public Insertar()
        {
            InitializeComponent();
            gbRegistros.IsEnabled = false;
        }

        private void btnIniciar_Click(object sender, RoutedEventArgs e)
        {
            inicio = DateTime.Now;
            gbRegistros.IsEnabled = true;
            btnIniciar.IsEnabled = false;
        }

        private void btnDetener_Click(object sender, RoutedEventArgs e)
        {
            fin = DateTime.Now;
            gbRegistros.IsEnabled = false;
            btnDetener.IsEnabled = false;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                l = new Lectura(inicio, fin, txtNombreLectura.Text, txtMotivoLectura.Text, txtResponsableLectura.Text, registros);
                dalLecturas = new LecturasDAL(l);
                dalLecturas.Insert();
                MessageBox.Show("Lectura Creada con éxito...");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRegistro_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Registro nuevo = new Registro();
                nuevo.Humedad = double.Parse(txtHumedad.Text);
                nuevo.PresionAire = double.Parse(txtPresion.Text);
                nuevo.Temperatura = double.Parse(txtTemperatura.Text);
                registros.Add(nuevo);
                MessageBox.Show("Registro agregado con éxito");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
