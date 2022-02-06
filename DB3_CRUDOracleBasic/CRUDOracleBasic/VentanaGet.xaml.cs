using System;
using System.Collections.Generic;
using System.Data;
using System.Windows;
using Common;
using BRL;

namespace CRUDOracleBasic
{
    /// <summary>
    /// Lógica de interacción para VentanaGet.xaml
    /// </summary>
    public partial class VentanaGet : Window
    {
        DataRowView dr;
        Figura figura;
        FiguraBRL brl;
        public VentanaGet(DataRowView drv)
        {
            InitializeComponent();
            dr = drv;
            Cargar();
        }

        private void btnModificar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                figura.IdFigura = int.Parse(dr.Row.ItemArray[0].ToString());
                figura.Color = txtColor.Text;
                figura.Rectangulo = new Regtangulo(int.Parse(txtBase.Text), int.Parse(txtAltura.Text));
                brl = new FiguraBRL(figura);
                brl.Update();
                MessageBox.Show("La figura se ha modificado correctamente..", "MODIFICÓ UNA FIGURA", MessageBoxButton.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Cargar();
        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Esta segur@ de eliminar el registro?", "Eliminando Registro", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    brl = new FiguraBRL(figura);
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

        void Cargar()
        {
            try
            {
                if (dr != null)
                {
                    int id = int.Parse(dr.Row.ItemArray[0].ToString());
                    brl = new FiguraBRL();
                    figura = brl.GetFigura(id);
                    if (figura != null)
                    {
                        txtColor.Text = figura.Color;
                        txtBase.Text = figura.Rectangulo.Base.ToString();
                        txtAltura.Text = figura.Rectangulo.Altura.ToString();
                        lblArea.Content = figura.Rectangulo.Area.ToString();
                        lblPerimetro.Content = figura.Rectangulo.Perimetro.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
