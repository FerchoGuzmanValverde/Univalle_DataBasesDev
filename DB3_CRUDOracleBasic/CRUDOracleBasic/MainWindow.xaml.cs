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
using Common;
using BRL;
using System.Data;

namespace CRUDOracleBasic
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Figura figura;
        FiguraBRL brl;
        public MainWindow()
        {
            InitializeComponent();
            Load();
        }

        private void btnInsertar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                figura = new Figura(txtColor.Text, new Regtangulo(int.Parse(txtBase.Text), int.Parse(txtAltura.Text)));
                brl = new FiguraBRL(figura);
                brl.Insertar();
                Load();
                MessageBox.Show("Figura Insertada Correctamente...");
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
                brl = new FiguraBRL();
                dgvDatos.ItemsSource = null;
                dgvDatos.ItemsSource = brl.SelectAll().DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvDatos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                if (dgvDatos.Items.Count > 0 && dgvDatos.SelectedItem != null)
                {
                    DataRowView dataRow = (DataRowView)dgvDatos.SelectedItem;

                    VentanaGet mostrar = new VentanaGet(dataRow);
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
