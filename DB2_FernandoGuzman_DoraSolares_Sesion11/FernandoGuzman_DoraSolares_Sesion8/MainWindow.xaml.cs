using System;
using System.Configuration;
using System.IO;
using System.Windows;
using System.Data.OleDb;

namespace FernandoGuzman_DoraSolares_Sesion11
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
                
                string connectionString = ConfigurationManager.ConnectionStrings["CadenaConexion"].ConnectionString;
                OleDbConnection connection = new OleDbConnection(connectionString);
                OleDbCommand command = connection.CreateCommand();

                command.CommandText = @"SELECT P.ProductID, P.ProductName, P.UnitPrice, P.UnitsInStock, P.UnitsOnOrder 
                                        FROM Products P 
                                        WHERE P.Discontinued = 0";
                using (connection)
                {
                    connection.Open();
                    OleDbDataReader reader = command.ExecuteReader();
                    using (StreamWriter sw = new StreamWriter(fleName))
                    {
                        while (reader.Read())
                        {
                            string customerRow = @String.Format("{0}| {1}| {2}| {3}| {4}", 
                                reader.GetValue(0), 
                                reader.GetValue(1), 
                                reader.GetValue(2), 
                                reader.GetValue(3), 
                                reader.GetValue(4));
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
