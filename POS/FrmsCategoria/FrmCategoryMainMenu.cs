using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.FrmsCategoria
{
	public partial class FrmCategoryMainMenu : Form
	{
		public FrmCategoryMainMenu()
		{
			InitializeComponent();
		}

		private void btnRegistrar_Click(object sender, EventArgs e)
		{
			FrmAddCategory frmaddCategory = new FrmAddCategory();
				frmaddCategory.Show();
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
