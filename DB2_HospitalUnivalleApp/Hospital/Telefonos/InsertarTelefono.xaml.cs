using System;
using System.Windows.Controls;

namespace Univalle.Fie.Sistemas.BaseDeDatos2.HospitalApp.Wpf.Hospital.Telefonos
{
    /// <summary>
    /// Lógica de interacción para InsertarTelefono.xaml
    /// </summary>
    public partial class InsertarTelefono : UserControl
    {
        #region Propiedades

        public string Text
        {
            get { return txtNumero.Text; }
            set { txtNumero.Text = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public Guid IdTelefono { get; set; }

        #endregion

        #region Constructores
        
        public InsertarTelefono()
        {
            InitializeComponent();
        }

        #endregion

        #region Metodos

        /// <summary>
        /// Metodo para cargar tipo telefono de la logica de negocio
        /// </summary>
        public void CargarTipodTelefono()
        {
            cbxTipoTelefono.ItemsSource = EmpleadosBrl.TipoTelefonosListBrl.Get();
            cbxTipoTelefono.DisplayMemberPath = "Nombre";
            cbxTipoTelefono.SelectedValue = "IdTipoTelefono";
            cbxTipoTelefono.SelectedIndex = 0;
        }

        #endregion

        private void UserControl_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
           // CargarTipodTelefono();
        }

        private void cbxTipoTelefono_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            CargarTipodTelefono();
        }

    }
}
