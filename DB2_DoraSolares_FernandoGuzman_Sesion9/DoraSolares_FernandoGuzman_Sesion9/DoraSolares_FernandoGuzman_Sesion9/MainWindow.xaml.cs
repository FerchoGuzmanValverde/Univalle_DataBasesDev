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
using System.Xml;

namespace DoraSolares_FernandoGuzman_Sesion9
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            using (XmlReader reader = XmlReader.Create("Productos.xml"))
            {
                while (reader.Read())
                {
                    if (reader.IsStartElement())
                    {
                        switch (reader.Name)
                        {
                            case "nombre":
                                if (reader.Read())
                                {
                                    lstproductos.Items.Add("Nombre Producto: " + reader.Value);
                                }
                                break;
                            case "descripcion":
                                if (reader.Read())
                                {
                                    lstproductos.Items.Add("Descripcion:" + reader.Value);
                                }
                                break;
                            case "moneda":
                                if (reader.Read())
                                {
                                    lstproductos.Items.Add("Moneda: " + reader.Value);
                                }
                                break;
                            case "valor":
                                if (reader.Read())
                                {
                                    lstproductos.Items.Add("Valor: " + reader.Value + "\n");
                                }
                                break;
                        }
                    }
                }

            }
        }
    }
}
