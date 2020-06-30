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
    public partial class formPromoJubilados : Form
    {
        public formPromoJubilados()
        {
            InitializeComponent();
        }

        private void formPromoJubilados_Load(object sender, EventArgs e)
        {
            cargarComboPersonas();
        }

        public void cargarComboPersonas()
        {
            cmbCantidadPersonas.Items.Add("1");
            cmbCantidadPersonas.Items.Add("2");
            cmbCantidadPersonas.Items.Add("3");
            cmbCantidadPersonas.Items.Add("4");
            cmbCantidadPersonas.Items.Add("5");
            cmbCantidadPersonas.SelectedIndex = 0;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            webBrowser1.DocumentText = @"<Font = 'Arial'><b>$2200.- TARIFA POR JUBILADO INCLUYENDO:</b></br>
                                       ·7 noches de alojamiento con media pensión en el Hotel Riviera y en el Cadi Palace Hotel.</br>
                                       ·Transporte en bus ida y vuelta</br>
                                       ·Actividades diarias dictadas por profesores especialistas de la tercera edad.</br>
                                       ·Foto grupal + CD con todas las fotos de la semana.</br>
                                       </br></Font>";
        }

        private void cmbCantidadPersonas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCantidadPersonas.Items.Count!=0)
            {
                calcularTotalAPagar();
            }
        }

        public void calcularTotalAPagar()
        {
            int cantidadDePersonas = Convert.ToInt32(cmbCantidadPersonas.SelectedItem.ToString());
            lblPrecioTotal.Text = Convert.ToInt32(2200 * cantidadDePersonas).ToString();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            formDatos form5 = new formDatos(Convert.ToInt32(cmbCantidadPersonas.SelectedItem));
            form5.Show();
        }
    }
}
