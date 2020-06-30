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
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
        }

        private void btnPromociones_Click(object sender, EventArgs e)
        {
            
        }

        private void formMain_Load(object sender, EventArgs e)
        {/*
            Button btnVerDestinos = new Button();
            btnVerDestinos.Text = "Destinos";
            btnVerDestinos.Location = new Point(165, 75);
            btnVerDestinos.Size = new Size(221, 89);
            btnVerDestinos.BackColor = default(Color);
            btnVerDestinos.UseVisualStyleBackColor = true;
            btnVerDestinos.Font = new Font("Arial Narrow", 11);
            spCont.Panel2.Controls.Add(btnVerDestinos);
            */
            createMainMenu();

        }

        private void createMainMenu()
        {
            /* CreateMainMenu():
             * Creo los 4 botones de la pantalla principal
            */
            Button[] mainButtons = new Button[4];

            for (int i = 0; i < 4; i++)
            {
                // Inicializo las botones
               mainButtons[i] = new System.Windows.Forms.Button();
            }

            //Texto de cada botón
            mainButtons[0].Text = "Destinos";
            mainButtons[1].Text = "Promociones";
            mainButtons[2].Text = "Formas de Pago";
            mainButtons[3].Text = "Promo jubilados";

            //Ubicación de cada botón
            mainButtons[0].Location = new Point(165, 75);
            mainButtons[1].Location = new Point(529, 75);
            mainButtons[2].Location = new Point(529, 215);
            mainButtons[3].Location = new Point(165, 215);

            for (int i = 0; i < mainButtons.Length; i++)
            {
                mainButtons[i].Size = new Size(221, 89);
                mainButtons[i].BackColor = default(Color);
                mainButtons[i].UseVisualStyleBackColor = true;
                mainButtons[i].Font = new Font("Arial", 11);
                mainButtons[i].Click += new System.EventHandler(ClickButton);
                spCont.Panel2.Controls.Add(mainButtons[i]);
            }
            
        }

        public void ClickButton(Object sender, System.EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Text == "Destinos")
            {
                formDestinos form2 = new formDestinos();
                form2.Show();
            } else if (btn.Text == "Promociones")
            {
                formPromociones form3 = new formPromociones();
                form3.Show();
            } else if (btn.Text == "Formas de Pago")
            {
                formFormasDePago form4 = new formFormasDePago();
                form4.Show();
            } else if (btn.Text == "Promo jubilados")
            {
                formPromoJubilados form5 = new formPromoJubilados();
                form5.Show();
            }

        }

    }
}
