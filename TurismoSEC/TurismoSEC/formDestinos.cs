using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TurismoSEC
{
    public partial class formDestinos : Form
    {

        int precioHotel = 0;
        int cantidadPersonas = 0;

        public formDestinos()
        {
            InitializeComponent();
        }

        private void formDestinos_Load(object sender, EventArgs e)
        {
            cargarComboDestinos();
            cargarComboPersonas();
            cargarComboMediosDePago();
        }

        private void cargarComboDestinos()
        {
            cmbDestinos.Items.Add("Mar del Plata");
            cmbDestinos.Items.Add("San Clemente");
            cmbDestinos.Items.Add("La Falda");
            cmbDestinos.Items.Add("Villa Carlos Paz");
            cmbDestinos.Items.Add("Ezeiza");
            cmbDestinos.Items.Add("Entre Ríos");
            cmbDestinos.Items.Add("Capital Federal");
            cmbDestinos.SelectedIndex = 0;
        }

        private void cargarComboPersonas()
        {
            cmbCantidadPersonas.Items.Add("1");
            cmbCantidadPersonas.Items.Add("2");
            cmbCantidadPersonas.Items.Add("3");
            cmbCantidadPersonas.Items.Add("4");
            cmbCantidadPersonas.Items.Add("5");
            cmbCantidadPersonas.SelectedIndex = 0;
        }

        private void cargarComboMediosDePago()
        {
            cmbMediosDePago.Items.Add("Electron / Maestro");
            cmbMediosDePago.Items.Add("VISA");
            cmbMediosDePago.Items.Add("Master Card");
            cmbMediosDePago.Items.Add("American Express");
            cmbMediosDePago.Items.Add("Créditos internos SEC");
            cmbMediosDePago.Items.Add("Efectivo - Pesos");
            cmbMediosDePago.Items.Add("Efectivo - Dólares");
            cmbMediosDePago.SelectedIndex = 0;
        }

        private void cmbDestinos_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbDestinos.SelectedIndex)
            {
                case 0: //Mar del Plata
                    cmbHotel.Items.Clear();
                    cmbHotel.Enabled = true;
                    cmbCantidadPersonas.Enabled = true;
                    cmbHotel.Items.Add("Riviera Hotel");
                    cmbHotel.Items.Add("Cadi Palace Hotel");
                    cmbHotel.SelectedIndex = 0;
                    break;
                case 1: //San Clemente
                    cmbHotel.Items.Clear();
                    cmbHotel.Enabled = true;
                    cmbCantidadPersonas.Enabled = true;
                    cmbHotel.Items.Add("Hotel Savoia");
                    cmbHotel.SelectedIndex = 0;
                    break;
                case 2: //La Falda
                    cmbHotel.Items.Clear();
                    cmbHotel.Enabled = true;
                    cmbCantidadPersonas.Enabled = true;
                    cmbHotel.Items.Add("Hotel España");
                    cmbHotel.SelectedIndex = 0;
                    break;
                case 3: //Villa Carlos Paz
                    cmbHotel.Items.Clear();
                    cmbHotel.Enabled = true;
                    cmbCantidadPersonas.Enabled = true;
                    cmbHotel.Items.Add("Hotel Bella Vista");
                    cmbHotel.Items.Add("Hotel Capri");
                    cmbHotel.SelectedIndex = 0;
                    break;
                case 4: //Ezeiza
                    cmbHotel.Items.Clear();
                    cmbHotel.Enabled = true;
                    cmbCantidadPersonas.Enabled = true;
                    cmbHotel.Items.Add("Hotel Mercotel");
                    cmbHotel.SelectedIndex = 0;
                    break;
                case 5: //Entre Ríos
                    cmbHotel.Items.Clear();
                    cmbHotel.Enabled = true;
                    cmbCantidadPersonas.Enabled = true;
                    cmbHotel.Items.Add("La Fuente Apart Hotel");
                    cmbHotel.Items.Add("Hotel Queguay");
                    cmbHotel.SelectedIndex = 0;
                    break;
                case 6: //Capital Federal
                    cmbHotel.Items.Clear();
                    cmbHotel.Enabled = true;
                    cmbCantidadPersonas.Enabled = true;
                    cmbHotel.Items.Add("Grand Hotel");
                    cmbHotel.SelectedIndex = 0;
                    break;
            }
        }

        private void cmbHotel_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbHotel.SelectedItem.ToString())
            {
                case "Riviera Hotel":
                    precioHotel = 800;
                    break;
                case "Cadi Palace Hotel":
                    precioHotel = 1050;
                    break;
                case "Hotel Savoia":
                    precioHotel = 600;
                    break;
                case "Hotel España":
                    precioHotel = 424;
                    break;
                case "Hotel Bella Vista":
                    precioHotel = 610;
                    break;
                case "Hotel Capri":
                    precioHotel = 823;
                    break;
                case "Hotel Mercotel":
                    precioHotel = 850;
                    break;
                case "La Fuente Apart Hotel":
                    precioHotel = 1400;
                    break;
                case "Hotel Queguay":
                    precioHotel = 940;
                    break;
                case "Grand Hotel":
                    precioHotel = 850;
                    break;
                default:
                    precioHotel = 0;
                    break;
            }
            calcularPrecioTotal();
        }
         private void calcularPrecioTotal()
        {
            if (checkBox1.Checked==false)
            lblPrecioTotal.Text = (precioHotel*cantidadPersonas).ToString();
            else
            lblPrecioTotal.Text = ((precioHotel * cantidadPersonas)*0.75).ToString();
        }

        private void cmbCantidadPersonas_SelectedIndexChanged(object sender, EventArgs e)
        {
            cantidadPersonas = Convert.ToInt32(cmbCantidadPersonas.SelectedItem);
            calcularPrecioTotal();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            calcularPrecioTotal();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            formDatos form5 = new formDatos(cantidadPersonas);
            form5.Show();
        }
    }
}
