namespace POS.FmsProductsCategory
{
	partial class FrmUpdateCategoryProduct
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.cbCategoria = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btnActualizarDatos = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// cbCategoria
			// 
			this.cbCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbCategoria.FormattingEnabled = true;
			this.cbCategoria.Location = new System.Drawing.Point(215, 174);
			this.cbCategoria.Margin = new System.Windows.Forms.Padding(2);
			this.cbCategoria.Name = "cbCategoria";
			this.cbCategoria.Size = new System.Drawing.Size(318, 25);
			this.cbCategoria.TabIndex = 26;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(104, 174);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(76, 18);
			this.label4.TabIndex = 25;
			this.label4.Text = "Categoria:";
			// 
			// btnCancelar
			// 
			this.btnCancelar.BackColor = System.Drawing.SystemColors.Highlight;
			this.btnCancelar.FlatAppearance.BorderSize = 0;
			this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnCancelar.Location = new System.Drawing.Point(101, 245);
			this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(213, 41);
			this.btnCancelar.TabIndex = 24;
			this.btnCancelar.Text = "CANCELAR";
			this.btnCancelar.UseVisualStyleBackColor = false;
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// btnActualizarDatos
			// 
			this.btnActualizarDatos.BackColor = System.Drawing.SystemColors.Highlight;
			this.btnActualizarDatos.FlatAppearance.BorderSize = 0;
			this.btnActualizarDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnActualizarDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnActualizarDatos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnActualizarDatos.Location = new System.Drawing.Point(338, 245);
			this.btnActualizarDatos.Margin = new System.Windows.Forms.Padding(2);
			this.btnActualizarDatos.Name = "btnActualizarDatos";
			this.btnActualizarDatos.Size = new System.Drawing.Size(213, 41);
			this.btnActualizarDatos.TabIndex = 23;
			this.btnActualizarDatos.Text = "ACTUALIZAR DATOS";
			this.btnActualizarDatos.UseVisualStyleBackColor = false;
			this.btnActualizarDatos.Click += new System.EventHandler(this.btnActualizarDatos_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(103, 97);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(69, 18);
			this.label2.TabIndex = 19;
			this.label2.Text = "Producto";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(156, 47);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(427, 20);
			this.label1.TabIndex = 18;
			this.label1.Text = "ACTUALIZAR DATOS CATEGORIA DE PRODUCTO";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(226, 101);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(290, 31);
			this.label5.TabIndex = 27;
			this.label5.Text = ".";
			// 
			// FrmUpdateCategoryProduct
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(669, 351);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.cbCategoria);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnActualizarDatos);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "FrmUpdateCategoryProduct";
			this.Text = "FrmUpdateCategoryProduct";
			this.Load += new System.EventHandler(this.FrmUpdateCategoryProduct_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cbCategoria;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Button btnActualizarDatos;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label5;
	}
}