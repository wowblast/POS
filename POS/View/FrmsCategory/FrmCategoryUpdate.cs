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
    public partial class FrmCategoryUpdate : Form
    {

        private int idCategoria;

        public FrmCategoryUpdate()
        {
            InitializeComponent();
        }

        public void RellenarDatos(Categoria categoria)
        {
            idCategoria = categoria.IdCategoria;

            tbNombre.Text = categoria.Nombre;
            tbDescripcion.Text = categoria.Descripcion;
            cbCategoriaSuperior.SelectedValue = categoria.Subcategoria;

            CargarCategoriasSuperiores();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string nombre = tbNombre.Text;
            string descripcion = tbDescripcion.Text;
            int categoriaSuperior = Convert.ToInt32(cbCategoriaSuperior.SelectedValue.ToString());

            CategoriaControl categoriaControl = new CategoriaControl();
            categoriaControl.Modificar(new Categoria(idCategoria, nombre, descripcion, categoriaSuperior));
        }

        private void CargarCategoriasSuperiores()
        {
            CategoriaControl categoriaControl = new CategoriaControl();
            cbCategoriaSuperior.DataSource = categoriaControl.ListarParcialmente(idCategoria);
            cbCategoriaSuperior.DisplayMember = "NOMBRE";
            cbCategoriaSuperior.ValueMember = "ID CATEGORIA";
        }

    }
}
