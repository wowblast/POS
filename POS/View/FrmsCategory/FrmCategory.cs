using POS.Control;
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
    public partial class FrmCategory : Form
    {
        public FrmCategory()
        {
            InitializeComponent();
        }

        private void btnMenuPrincipal_Click(object sender, EventArgs e)
        {
            FrmMainMenu frmMainMenu = new FrmMainMenu();
            frmMainMenu.Show();
            Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            FrmCategoryRegister frmCategoryRegister = new FrmCategoryRegister();
            frmCategoryRegister.Show();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            Listar();
        }

        public void Listar()
        {
            CategoriaControl categoriaControl = new CategoriaControl();
            dgvCategorias.DataSource = categoriaControl.Listar();
        }

        private void FrmCategory_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dgvCategorias.SelectedRows.Count == 1)
            {
                int idCategoria = Convert.ToInt32(dgvCategorias.SelectedCells[0].Value);
                string nombre = dgvCategorias.SelectedCells[1].Value.ToString();
                string descripcion = dgvCategorias.SelectedCells[2].Value.ToString();
                int subcategoria = Convert.ToInt32(dgvCategorias.SelectedCells[3].Value.ToString());
               
                FrmCategoryUpdate frmCategoryUpdate = new FrmCategoryUpdate();
                frmCategoryUpdate.Show();
                frmCategoryUpdate.RellenarDatos(new Entity.Categoria(idCategoria, nombre, descripcion, subcategoria));
            }
            else
            {
                MessageBox.Show("¡Debes seleccionar a una categoría!", "Error");
            }
        }
    }
}
