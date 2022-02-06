using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
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

namespace FernandoGuzman_DoraSolares_Sesion8
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void CopyDataToTextFile(string fleName)
        {
            try
            {
                // Cambia el string de conexión
                // para coincidir con su sustema.
                string connectionString = @"Data Source=.;Initial Catalog=NORTHWND;Integrated Security=True";
                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand command = connection.CreateCommand();

                command.CommandText = "SELECT P.ProductID, P.ProductName,S.CompanyName, C.CategoryName, P.QuantityPerUnit, P.UnitPrice, P.UnitsInStock, P.UnitsOnOrder FROM Products P INNER JOIN Suppliers S ON S.SupplierID = P.SupplierID INNER JOIN Categories C ON C.CategoryID = P.CategoryID WHERE P.Discontinued = 1";
                using (connection)
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    using (StreamWriter sw = new StreamWriter(fleName))
                    {
                        while (reader.Read())
                        {
                            string customerRow = String.Format("{0}| {1}| {2}| {3}| {4}| {5}| {6}| {7}", reader.GetValue(0), reader.GetValue(1), reader.GetValue(2), reader.GetValue(3), reader.GetValue(4), reader.GetValue(5), reader.GetValue(6), reader.GetValue(7));
                            sw.WriteLine(customerRow);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void DisplayTextFile(string fleName)
        {
            try
            {
                using (StreamReader sr =new StreamReader(fleName))
                {
                    string line;


                    while ((line = sr.ReadLine()) != null)
                    {
                        lstmostrar.Items.Add(line);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnHacer_Click(object sender, RoutedEventArgs e)
        {
            string myDocumentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            CopyDataToTextFile(myDocumentsPath + @"\ListaDeProductos.txt");
            DisplayTextFile(myDocumentsPath + @"\ListaDeProductos.txt");
        }
    }
}
