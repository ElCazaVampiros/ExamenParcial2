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

namespace examen2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnContinuar_Click(object sender, RoutedEventArgs e)
        {
            if (infop.Visibility == Visibility.Visible)
            {
                if (infop.txtNombre.Text == "" ||
                    infop.txtApellidoPaterno.Text == "" ||
                    infop.txtApellidoMaterno.Text == "" ||
                    infop.txtEdad.Text == "")
                {
                    txtAlertaLlenarCampos.Visibility = Visibility.Visible;
                }
                else
                {
                    txtAlertaLlenarCampos.Visibility = Visibility.Collapsed;
                    infop.Visibility = Visibility.Collapsed;
                    contacto.Visibility = Visibility.Visible;
                }
            }

            else if (contacto.Visibility == Visibility.Visible)
            {
                if (contacto.txtCorreo.Text == "" ||
                    contacto.txtTelefono.Text == "" ||
                    contacto.txtCelular.Text == "")
                {
                    txtAlertaLlenarCampos.Visibility = Visibility.Visible;
                }
                else
                {
                    txtAlertaLlenarCampos.Visibility = Visibility.Collapsed;
                    contacto.Visibility = Visibility.Collapsed;
                    pago.Visibility = Visibility.Visible;
                }
            }

            else if (pago.Visibility == Visibility.Visible)
            {
                var digitosTarjeta = pago.txtNumeroTarjeta.Text.ToString();
                if (digitosTarjeta.Length != 16)
                {
                    txtAlertaDigitosTarjeta.Visibility = Visibility.Visible;
                }
                else
                {
                    txtAlertaDigitosTarjeta.Visibility = Visibility.Collapsed;
                }
            }
        }
    }
}
