
namespace GestionGastos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCantidadDias = new System.Windows.Forms.Label();
            this.txtCantidadDias = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.cbxGastos = new System.Windows.Forms.ComboBox();
            this.lblGastos = new System.Windows.Forms.Label();
            this.txtTotalGastos = new System.Windows.Forms.TextBox();
            this.lblTotalGastos = new System.Windows.Forms.Label();
            this.txtDiaMayorGasto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCantidadDias
            // 
            this.lblCantidadDias.AutoSize = true;
            this.lblCantidadDias.Location = new System.Drawing.Point(144, 62);
            this.lblCantidadDias.Name = "lblCantidadDias";
            this.lblCantidadDias.Size = new System.Drawing.Size(86, 13);
            this.lblCantidadDias.TabIndex = 0;
            this.lblCantidadDias.Text = "Cantidad de dias";
            this.lblCantidadDias.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtCantidadDias
            // 
            this.txtCantidadDias.Location = new System.Drawing.Point(288, 55);
            this.txtCantidadDias.Name = "txtCantidadDias";
            this.txtCantidadDias.Size = new System.Drawing.Size(121, 20);
            this.txtCantidadDias.TabIndex = 1;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(288, 91);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(75, 23);
            this.btnIngresar.TabIndex = 2;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // cbxGastos
            // 
            this.cbxGastos.FormattingEnabled = true;
            this.cbxGastos.Location = new System.Drawing.Point(288, 135);
            this.cbxGastos.Name = "cbxGastos";
            this.cbxGastos.Size = new System.Drawing.Size(121, 21);
            this.cbxGastos.TabIndex = 3;
            this.cbxGastos.SelectedIndexChanged += new System.EventHandler(this.cbxGastos_SelectedIndexChanged);
            // 
            // lblGastos
            // 
            this.lblGastos.AutoSize = true;
            this.lblGastos.Location = new System.Drawing.Point(144, 143);
            this.lblGastos.Name = "lblGastos";
            this.lblGastos.Size = new System.Drawing.Size(40, 13);
            this.lblGastos.TabIndex = 4;
            this.lblGastos.Text = "Gastos";
            // 
            // txtTotalGastos
            // 
            this.txtTotalGastos.Location = new System.Drawing.Point(288, 175);
            this.txtTotalGastos.Name = "txtTotalGastos";
            this.txtTotalGastos.Size = new System.Drawing.Size(121, 20);
            this.txtTotalGastos.TabIndex = 5;
            // 
            // lblTotalGastos
            // 
            this.lblTotalGastos.AutoSize = true;
            this.lblTotalGastos.Location = new System.Drawing.Point(144, 182);
            this.lblTotalGastos.Name = "lblTotalGastos";
            this.lblTotalGastos.Size = new System.Drawing.Size(65, 13);
            this.lblTotalGastos.TabIndex = 6;
            this.lblTotalGastos.Text = "Total gastos";
            // 
            // txtDiaMayorGasto
            // 
            this.txtDiaMayorGasto.Location = new System.Drawing.Point(288, 211);
            this.txtDiaMayorGasto.Name = "txtDiaMayorGasto";
            this.txtDiaMayorGasto.Size = new System.Drawing.Size(121, 20);
            this.txtDiaMayorGasto.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Dia mayor gastos";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(288, 237);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 9;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(392, 237);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDiaMayorGasto);
            this.Controls.Add(this.lblTotalGastos);
            this.Controls.Add(this.txtTotalGastos);
            this.Controls.Add(this.lblGastos);
            this.Controls.Add(this.cbxGastos);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.txtCantidadDias);
            this.Controls.Add(this.lblCantidadDias);
            this.Name = "Form1";
            this.Text = "Gestion de gastos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCantidadDias;
        private System.Windows.Forms.TextBox txtCantidadDias;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.ComboBox cbxGastos;
        private System.Windows.Forms.Label lblGastos;
        private System.Windows.Forms.TextBox txtTotalGastos;
        private System.Windows.Forms.Label lblTotalGastos;
        private System.Windows.Forms.TextBox txtDiaMayorGasto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnSalir;
    }
}

