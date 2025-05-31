namespace PrevioClubDeportivo.InterfazGrafica
{
    partial class frmCobrarCuota
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCobrarCuota));
            this.picBanner = new System.Windows.Forms.PictureBox();
            this.lblCobrarCuota = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblNroComprobante = new System.Windows.Forms.Label();
            this.txtNroComprobante = new System.Windows.Forms.TextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.rbMensual = new System.Windows.Forms.RadioButton();
            this.rbDiaria = new System.Windows.Forms.RadioButton();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblVencimiento = new System.Windows.Forms.Label();
            this.dtpVencimiento = new System.Windows.Forms.DateTimePicker();
            this.lblImporte = new System.Windows.Forms.Label();
            this.txtImporte = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNroSocio = new System.Windows.Forms.Label();
            this.txtNroSocio = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCobrar = new System.Windows.Forms.Button();
            this.lblActividad = new System.Windows.Forms.Label();
            this.lblMetodoPago = new System.Windows.Forms.Label();
            this.rbEfectivo = new System.Windows.Forms.RadioButton();
            this.rbQr = new System.Windows.Forms.RadioButton();
            this.rbTarjeta = new System.Windows.Forms.RadioButton();
            this.lblCantCuotas = new System.Windows.Forms.Label();
            this.cbCuotas = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbActividad = new System.Windows.Forms.ComboBox();
            this.grpTipoPago = new System.Windows.Forms.GroupBox();
            this.grpMetodoPago = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBanner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpTipoPago.SuspendLayout();
            this.grpMetodoPago.SuspendLayout();
            this.SuspendLayout();
            // 
            // picBanner
            // 
            this.picBanner.Location = new System.Drawing.Point(-1, 0);
            this.picBanner.Name = "picBanner";
            this.picBanner.Size = new System.Drawing.Size(1035, 144);
            this.picBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBanner.TabIndex = 0;
            this.picBanner.TabStop = false;
            // 
            // lblCobrarCuota
            // 
            this.lblCobrarCuota.AutoSize = true;
            this.lblCobrarCuota.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.lblCobrarCuota.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblCobrarCuota.Location = new System.Drawing.Point(25, 170);
            this.lblCobrarCuota.Name = "lblCobrarCuota";
            this.lblCobrarCuota.Size = new System.Drawing.Size(224, 39);
            this.lblCobrarCuota.TabIndex = 2;
            this.lblCobrarCuota.Text = "Cobrar Cuota";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblFecha.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblFecha.Location = new System.Drawing.Point(775, 174);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(69, 20);
            this.lblFecha.TabIndex = 4;
            this.lblFecha.Text = "FECHA";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(850, 170);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(162, 24);
            this.dtpFecha.TabIndex = 5;
            // 
            // lblNroComprobante
            // 
            this.lblNroComprobante.AutoSize = true;
            this.lblNroComprobante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblNroComprobante.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblNroComprobante.Location = new System.Drawing.Point(678, 217);
            this.lblNroComprobante.Name = "lblNroComprobante";
            this.lblNroComprobante.Size = new System.Drawing.Size(166, 20);
            this.lblNroComprobante.TabIndex = 4;
            this.lblNroComprobante.Text = "N° COMPROBANTE";
            // 
            // txtNroComprobante
            // 
            this.txtNroComprobante.Font = new System.Drawing.Font("Gadugi", 9.75F);
            this.txtNroComprobante.Location = new System.Drawing.Point(850, 212);
            this.txtNroComprobante.Name = "txtNroComprobante";
            this.txtNroComprobante.Size = new System.Drawing.Size(162, 25);
            this.txtNroComprobante.TabIndex = 6;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblTipo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTipo.Location = new System.Drawing.Point(326, 328);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(49, 20);
            this.lblTipo.TabIndex = 4;
            this.lblTipo.Text = "TIPO";
            // 
            // rbMensual
            // 
            this.rbMensual.AutoSize = true;
            this.rbMensual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMensual.Location = new System.Drawing.Point(6, 14);
            this.rbMensual.Name = "rbMensual";
            this.rbMensual.Size = new System.Drawing.Size(90, 20);
            this.rbMensual.TabIndex = 7;
            this.rbMensual.TabStop = true;
            this.rbMensual.Text = "MENSUAL";
            this.rbMensual.UseVisualStyleBackColor = true;
            // 
            // rbDiaria
            // 
            this.rbDiaria.AutoSize = true;
            this.rbDiaria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDiaria.Location = new System.Drawing.Point(116, 14);
            this.rbDiaria.Name = "rbDiaria";
            this.rbDiaria.Size = new System.Drawing.Size(69, 20);
            this.rbDiaria.TabIndex = 7;
            this.rbDiaria.TabStop = true;
            this.rbDiaria.Text = "DIARIA";
            this.rbDiaria.UseVisualStyleBackColor = true;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblApellido.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblApellido.Location = new System.Drawing.Point(434, 284);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(96, 20);
            this.lblApellido.TabIndex = 4;
            this.lblApellido.Text = "APELLIDO";
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Gadugi", 9.75F);
            this.txtApellido.Location = new System.Drawing.Point(537, 279);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(224, 25);
            this.txtApellido.TabIndex = 6;
            // 
            // lblVencimiento
            // 
            this.lblVencimiento.AutoSize = true;
            this.lblVencimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblVencimiento.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblVencimiento.Location = new System.Drawing.Point(776, 480);
            this.lblVencimiento.Name = "lblVencimiento";
            this.lblVencimiento.Size = new System.Drawing.Size(130, 20);
            this.lblVencimiento.TabIndex = 4;
            this.lblVencimiento.Text = "VENCIMIENTO";
            // 
            // dtpVencimiento
            // 
            this.dtpVencimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.dtpVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVencimiento.Location = new System.Drawing.Point(912, 476);
            this.dtpVencimiento.Name = "dtpVencimiento";
            this.dtpVencimiento.Size = new System.Drawing.Size(100, 24);
            this.dtpVencimiento.TabIndex = 5;
            // 
            // lblImporte
            // 
            this.lblImporte.AutoSize = true;
            this.lblImporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImporte.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblImporte.Location = new System.Drawing.Point(658, 370);
            this.lblImporte.Name = "lblImporte";
            this.lblImporte.Size = new System.Drawing.Size(88, 20);
            this.lblImporte.TabIndex = 4;
            this.lblImporte.Text = "IMPORTE";
            // 
            // txtImporte
            // 
            this.txtImporte.Font = new System.Drawing.Font("Gadugi", 9.75F);
            this.txtImporte.Location = new System.Drawing.Point(753, 368);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.Size = new System.Drawing.Size(224, 25);
            this.txtImporte.TabIndex = 6;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblNombre.Location = new System.Drawing.Point(40, 284);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(85, 20);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "NOMBRE";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Gadugi", 9.75F);
            this.txtNombre.Location = new System.Drawing.Point(131, 279);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(224, 25);
            this.txtNombre.TabIndex = 6;
            // 
            // lblNroSocio
            // 
            this.lblNroSocio.AutoSize = true;
            this.lblNroSocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblNroSocio.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblNroSocio.Location = new System.Drawing.Point(37, 239);
            this.lblNroSocio.Name = "lblNroSocio";
            this.lblNroSocio.Size = new System.Drawing.Size(88, 20);
            this.lblNroSocio.TabIndex = 4;
            this.lblNroSocio.Text = "N° SOCIO";
            // 
            // txtNroSocio
            // 
            this.txtNroSocio.Font = new System.Drawing.Font("Gadugi", 9.75F);
            this.txtNroSocio.Location = new System.Drawing.Point(131, 234);
            this.txtNroSocio.Name = "txtNroSocio";
            this.txtNroSocio.Size = new System.Drawing.Size(224, 25);
            this.txtNroSocio.TabIndex = 6;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Firebrick;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(237, 522);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(138, 36);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnCobrar
            // 
            this.btnCobrar.BackColor = System.Drawing.Color.ForestGreen;
            this.btnCobrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCobrar.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnCobrar.ForeColor = System.Drawing.Color.White;
            this.btnCobrar.Location = new System.Drawing.Point(660, 522);
            this.btnCobrar.Name = "btnCobrar";
            this.btnCobrar.Size = new System.Drawing.Size(138, 36);
            this.btnCobrar.TabIndex = 8;
            this.btnCobrar.Text = "COBRAR";
            this.btnCobrar.UseVisualStyleBackColor = false;
            this.btnCobrar.Click += new System.EventHandler(this.btnCobrar_Click);
            // 
            // lblActividad
            // 
            this.lblActividad.AutoSize = true;
            this.lblActividad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblActividad.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblActividad.Location = new System.Drawing.Point(270, 373);
            this.lblActividad.Name = "lblActividad";
            this.lblActividad.Size = new System.Drawing.Size(105, 20);
            this.lblActividad.TabIndex = 4;
            this.lblActividad.Text = "ACTIVIDAD";
            // 
            // lblMetodoPago
            // 
            this.lblMetodoPago.AutoSize = true;
            this.lblMetodoPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblMetodoPago.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblMetodoPago.Location = new System.Drawing.Point(266, 435);
            this.lblMetodoPago.Name = "lblMetodoPago";
            this.lblMetodoPago.Size = new System.Drawing.Size(169, 20);
            this.lblMetodoPago.TabIndex = 10;
            this.lblMetodoPago.Text = "METODO DE PAGO";
            // 
            // rbEfectivo
            // 
            this.rbEfectivo.AutoSize = true;
            this.rbEfectivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEfectivo.Location = new System.Drawing.Point(10, 7);
            this.rbEfectivo.Name = "rbEfectivo";
            this.rbEfectivo.Size = new System.Drawing.Size(91, 20);
            this.rbEfectivo.TabIndex = 11;
            this.rbEfectivo.TabStop = true;
            this.rbEfectivo.Text = "EFECTIVO";
            this.rbEfectivo.UseVisualStyleBackColor = true;
            // 
            // rbQr
            // 
            this.rbQr.AutoSize = true;
            this.rbQr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbQr.Location = new System.Drawing.Point(137, 7);
            this.rbQr.Name = "rbQr";
            this.rbQr.Size = new System.Drawing.Size(45, 20);
            this.rbQr.TabIndex = 12;
            this.rbQr.TabStop = true;
            this.rbQr.Text = "QR";
            this.rbQr.UseVisualStyleBackColor = true;
            // 
            // rbTarjeta
            // 
            this.rbTarjeta.AutoSize = true;
            this.rbTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTarjeta.Location = new System.Drawing.Point(235, 7);
            this.rbTarjeta.Name = "rbTarjeta";
            this.rbTarjeta.Size = new System.Drawing.Size(87, 20);
            this.rbTarjeta.TabIndex = 14;
            this.rbTarjeta.TabStop = true;
            this.rbTarjeta.Text = "TARJETA";
            this.rbTarjeta.UseVisualStyleBackColor = true;
            // 
            // lblCantCuotas
            // 
            this.lblCantCuotas.AutoSize = true;
            this.lblCantCuotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblCantCuotas.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblCantCuotas.Location = new System.Drawing.Point(266, 476);
            this.lblCantCuotas.Name = "lblCantCuotas";
            this.lblCantCuotas.Size = new System.Drawing.Size(206, 20);
            this.lblCantCuotas.TabIndex = 15;
            this.lblCantCuotas.Text = "CANTIDAD DE CUOTAS";
            // 
            // cbCuotas
            // 
            this.cbCuotas.FormattingEnabled = true;
            this.cbCuotas.Location = new System.Drawing.Point(479, 475);
            this.cbCuotas.Name = "cbCuotas";
            this.cbCuotas.Size = new System.Drawing.Size(70, 21);
            this.cbCuotas.TabIndex = 16;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(1035, 144);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(1035, 144);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1035, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // cbActividad
            // 
            this.cbActividad.FormattingEnabled = true;
            this.cbActividad.Location = new System.Drawing.Point(393, 368);
            this.cbActividad.Name = "cbActividad";
            this.cbActividad.Size = new System.Drawing.Size(224, 21);
            this.cbActividad.TabIndex = 18;
            // 
            // grpTipoPago
            // 
            this.grpTipoPago.Controls.Add(this.rbDiaria);
            this.grpTipoPago.Controls.Add(this.rbMensual);
            this.grpTipoPago.Location = new System.Drawing.Point(381, 314);
            this.grpTipoPago.Name = "grpTipoPago";
            this.grpTipoPago.Size = new System.Drawing.Size(191, 34);
            this.grpTipoPago.TabIndex = 19;
            this.grpTipoPago.TabStop = false;
            // 
            // grpMetodoPago
            // 
            this.grpMetodoPago.Controls.Add(this.rbTarjeta);
            this.grpMetodoPago.Controls.Add(this.rbQr);
            this.grpMetodoPago.Controls.Add(this.rbEfectivo);
            this.grpMetodoPago.Location = new System.Drawing.Point(448, 429);
            this.grpMetodoPago.Name = "grpMetodoPago";
            this.grpMetodoPago.Size = new System.Drawing.Size(332, 33);
            this.grpMetodoPago.TabIndex = 20;
            this.grpMetodoPago.TabStop = false;
            // 
            // frmCobrarCuota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1034, 591);
            this.Controls.Add(this.grpMetodoPago);
            this.Controls.Add(this.grpTipoPago);
            this.Controls.Add(this.cbActividad);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbCuotas);
            this.Controls.Add(this.lblCantCuotas);
            this.Controls.Add(this.lblMetodoPago);
            this.Controls.Add(this.btnCobrar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtImporte);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNroSocio);
            this.Controls.Add(this.txtNroComprobante);
            this.Controls.Add(this.dtpVencimiento);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblImporte);
            this.Controls.Add(this.lblVencimiento);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblActividad);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblNroSocio);
            this.Controls.Add(this.lblNroComprobante);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblCobrarCuota);
            this.Controls.Add(this.picBanner);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1050, 630);
            this.MinimumSize = new System.Drawing.Size(1050, 630);
            this.Name = "frmCobrarCuota";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cobrar Cuota";
            ((System.ComponentModel.ISupportInitialize)(this.picBanner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpTipoPago.ResumeLayout(false);
            this.grpTipoPago.PerformLayout();
            this.grpMetodoPago.ResumeLayout(false);
            this.grpMetodoPago.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBanner;
        private System.Windows.Forms.Label lblCobrarCuota;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblNroComprobante;
        private System.Windows.Forms.TextBox txtNroComprobante;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.RadioButton rbMensual;
        private System.Windows.Forms.RadioButton rbDiaria;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblVencimiento;
        private System.Windows.Forms.DateTimePicker dtpVencimiento;
        private System.Windows.Forms.Label lblImporte;
        private System.Windows.Forms.TextBox txtImporte;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNroSocio;
        private System.Windows.Forms.TextBox txtNroSocio;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCobrar;
        private System.Windows.Forms.Label lblActividad;
        private System.Windows.Forms.Label lblMetodoPago;
        private System.Windows.Forms.RadioButton rbEfectivo;
        private System.Windows.Forms.RadioButton rbQr;
        private System.Windows.Forms.RadioButton rbTarjeta;
        private System.Windows.Forms.Label lblCantCuotas;
        private System.Windows.Forms.ComboBox cbCuotas;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbActividad;
        private System.Windows.Forms.GroupBox grpTipoPago;
        private System.Windows.Forms.GroupBox grpMetodoPago;
    }
}