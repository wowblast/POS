﻿namespace POS.FrmsEmployee
{
    partial class FrmEmployeeUpdate
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
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpContratacion = new System.Windows.Forms.DateTimePicker();
            this.dtpNacimiento = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.tbDireccion = new System.Windows.Forms.RichTextBox();
            this.tbClave = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbApellidoMaterno = new System.Windows.Forms.TextBox();
            this.tbApellidoPaterno = new System.Windows.Forms.TextBox();
            this.tbNombres = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbCargo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.SuspendLayout();
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRegistrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegistrar.Location = new System.Drawing.Point(437, 535);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(251, 55);
            this.btnRegistrar.TabIndex = 59;
            this.btnRegistrar.Text = "ACTUALIZAR";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(72, 417);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(203, 24);
            this.label11.TabIndex = 58;
            this.label11.Text = "Fecha de contratación:";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(77, 310);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(193, 24);
            this.label10.TabIndex = 57;
            this.label10.Text = "Fecha de nacimiento:";
            // 
            // dtpContratacion
            // 
            this.dtpContratacion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtpContratacion.Location = new System.Drawing.Point(76, 468);
            this.dtpContratacion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpContratacion.Name = "dtpContratacion";
            this.dtpContratacion.Size = new System.Drawing.Size(422, 28);
            this.dtpContratacion.TabIndex = 56;
            // 
            // dtpNacimiento
            // 
            this.dtpNacimiento.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtpNacimiento.Location = new System.Drawing.Point(76, 359);
            this.dtpNacimiento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpNacimiento.Name = "dtpNacimiento";
            this.dtpNacimiento.Size = new System.Drawing.Size(422, 28);
            this.dtpNacimiento.TabIndex = 55;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(580, 310);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 24);
            this.label9.TabIndex = 54;
            this.label9.Text = "Dirección:";
            // 
            // tbDireccion
            // 
            this.tbDireccion.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tbDireccion.Location = new System.Drawing.Point(581, 361);
            this.tbDireccion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.Size = new System.Drawing.Size(422, 135);
            this.tbDireccion.TabIndex = 53;
            this.tbDireccion.Text = "";
            // 
            // tbClave
            // 
            this.tbClave.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tbClave.Location = new System.Drawing.Point(713, 160);
            this.tbClave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbClave.Name = "tbClave";
            this.tbClave.Size = new System.Drawing.Size(290, 28);
            this.tbClave.TabIndex = 52;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(577, 156);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 24);
            this.label8.TabIndex = 51;
            this.label8.Text = "Contraseña:";
            // 
            // tbUsuario
            // 
            this.tbUsuario.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tbUsuario.Location = new System.Drawing.Point(715, 92);
            this.tbUsuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(288, 28);
            this.tbUsuario.TabIndex = 50;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(577, 96);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 24);
            this.label7.TabIndex = 49;
            this.label7.Text = "Usuario:";
            // 
            // tbApellidoMaterno
            // 
            this.tbApellidoMaterno.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbApellidoMaterno.Location = new System.Drawing.Point(207, 222);
            this.tbApellidoMaterno.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbApellidoMaterno.Name = "tbApellidoMaterno";
            this.tbApellidoMaterno.Size = new System.Drawing.Size(291, 28);
            this.tbApellidoMaterno.TabIndex = 48;
            // 
            // tbApellidoPaterno
            // 
            this.tbApellidoPaterno.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbApellidoPaterno.Location = new System.Drawing.Point(207, 162);
            this.tbApellidoPaterno.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbApellidoPaterno.Name = "tbApellidoPaterno";
            this.tbApellidoPaterno.Size = new System.Drawing.Size(291, 28);
            this.tbApellidoPaterno.TabIndex = 47;
            // 
            // tbNombres
            // 
            this.tbNombres.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbNombres.Location = new System.Drawing.Point(207, 101);
            this.tbNombres.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbNombres.Name = "tbNombres";
            this.tbNombres.Size = new System.Drawing.Size(291, 28);
            this.tbNombres.TabIndex = 46;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 222);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 24);
            this.label6.TabIndex = 45;
            this.label6.Text = "Apellido materno:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 162);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 24);
            this.label5.TabIndex = 44;
            this.label5.Text = "Apellido paterno:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(106, 100);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 24);
            this.label4.TabIndex = 43;
            this.label4.Text = "Nombres:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(577, 216);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 24);
            this.label3.TabIndex = 42;
            this.label3.Text = "Cargo:";
            // 
            // cbCargo
            // 
            this.cbCargo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cbCargo.FormattingEnabled = true;
            this.cbCargo.Location = new System.Drawing.Point(713, 222);
            this.cbCargo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbCargo.Name = "cbCargo";
            this.cbCargo.Size = new System.Drawing.Size(290, 30);
            this.cbCargo.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(472, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 31);
            this.label2.TabIndex = 40;
            this.label2.Text = "Actualizar";
            // 
            // FrmEmployeeUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1088, 621);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dtpContratacion);
            this.Controls.Add(this.dtpNacimiento);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbDireccion);
            this.Controls.Add(this.tbClave);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbUsuario);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbApellidoMaterno);
            this.Controls.Add(this.tbApellidoPaterno);
            this.Controls.Add(this.tbNombres);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbCargo);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmEmployeeUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actualizar datos de empleado";
            this.Load += new System.EventHandler(this.FrmEmployeeUpdate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpContratacion;
        private System.Windows.Forms.DateTimePicker dtpNacimiento;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox tbDireccion;
        private System.Windows.Forms.TextBox tbClave;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbApellidoMaterno;
        private System.Windows.Forms.TextBox tbApellidoPaterno;
        private System.Windows.Forms.TextBox tbNombres;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbCargo;
        private System.Windows.Forms.Label label2;
    }
}