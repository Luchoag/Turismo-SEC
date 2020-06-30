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
    public partial class formFormasDePago : Form
    {
        public formFormasDePago()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            webBrowser1.DocumentText = @"<Font = 'Arial'>-Tarjetas de Debito: <b>ELECTRON/MAESTRO.</b></br>
                                       -Tarjetas de Credito:  <b>VISA / MASTER / A.EXPRESS</b></br>
                                       Interes: (1 pago 0 % 3 pagos 6 % 4 a 6 pagos 10 % ).</br>
                                       </br>
                                       -Creditos internos para empleados de: <b>SEC / OSECAC / FAECYS.</b></br>
                                       (3 cuotas sin interes).</br>
                                       </br>
                                       -Pago en <b>PESOS.</b></br>
                                       -Pago en <b>DOLARES: </b></br>
                                       Abonando importe justo.</br>
                                       La cotizacion se confirma en el momento de pago.</Font>";
        }
    }
}
