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
    public partial class formDatos : Form 
    {
        public static int personas=0;
        public static GroupBox[] arrayGB;
        public static Label[] arrayLblNombre;
        public static Label[] arrayLblApellido;
        public static Label[] arrayLblDNI;
        public static Label[] arrayLblFechaNacimiento;
        public static Label[] arrayLblMail;
        public static Label[] arrayLblTelefono;

        public static TextBox[] arrayTxtNombre;
        public static TextBox[] arrayTxtApellido;
        public static TextBox[] arrayTxtFechaNacimiento;
        public static TextBox[] arrayTxtDNI;
        public static TextBox[] arrayTxtTelefono;
        public static TextBox[] arrayTxtMail;

        public formDatos(int cantidadPersonas)
        {
            InitializeComponent();
            personas = cantidadPersonas;
            arrayGB = new GroupBox[cantidadPersonas-1];
            arrayLblNombre = new Label[cantidadPersonas-1];
            arrayLblApellido = new Label[cantidadPersonas - 1];
            arrayLblDNI = new Label[cantidadPersonas - 1];
            arrayLblFechaNacimiento = new Label[cantidadPersonas - 1];
            arrayLblMail = new Label[cantidadPersonas - 1];
            arrayLblTelefono = new Label[cantidadPersonas - 1];
            arrayTxtNombre = new TextBox[cantidadPersonas - 1];
            arrayTxtApellido = new TextBox[cantidadPersonas - 1];
            arrayTxtFechaNacimiento = new TextBox[cantidadPersonas - 1];
            arrayTxtDNI = new TextBox[cantidadPersonas - 1];
            arrayTxtTelefono = new TextBox[cantidadPersonas - 1];
            arrayTxtMail = new TextBox[cantidadPersonas - 1];
        }

        private void formDatos_Load(object sender, EventArgs e)
        {
            inicializarGroupBox();
            crearFormularios();
            panel1.VerticalScroll.Value = 0;
            this.ActiveControl = txtNombre;
        }
        private void inicializarGroupBox()
        {
            for (int i = 0; i<arrayGB.Length; i++)
            {
                arrayGB[i] = new GroupBox();
                arrayLblNombre[i] = new Label();
                arrayLblApellido[i] = new Label();
                arrayLblDNI[i] = new Label();
                arrayLblFechaNacimiento[i] = new Label();
                arrayLblTelefono[i] = new Label();
                arrayLblMail[i] = new Label();
                arrayTxtNombre[i] = new TextBox();
                arrayTxtApellido[i] = new TextBox();
                arrayTxtFechaNacimiento[i] = new TextBox();
                arrayTxtDNI[i] = new TextBox();
                arrayTxtTelefono[i] = new TextBox();
                arrayTxtMail[i] = new TextBox();
                
            }
        }
        private void crearFormularios()
        {
            //Groupbox
            for (int i = 0; i<arrayGB.Length; i++)
            {
                arrayGB[i].Location = new Point(groupBox1.Location.X, groupBox1.Location.Y + 180*(i+1));
                arrayGB[i].Size = new Size(644, 174);
                arrayGB[i].Text = "Pasajero " + (i+2);
                panel1.Controls.Add(arrayGB[i]);
            }

            //Label Nombre
            for (int i = 0; i < arrayLblNombre.Length; i++)
            {
                arrayLblNombre[i].Location = new Point(lblNombre.Location.X, lblNombre.Location.Y);
                arrayLblNombre[i].Font = new Font("Arial", 11);
                arrayLblNombre[i].AutoSize = true;
                arrayLblNombre[i].Text = "Nombre:";
                arrayLblNombre[i].Show();
                arrayGB[i].Controls.Add(arrayLblNombre[i]);
            }

            //Label Apellido
            for (int i = 0; i < arrayLblNombre.Length; i++)
            {
                arrayLblApellido[i].Location = new Point(lblApellido.Location.X, lblApellido.Location.Y);
                arrayLblApellido[i].Font = new Font("Arial", 11);
                arrayLblApellido[i].AutoSize = true;
                arrayLblApellido[i].Text = "Apellido:";
                arrayLblApellido[i].Show();
                arrayGB[i].Controls.Add(arrayLblApellido[i]);
            }

            //Label Fecha de Nacimiento
            for (int i = 0; i < arrayGB.Length; i++)
            {
                arrayLblFechaNacimiento[i].Location = new Point(lblFecha.Location.X, lblFecha.Location.Y);
                arrayLblFechaNacimiento[i].Font = new Font("Arial", 11);
                arrayLblFechaNacimiento[i].AutoSize = true;
                arrayLblFechaNacimiento[i].Text = "Fecha de nacimiento:";
                arrayLblFechaNacimiento[i].Show();
                arrayGB[i].Controls.Add(arrayLblFechaNacimiento[i]);
            }

            //Label DNI
            for (int i = 0; i < arrayLblNombre.Length; i++)
            {
                arrayLblDNI[i].Location = new Point(lblDNI.Location.X, lblDNI.Location.Y);
                arrayLblDNI[i].Font = new Font("Arial", 11);
                arrayLblDNI[i].AutoSize = true;
                arrayLblDNI[i].Text = "DNI:";
                arrayLblDNI[i].Show();
                arrayGB[i].Controls.Add(arrayLblDNI[i]);
            }

            //Label Teléfono
            for (int i = 0; i < arrayLblNombre.Length; i++)
            {
                arrayLblTelefono[i].Location = new Point(lblTelefono.Location.X, lblTelefono.Location.Y);
                arrayLblTelefono[i].Font = new Font("Arial", 11);
                arrayLblTelefono[i].AutoSize = true;
                arrayLblTelefono[i].Text = "Teléfono:";
                arrayLblTelefono[i].Show();
                arrayGB[i].Controls.Add(arrayLblTelefono[i]);
            }

            //Label Mail
            for (int i = 0; i < arrayLblNombre.Length; i++)
            {
                arrayLblMail[i].Location = new Point(lblMail.Location.X, lblMail.Location.Y);
                arrayLblMail[i].Font = new Font("Arial", 11);
                arrayLblMail[i].AutoSize = true;
                arrayLblMail[i].Text = "Mail:";
                arrayLblMail[i].Show();
                arrayGB[i].Controls.Add(arrayLblMail[i]);
            }

            //TextBox Nombre
            for (int i = 0; i < arrayLblNombre.Length; i++)
            {
                arrayTxtNombre[i].Location = new Point(txtNombre.Location.X, txtNombre.Location.Y);
                arrayTxtNombre[i].Font = new Font("Arial", 11);
                arrayTxtNombre[i].Size = new Size(txtNombre.Size.Width, txtNombre.Size.Height);
                arrayTxtNombre[i].Show();
                arrayGB[i].Controls.Add(arrayTxtNombre[i]);
            }

            //TextBox Apellido
            for (int i = 0; i < arrayLblNombre.Length; i++)
            {
                arrayTxtApellido[i].Location = new Point(txtApellido.Location.X, txtApellido.Location.Y);
                arrayTxtApellido[i].Font = new Font("Arial", 11);
                arrayTxtApellido[i].Size = new Size(txtApellido.Size.Width, txtApellido.Size.Height);
                arrayTxtApellido[i].Show();
                arrayGB[i].Controls.Add(arrayTxtApellido[i]);
            }

            //TextBox Fecha de Nacimiento
            for (int i = 0; i < arrayLblNombre.Length; i++)
            {
                arrayTxtFechaNacimiento[i].Location = new Point(txtFecha.Location.X, txtFecha.Location.Y);
                arrayTxtFechaNacimiento[i].Font = new Font("Arial", 11);
                arrayTxtFechaNacimiento[i].Size = new Size(txtFecha.Size.Width, txtFecha.Size.Height);
                arrayTxtFechaNacimiento[i].Show();
                arrayGB[i].Controls.Add(arrayTxtFechaNacimiento[i]);
            }

            //TextBox DNI
            for (int i = 0; i < arrayLblNombre.Length; i++)
            {
                arrayTxtDNI[i].Location = new Point(txtDNI.Location.X, txtDNI.Location.Y);
                arrayTxtDNI[i].Font = new Font("Arial", 11);
                arrayTxtDNI[i].Size = new Size(txtDNI.Size.Width, txtDNI.Size.Height);
                arrayTxtDNI[i].Show();
                arrayGB[i].Controls.Add(arrayTxtDNI[i]);
            }

            //TextBox Telefono
            for (int i = 0; i < arrayLblNombre.Length; i++)
            {
                arrayTxtTelefono[i].Location = new Point(txtTelefono.Location.X, txtTelefono.Location.Y);
                arrayTxtTelefono[i].Font = new Font("Arial", 11);
                arrayTxtTelefono[i].Size = new Size(txtTelefono.Size.Width, txtTelefono.Size.Height);
                arrayTxtTelefono[i].Show();
                arrayGB[i].Controls.Add(arrayTxtTelefono[i]);
            }

            //TextBox Mail
            for (int i = 0; i < arrayLblNombre.Length; i++)
            {
                arrayTxtMail[i].Location = new Point(txtMail.Location.X, txtMail.Location.Y);
                arrayTxtMail[i].Font = new Font("Arial", 11);
                arrayTxtMail[i].Size = new Size(txtMail.Size.Width, txtMail.Size.Height);
                arrayTxtMail[i].Show();
                arrayGB[i].Controls.Add(arrayTxtMail[i]);
            }

            btnCancelar.Location = new Point(btnCancelar.Location.X, btnCancelar.Location.Y + 180 * arrayGB.Length);
            btnAceptar.Location = new Point(btnAceptar.Location.X, btnAceptar.Location.Y + 180*arrayGB.Length);
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("¿Desea confirmar la reserva?",
                                                 "Confirmar reserva",
                                                 MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                MessageBox.Show("¡Reserva confirmada!");
                this.Hide();
            }
            else
            {
                // If 'No', do something here.
            }
        }
    }
}
