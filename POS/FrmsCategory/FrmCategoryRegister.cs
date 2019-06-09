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

namespace POS.FrmsCategory
{
    public partial class FrmCategoryRegister : Form
    {
        public FrmCategoryRegister()
        {
            InitializeComponent();
        }

        private void FrmCategoryRegister_Load(object sender, EventArgs e)
        {
            CategoriaControl categoriaControl = new CategoriaControl();
            cbCategoriaSuperior.DataSource = categoriaControl.ListarParcialmente(-1);
            cbCategoriaSuperior.DisplayMember = "NOMBRE";
            cbCategoriaSuperior.ValueMember = "ID CATEGORIA";
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string nombre = tbNombre.Text;
            string descripcion = tbDescripcion.Text;
            int categoriaSuperior = Convert.ToInt32(cbCategoriaSuperior.SelectedValue.ToString());

            CategoriaControl categoriaControl = new CategoriaControl();
            categoriaControl.Ingresar(new Categoria(nombre, descripcion, categoriaSuperior));
        }

    }
}
