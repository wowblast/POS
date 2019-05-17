namespace POS
{
    partial class FrmProducts
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProducts));
			this.btnBack = new System.Windows.Forms.Button();
			this.btnUpdateProduct = new System.Windows.Forms.Button();
			this.EliminarProducto = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.menuStrip2 = new System.Windows.Forms.MenuStrip();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.label11 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label15 = new System.Windows.Forms.Label();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.label16 = new System.Windows.Forms.Label();
			this.textBox8 = new System.Windows.Forms.TextBox();
			this.label17 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// btnBack
			// 
			this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
			this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnBack.FlatAppearance.BorderSize = 0;
			this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBack.Location = new System.Drawing.Point(826, 10);
			this.btnBack.Margin = new System.Windows.Forms.Padding(2);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(30, 32);
			this.btnBack.TabIndex = 8;
			this.btnBack.UseVisualStyleBackColor = true;
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click_1);
			// 
			// btnUpdateProduct
			// 
			this.btnUpdateProduct.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btnUpdateProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnUpdateProduct.Location = new System.Drawing.Point(144, 26);
			this.btnUpdateProduct.Margin = new System.Windows.Forms.Padding(2);
			this.btnUpdateProduct.Name = "btnUpdateProduct";
			this.btnUpdateProduct.Size = new System.Drawing.Size(178, 32);
			this.btnUpdateProduct.TabIndex = 2;
			this.btnUpdateProduct.Text = "Actualizar producto";
			this.btnUpdateProduct.UseVisualStyleBackColor = true;
			this.btnUpdateProduct.Click += new System.EventHandler(this.btnUpdateProduct_Click);
			// 
			// EliminarProducto
			// 
			this.EliminarProducto.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.EliminarProducto.Location = new System.Drawing.Point(544, 48);
			this.EliminarProducto.Margin = new System.Windows.Forms.Padding(2);
			this.EliminarProducto.Name = "EliminarProducto";
			this.EliminarProducto.Size = new System.Drawing.Size(191, 39);
			this.EliminarProducto.TabIndex = 1;
			this.EliminarProducto.Text = "Eliminar producto";
			this.EliminarProducto.UseVisualStyleBackColor = true;
			this.EliminarProducto.Click += new System.EventHandler(this.EliminarProducto_Click);
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(400, 46);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(110, 26);
			this.label1.TabIndex = 10;
			this.label1.Text = "Productos";
			// 
			// menuStrip2
			// 
			this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip2.Location = new System.Drawing.Point(0, 0);
			this.menuStrip2.Name = "menuStrip2";
			this.menuStrip2.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
			this.menuStrip2.Size = new System.Drawing.Size(878, 24);
			this.menuStrip2.TabIndex = 11;
			this.menuStrip2.Text = "menuStrip2";
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// comboBox2
			// 
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Location = new System.Drawing.Point(335, 145);
			this.comboBox2.Margin = new System.Windows.Forms.Padding(2);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(278, 21);
			this.comboBox2.TabIndex = 58;
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
			this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox2.Location = new System.Drawing.Point(357, 414);
			this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(200, 133);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 57;
			this.pictureBox2.TabStop = false;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(350, 382);
			this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(253, 17);
			this.label11.TabIndex = 56;
			this.label11.Text = "Aún no se ha cargado ninguna imagen";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(620, 369);
			this.button1.Margin = new System.Windows.Forms.Padding(2);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(61, 45);
			this.button1.TabIndex = 55;
			this.button1.Text = "...";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(179, 369);
			this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(167, 13);
			this.label12.TabIndex = 54;
			this.label12.Text = "Seleccionar archivo de la imagen:";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(435, 324);
			this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(22, 13);
			this.label13.TabIndex = 53;
			this.label13.Text = "Bs.";
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.SystemColors.Highlight;
			this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.Location = new System.Drawing.Point(349, 568);
			this.button3.Margin = new System.Windows.Forms.Padding(2);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(221, 43);
			this.button3.TabIndex = 52;
			this.button3.Text = "REGISTRAR PRODUCTO";
			this.button3.UseVisualStyleBackColor = false;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(544, 321);
			this.textBox1.Margin = new System.Windows.Forms.Padding(2);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(102, 20);
			this.textBox1.TabIndex = 51;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(466, 323);
			this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(52, 13);
			this.label14.TabIndex = 50;
			this.label14.Text = "Cantidad:";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(321, 320);
			this.textBox2.Margin = new System.Windows.Forms.Padding(2);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(110, 20);
			this.textBox2.TabIndex = 49;
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(165, 322);
			this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(107, 13);
			this.label15.TabIndex = 48;
			this.label15.Text = "Precio unitario venta:";
			// 
			// textBox7
			// 
			this.textBox7.Location = new System.Drawing.Point(335, 238);
			this.textBox7.Margin = new System.Windows.Forms.Padding(2);
			this.textBox7.Multiline = true;
			this.textBox7.Name = "textBox7";
			this.textBox7.Size = new System.Drawing.Size(278, 55);
			this.textBox7.TabIndex = 47;
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(179, 238);
			this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(66, 13);
			this.label16.TabIndex = 46;
			this.label16.Text = "Descripción:";
			// 
			// textBox8
			// 
			this.textBox8.Location = new System.Drawing.Point(335, 188);
			this.textBox8.Margin = new System.Windows.Forms.Padding(2);
			this.textBox8.Name = "textBox8";
			this.textBox8.Size = new System.Drawing.Size(278, 20);
			this.textBox8.TabIndex = 45;
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Location = new System.Drawing.Point(238, 188);
			this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(47, 13);
			this.label17.TabIndex = 44;
			this.label17.Text = "Nombre:";
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Location = new System.Drawing.Point(238, 145);
			this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(57, 13);
			this.label18.TabIndex = 43;
			this.label18.Text = "Id estante:";
			// 
			// FrmProducts
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(878, 673);
			this.Controls.Add(this.comboBox2);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.textBox7);
			this.Controls.Add(this.label16);
			this.Controls.Add(this.textBox8);
			this.Controls.Add(this.label17);
			this.Controls.Add(this.label18);
			this.Controls.Add(this.btnUpdateProduct);
			this.Controls.Add(this.EliminarProducto);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnBack);
			this.Controls.Add(this.menuStrip2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "FrmProducts";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmProducts";
			this.Load += new System.EventHandler(this.FrmProducts_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdateProduct;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.Button EliminarProducto;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.TextBox textBox7;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.TextBox textBox8;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label18;
	}
}