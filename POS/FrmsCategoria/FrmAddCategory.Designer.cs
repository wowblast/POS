﻿namespace POS.FrmsCategoria
{
	partial class FrmAddCategory
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
			this.label1 = new System.Windows.Forms.Label();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btnRegistrar = new System.Windows.Forms.Button();
			this.cbcategoria = new System.Windows.Forms.ComboBox();
			this.txtSubcategoria = new System.Windows.Forms.Label();
			this.txtDescripcion = new System.Windows.Forms.TextBox();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(453, 43);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(233, 31);
			this.label1.TabIndex = 0;
			this.label1.Text = "Añadir Categoria";
			// 
			// btnCancelar
			// 
			this.btnCancelar.BackColor = System.Drawing.SystemColors.Highlight;
			this.btnCancelar.FlatAppearance.BorderSize = 0;
			this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnCancelar.Location = new System.Drawing.Point(252, 464);
			this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(284, 51);
			this.btnCancelar.TabIndex = 22;
			this.btnCancelar.Text = "CANCELAR";
			this.btnCancelar.UseVisualStyleBackColor = false;
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// btnRegistrar
			// 
			this.btnRegistrar.BackColor = System.Drawing.SystemColors.Highlight;
			this.btnRegistrar.FlatAppearance.BorderSize = 0;
			this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRegistrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnRegistrar.Location = new System.Drawing.Point(568, 464);
			this.btnRegistrar.Margin = new System.Windows.Forms.Padding(4);
			this.btnRegistrar.Name = "btnRegistrar";
			this.btnRegistrar.Size = new System.Drawing.Size(284, 51);
			this.btnRegistrar.TabIndex = 21;
			this.btnRegistrar.Text = "REGISTRAR";
			this.btnRegistrar.UseVisualStyleBackColor = false;
			this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
			// 
			// cbcategoria
			// 
			this.cbcategoria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cbcategoria.FormattingEnabled = true;
			this.cbcategoria.Location = new System.Drawing.Point(404, 376);
			this.cbcategoria.Margin = new System.Windows.Forms.Padding(4);
			this.cbcategoria.Name = "cbcategoria";
			this.cbcategoria.Size = new System.Drawing.Size(423, 21);
			this.cbcategoria.TabIndex = 20;
			// 
			// txtSubcategoria
			// 
			this.txtSubcategoria.AutoSize = true;
			this.txtSubcategoria.Location = new System.Drawing.Point(256, 376);
			this.txtSubcategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.txtSubcategoria.Name = "txtSubcategoria";
			this.txtSubcategoria.Size = new System.Drawing.Size(77, 13);
			this.txtSubcategoria.TabIndex = 19;
			this.txtSubcategoria.Text = "SubCategoria :";
			// 
			// txtDescripcion
			// 
			this.txtDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtDescripcion.Location = new System.Drawing.Point(404, 221);
			this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4);
			this.txtDescripcion.Multiline = true;
			this.txtDescripcion.Name = "txtDescripcion";
			this.txtDescripcion.Size = new System.Drawing.Size(423, 120);
			this.txtDescripcion.TabIndex = 18;
			// 
			// txtNombre
			// 
			this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtNombre.Location = new System.Drawing.Point(404, 157);
			this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(423, 20);
			this.txtNombre.TabIndex = 17;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(246, 221);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(63, 13);
			this.label3.TabIndex = 16;
			this.label3.Text = "Descripción";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(256, 157);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(47, 13);
			this.label2.TabIndex = 15;
			this.label2.Text = "Nombre:";
			// 
			// FrmAddCategory
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1098, 672);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnRegistrar);
			this.Controls.Add(this.cbcategoria);
			this.Controls.Add(this.txtSubcategoria);
			this.Controls.Add(this.txtDescripcion);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "FrmAddCategory";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Añadir Categoria";
			this.Load += new System.EventHandler(this.FrmAddCategory_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Button btnRegistrar;
		private System.Windows.Forms.ComboBox cbcategoria;
		private System.Windows.Forms.Label txtSubcategoria;
		private System.Windows.Forms.TextBox txtDescripcion;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
	}
}