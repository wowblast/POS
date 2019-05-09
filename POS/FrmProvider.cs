﻿using POS.Control;
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
    public partial class FrmProvider : Form
    {
        public FrmProvider()
        {
            InitializeComponent();
            //CargarDatosEmpresa();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmMainMenu frmMainMenu = new FrmMainMenu();
            frmMainMenu.Show();
            Close();
        }

        private void btnMenuPrincipal_Click(object sender, EventArgs e)
        {
            FrmMainMenu frmMainMenu = new FrmMainMenu();
            frmMainMenu.Show();
            Close();
        }

        private void btnRegistrar_Click_1(object sender, EventArgs e)
        {
            FrmRegisterProvider frmRegisterProvider = new FrmRegisterProvider();
            frmRegisterProvider.Show();
        }

        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            if (dataGridView3.SelectedRows.Count == 1)
            {
                int idProveedor = Convert.ToInt32(dataGridView3.SelectedCells[0].Value);
                string nombre = dataGridView3.SelectedCells[1].Value.ToString();
                string ubicacion = dataGridView3.SelectedCells[2].Value.ToString();

                FrmUpdateProvider frmUpdateProvider = new FrmUpdateProvider();
                frmUpdateProvider.Show();
                frmUpdateProvider.RellenarDatos(idProveedor, nombre, ubicacion);
            }
            else
            {
                MessageBox.Show("¡Debe seleccionar a un proveedor!", "Error");
            }

        }

        private void FrmProvider_Load(object sender, EventArgs e)
        {
            Listar();
        }

        public void Listar()
        {
            ProveedorControl proveedorControl = new ProveedorControl();
            dataGridView3.DataSource = proveedorControl.ListarProveedor();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView3.SelectedRows.Count == 1)
            {
                DialogResult result = MessageBox.Show("¿Esta seguro que desea eliminar el proveedor?", "Importante", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    int idProveedor = Convert.ToInt32(dataGridView3.SelectedCells[0].Value);
                    ProveedorControl providerController = new ProveedorControl();
                    providerController.EliminarProveedor(idProveedor);
                    Listar();
                }
            }
            else
            {
                MessageBox.Show("¡Debe seleccionar a un proveedor!", "Error");
            }
        }
    }
}
