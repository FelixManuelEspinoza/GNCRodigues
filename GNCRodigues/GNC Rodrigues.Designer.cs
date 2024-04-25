namespace GNCRodigues
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Btn_limpiar = new System.Windows.Forms.Button();
            this.Btn_ok = new System.Windows.Forms.Button();
            this.TB_Total = new System.Windows.Forms.TextBox();
            this.TB_presupuesto = new System.Windows.Forms.TextBox();
            this.CB_Avisopararetirar = new System.Windows.Forms.CheckBox();
            this.CB_Confirmocliente = new System.Windows.Forms.CheckBox();
            this.CB_Cortacorriente = new System.Windows.Forms.CheckBox();
            this.CB_Nafta = new System.Windows.Forms.CheckBox();
            this.Dtp_Fecha = new System.Windows.Forms.DateTimePicker();
            this.TB_Fallas = new System.Windows.Forms.TextBox();
            this.TB_Detalles = new System.Windows.Forms.TextBox();
            this.TB_Telefono = new System.Windows.Forms.TextBox();
            this.TB_Dominio = new System.Windows.Forms.TextBox();
            this.TB_Vehiculo = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.TB_buscador = new System.Windows.Forms.TextBox();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Dgv_historial = new System.Windows.Forms.DataGridView();
            this.gNCRodriguesDataSet = new GNCRodigues.GNCRodriguesDataSet();
            this.ordenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordenTableAdapter = new GNCRodigues.GNCRodriguesDataSetTableAdapters.OrdenTableAdapter();
            this.dominioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehiculoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naftaDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cortaCorrienteDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.detallesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fallaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.presupuestoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.confirmoClienteDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.avisoParaRetirarDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_historial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gNCRodriguesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordenBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Btn_limpiar);
            this.tabPage1.Controls.Add(this.Btn_ok);
            this.tabPage1.Controls.Add(this.TB_Total);
            this.tabPage1.Controls.Add(this.TB_presupuesto);
            this.tabPage1.Controls.Add(this.CB_Avisopararetirar);
            this.tabPage1.Controls.Add(this.CB_Confirmocliente);
            this.tabPage1.Controls.Add(this.CB_Cortacorriente);
            this.tabPage1.Controls.Add(this.CB_Nafta);
            this.tabPage1.Controls.Add(this.Dtp_Fecha);
            this.tabPage1.Controls.Add(this.TB_Fallas);
            this.tabPage1.Controls.Add(this.TB_Detalles);
            this.tabPage1.Controls.Add(this.TB_Telefono);
            this.tabPage1.Controls.Add(this.TB_Dominio);
            this.tabPage1.Controls.Add(this.TB_Vehiculo);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Orden";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // Btn_limpiar
            // 
            this.Btn_limpiar.Location = new System.Drawing.Point(478, 360);
            this.Btn_limpiar.Name = "Btn_limpiar";
            this.Btn_limpiar.Size = new System.Drawing.Size(75, 23);
            this.Btn_limpiar.TabIndex = 26;
            this.Btn_limpiar.Text = "Limpiar";
            this.Btn_limpiar.UseVisualStyleBackColor = true;
            // 
            // Btn_ok
            // 
            this.Btn_ok.Location = new System.Drawing.Point(364, 360);
            this.Btn_ok.Name = "Btn_ok";
            this.Btn_ok.Size = new System.Drawing.Size(75, 23);
            this.Btn_ok.TabIndex = 25;
            this.Btn_ok.Text = "OK";
            this.Btn_ok.UseVisualStyleBackColor = true;
            this.Btn_ok.Click += new System.EventHandler(this.Btn_ok_Click);
            // 
            // TB_Total
            // 
            this.TB_Total.Location = new System.Drawing.Point(512, 273);
            this.TB_Total.Name = "TB_Total";
            this.TB_Total.Size = new System.Drawing.Size(100, 20);
            this.TB_Total.TabIndex = 24;
            // 
            // TB_presupuesto
            // 
            this.TB_presupuesto.Location = new System.Drawing.Point(364, 273);
            this.TB_presupuesto.Name = "TB_presupuesto";
            this.TB_presupuesto.Size = new System.Drawing.Size(100, 20);
            this.TB_presupuesto.TabIndex = 23;
            // 
            // CB_Avisopararetirar
            // 
            this.CB_Avisopararetirar.AutoSize = true;
            this.CB_Avisopararetirar.Location = new System.Drawing.Point(304, 180);
            this.CB_Avisopararetirar.Name = "CB_Avisopararetirar";
            this.CB_Avisopararetirar.Size = new System.Drawing.Size(117, 17);
            this.CB_Avisopararetirar.TabIndex = 22;
            this.CB_Avisopararetirar.Text = "Avisado para retirar";
            this.CB_Avisopararetirar.UseVisualStyleBackColor = true;
            // 
            // CB_Confirmocliente
            // 
            this.CB_Confirmocliente.AutoSize = true;
            this.CB_Confirmocliente.Location = new System.Drawing.Point(564, 39);
            this.CB_Confirmocliente.Name = "CB_Confirmocliente";
            this.CB_Confirmocliente.Size = new System.Drawing.Size(102, 17);
            this.CB_Confirmocliente.TabIndex = 21;
            this.CB_Confirmocliente.Text = "Confirmo Cliente";
            this.CB_Confirmocliente.UseVisualStyleBackColor = true;
            // 
            // CB_Cortacorriente
            // 
            this.CB_Cortacorriente.AutoSize = true;
            this.CB_Cortacorriente.Location = new System.Drawing.Point(336, 77);
            this.CB_Cortacorriente.Name = "CB_Cortacorriente";
            this.CB_Cortacorriente.Size = new System.Drawing.Size(96, 17);
            this.CB_Cortacorriente.TabIndex = 20;
            this.CB_Cortacorriente.Text = "Corta Corriente";
            this.CB_Cortacorriente.UseVisualStyleBackColor = true;
            // 
            // CB_Nafta
            // 
            this.CB_Nafta.AutoSize = true;
            this.CB_Nafta.Location = new System.Drawing.Point(9, 86);
            this.CB_Nafta.Name = "CB_Nafta";
            this.CB_Nafta.Size = new System.Drawing.Size(52, 17);
            this.CB_Nafta.TabIndex = 18;
            this.CB_Nafta.Text = "Nafta";
            this.CB_Nafta.UseVisualStyleBackColor = true;
            // 
            // Dtp_Fecha
            // 
            this.Dtp_Fecha.Location = new System.Drawing.Point(324, 3);
            this.Dtp_Fecha.Name = "Dtp_Fecha";
            this.Dtp_Fecha.Size = new System.Drawing.Size(200, 20);
            this.Dtp_Fecha.TabIndex = 17;
            // 
            // TB_Fallas
            // 
            this.TB_Fallas.Location = new System.Drawing.Point(9, 292);
            this.TB_Fallas.Multiline = true;
            this.TB_Fallas.Name = "TB_Fallas";
            this.TB_Fallas.Size = new System.Drawing.Size(278, 102);
            this.TB_Fallas.TabIndex = 16;
            // 
            // TB_Detalles
            // 
            this.TB_Detalles.Location = new System.Drawing.Point(9, 180);
            this.TB_Detalles.Multiline = true;
            this.TB_Detalles.Name = "TB_Detalles";
            this.TB_Detalles.Size = new System.Drawing.Size(278, 93);
            this.TB_Detalles.TabIndex = 15;
            // 
            // TB_Telefono
            // 
            this.TB_Telefono.Location = new System.Drawing.Point(336, 37);
            this.TB_Telefono.Name = "TB_Telefono";
            this.TB_Telefono.Size = new System.Drawing.Size(100, 20);
            this.TB_Telefono.TabIndex = 14;
            // 
            // TB_Dominio
            // 
            this.TB_Dominio.Location = new System.Drawing.Point(60, 37);
            this.TB_Dominio.Name = "TB_Dominio";
            this.TB_Dominio.Size = new System.Drawing.Size(100, 20);
            this.TB_Dominio.TabIndex = 13;
            // 
            // TB_Vehiculo
            // 
            this.TB_Vehiculo.Location = new System.Drawing.Point(60, 3);
            this.TB_Vehiculo.Name = "TB_Vehiculo";
            this.TB_Vehiculo.Size = new System.Drawing.Size(100, 20);
            this.TB_Vehiculo.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(475, 276);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Total";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 276);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Fallas";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(292, 276);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Presupuesto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Detalles";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(281, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefono";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(281, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dominio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vehiculo";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.TB_buscador);
            this.tabPage2.Controls.Add(this.Btn_Buscar);
            this.tabPage2.Controls.Add(this.Btn_Eliminar);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.Dgv_historial);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Historial";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // TB_buscador
            // 
            this.TB_buscador.Location = new System.Drawing.Point(3, 8);
            this.TB_buscador.Name = "TB_buscador";
            this.TB_buscador.Size = new System.Drawing.Size(100, 20);
            this.TB_buscador.TabIndex = 4;
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.Location = new System.Drawing.Point(109, 6);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Buscar.TabIndex = 3;
            this.Btn_Buscar.Text = "Buscar";
            this.Btn_Buscar.UseVisualStyleBackColor = true;
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.Location = new System.Drawing.Point(314, 362);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Eliminar.TabIndex = 2;
            this.Btn_Eliminar.Text = "Eliminar";
            this.Btn_Eliminar.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(345, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Historial";
            // 
            // Dgv_historial
            // 
            this.Dgv_historial.AutoGenerateColumns = false;
            this.Dgv_historial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_historial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dominioDataGridViewTextBoxColumn,
            this.vehiculoDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.naftaDataGridViewCheckBoxColumn,
            this.cortaCorrienteDataGridViewCheckBoxColumn,
            this.detallesDataGridViewTextBoxColumn,
            this.fallaDataGridViewTextBoxColumn,
            this.presupuestoDataGridViewTextBoxColumn,
            this.confirmoClienteDataGridViewCheckBoxColumn,
            this.avisoParaRetirarDataGridViewCheckBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn});
            this.Dgv_historial.DataSource = this.ordenBindingSource;
            this.Dgv_historial.Location = new System.Drawing.Point(125, 62);
            this.Dgv_historial.Name = "Dgv_historial";
            this.Dgv_historial.Size = new System.Drawing.Size(473, 294);
            this.Dgv_historial.TabIndex = 0;
            this.Dgv_historial.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_historial_CellContentClick);
            // 
            // gNCRodriguesDataSet
            // 
            this.gNCRodriguesDataSet.DataSetName = "GNCRodriguesDataSet";
            this.gNCRodriguesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordenBindingSource
            // 
            this.ordenBindingSource.DataMember = "Orden";
            this.ordenBindingSource.DataSource = this.gNCRodriguesDataSet;
            // 
            // ordenTableAdapter
            // 
            this.ordenTableAdapter.ClearBeforeFill = true;
            // 
            // dominioDataGridViewTextBoxColumn
            // 
            this.dominioDataGridViewTextBoxColumn.DataPropertyName = "Dominio";
            this.dominioDataGridViewTextBoxColumn.HeaderText = "Dominio";
            this.dominioDataGridViewTextBoxColumn.Name = "dominioDataGridViewTextBoxColumn";
            // 
            // vehiculoDataGridViewTextBoxColumn
            // 
            this.vehiculoDataGridViewTextBoxColumn.DataPropertyName = "Vehiculo";
            this.vehiculoDataGridViewTextBoxColumn.HeaderText = "Vehiculo";
            this.vehiculoDataGridViewTextBoxColumn.Name = "vehiculoDataGridViewTextBoxColumn";
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            // 
            // naftaDataGridViewCheckBoxColumn
            // 
            this.naftaDataGridViewCheckBoxColumn.DataPropertyName = "Nafta";
            this.naftaDataGridViewCheckBoxColumn.HeaderText = "Nafta";
            this.naftaDataGridViewCheckBoxColumn.Name = "naftaDataGridViewCheckBoxColumn";
            // 
            // cortaCorrienteDataGridViewCheckBoxColumn
            // 
            this.cortaCorrienteDataGridViewCheckBoxColumn.DataPropertyName = "CortaCorriente";
            this.cortaCorrienteDataGridViewCheckBoxColumn.HeaderText = "CortaCorriente";
            this.cortaCorrienteDataGridViewCheckBoxColumn.Name = "cortaCorrienteDataGridViewCheckBoxColumn";
            // 
            // detallesDataGridViewTextBoxColumn
            // 
            this.detallesDataGridViewTextBoxColumn.DataPropertyName = "Detalles";
            this.detallesDataGridViewTextBoxColumn.HeaderText = "Detalles";
            this.detallesDataGridViewTextBoxColumn.Name = "detallesDataGridViewTextBoxColumn";
            // 
            // fallaDataGridViewTextBoxColumn
            // 
            this.fallaDataGridViewTextBoxColumn.DataPropertyName = "Falla";
            this.fallaDataGridViewTextBoxColumn.HeaderText = "Falla";
            this.fallaDataGridViewTextBoxColumn.Name = "fallaDataGridViewTextBoxColumn";
            // 
            // presupuestoDataGridViewTextBoxColumn
            // 
            this.presupuestoDataGridViewTextBoxColumn.DataPropertyName = "Presupuesto";
            this.presupuestoDataGridViewTextBoxColumn.HeaderText = "Presupuesto";
            this.presupuestoDataGridViewTextBoxColumn.Name = "presupuestoDataGridViewTextBoxColumn";
            // 
            // confirmoClienteDataGridViewCheckBoxColumn
            // 
            this.confirmoClienteDataGridViewCheckBoxColumn.DataPropertyName = "ConfirmoCliente";
            this.confirmoClienteDataGridViewCheckBoxColumn.HeaderText = "ConfirmoCliente";
            this.confirmoClienteDataGridViewCheckBoxColumn.Name = "confirmoClienteDataGridViewCheckBoxColumn";
            // 
            // avisoParaRetirarDataGridViewCheckBoxColumn
            // 
            this.avisoParaRetirarDataGridViewCheckBoxColumn.DataPropertyName = "AvisoParaRetirar";
            this.avisoParaRetirarDataGridViewCheckBoxColumn.HeaderText = "AvisoParaRetirar";
            this.avisoParaRetirarDataGridViewCheckBoxColumn.Name = "avisoParaRetirarDataGridViewCheckBoxColumn";
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono ";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "Telefono ";
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "GNC Rodrigues";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_historial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gNCRodriguesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordenBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_Fallas;
        private System.Windows.Forms.TextBox TB_Detalles;
        private System.Windows.Forms.TextBox TB_Telefono;
        private System.Windows.Forms.TextBox TB_Dominio;
        private System.Windows.Forms.TextBox TB_Vehiculo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button Btn_limpiar;
        private System.Windows.Forms.Button Btn_ok;
        private System.Windows.Forms.TextBox TB_Total;
        private System.Windows.Forms.TextBox TB_presupuesto;
        private System.Windows.Forms.CheckBox CB_Avisopararetirar;
        private System.Windows.Forms.CheckBox CB_Confirmocliente;
        private System.Windows.Forms.CheckBox CB_Cortacorriente;
        private System.Windows.Forms.CheckBox CB_Nafta;
        private System.Windows.Forms.DateTimePicker Dtp_Fecha;
        private System.Windows.Forms.Button Btn_Eliminar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView Dgv_historial;
        private System.Windows.Forms.TextBox TB_buscador;
        private System.Windows.Forms.Button Btn_Buscar;
        private GNCRodriguesDataSet gNCRodriguesDataSet;
        private System.Windows.Forms.BindingSource ordenBindingSource;
        private GNCRodriguesDataSetTableAdapters.OrdenTableAdapter ordenTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dominioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehiculoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn naftaDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cortaCorrienteDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detallesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fallaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn presupuestoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn confirmoClienteDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn avisoParaRetirarDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
    }
}

