namespace PaymentFeeCalculator
{
    partial class frmMain
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClip = new System.Windows.Forms.Button();
            this.btnMercadoPago = new System.Windows.Forms.Button();
            this.btnMercadoLibre = new System.Windows.Forms.Button();
            this.btnSenorPago = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gbCalculadoraComisiones = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCantidadARecibir = new System.Windows.Forms.NumericUpDown();
            this.txtComisionAPagar = new System.Windows.Forms.NumericUpDown();
            this.txtCantidadPagada = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCantidadACobrar = new System.Windows.Forms.NumericUpDown();
            this.txtCantidadDeseada = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.gbComisiones = new System.Windows.Forms.GroupBox();
            this.panelMSI = new System.Windows.Forms.Panel();
            this.rbTresMSI = new System.Windows.Forms.RadioButton();
            this.rbSeisMSI = new System.Windows.Forms.RadioButton();
            this.rbDoceMSI = new System.Windows.Forms.RadioButton();
            this.rbNueveMSI = new System.Windows.Forms.RadioButton();
            this.cbMSI = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTarifaFija = new System.Windows.Forms.TextBox();
            this.txtTarifaPorcentaje = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPaypal = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gbCalculadoraComisiones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidadARecibir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComisionAPagar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidadPagada)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidadACobrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidadDeseada)).BeginInit();
            this.gbComisiones.SuspendLayout();
            this.panelMSI.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(78)))), ((int)(((byte)(122)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(171, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(762, 76);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10);
            this.label1.Size = new System.Drawing.Size(762, 76);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculadora de comisiones de pago";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(78)))), ((int)(((byte)(122)))));
            this.panel2.Controls.Add(this.btnClip);
            this.panel2.Controls.Add(this.btnMercadoPago);
            this.panel2.Controls.Add(this.btnMercadoLibre);
            this.panel2.Controls.Add(this.btnSenorPago);
            this.panel2.Controls.Add(this.btnPaypal);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(174, 511);
            this.panel2.TabIndex = 1;
            // 
            // btnClip
            // 
            this.btnClip.BackgroundImage = global::PaymentFeeCalculator.Properties.Resources.logo_clip;
            this.btnClip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClip.Location = new System.Drawing.Point(12, 380);
            this.btnClip.Name = "btnClip";
            this.btnClip.Size = new System.Drawing.Size(152, 45);
            this.btnClip.TabIndex = 5;
            this.btnClip.UseVisualStyleBackColor = true;
            this.btnClip.Click += new System.EventHandler(this.btnClip_Click);
            // 
            // btnMercadoPago
            // 
            this.btnMercadoPago.BackgroundImage = global::PaymentFeeCalculator.Properties.Resources.logo_mercadopago;
            this.btnMercadoPago.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMercadoPago.Location = new System.Drawing.Point(11, 329);
            this.btnMercadoPago.Name = "btnMercadoPago";
            this.btnMercadoPago.Size = new System.Drawing.Size(152, 45);
            this.btnMercadoPago.TabIndex = 4;
            this.btnMercadoPago.UseVisualStyleBackColor = true;
            this.btnMercadoPago.Click += new System.EventHandler(this.btnMercadoPago_Click);
            // 
            // btnMercadoLibre
            // 
            this.btnMercadoLibre.BackgroundImage = global::PaymentFeeCalculator.Properties.Resources.logo_mercadolibre;
            this.btnMercadoLibre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMercadoLibre.Location = new System.Drawing.Point(11, 278);
            this.btnMercadoLibre.Name = "btnMercadoLibre";
            this.btnMercadoLibre.Size = new System.Drawing.Size(152, 45);
            this.btnMercadoLibre.TabIndex = 3;
            this.btnMercadoLibre.UseVisualStyleBackColor = true;
            this.btnMercadoLibre.Click += new System.EventHandler(this.btnMercadoLibre_Click);
            // 
            // btnSenorPago
            // 
            this.btnSenorPago.BackgroundImage = global::PaymentFeeCalculator.Properties.Resources.logo_senor;
            this.btnSenorPago.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSenorPago.Location = new System.Drawing.Point(11, 227);
            this.btnSenorPago.Name = "btnSenorPago";
            this.btnSenorPago.Size = new System.Drawing.Size(152, 45);
            this.btnSenorPago.TabIndex = 2;
            this.btnSenorPago.UseVisualStyleBackColor = true;
            this.btnSenorPago.Click += new System.EventHandler(this.btnSenorPago_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(174, 153);
            this.panel3.TabIndex = 0;
            // 
            // gbCalculadoraComisiones
            // 
            this.gbCalculadoraComisiones.Controls.Add(this.splitContainer1);
            this.gbCalculadoraComisiones.Location = new System.Drawing.Point(180, 176);
            this.gbCalculadoraComisiones.Name = "gbCalculadoraComisiones";
            this.gbCalculadoraComisiones.Size = new System.Drawing.Size(753, 335);
            this.gbCalculadoraComisiones.TabIndex = 2;
            this.gbCalculadoraComisiones.TabStop = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 16);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Size = new System.Drawing.Size(747, 316);
            this.splitContainer1.SplitterDistance = 370;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCantidadARecibir);
            this.groupBox1.Controls.Add(this.txtComisionAPagar);
            this.groupBox1.Controls.Add(this.txtCantidadPagada);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 316);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calculadora De Comisiones";
            // 
            // txtCantidadARecibir
            // 
            this.txtCantidadARecibir.DecimalPlaces = 2;
            this.txtCantidadARecibir.Enabled = false;
            this.txtCantidadARecibir.Increment = new decimal(new int[] {
            10,
            0,
            0,
            131072});
            this.txtCantidadARecibir.Location = new System.Drawing.Point(136, 155);
            this.txtCantidadARecibir.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.txtCantidadARecibir.Name = "txtCantidadARecibir";
            this.txtCantidadARecibir.Size = new System.Drawing.Size(144, 20);
            this.txtCantidadARecibir.TabIndex = 8;
            this.txtCantidadARecibir.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCantidadARecibir.ThousandsSeparator = true;
            // 
            // txtComisionAPagar
            // 
            this.txtComisionAPagar.DecimalPlaces = 2;
            this.txtComisionAPagar.Enabled = false;
            this.txtComisionAPagar.Increment = new decimal(new int[] {
            10,
            0,
            0,
            131072});
            this.txtComisionAPagar.Location = new System.Drawing.Point(136, 122);
            this.txtComisionAPagar.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.txtComisionAPagar.Name = "txtComisionAPagar";
            this.txtComisionAPagar.Size = new System.Drawing.Size(144, 20);
            this.txtComisionAPagar.TabIndex = 7;
            this.txtComisionAPagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtComisionAPagar.ThousandsSeparator = true;
            // 
            // txtCantidadPagada
            // 
            this.txtCantidadPagada.DecimalPlaces = 2;
            this.txtCantidadPagada.Increment = new decimal(new int[] {
            10,
            0,
            0,
            131072});
            this.txtCantidadPagada.Location = new System.Drawing.Point(136, 89);
            this.txtCantidadPagada.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.txtCantidadPagada.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.txtCantidadPagada.Name = "txtCantidadPagada";
            this.txtCantidadPagada.Size = new System.Drawing.Size(144, 20);
            this.txtCantidadPagada.TabIndex = 6;
            this.txtCantidadPagada.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCantidadPagada.ThousandsSeparator = true;
            this.txtCantidadPagada.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.txtCantidadPagada.ValueChanged += new System.EventHandler(this.txtCantidadPagada_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Y usted recibirá: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "La comisión es: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Si una persona le paga: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCantidadACobrar);
            this.groupBox2.Controls.Add(this.txtCantidadDeseada);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(373, 316);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Calculadora Inversa De Comisiones";
            // 
            // txtCantidadACobrar
            // 
            this.txtCantidadACobrar.DecimalPlaces = 2;
            this.txtCantidadACobrar.Enabled = false;
            this.txtCantidadACobrar.Increment = new decimal(new int[] {
            10,
            0,
            0,
            131072});
            this.txtCantidadACobrar.Location = new System.Drawing.Point(160, 124);
            this.txtCantidadACobrar.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.txtCantidadACobrar.Name = "txtCantidadACobrar";
            this.txtCantidadACobrar.Size = new System.Drawing.Size(144, 20);
            this.txtCantidadACobrar.TabIndex = 8;
            this.txtCantidadACobrar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCantidadACobrar.ThousandsSeparator = true;
            // 
            // txtCantidadDeseada
            // 
            this.txtCantidadDeseada.DecimalPlaces = 2;
            this.txtCantidadDeseada.Increment = new decimal(new int[] {
            10,
            0,
            0,
            131072});
            this.txtCantidadDeseada.Location = new System.Drawing.Point(160, 86);
            this.txtCantidadDeseada.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.txtCantidadDeseada.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.txtCantidadDeseada.Name = "txtCantidadDeseada";
            this.txtCantidadDeseada.Size = new System.Drawing.Size(144, 20);
            this.txtCantidadDeseada.TabIndex = 7;
            this.txtCantidadDeseada.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCantidadDeseada.ThousandsSeparator = true;
            this.txtCantidadDeseada.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.txtCantidadDeseada.ValueChanged += new System.EventHandler(this.txtCantidadDeseada_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Una persona deberá pagarle: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(88, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Para recibir: ";
            // 
            // gbComisiones
            // 
            this.gbComisiones.Controls.Add(this.panelMSI);
            this.gbComisiones.Controls.Add(this.cbMSI);
            this.gbComisiones.Controls.Add(this.label9);
            this.gbComisiones.Controls.Add(this.txtTarifaFija);
            this.gbComisiones.Controls.Add(this.txtTarifaPorcentaje);
            this.gbComisiones.Controls.Add(this.label8);
            this.gbComisiones.Controls.Add(this.label5);
            this.gbComisiones.Location = new System.Drawing.Point(180, 79);
            this.gbComisiones.Name = "gbComisiones";
            this.gbComisiones.Size = new System.Drawing.Size(753, 107);
            this.gbComisiones.TabIndex = 3;
            this.gbComisiones.TabStop = false;
            this.gbComisiones.Text = "Ingrese el % de comisión del proveedor de pago";
            // 
            // panelMSI
            // 
            this.panelMSI.Controls.Add(this.rbTresMSI);
            this.panelMSI.Controls.Add(this.rbSeisMSI);
            this.panelMSI.Controls.Add(this.rbDoceMSI);
            this.panelMSI.Controls.Add(this.rbNueveMSI);
            this.panelMSI.Location = new System.Drawing.Point(386, 34);
            this.panelMSI.Name = "panelMSI";
            this.panelMSI.Size = new System.Drawing.Size(364, 65);
            this.panelMSI.TabIndex = 15;
            // 
            // rbTresMSI
            // 
            this.rbTresMSI.AutoSize = true;
            this.rbTresMSI.Location = new System.Drawing.Point(16, 16);
            this.rbTresMSI.Name = "rbTresMSI";
            this.rbTresMSI.Size = new System.Drawing.Size(65, 17);
            this.rbTresMSI.TabIndex = 10;
            this.rbTresMSI.TabStop = true;
            this.rbTresMSI.Text = "3 MSI = ";
            this.rbTresMSI.UseVisualStyleBackColor = true;
            this.rbTresMSI.Click += new System.EventHandler(this.RadioButton_Click);
            // 
            // rbSeisMSI
            // 
            this.rbSeisMSI.AutoSize = true;
            this.rbSeisMSI.Location = new System.Drawing.Point(16, 41);
            this.rbSeisMSI.Name = "rbSeisMSI";
            this.rbSeisMSI.Size = new System.Drawing.Size(65, 17);
            this.rbSeisMSI.TabIndex = 11;
            this.rbSeisMSI.TabStop = true;
            this.rbSeisMSI.Text = "6 MSI = ";
            this.rbSeisMSI.UseVisualStyleBackColor = true;
            this.rbSeisMSI.Click += new System.EventHandler(this.RadioButton_Click);
            // 
            // rbDoceMSI
            // 
            this.rbDoceMSI.AutoSize = true;
            this.rbDoceMSI.Location = new System.Drawing.Point(167, 41);
            this.rbDoceMSI.Name = "rbDoceMSI";
            this.rbDoceMSI.Size = new System.Drawing.Size(71, 17);
            this.rbDoceMSI.TabIndex = 13;
            this.rbDoceMSI.TabStop = true;
            this.rbDoceMSI.Text = "12 MSI = ";
            this.rbDoceMSI.UseVisualStyleBackColor = true;
            this.rbDoceMSI.Click += new System.EventHandler(this.RadioButton_Click);
            // 
            // rbNueveMSI
            // 
            this.rbNueveMSI.AutoSize = true;
            this.rbNueveMSI.Location = new System.Drawing.Point(167, 16);
            this.rbNueveMSI.Name = "rbNueveMSI";
            this.rbNueveMSI.Size = new System.Drawing.Size(65, 17);
            this.rbNueveMSI.TabIndex = 12;
            this.rbNueveMSI.TabStop = true;
            this.rbNueveMSI.Text = "9 MSI = ";
            this.rbNueveMSI.UseVisualStyleBackColor = true;
            this.rbNueveMSI.Click += new System.EventHandler(this.RadioButton_Click);
            // 
            // cbMSI
            // 
            this.cbMSI.AutoSize = true;
            this.cbMSI.Location = new System.Drawing.Point(386, 19);
            this.cbMSI.Name = "cbMSI";
            this.cbMSI.Size = new System.Drawing.Size(107, 17);
            this.cbMSI.TabIndex = 14;
            this.cbMSI.Text = "Meses sin interes";
            this.cbMSI.UseVisualStyleBackColor = true;
            this.cbMSI.CheckedChanged += new System.EventHandler(this.cbMSI_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.OrangeRed;
            this.label9.Location = new System.Drawing.Point(11, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(280, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Nota: El sistema agrega el IVA automáticamente";
            // 
            // txtTarifaFija
            // 
            this.txtTarifaFija.Location = new System.Drawing.Point(161, 59);
            this.txtTarifaFija.Name = "txtTarifaFija";
            this.txtTarifaFija.ReadOnly = true;
            this.txtTarifaFija.Size = new System.Drawing.Size(100, 20);
            this.txtTarifaFija.TabIndex = 7;
            this.txtTarifaFija.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumber_KeyPress);
            // 
            // txtTarifaPorcentaje
            // 
            this.txtTarifaPorcentaje.Location = new System.Drawing.Point(161, 30);
            this.txtTarifaPorcentaje.Name = "txtTarifaPorcentaje";
            this.txtTarifaPorcentaje.ReadOnly = true;
            this.txtTarifaPorcentaje.Size = new System.Drawing.Size(100, 20);
            this.txtTarifaPorcentaje.TabIndex = 6;
            this.txtTarifaPorcentaje.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumber_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(84, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Tarifa fija ($): ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Porcentaje del proveedor (%): ";
            // 
            // btnPaypal
            // 
            this.btnPaypal.BackgroundImage = global::PaymentFeeCalculator.Properties.Resources.logo_paypal;
            this.btnPaypal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPaypal.Location = new System.Drawing.Point(12, 176);
            this.btnPaypal.Name = "btnPaypal";
            this.btnPaypal.Size = new System.Drawing.Size(152, 45);
            this.btnPaypal.TabIndex = 1;
            this.btnPaypal.UseVisualStyleBackColor = true;
            this.btnPaypal.Click += new System.EventHandler(this.btnPaypal_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(934, 511);
            this.Controls.Add(this.gbComisiones);
            this.Controls.Add(this.gbCalculadoraComisiones);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(950, 550);
            this.MinimumSize = new System.Drawing.Size(950, 550);
            this.Name = "frmMain";
            this.Text = "Calculadora De Comisiones De Pago";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.gbCalculadoraComisiones.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidadARecibir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtComisionAPagar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidadPagada)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidadACobrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidadDeseada)).EndInit();
            this.gbComisiones.ResumeLayout(false);
            this.gbComisiones.PerformLayout();
            this.panelMSI.ResumeLayout(false);
            this.panelMSI.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnMercadoPago;
        private System.Windows.Forms.Button btnMercadoLibre;
        private System.Windows.Forms.Button btnSenorPago;
        private System.Windows.Forms.Button btnPaypal;
        private System.Windows.Forms.Button btnClip;
        private System.Windows.Forms.GroupBox gbCalculadoraComisiones;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbComisiones;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTarifaFija;
        private System.Windows.Forms.TextBox txtTarifaPorcentaje;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbDoceMSI;
        private System.Windows.Forms.RadioButton rbNueveMSI;
        private System.Windows.Forms.RadioButton rbSeisMSI;
        private System.Windows.Forms.RadioButton rbTresMSI;
        private System.Windows.Forms.Panel panelMSI;
        private System.Windows.Forms.CheckBox cbMSI;
        private System.Windows.Forms.NumericUpDown txtCantidadARecibir;
        private System.Windows.Forms.NumericUpDown txtComisionAPagar;
        private System.Windows.Forms.NumericUpDown txtCantidadPagada;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown txtCantidadACobrar;
        private System.Windows.Forms.NumericUpDown txtCantidadDeseada;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

