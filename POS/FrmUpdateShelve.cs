using POS.Control;
using POS.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class FrmUpdateShelve : Form
    {
        public Estante estante;

        public FrmUpdateShelve()
        {
            InitializeComponent();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            TiendaControl tiendaControl = new TiendaControl();

            string nuevoNumero = newEstNumTxt.Text;
            string nuevoNivel = newEstLvlTxt.Text;

            tiendaControl.ModificarEstante(estante.CodigoEstante, nuevoNumero, nuevoNivel);

            Close();
        }
        public void cambiarDatos(int idEstante,string numero,string nivel)
        {
            this.estante = new Estante(idEstante, numero, nivel);
            newEstNumTxt.Text = estante.NumeroEstante;
            newEstLvlTxt.Text = estante.Niveles;
        }
    }
}
