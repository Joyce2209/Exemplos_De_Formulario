using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade2804
{
    public partial class frmPedido : Form
    {
        public frmPedido()
        {
            InitializeComponent();
        }

        private void frmPedido_Load(object sender, EventArgs e)
        {

        }

        private void bttExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bttEnvio_Click(object sender, EventArgs e)
        {
            String lanche = " ";
            String bebida = " ";
            String acomp = " ";
            int calorias = 0;

            if (rbtHotdog.Checked)
            {
                lanche = rbtHotdog.Text;
                calorias += 150;
            }
            else if (rbtMistoquente.Checked)
            {
                lanche = rbtMistoquente.Text;
                calorias += 100;
            }
            else if (rbtXsalada.Checked)
            {
                lanche = rbtXsalada.Text;
                calorias += 180;
            }
            else if (rbtXburger.Checked)
            {
                lanche = rbtXburger.Text;
                calorias += 160;
            }
            else
            {
                lanche = rbtXbacon.Text;
                calorias += 180;
            }



            if (rbtSuco.Checked)
            {
                bebida = rbtSuco.Text;
                calorias += 60;
            }
            else if (rbtRefri.Checked)
            {
                bebida = rbtRefri.Text;
                calorias += 80;
            }
            else if (rbtCerveja.Checked)
            {
                bebida = rbtCerveja.Text;
                calorias += 1200;
            }
            else if (rbtAgua.Checked)
            {
                bebida = rbtAgua.Text;
                calorias += 0;
            }
            else
            {
                bebida = rbtChopp.Text;
                calorias += 90;
            }


            if (rbtBatata.Checked)
            {
                acomp = rbtBatata.Text;
                calorias += 170;
            }
            else if (rbtMandioca.Checked)
            {
                acomp = rbtMandioca.Text;
                calorias += 190;
            }
            else if (rbtPolenta.Checked)
            {
                acomp = rbtPolenta.Text;
                calorias += 160;
            }
            else if (rbtSalada.Checked)
            {
                acomp = rbtSalada.Text;
                calorias += 30;
            }
            else
            {
                acomp = rbtProvolone.Text;
                calorias += 220;
            }

            txtPedido.Text = String.Format("Lanche: {0}. Bebida: {1}. Acompanhamento: {2}.", lanche, bebida, acomp);
            txtCaloria.Text = String.Format("{0} Kcal", calorias);

            if (calorias <= 350)
            {
                txtValor.Text = "Assim está bom";
            }
            else
            {
                txtValor.Text = "Assim você vai engordar";
            }
        }
    }
}
