namespace ModuloImpresion
{
    partial class FrmPrincipal
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
            this.btnImprimir = new System.Windows.Forms.Button();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.lblOrden = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.txtEmpresa = new System.Windows.Forms.TextBox();
            this.txtOrden = new System.Windows.Forms.TextBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.txtAncho = new System.Windows.Forms.TextBox();
            this.lblAncho = new System.Windows.Forms.Label();
            this.txtAlto = new System.Windows.Forms.TextBox();
            this.lblAlto = new System.Windows.Forms.Label();
            this.txtEtiqXRollo = new System.Windows.Forms.TextBox();
            this.lblEtiqXRollo = new System.Windows.Forms.Label();
            this.txtRollosXCaja = new System.Windows.Forms.TextBox();
            this.lblRollosXCaja = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbMaterial = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbPoliamidaSatin = new System.Windows.Forms.ComboBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblPoliamidaSatin = new System.Windows.Forms.Label();
            this.lblBuje = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblLargo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBuje = new System.Windows.Forms.ComboBox();
            this.nCantCopias = new System.Windows.Forms.NumericUpDown();
            this.cmbRibbon = new System.Windows.Forms.ComboBox();
            this.lblComposicion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nCantCopias)).BeginInit();
            this.SuspendLayout();
            // 
            // btnImprimir
            // 
            this.btnImprimir.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Location = new System.Drawing.Point(151, 445);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(207, 67);
            this.btnImprimir.TabIndex = 0;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpresa.Location = new System.Drawing.Point(114, 109);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(77, 23);
            this.lblEmpresa.TabIndex = 1;
            this.lblEmpresa.Text = "Empresa:";
            // 
            // lblOrden
            // 
            this.lblOrden.AutoSize = true;
            this.lblOrden.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrden.Location = new System.Drawing.Point(110, 148);
            this.lblOrden.Name = "lblOrden";
            this.lblOrden.Size = new System.Drawing.Size(81, 23);
            this.lblOrden.TabIndex = 2;
            this.lblOrden.Text = "Orden N°:";
            this.lblOrden.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(147, 185);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(44, 23);
            this.lblTipo.TabIndex = 4;
            this.lblTipo.Text = "Tipo:";
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.Location = new System.Drawing.Point(227, 112);
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.Size = new System.Drawing.Size(190, 20);
            this.txtEmpresa.TabIndex = 5;
            // 
            // txtOrden
            // 
            this.txtOrden.Location = new System.Drawing.Point(227, 148);
            this.txtOrden.Name = "txtOrden";
            this.txtOrden.Size = new System.Drawing.Size(190, 20);
            this.txtOrden.TabIndex = 6;
            this.txtOrden.TextChanged += new System.EventHandler(this.txtOrden_TextChanged);
            this.txtOrden.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOrden_KeyPress);
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(227, 190);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(190, 20);
            this.txtTipo.TabIndex = 8;
            // 
            // txtAncho
            // 
            this.txtAncho.Location = new System.Drawing.Point(227, 233);
            this.txtAncho.Name = "txtAncho";
            this.txtAncho.Size = new System.Drawing.Size(190, 20);
            this.txtAncho.TabIndex = 10;
            this.txtAncho.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAncho_KeyPress);
            // 
            // lblAncho
            // 
            this.lblAncho.AutoSize = true;
            this.lblAncho.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAncho.Location = new System.Drawing.Point(132, 228);
            this.lblAncho.Name = "lblAncho";
            this.lblAncho.Size = new System.Drawing.Size(59, 23);
            this.lblAncho.TabIndex = 9;
            this.lblAncho.Text = "Ancho:";
            this.lblAncho.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtAlto
            // 
            this.txtAlto.Location = new System.Drawing.Point(227, 264);
            this.txtAlto.Name = "txtAlto";
            this.txtAlto.Size = new System.Drawing.Size(190, 20);
            this.txtAlto.TabIndex = 12;
            this.txtAlto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAlto_KeyPress);
            // 
            // lblAlto
            // 
            this.lblAlto.AutoSize = true;
            this.lblAlto.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlto.Location = new System.Drawing.Point(147, 261);
            this.lblAlto.Name = "lblAlto";
            this.lblAlto.Size = new System.Drawing.Size(39, 23);
            this.lblAlto.TabIndex = 11;
            this.lblAlto.Text = "Alto:";
            // 
            // txtEtiqXRollo
            // 
            this.txtEtiqXRollo.Location = new System.Drawing.Point(227, 304);
            this.txtEtiqXRollo.Name = "txtEtiqXRollo";
            this.txtEtiqXRollo.Size = new System.Drawing.Size(190, 20);
            this.txtEtiqXRollo.TabIndex = 14;
            this.txtEtiqXRollo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEtiqXRollo_KeyPress);
            // 
            // lblEtiqXRollo
            // 
            this.lblEtiqXRollo.AutoSize = true;
            this.lblEtiqXRollo.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtiqXRollo.Location = new System.Drawing.Point(115, 299);
            this.lblEtiqXRollo.Name = "lblEtiqXRollo";
            this.lblEtiqXRollo.Size = new System.Drawing.Size(94, 23);
            this.lblEtiqXRollo.TabIndex = 13;
            this.lblEtiqXRollo.Text = "Etiq. x Rollo:";
            this.lblEtiqXRollo.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtRollosXCaja
            // 
            this.txtRollosXCaja.Location = new System.Drawing.Point(227, 343);
            this.txtRollosXCaja.Name = "txtRollosXCaja";
            this.txtRollosXCaja.Size = new System.Drawing.Size(190, 20);
            this.txtRollosXCaja.TabIndex = 16;
            this.txtRollosXCaja.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRollosXCaja_KeyPress);
            // 
            // lblRollosXCaja
            // 
            this.lblRollosXCaja.AutoSize = true;
            this.lblRollosXCaja.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRollosXCaja.Location = new System.Drawing.Point(104, 338);
            this.lblRollosXCaja.Name = "lblRollosXCaja";
            this.lblRollosXCaja.Size = new System.Drawing.Size(105, 23);
            this.lblRollosXCaja.TabIndex = 15;
            this.lblRollosXCaja.Text = "Rollos x Caja:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(147, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 23);
            this.label3.TabIndex = 17;
            this.label3.Text = "Material:";
            // 
            // cmbMaterial
            // 
            this.cmbMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaterial.FormattingEnabled = true;
            this.cmbMaterial.Items.AddRange(new object[] {
            "Etiquetas",
            "Ribbon",
            "Poliamida / Satin"});
            this.cmbMaterial.Location = new System.Drawing.Point(227, 23);
            this.cmbMaterial.Name = "cmbMaterial";
            this.cmbMaterial.Size = new System.Drawing.Size(178, 21);
            this.cmbMaterial.TabIndex = 18;
            this.cmbMaterial.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(199, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(159, 23);
            this.label9.TabIndex = 19;
            this.label9.Text = "*ESCRIBIR SIN TILDE";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // cmbPoliamidaSatin
            // 
            this.cmbPoliamidaSatin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPoliamidaSatin.FormattingEnabled = true;
            this.cmbPoliamidaSatin.Items.AddRange(new object[] {
            "Poliamida",
            "Satin"});
            this.cmbPoliamidaSatin.Location = new System.Drawing.Point(227, 190);
            this.cmbPoliamidaSatin.Name = "cmbPoliamidaSatin";
            this.cmbPoliamidaSatin.Size = new System.Drawing.Size(178, 21);
            this.cmbPoliamidaSatin.TabIndex = 20;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(227, 343);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(190, 20);
            this.txtCantidad.TabIndex = 22;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // lblPoliamidaSatin
            // 
            this.lblPoliamidaSatin.AutoSize = true;
            this.lblPoliamidaSatin.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoliamidaSatin.Location = new System.Drawing.Point(49, 190);
            this.lblPoliamidaSatin.Name = "lblPoliamidaSatin";
            this.lblPoliamidaSatin.Size = new System.Drawing.Size(142, 23);
            this.lblPoliamidaSatin.TabIndex = 23;
            this.lblPoliamidaSatin.Text = "Poliamida o Satin?:";
            // 
            // lblBuje
            // 
            this.lblBuje.AutoSize = true;
            this.lblBuje.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuje.Location = new System.Drawing.Point(141, 299);
            this.lblBuje.Name = "lblBuje";
            this.lblBuje.Size = new System.Drawing.Size(45, 23);
            this.lblBuje.TabIndex = 24;
            this.lblBuje.Text = "Buje:";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(132, 340);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(76, 23);
            this.lblCantidad.TabIndex = 25;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // lblLargo
            // 
            this.lblLargo.AutoSize = true;
            this.lblLargo.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLargo.Location = new System.Drawing.Point(136, 261);
            this.lblLargo.Name = "lblLargo";
            this.lblLargo.Size = new System.Drawing.Size(55, 23);
            this.lblLargo.TabIndex = 26;
            this.lblLargo.Text = "Largo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 384);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 23);
            this.label1.TabIndex = 28;
            this.label1.Text = "Cantidad de Cajas:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmbBuje
            // 
            this.cmbBuje.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBuje.FormattingEnabled = true;
            this.cmbBuje.Items.AddRange(new object[] {
            "25",
            "40",
            "76"});
            this.cmbBuje.Location = new System.Drawing.Point(227, 303);
            this.cmbBuje.Name = "cmbBuje";
            this.cmbBuje.Size = new System.Drawing.Size(190, 21);
            this.cmbBuje.TabIndex = 29;
            // 
            // nCantCopias
            // 
            this.nCantCopias.Location = new System.Drawing.Point(227, 387);
            this.nCantCopias.Name = "nCantCopias";
            this.nCantCopias.Size = new System.Drawing.Size(84, 20);
            this.nCantCopias.TabIndex = 30;
            // 
            // cmbRibbon
            // 
            this.cmbRibbon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRibbon.FormattingEnabled = true;
            this.cmbRibbon.Items.AddRange(new object[] {
            "WAO",
            "WAI",
            "WRO",
            "WRI",
            "RSO",
            "RSI",
            "RDO",
            "RDI"});
            this.cmbRibbon.Location = new System.Drawing.Point(227, 190);
            this.cmbRibbon.Name = "cmbRibbon";
            this.cmbRibbon.Size = new System.Drawing.Size(178, 21);
            this.cmbRibbon.TabIndex = 31;
            // 
            // lblComposicion
            // 
            this.lblComposicion.AutoSize = true;
            this.lblComposicion.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComposicion.Location = new System.Drawing.Point(81, 190);
            this.lblComposicion.Name = "lblComposicion";
            this.lblComposicion.Size = new System.Drawing.Size(105, 23);
            this.lblComposicion.TabIndex = 32;
            this.lblComposicion.Text = "Composición:";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 555);
            this.Controls.Add(this.lblComposicion);
            this.Controls.Add(this.cmbRibbon);
            this.Controls.Add(this.nCantCopias);
            this.Controls.Add(this.cmbBuje);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblLargo);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblBuje);
            this.Controls.Add(this.cmbPoliamidaSatin);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbMaterial);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblRollosXCaja);
            this.Controls.Add(this.lblEtiqXRollo);
            this.Controls.Add(this.txtAlto);
            this.Controls.Add(this.lblAlto);
            this.Controls.Add(this.txtAncho);
            this.Controls.Add(this.lblAncho);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.txtOrden);
            this.Controls.Add(this.txtEmpresa);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblOrden);
            this.Controls.Add(this.lblEmpresa);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtRollosXCaja);
            this.Controls.Add(this.txtEtiqXRollo);
            this.Controls.Add(this.lblPoliamidaSatin);
            this.Name = "FrmPrincipal";
            this.Text = "Módulo de Impresión";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nCantCopias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.Label lblOrden;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.TextBox txtEmpresa;
        private System.Windows.Forms.TextBox txtOrden;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.TextBox txtAncho;
        private System.Windows.Forms.Label lblAncho;
        private System.Windows.Forms.TextBox txtAlto;
        private System.Windows.Forms.Label lblAlto;
        private System.Windows.Forms.TextBox txtEtiqXRollo;
        private System.Windows.Forms.Label lblEtiqXRollo;
        private System.Windows.Forms.TextBox txtRollosXCaja;
        private System.Windows.Forms.Label lblRollosXCaja;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbMaterial;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbPoliamidaSatin;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblPoliamidaSatin;
        private System.Windows.Forms.Label lblBuje;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblLargo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBuje;
        private System.Windows.Forms.NumericUpDown nCantCopias;
        private System.Windows.Forms.ComboBox cmbRibbon;
        private System.Windows.Forms.Label lblComposicion;
    }
}

