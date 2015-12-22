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
            this.ckbDoblePaleta = new System.Windows.Forms.CheckBox();
            this.ckbYale = new System.Windows.Forms.CheckBox();
            this.ckbAutomotor = new System.Windows.Forms.CheckBox();
            this.ckbEspecial = new System.Windows.Forms.CheckBox();
            this.ckbCerraduras = new System.Windows.Forms.CheckBox();
            this.ckbCerrojo = new System.Windows.Forms.CheckBox();
            this.txtDoblePaletaCAN = new System.Windows.Forms.TextBox();
            this.txtYaleCAN = new System.Windows.Forms.TextBox();
            this.txtAutomotorCAN = new System.Windows.Forms.TextBox();
            this.txtEspecialCAN = new System.Windows.Forms.TextBox();
            this.txtCerraduraCAN = new System.Windows.Forms.TextBox();
            this.txtCerrojoCAN = new System.Windows.Forms.TextBox();
            this.gpbActividades = new System.Windows.Forms.GroupBox();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnQuitarTodo = new System.Windows.Forms.Button();
            this.gpbFactura = new System.Windows.Forms.GroupBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.gpbInsumos = new System.Windows.Forms.GroupBox();
            this.txtDoblePaletaMON = new System.Windows.Forms.TextBox();
            this.txtYaleMON = new System.Windows.Forms.TextBox();
            this.txtAutomotorMON = new System.Windows.Forms.TextBox();
            this.txtEspecialMON = new System.Windows.Forms.TextBox();
            this.txtCerrojoMON = new System.Windows.Forms.TextBox();
            this.txtCerraduraMON = new System.Windows.Forms.TextBox();
            this.txtOtroMON = new System.Windows.Forms.TextBox();
            this.lblMontoOtro = new System.Windows.Forms.Label();
            this.lblCant = new System.Windows.Forms.Label();
            this.lblTipoInsumo = new System.Windows.Forms.Label();
            this.txtOtroCAN = new System.Windows.Forms.TextBox();
            this.ckbOtros = new System.Windows.Forms.CheckBox();
            this.gpbActividades.SuspendLayout();
            this.gpbFactura.SuspendLayout();
            this.gpbInsumos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstActividades
            // 
            this.lstActividades.FormattingEnabled = true;
            this.lstActividades.Location = new System.Drawing.Point(4, 17);
            this.lstActividades.Margin = new System.Windows.Forms.Padding(2);
            this.lstActividades.Name = "lstActividades";
            this.lstActividades.Size = new System.Drawing.Size(202, 303);
            this.lstActividades.TabIndex = 0;
            // 
            // lstFactura
            // 
            this.lstFactura.FormattingEnabled = true;
            this.lstFactura.Location = new System.Drawing.Point(4, 17);
            this.lstFactura.Margin = new System.Windows.Forms.Padding(2);
            this.lstFactura.Name = "lstFactura";
            this.lstFactura.Size = new System.Drawing.Size(208, 121);
            this.lstFactura.TabIndex = 1;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(224, 29);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(98, 28);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Enabled = false;
            this.btnQuitar.Location = new System.Drawing.Point(224, 84);
            this.btnQuitar.Margin = new System.Windows.Forms.Padding(2);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(98, 28);
            this.btnQuitar.TabIndex = 3;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(107, 358);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(98, 28);
            this.btnEditar.TabIndex = 4;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(280, 62);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(2);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(43, 20);
            this.txtCantidad.TabIndex = 5;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(222, 64);
            this.lblCantidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(49, 13);
            this.lblCantidad.TabIndex = 6;
            this.lblCantidad.Text = "Cantidad";
            // 
            // txtMontoTotal
            // 
            this.txtMontoTotal.Location = new System.Drawing.Point(121, 356);
            this.txtMontoTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtMontoTotal.Name = "txtMontoTotal";
            this.txtMontoTotal.Size = new System.Drawing.Size(92, 20);
            this.txtMontoTotal.TabIndex = 7;
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(50, 358);
            this.lblMonto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(60, 13);
            this.lblMonto.TabIndex = 8;
            this.lblMonto.Text = "Monto total";
            // 
            // btnReportes
            // 
            this.btnReportes.Location = new System.Drawing.Point(445, 425);
            this.btnReportes.Margin = new System.Windows.Forms.Padding(2);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(98, 28);
            this.btnReportes.TabIndex = 9;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.UseVisualStyleBackColor = true;
            // 
            // ckbDoblePaleta
            // 
            this.ckbDoblePaleta.AutoSize = true;
            this.ckbDoblePaleta.Location = new System.Drawing.Point(4, 49);
            this.ckbDoblePaleta.Margin = new System.Windows.Forms.Padding(2);
            this.ckbDoblePaleta.Name = "ckbDoblePaleta";
            this.ckbDoblePaleta.Size = new System.Drawing.Size(87, 17);
            this.ckbDoblePaleta.TabIndex = 12;
            this.ckbDoblePaleta.Text = "Doble Paleta";
            this.ckbDoblePaleta.UseVisualStyleBackColor = true;
            // 
            // ckbYale
            // 
            this.ckbYale.AutoSize = true;
            this.ckbYale.Location = new System.Drawing.Point(4, 67);
            this.ckbYale.Margin = new System.Windows.Forms.Padding(2);
            this.ckbYale.Name = "ckbYale";
            this.ckbYale.Size = new System.Drawing.Size(47, 17);
            this.ckbYale.TabIndex = 13;
            this.ckbYale.Text = "Yale";
            this.ckbYale.UseVisualStyleBackColor = true;
            // 
            // ckbAutomotor
            // 
            this.ckbAutomotor.AutoSize = true;
            this.ckbAutomotor.Location = new System.Drawing.Point(4, 84);
            this.ckbAutomotor.Margin = new System.Windows.Forms.Padding(2);
            this.ckbAutomotor.Name = "ckbAutomotor";
            this.ckbAutomotor.Size = new System.Drawing.Size(74, 17);
            this.ckbAutomotor.TabIndex = 14;
            this.ckbAutomotor.Text = "Automotor";
            this.ckbAutomotor.UseVisualStyleBackColor = true;
            // 
            // ckbEspecial
            // 
            this.ckbEspecial.AutoSize = true;
            this.ckbEspecial.Location = new System.Drawing.Point(4, 102);
            this.ckbEspecial.Margin = new System.Windows.Forms.Padding(2);
            this.ckbEspecial.Name = "ckbEspecial";
            this.ckbEspecial.Size = new System.Drawing.Size(66, 17);
            this.ckbEspecial.TabIndex = 15;
            this.ckbEspecial.Text = "Especial";
            this.ckbEspecial.UseVisualStyleBackColor = true;
            // 
            // ckbCerraduras
            // 
            this.ckbCerraduras.AutoSize = true;
            this.ckbCerraduras.Location = new System.Drawing.Point(4, 122);
            this.ckbCerraduras.Margin = new System.Windows.Forms.Padding(2);
            this.ckbCerraduras.Name = "ckbCerraduras";
            this.ckbCerraduras.Size = new System.Drawing.Size(72, 17);
            this.ckbCerraduras.TabIndex = 16;
            this.ckbCerraduras.Text = "Cerradura";
            this.ckbCerraduras.UseVisualStyleBackColor = true;
            // 
            // ckbCerrojo
            // 
            this.ckbCerrojo.AutoSize = true;
            this.ckbCerrojo.Location = new System.Drawing.Point(4, 140);
            this.ckbCerrojo.Margin = new System.Windows.Forms.Padding(2);
            this.ckbCerrojo.Name = "ckbCerrojo";
            this.ckbCerrojo.Size = new System.Drawing.Size(59, 17);
            this.ckbCerrojo.TabIndex = 17;
            this.ckbCerrojo.Text = "Cerrojo";
            this.ckbCerrojo.UseVisualStyleBackColor = true;
            // 
            // txtDoblePaletaCAN
            // 
            this.txtDoblePaletaCAN.Location = new System.Drawing.Point(92, 47);
            this.txtDoblePaletaCAN.Margin = new System.Windows.Forms.Padding(2);
            this.txtDoblePaletaCAN.Name = "txtDoblePaletaCAN";
            this.txtDoblePaletaCAN.Size = new System.Drawing.Size(30, 20);
            this.txtDoblePaletaCAN.TabIndex = 18;
            // 
            // txtYaleCAN
            // 
            this.txtYaleCAN.Location = new System.Drawing.Point(92, 65);
            this.txtYaleCAN.Margin = new System.Windows.Forms.Padding(2);
            this.txtYaleCAN.Name = "txtYaleCAN";
            this.txtYaleCAN.Size = new System.Drawing.Size(30, 20);
            this.txtYaleCAN.TabIndex = 20;
            // 
            // txtAutomotorCAN
            // 
            this.txtAutomotorCAN.Location = new System.Drawing.Point(92, 83);
            this.txtAutomotorCAN.Margin = new System.Windows.Forms.Padding(2);
            this.txtAutomotorCAN.Name = "txtAutomotorCAN";
            this.txtAutomotorCAN.Size = new System.Drawing.Size(30, 20);
            this.txtAutomotorCAN.TabIndex = 22;
            // 
            // txtEspecialCAN
            // 
            this.txtEspecialCAN.Location = new System.Drawing.Point(92, 101);
            this.txtEspecialCAN.Margin = new System.Windows.Forms.Padding(2);
            this.txtEspecialCAN.Name = "txtEspecialCAN";
            this.txtEspecialCAN.Size = new System.Drawing.Size(30, 20);
            this.txtEspecialCAN.TabIndex = 24;
            // 
            // txtCerraduraCAN
            // 
            this.txtCerraduraCAN.Location = new System.Drawing.Point(92, 120);
            this.txtCerraduraCAN.Margin = new System.Windows.Forms.Padding(2);
            this.txtCerraduraCAN.Name = "txtCerraduraCAN";
            this.txtCerraduraCAN.Size = new System.Drawing.Size(30, 20);
            this.txtCerraduraCAN.TabIndex = 26;
            // 
            // txtCerrojoCAN
            // 
            this.txtCerrojoCAN.Location = new System.Drawing.Point(92, 138);
            this.txtCerrojoCAN.Margin = new System.Windows.Forms.Padding(2);
            this.txtCerrojoCAN.Name = "txtCerrojoCAN";
            this.txtCerrojoCAN.Size = new System.Drawing.Size(30, 20);
            this.txtCerrojoCAN.TabIndex = 28;
            // 
            // gpbActividades
            // 
            this.gpbActividades.Controls.Add(this.btnAñadir);
            this.gpbActividades.Controls.Add(this.btnEliminar);
            this.gpbActividades.Controls.Add(this.lstActividades);
            this.gpbActividades.Controls.Add(this.btnEditar);
            this.gpbActividades.Location = new System.Drawing.Point(9, 12);
            this.gpbActividades.Margin = new System.Windows.Forms.Padding(2);
            this.gpbActividades.Name = "gpbActividades";
            this.gpbActividades.Padding = new System.Windows.Forms.Padding(2);
            this.gpbActividades.Size = new System.Drawing.Size(211, 391);
            this.gpbActividades.TabIndex = 30;
            this.gpbActividades.TabStop = false;
            this.gpbActividades.Text = "Actividades";
            // 
            // btnAñadir
            // 
            this.btnAñadir.Location = new System.Drawing.Point(4, 326);
            this.btnAñadir.Margin = new System.Windows.Forms.Padding(2);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(201, 28);
            this.btnAñadir.TabIndex = 6;
            this.btnAñadir.Text = "Añadir";
            this.btnAñadir.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(4, 358);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(98, 28);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnQuitarTodo
            // 
            this.btnQuitarTodo.Enabled = false;
            this.btnQuitarTodo.Location = new System.Drawing.Point(224, 117);
            this.btnQuitarTodo.Margin = new System.Windows.Forms.Padding(2);
            this.btnQuitarTodo.Name = "btnQuitarTodo";
            this.btnQuitarTodo.Size = new System.Drawing.Size(98, 28);
            this.btnQuitarTodo.TabIndex = 31;
            this.btnQuitarTodo.Text = "Quitar todo";
            this.btnQuitarTodo.UseVisualStyleBackColor = true;
            this.btnQuitarTodo.Click += new System.EventHandler(this.btnQuitarTodo_Click);
            // 
            // gpbFactura
            // 
            this.gpbFactura.Controls.Add(this.btnConfirmar);
            this.gpbFactura.Controls.Add(this.gpbInsumos);
            this.gpbFactura.Controls.Add(this.lblMonto);
            this.gpbFactura.Controls.Add(this.txtMontoTotal);
            this.gpbFactura.Controls.Add(this.lstFactura);
            this.gpbFactura.Location = new System.Drawing.Point(327, 12);
            this.gpbFactura.Margin = new System.Windows.Forms.Padding(2);
            this.gpbFactura.Name = "gpbFactura";
            this.gpbFactura.Padding = new System.Windows.Forms.Padding(2);
            this.gpbFactura.Size = new System.Drawing.Size(216, 408);
            this.gpbFactura.TabIndex = 32;
            this.gpbFactura.TabStop = false;
            this.gpbFactura.Text = "Factura";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Enabled = false;
            this.btnConfirmar.Location = new System.Drawing.Point(113, 379);
            this.btnConfirmar.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(98, 22);
            this.btnConfirmar.TabIndex = 33;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            // 
            // gpbInsumos
            // 
            this.gpbInsumos.Controls.Add(this.txtDoblePaletaMON);
            this.gpbInsumos.Controls.Add(this.txtYaleMON);
            this.gpbInsumos.Controls.Add(this.txtAutomotorMON);
            this.gpbInsumos.Controls.Add(this.txtEspecialMON);
            this.gpbInsumos.Controls.Add(this.txtCerrojoMON);
            this.gpbInsumos.Controls.Add(this.txtCerraduraMON);
            this.gpbInsumos.Controls.Add(this.txtOtroMON);
            this.gpbInsumos.Controls.Add(this.lblMontoOtro);
            this.gpbInsumos.Controls.Add(this.lblCant);
            this.gpbInsumos.Controls.Add(this.lblTipoInsumo);
            this.gpbInsumos.Controls.Add(this.txtOtroCAN);
            this.gpbInsumos.Controls.Add(this.ckbOtros);
            this.gpbInsumos.Controls.Add(this.txtCerrojoCAN);
            this.gpbInsumos.Controls.Add(this.txtCerraduraCAN);
            this.gpbInsumos.Controls.Add(this.txtEspecialCAN);
            this.gpbInsumos.Controls.Add(this.txtAutomotorCAN);
            this.gpbInsumos.Controls.Add(this.txtYaleCAN);
            this.gpbInsumos.Controls.Add(this.txtDoblePaletaCAN);
            this.gpbInsumos.Controls.Add(this.ckbCerrojo);
            this.gpbInsumos.Controls.Add(this.ckbCerraduras);
            this.gpbInsumos.Controls.Add(this.ckbEspecial);
            this.gpbInsumos.Controls.Add(this.ckbAutomotor);
            this.gpbInsumos.Controls.Add(this.ckbYale);
            this.gpbInsumos.Controls.Add(this.ckbDoblePaleta);
            this.gpbInsumos.Location = new System.Drawing.Point(4, 142);
            this.gpbInsumos.Margin = new System.Windows.Forms.Padding(2);
            this.gpbInsumos.Name = "gpbInsumos";
            this.gpbInsumos.Padding = new System.Windows.Forms.Padding(2);
            this.gpbInsumos.Size = new System.Drawing.Size(207, 209);
            this.gpbInsumos.TabIndex = 31;
            this.gpbInsumos.TabStop = false;
            this.gpbInsumos.Text = "Insumos";
            // 
            // txtDoblePaletaMON
            // 
            this.txtDoblePaletaMON.Location = new System.Drawing.Point(145, 47);
            this.txtDoblePaletaMON.Margin = new System.Windows.Forms.Padding(2);
            this.txtDoblePaletaMON.Name = "txtDoblePaletaMON";
            this.txtDoblePaletaMON.Size = new System.Drawing.Size(43, 20);
            this.txtDoblePaletaMON.TabIndex = 42;
            // 
            // txtYaleMON
            // 
            this.txtYaleMON.Location = new System.Drawing.Point(145, 65);
            this.txtYaleMON.Margin = new System.Windows.Forms.Padding(2);
            this.txtYaleMON.Name = "txtYaleMON";
            this.txtYaleMON.Size = new System.Drawing.Size(43, 20);
            this.txtYaleMON.TabIndex = 41;
            // 
            // txtAutomotorMON
            // 
            this.txtAutomotorMON.Location = new System.Drawing.Point(145, 83);
            this.txtAutomotorMON.Margin = new System.Windows.Forms.Padding(2);
            this.txtAutomotorMON.Name = "txtAutomotorMON";
            this.txtAutomotorMON.Size = new System.Drawing.Size(43, 20);
            this.txtAutomotorMON.TabIndex = 40;
            // 
            // txtEspecialMON
            // 
            this.txtEspecialMON.Location = new System.Drawing.Point(145, 101);
            this.txtEspecialMON.Margin = new System.Windows.Forms.Padding(2);
            this.txtEspecialMON.Name = "txtEspecialMON";
            this.txtEspecialMON.Size = new System.Drawing.Size(43, 20);
            this.txtEspecialMON.TabIndex = 39;
            // 
            // txtCerrojoMON
            // 
            this.txtCerrojoMON.Location = new System.Drawing.Point(145, 138);
            this.txtCerrojoMON.Margin = new System.Windows.Forms.Padding(2);
            this.txtCerrojoMON.Name = "txtCerrojoMON";
            this.txtCerrojoMON.Size = new System.Drawing.Size(43, 20);
            this.txtCerrojoMON.TabIndex = 38;
            // 
            // txtCerraduraMON
            // 
            this.txtCerraduraMON.Location = new System.Drawing.Point(145, 120);
            this.txtCerraduraMON.Margin = new System.Windows.Forms.Padding(2);
            this.txtCerraduraMON.Name = "txtCerraduraMON";
            this.txtCerraduraMON.Size = new System.Drawing.Size(43, 20);
            this.txtCerraduraMON.TabIndex = 37;
            // 
            // txtOtroMON
            // 
            this.txtOtroMON.Location = new System.Drawing.Point(145, 156);
            this.txtOtroMON.Margin = new System.Windows.Forms.Padding(2);
            this.txtOtroMON.Name = "txtOtroMON";
            this.txtOtroMON.Size = new System.Drawing.Size(43, 20);
            this.txtOtroMON.TabIndex = 36;
            // 
            // lblMontoOtro
            // 
            this.lblMontoOtro.AutoSize = true;
            this.lblMontoOtro.Location = new System.Drawing.Point(142, 31);
            this.lblMontoOtro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMontoOtro.Name = "lblMontoOtro";
            this.lblMontoOtro.Size = new System.Drawing.Size(37, 13);
            this.lblMontoOtro.TabIndex = 35;
            this.lblMontoOtro.Text = "Monto";
            // 
            // lblCant
            // 
            this.lblCant.AutoSize = true;
            this.lblCant.Location = new System.Drawing.Point(89, 31);
            this.lblCant.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCant.Name = "lblCant";
            this.lblCant.Size = new System.Drawing.Size(32, 13);
            this.lblCant.TabIndex = 34;
            this.lblCant.Text = "Cant.";
            // 
            // lblTipoInsumo
            // 
            this.lblTipoInsumo.AutoSize = true;
            this.lblTipoInsumo.Location = new System.Drawing.Point(4, 32);
            this.lblTipoInsumo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTipoInsumo.Name = "lblTipoInsumo";
            this.lblTipoInsumo.Size = new System.Drawing.Size(64, 13);
            this.lblTipoInsumo.TabIndex = 33;
            this.lblTipoInsumo.Text = "Tipo insumo";
            // 
            // txtOtroCAN
            // 
            this.txtOtroCAN.Location = new System.Drawing.Point(92, 156);
            this.txtOtroCAN.Margin = new System.Windows.Forms.Padding(2);
            this.txtOtroCAN.Name = "txtOtroCAN";
            this.txtOtroCAN.Size = new System.Drawing.Size(30, 20);
            this.txtOtroCAN.TabIndex = 30;
            // 
            // ckbOtros
            // 
            this.ckbOtros.AutoSize = true;
            this.ckbOtros.Location = new System.Drawing.Point(4, 158);
            this.ckbOtros.Margin = new System.Windows.Forms.Padding(2);
            this.ckbOtros.Name = "ckbOtros";
            this.ckbOtros.Size = new System.Drawing.Size(46, 17);
            this.ckbOtros.TabIndex = 29;
            this.ckbOtros.Text = "Otro";
            this.ckbOtros.UseVisualStyleBackColor = true;
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 462);
            this.Controls.Add(this.gpbFactura);
            this.Controls.Add(this.btnQuitarTodo);
            this.Controls.Add(this.btnReportes);
            this.Controls.Add(this.gpbActividades);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnAgregar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmInicio";
            this.Text = "Abrete Sesamo";
            this.Load += new System.EventHandler(this.frmInicio_Load);
            this.gpbActividades.ResumeLayout(false);
            this.gpbFactura.ResumeLayout(false);
            this.gpbFactura.PerformLayout();
            this.gpbInsumos.ResumeLayout(false);
            this.gpbInsumos.PerformLayout();
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
        private System.Windows.Forms.CheckBox ckbDoblePaleta;
        private System.Windows.Forms.CheckBox ckbYale;
        private System.Windows.Forms.CheckBox ckbAutomotor;
        private System.Windows.Forms.CheckBox ckbEspecial;
        private System.Windows.Forms.CheckBox ckbCerraduras;
        private System.Windows.Forms.CheckBox ckbCerrojo;
        private System.Windows.Forms.TextBox txtDoblePaletaCAN;
        private System.Windows.Forms.TextBox txtYaleCAN;
        private System.Windows.Forms.TextBox txtAutomotorCAN;
        private System.Windows.Forms.TextBox txtEspecialCAN;
        private System.Windows.Forms.TextBox txtCerraduraCAN;
        private System.Windows.Forms.TextBox txtCerrojoCAN;
        private System.Windows.Forms.GroupBox gpbActividades;
        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnQuitarTodo;
        private System.Windows.Forms.GroupBox gpbFactura;
        private System.Windows.Forms.TextBox txtOtroCAN;
        private System.Windows.Forms.CheckBox ckbOtros;
        private System.Windows.Forms.GroupBox gpbInsumos;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.TextBox txtOtroMON;
        private System.Windows.Forms.Label lblMontoOtro;
        private System.Windows.Forms.Label lblCant;
        private System.Windows.Forms.Label lblTipoInsumo;
        private System.Windows.Forms.TextBox txtDoblePaletaMON;
        private System.Windows.Forms.TextBox txtYaleMON;
        private System.Windows.Forms.TextBox txtAutomotorMON;
        private System.Windows.Forms.TextBox txtEspecialMON;
        private System.Windows.Forms.TextBox txtCerrojoMON;
        private System.Windows.Forms.TextBox txtCerraduraMON;
    }
}

