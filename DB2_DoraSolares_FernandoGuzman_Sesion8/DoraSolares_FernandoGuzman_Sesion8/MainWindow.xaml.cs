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

namespace DoraSolares_FernandoGuzman_Sesion8
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            using (XmlReader reader = XmlReader.Create("Customers.xml"))
            {
                while (reader.Read())
                {
                    if (reader.IsStartElement())
                    {
                        switch (reader.Name)
                        {
                            case "CompanyName":
                                if (reader.Read())
                                {
                                    Console.Write("Company Name: {0}, ", reader.Value);
                                }
                                break;
                            case "Phone":
                                if (reader.Read())
                                {
                                    Console.WriteLine("Phone: {0}", reader.Value);
                                }
                                break;
                        }
                    }
                }

            }
        }

        
    }
}