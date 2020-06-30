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
    public partial class formPromociones : Form
    {
        public formPromociones()
        {
            InitializeComponent();
        }

        private void formPromociones_Load(object sender, EventArgs e)
        {
            cargarComboPromociones();
            cargarComboCantidadHabitacionesStandard();
            cargarComboCantidadHabitacionesSuperior();
            cargarComboPersonas();
        }

        public void cargarComboPromociones()
        {
            cmbPromociones.Items.Add("Miramar - Temporada Baja");
            cmbPromociones.Items.Add("Santa Teresita - Noviembre");
            cmbPromociones.Items.Add("San Clemente - Noviembre");
            cmbPromociones.Items.Add("Villa Gesell - Diciembre");
            cmbPromociones.Items.Add("Noche de bodas");
            cmbPromociones.SelectedIndex = 0;
        }

        public void cargarComboCantidadHabitacionesStandard()
        {
            cmbCantidadStandard.Items.Add("0");
            cmbCantidadStandard.Items.Add("1");
            cmbCantidadStandard.Items.Add("2");
            cmbCantidadStandard.Items.Add("3");
            cmbCantidadStandard.Items.Add("4");
            cmbCantidadStandard.SelectedIndex = 0;
        }


        public void cargarComboCantidadHabitacionesSuperior()
        {
            cmbCantidadSuperior.Items.Add("0");
            cmbCantidadSuperior.Items.Add("1");
            cmbCantidadSuperior.Items.Add("2");
            cmbCantidadSuperior.Items.Add("3");
            cmbCantidadSuperior.Items.Add("4");
            cmbCantidadSuperior.SelectedIndex = 0;
        }


        private void cmbPromociones_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPromociones.SelectedIndex==0)
            {
                promocionMiramar();
            }
            else if (cmbPromociones.SelectedIndex == 1)
            {
                promocionSantaTeresita();
            }
            else if (cmbPromociones.SelectedIndex == 2)
            {
                promocionSanClemente();
            }
            else if (cmbPromociones.SelectedIndex == 3)
            {
                promocionVillaGesell();
            }
            else if (cmbPromociones.SelectedIndex == 4)
            {
                promocionNocheDeBodas();
            }
        }
        //Promoción Miramar - Comienzo
        public void promocionMiramar()
        {
            lblHotel.Text = "Hotel Nuevo Luxor";
            lblProgramaNoches.Hide();
            cargarComboStandardMiramar();
            cargarComboSuperiorMiramar();
        }

        public void cargarComboStandardMiramar()
        {
            cmbStandard.Items.Clear();
            cmbStandard.Enabled = true;
            cmbCantidadStandard.Enabled = true;
            cmbStandard.Items.Add("Doble");
            cmbStandard.Items.Add("Triple");
            cmbStandard.Items.Add("Dpto x4");
            cmbStandard.SelectedIndex = 0;
            lblPrecioStandard.Text = "560";
        }

        public void cargarComboSuperiorMiramar()
        {
            cmbSuperior.Items.Clear();
            cmbSuperior.Enabled = true;
            cmbCantidadSuperior.Enabled = true;
            cmbSuperior.Items.Add("Doble");
            cmbSuperior.SelectedIndex = 0;
            lblPrecioSuperior.Text = "605";
        }
        //Promoción Miramar - Fin


        //Promoción Santa Teresita - Comienzo
        public void promocionSantaTeresita()
        {
            lblHotel.Text = "Hostería Jaguel del Medio";
            lblProgramaNoches.Show();
            cargarComboStandardSantaTeresita();
            cargarComboSuperiorSantaTeresita();
        }

        public void cargarComboStandardSantaTeresita()
        {
            cmbStandard.Items.Clear();
            cmbStandard.Enabled = true;
            cmbCantidadStandard.Enabled = true;
            cmbStandard.Items.Add("Single");
            cmbStandard.Items.Add("Doble");
            cmbStandard.Items.Add("Triple");
            cmbStandard.SelectedIndex = 0;
            lblPrecioStandard.Text = "1680";
        }

        public void cargarComboSuperiorSantaTeresita()
        {
            cmbSuperior.Items.Clear();
            cmbSuperior.Enabled = true;
            cmbCantidadSuperior.Enabled = true;
            cmbSuperior.Items.Add("Single");
            cmbSuperior.Items.Add("Doble");
            cmbSuperior.Items.Add("Triple");
            cmbSuperior.SelectedIndex = 0;
            lblPrecioSuperior.Text = "2365";
        }
        //Promoción Santa Teresita - Fin


        //Promoción San Clemente - Comienzo
        public void promocionSanClemente()
        {
            lblHotel.Text = "Hotel Savoia";
            lblProgramaNoches.Show();
            cargarComboStandardSanClemente();
            cargarComboSuperiorSanClemente();
        }

        public void cargarComboStandardSanClemente()
        {
            cmbStandard.Items.Clear();
            cmbStandard.Enabled = true;
            cmbCantidadStandard.Enabled = true;
            cmbStandard.Items.Add("Single");
            cmbStandard.Items.Add("Doble");
            cmbStandard.Items.Add("Triple");
            cmbStandard.Items.Add("Depto x4");
            cmbStandard.Items.Add("Depto x5");
            cmbStandard.SelectedIndex = 0;
            lblPrecioStandard.Text = "3210";
        }

        public void cargarComboSuperiorSanClemente()
        {
            cmbSuperior.Items.Clear();
            cmbSuperior.Enabled = true;
            cmbCantidadSuperior.Enabled = true;
            cmbSuperior.Items.Add("Single");
            cmbSuperior.Items.Add("Doble");
            cmbSuperior.Items.Add("Triple");
            cmbSuperior.SelectedIndex = 0;
            lblPrecioSuperior.Text = "3660";
        }
        //Promoción San Clemente - Fin


        //Promoción Villa Gesell - Comienzo
        public void promocionVillaGesell()
        {
            lblHotel.Text = "Hotel Caparcona";
            lblProgramaNoches.Hide();
            cargarComboStandardVillaGesell();
            cargarComboSuperiorVillaGesell();
        }

        public void cargarComboStandardVillaGesell()
        {
            cmbStandard.Items.Clear();
            cmbStandard.Enabled = true;
            cmbCantidadStandard.Enabled = true;
            cmbStandard.Items.Add("Doble");
            cmbStandard.SelectedIndex = 0;
            lblPrecioStandard.Text = "3750";
        }

        public void cargarComboSuperiorVillaGesell()
        {
            cmbSuperior.Items.Clear();
            cmbSuperior.Enabled = false;
            cmbCantidadSuperior.Enabled = false;
            lblPrecioSuperior.Text = "-";
        }
        //Promoción VillaGesell - Fin


        //Promoción Noche de Bodas - Comienzo

        public void promocionNocheDeBodas()
        {
            cmbStandard.Items.Clear();
            cmbStandard.Enabled = false;
            cmbSuperior.Items.Clear();
            cmbSuperior.Enabled = false;
            cmbCantidadStandard.Enabled = false;
            cmbCantidadSuperior.Enabled = false;
            lblProgramaNoches.Hide();
            lblHotel.Text = "Grand Hotel";

        }

        // Promoción Noche de Bodas - Fin

        public void calcularTotalAPagar()
        {
            int precioStandard = Convert.ToInt32(lblPrecioStandard.Text) * Convert.ToInt32(cmbCantidadStandard.SelectedItem.ToString());
            int precioSuperior = Convert.ToInt32(lblPrecioSuperior.Text) * Convert.ToInt32(cmbCantidadSuperior.SelectedItem.ToString());
            int cantidadDePersonas = Convert.ToInt32(cmbCantidadPersonas.SelectedItem.ToString());
            lblPrecioTotal.Text = Convert.ToInt32((precioStandard + precioSuperior)*cantidadDePersonas).ToString();
        }

        private void cmbCantidadStandard_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCantidadStandard.Items.Count!=0 && cmbCantidadSuperior.Items.Count!=0 && cmbCantidadPersonas.Items.Count != 0)
            {
                calcularTotalAPagar();
            }
            
        }

        private void cmbCantidadSuperior_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCantidadStandard.Items.Count != 0 && cmbCantidadSuperior.Items.Count != 0 && cmbCantidadPersonas.Items.Count!=0)
            {
                calcularTotalAPagar();
            }
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

        private void cmbCantidadPersonas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCantidadStandard.Items.Count != 0 && cmbCantidadSuperior.Items.Count != 0 && cmbCantidadPersonas.Items.Count != 0)
            {
                calcularTotalAPagar();
            }
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
