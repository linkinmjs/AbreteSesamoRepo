namespace AbreteSesamo
{
    partial class frmInicio
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
            this.lstActividades = new System.Windows.Forms.ListBox();
            this.lstFactura = new System.Windows.Forms.ListBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtMontoTotal = new System.Windows.Forms.TextBox();
            this.lblMonto = new System.Windows.Forms.Label();
            this.btnReportes = new System.Windows.Forms.Button();
            this.gpbActividades = new System.Windows.Forms.GroupBox();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnQuitarTodo = new System.Windows.Forms.Button();
            this.gpbFactura = new System.Windows.Forms.GroupBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.lblMontoOtro = new System.Windows.Forms.Label();
            this.gpbActividades.SuspendLayout();
            this.gpbFactura.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstActividades
            // 
            this.lstActividades.FormattingEnabled = true;
            this.lstActividades.ItemHeight = 16;
            this.lstActividades.Location = new System.Drawing.Point(5, 21);
            this.lstActividades.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstActividades.Name = "lstActividades";
            this.lstActividades.Size = new System.Drawing.Size(268, 372);
            this.lstActividades.TabIndex = 0;
            this.lstActividades.SelectedIndexChanged += new System.EventHandler(this.lstActividades_SelectedIndexChanged);
            // 
            // lstFactura
            // 
            this.lstFactura.FormattingEnabled = true;
            this.lstFactura.ItemHeight = 16;
            this.lstFactura.Location = new System.Drawing.Point(5, 21);
            this.lstFactura.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstFactura.Name = "lstFactura";
            this.lstFactura.Size = new System.Drawing.Size(276, 212);
            this.lstFactura.TabIndex = 1;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(299, 38);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(131, 34);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Enabled = false;
            this.btnQuitar.Location = new System.Drawing.Point(298, 161);
            this.btnQuitar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(131, 34);
            this.btnQuitar.TabIndex = 3;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(143, 441);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(131, 34);
            this.btnEditar.TabIndex = 4;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(373, 76);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(56, 22);
            this.txtCantidad.TabIndex = 5;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(296, 79);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(64, 17);
            this.lblCantidad.TabIndex = 6;
            this.lblCantidad.Text = "Cantidad";
            // 
            // txtMontoTotal
            // 
            this.txtMontoTotal.Location = new System.Drawing.Point(162, 237);
            this.txtMontoTotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMontoTotal.Name = "txtMontoTotal";
            this.txtMontoTotal.ReadOnly = true;
            this.txtMontoTotal.Size = new System.Drawing.Size(121, 22);
            this.txtMontoTotal.TabIndex = 7;
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(68, 240);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(78, 17);
            this.lblMonto.TabIndex = 8;
            this.lblMonto.Text = "Monto total";
            // 
            // btnReportes
            // 
            this.btnReportes.Location = new System.Drawing.Point(593, 523);
            this.btnReportes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(131, 34);
            this.btnReportes.TabIndex = 9;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.UseVisualStyleBackColor = true;
            // 
            // gpbActividades
            // 
            this.gpbActividades.Controls.Add(this.btnAñadir);
            this.gpbActividades.Controls.Add(this.btnEliminar);
            this.gpbActividades.Controls.Add(this.lstActividades);
            this.gpbActividades.Controls.Add(this.btnEditar);
            this.gpbActividades.Location = new System.Drawing.Point(12, 15);
            this.gpbActividades.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbActividades.Name = "gpbActividades";
            this.gpbActividades.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbActividades.Size = new System.Drawing.Size(281, 481);
            this.gpbActividades.TabIndex = 30;
            this.gpbActividades.TabStop = false;
            this.gpbActividades.Text = "Actividades";
            // 
            // btnAñadir
            // 
            this.btnAñadir.Location = new System.Drawing.Point(5, 401);
            this.btnAñadir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(268, 34);
            this.btnAñadir.TabIndex = 6;
            this.btnAñadir.Text = "Añadir";
            this.btnAñadir.UseVisualStyleBackColor = true;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(5, 441);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(131, 34);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnQuitarTodo
            // 
            this.btnQuitarTodo.Enabled = false;
            this.btnQuitarTodo.Location = new System.Drawing.Point(298, 199);
            this.btnQuitarTodo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnQuitarTodo.Name = "btnQuitarTodo";
            this.btnQuitarTodo.Size = new System.Drawing.Size(131, 34);
            this.btnQuitarTodo.TabIndex = 31;
            this.btnQuitarTodo.Text = "Quitar todo";
            this.btnQuitarTodo.UseVisualStyleBackColor = true;
            this.btnQuitarTodo.Click += new System.EventHandler(this.btnQuitarTodo_Click);
            // 
            // gpbFactura
            // 
            this.gpbFactura.Controls.Add(this.btnConfirmar);
            this.gpbFactura.Controls.Add(this.lblMonto);
            this.gpbFactura.Controls.Add(this.txtMontoTotal);
            this.gpbFactura.Controls.Add(this.lstFactura);
            this.gpbFactura.Location = new System.Drawing.Point(436, 15);
            this.gpbFactura.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbFactura.Name = "gpbFactura";
            this.gpbFactura.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbFactura.Size = new System.Drawing.Size(288, 298);
            this.gpbFactura.TabIndex = 32;
            this.gpbFactura.TabStop = false;
            this.gpbFactura.Text = "Factura";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Enabled = false;
            this.btnConfirmar.Location = new System.Drawing.Point(152, 265);
            this.btnConfirmar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(131, 27);
            this.btnConfirmar.TabIndex = 33;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(374, 102);
            this.txtMonto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.ReadOnly = true;
            this.txtMonto.Size = new System.Drawing.Size(56, 22);
            this.txtMonto.TabIndex = 42;
            // 
            // lblMontoOtro
            // 
            this.lblMontoOtro.AutoSize = true;
            this.lblMontoOtro.Location = new System.Drawing.Point(296, 105);
            this.lblMontoOtro.Name = "lblMontoOtro";
            this.lblMontoOtro.Size = new System.Drawing.Size(47, 17);
            this.lblMontoOtro.TabIndex = 35;
            this.lblMontoOtro.Text = "Monto";
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(731, 569);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.gpbFactura);
            this.Controls.Add(this.btnQuitarTodo);
            this.Controls.Add(this.btnReportes);
            this.Controls.Add(this.gpbActividades);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.lblMontoOtro);
            this.Controls.Add(this.btnAgregar);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmInicio";
            this.Text = "Abrete Sesamo";
            this.Load += new System.EventHandler(this.frmInicio_Load);
            this.gpbActividades.ResumeLayout(false);
            this.gpbFactura.ResumeLayout(false);
            this.gpbFactura.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstActividades;
        private System.Windows.Forms.ListBox lstFactura;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtMontoTotal;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.GroupBox gpbActividades;
        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnQuitarTodo;
        private System.Windows.Forms.GroupBox gpbFactura;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label lblMontoOtro;
        private System.Windows.Forms.TextBox txtMonto;
    }
}

