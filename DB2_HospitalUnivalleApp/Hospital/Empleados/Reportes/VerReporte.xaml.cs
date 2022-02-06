using System.Windows;
using Univalle.Fie.Sistemas.BaseDeDatos2.HospitalApp.EmpleadosBrl;
using Univalle.Fie.Sistemas.BaseDeDatos2.HospitalApp.EmpleadosDal;

namespace Univalle.Fie.Sistemas.BaseDeDatos2.HospitalApp.Wpf.Hospital.Empleados.Reportes
{
    /// <summary>
    /// Interaction logic for VerReporte.xaml
    /// </summary>
    public partial class VerReporte : Window
    {
        public VerReporte()
        {
            InitializeComponent();
        }
        private void crystalReportsViewerEmpleados_Loaded(object sender, RoutedEventArgs e)
        {
            EmpleadosListaReporte reporte = new EmpleadosListaReporte();
            HospitalDataSet dataset = EmpleadoListBrl.ObtenerListaEmpleadosReporte();
            reporte.Load("../../Empleados/Reportes/EmpleadosListaReporte.rpt");
            reporte.SetDataSource(dataset);
            crystalReportsViewerEmpleados.ViewerCore.ReportSource = reporte;

        }
    }
}