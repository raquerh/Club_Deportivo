﻿namespace PrevioClubDeportivo.InterfazGrafica
{
    partial class frmAptoFisico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAptoFisico));
            this.picBanner = new System.Windows.Forms.PictureBox();
            this.lblNroSocio = new System.Windows.Forms.Label();
            this.txtNroSocio = new System.Windows.Forms.TextBox();
            this.lblEsApto = new System.Windows.Forms.Label();
            this.lstEsApto = new System.Windows.Forms.ListBox();
            this.lblVtoAptoFisico = new System.Windows.Forms.Label();
            this.dtpVencimiento = new System.Windows.Forms.DateTimePicker();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBanner)).BeginInit();
            this.SuspendLayout();
            // 
            // picBanner
            // 
            this.picBanner.Image = ((System.Drawing.Image)(resources.GetObject("picBanner.Image")));
            this.picBanner.Location = new System.Drawing.Point(-1, 0);
            this.picBanner.Name = "picBanner";
            this.picBanner.Size = new System.Drawing.Size(1035, 144);
            this.picBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBanner.TabIndex = 0;
            this.picBanner.TabStop = false;
            // 
            // lblNroSocio
            // 
            this.lblNroSocio.AutoSize = true;
            this.lblNroSocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroSocio.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblNroSocio.Location = new System.Drawing.Point(309, 238);
            this.lblNroSocio.Name = "lblNroSocio";
            this.lblNroSocio.Size = new System.Drawing.Size(130, 29);
            this.lblNroSocio.TabIndex = 4;
            this.lblNroSocio.Text = "N° SOCIO";
            // 
            // txtNroSocio
            // 
            this.txtNroSocio.BackColor = System.Drawing.Color.White;
            this.txtNroSocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNroSocio.Location = new System.Drawing.Point(457, 235);
            this.txtNroSocio.Name = "txtNroSocio";
            this.txtNroSocio.ReadOnly = true;
            this.txtNroSocio.Size = new System.Drawing.Size(167, 35);
            this.txtNroSocio.TabIndex = 5;
            this.txtNroSocio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblEsApto
            // 
            this.lblEsApto.AutoSize = true;
            this.lblEsApto.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEsApto.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblEsApto.Location = new System.Drawing.Point(315, 307);
            this.lblEsApto.Name = "lblEsApto";
            this.lblEsApto.Size = new System.Drawing.Size(124, 29);
            this.lblEsApto.TabIndex = 4;
            this.lblEsApto.Text = "ES APTO";
            // 
            // lstEsApto
            // 
            this.lstEsApto.Font = new System.Drawing.Font("Gadugi", 14.25F);
            this.lstEsApto.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lstEsApto.FormattingEnabled = true;
            this.lstEsApto.ItemHeight = 22;
            this.lstEsApto.Location = new System.Drawing.Point(454, 307);
            this.lstEsApto.Name = "lstEsApto";
            this.lstEsApto.Size = new System.Drawing.Size(179, 26);
            this.lstEsApto.TabIndex = 6;
            // 
            // lblVtoAptoFisico
            // 
            this.lblVtoAptoFisico.AutoSize = true;
            this.lblVtoAptoFisico.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVtoAptoFisico.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblVtoAptoFisico.Location = new System.Drawing.Point(248, 411);
            this.lblVtoAptoFisico.Name = "lblVtoAptoFisico";
            this.lblVtoAptoFisico.Size = new System.Drawing.Size(191, 29);
            this.lblVtoAptoFisico.TabIndex = 4;
            this.lblVtoAptoFisico.Text = "VENCIMIENTO";
            // 
            // dtpVencimiento
            // 
            this.dtpVencimiento.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.dtpVencimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpVencimiento.Location = new System.Drawing.Point(454, 411);
            this.dtpVencimiento.MinDate = new System.DateTime(2025, 1, 1, 0, 0, 0, 0);
            this.dtpVencimiento.Name = "dtpVencimiento";
            this.dtpVencimiento.Size = new System.Drawing.Size(179, 26);
            this.dtpVencimiento.TabIndex = 7;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Firebrick;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(178, 516);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(138, 36);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.ForestGreen;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(665, 516);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(138, 36);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTitulo.Location = new System.Drawing.Point(12, 163);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(304, 39);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Cargar Apto Físico";
            // 
            // frmAptoFisico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1034, 591);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.dtpVencimiento);
            this.Controls.Add(this.lstEsApto);
            this.Controls.Add(this.txtNroSocio);
            this.Controls.Add(this.lblVtoAptoFisico);
            this.Controls.Add(this.lblEsApto);
            this.Controls.Add(this.lblNroSocio);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.picBanner);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1050, 630);
            this.MinimumSize = new System.Drawing.Size(1050, 630);
            this.Name = "frmAptoFisico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AptoFisico";
            this.Load += new System.EventHandler(this.frmAptoFisico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBanner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBanner;
        private System.Windows.Forms.Label lblNroSocio;
        private System.Windows.Forms.TextBox txtNroSocio;
        private System.Windows.Forms.Label lblEsApto;
        private System.Windows.Forms.ListBox lstEsApto;
        private System.Windows.Forms.Label lblVtoAptoFisico;
        private System.Windows.Forms.DateTimePicker dtpVencimiento;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblTitulo;
    }
}