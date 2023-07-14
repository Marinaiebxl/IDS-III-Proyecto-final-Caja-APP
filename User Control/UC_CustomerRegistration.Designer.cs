namespace DS_III_Proyecto_final_Caja_APP.User_Control
{
    partial class UC_CustomerRegistration
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.txtname = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtapellidos = new Guna.UI2.WinForms.Guna2TextBox();
            this.txttelefono = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtcorreo = new Guna.UI2.WinForms.Guna2TextBox();
            this.AlloeRoombtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.hotelDataSet = new DS_III_Proyecto_final_Caja_APP.hotelDataSet();
            this.hotelDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empleadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empleadosTableAdapter = new DS_III_Proyecto_final_Caja_APP.hotelDataSetTableAdapters.EmpleadosTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.huespedesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empleadosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.huespedesTableAdapter = new DS_III_Proyecto_final_Caja_APP.hotelDataSetTableAdapters.HuespedesTableAdapter();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.hotelDataSet3 = new DS_III_Proyecto_final_Caja_APP.hotelDataSet3();
            this.buscarHuespedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buscarHuespedTableAdapter = new DS_III_Proyecto_final_Caja_APP.hotelDataSet3TableAdapters.BuscarHuespedTableAdapter();
            this.iDHuespedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.huespedesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buscarHuespedBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // txtname
            // 
            this.txtname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtname.DefaultText = "";
            this.txtname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtname.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtname.Location = new System.Drawing.Point(45, 116);
            this.txtname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtname.Name = "txtname";
            this.txtname.PasswordChar = '\0';
            this.txtname.PlaceholderText = "Ingresa Nombre Completo";
            this.txtname.SelectedText = "";
            this.txtname.Size = new System.Drawing.Size(260, 36);
            this.txtname.TabIndex = 0;
            this.txtname.TextChanged += new System.EventHandler(this.txtname_TextChanged);
            this.txtname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtname_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Facturación";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Correo Electrónico:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Teléfono:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Apellidos:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Nombres:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtapellidos
            // 
            this.txtapellidos.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtapellidos.DefaultText = "";
            this.txtapellidos.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtapellidos.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtapellidos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtapellidos.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtapellidos.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtapellidos.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtapellidos.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtapellidos.Location = new System.Drawing.Point(45, 184);
            this.txtapellidos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtapellidos.Name = "txtapellidos";
            this.txtapellidos.PasswordChar = '\0';
            this.txtapellidos.PlaceholderText = "Ingresa Apellido Completo";
            this.txtapellidos.SelectedText = "";
            this.txtapellidos.Size = new System.Drawing.Size(260, 36);
            this.txtapellidos.TabIndex = 7;
            this.txtapellidos.TextChanged += new System.EventHandler(this.txtapellidos_TextChanged);
            // 
            // txttelefono
            // 
            this.txttelefono.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txttelefono.DefaultText = "";
            this.txttelefono.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txttelefono.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txttelefono.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txttelefono.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txttelefono.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txttelefono.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txttelefono.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txttelefono.Location = new System.Drawing.Point(45, 246);
            this.txttelefono.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.PasswordChar = '\0';
            this.txttelefono.PlaceholderText = "Ingresa Numero de Telefono";
            this.txttelefono.SelectedText = "";
            this.txttelefono.Size = new System.Drawing.Size(260, 36);
            this.txttelefono.TabIndex = 8;
            this.txttelefono.TextChanged += new System.EventHandler(this.txttelefono_TextChanged);
            // 
            // txtcorreo
            // 
            this.txtcorreo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcorreo.DefaultText = "";
            this.txtcorreo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtcorreo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtcorreo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtcorreo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtcorreo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtcorreo.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtcorreo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtcorreo.Location = new System.Drawing.Point(45, 306);
            this.txtcorreo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.PasswordChar = '\0';
            this.txtcorreo.PlaceholderText = "Ingresa Correo Electronico";
            this.txtcorreo.SelectedText = "";
            this.txtcorreo.Size = new System.Drawing.Size(260, 36);
            this.txtcorreo.TabIndex = 9;
            // 
            // AlloeRoombtn
            // 
            this.AlloeRoombtn.AutoRoundedCorners = true;
            this.AlloeRoombtn.BorderRadius = 21;
            this.AlloeRoombtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AlloeRoombtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AlloeRoombtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AlloeRoombtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AlloeRoombtn.FillColor = System.Drawing.Color.DarkCyan;
            this.AlloeRoombtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlloeRoombtn.ForeColor = System.Drawing.Color.Black;
            this.AlloeRoombtn.Location = new System.Drawing.Point(78, 349);
            this.AlloeRoombtn.Name = "AlloeRoombtn";
            this.AlloeRoombtn.Size = new System.Drawing.Size(180, 45);
            this.AlloeRoombtn.TabIndex = 24;
            this.AlloeRoombtn.Text = "Crear Factura";
            this.AlloeRoombtn.Click += new System.EventHandler(this.AlloeRoombtn_Click);
            // 
            // hotelDataSet
            // 
            this.hotelDataSet.DataSetName = "hotelDataSet";
            this.hotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hotelDataSetBindingSource
            // 
            this.hotelDataSetBindingSource.DataSource = this.hotelDataSet;
            this.hotelDataSetBindingSource.Position = 0;
            // 
            // empleadosBindingSource
            // 
            this.empleadosBindingSource.DataMember = "Empleados";
            this.empleadosBindingSource.DataSource = this.hotelDataSetBindingSource;
            // 
            // empleadosTableAdapter
            // 
            this.empleadosTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDHuespedDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.apellidosDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.buscarHuespedBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(356, 116);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(471, 219);
            this.dataGridView1.TabIndex = 25;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // huespedesBindingSource
            // 
            this.huespedesBindingSource.DataMember = "Huespedes";
            this.huespedesBindingSource.DataSource = this.hotelDataSetBindingSource;
            // 
            // empleadosBindingSource1
            // 
            this.empleadosBindingSource1.DataMember = "Empleados";
            this.empleadosBindingSource1.DataSource = this.hotelDataSetBindingSource;
            // 
            // huespedesTableAdapter
            // 
            this.huespedesTableAdapter.ClearBeforeFill = true;
            // 
            // guna2Button1
            // 
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(563, 349);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(101, 45);
            this.guna2Button1.TabIndex = 26;
            this.guna2Button1.Text = "Refresh";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // hotelDataSet3
            // 
            this.hotelDataSet3.DataSetName = "hotelDataSet3";
            this.hotelDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buscarHuespedBindingSource
            // 
            this.buscarHuespedBindingSource.DataMember = "BuscarHuesped";
            this.buscarHuespedBindingSource.DataSource = this.hotelDataSet3;
            // 
            // buscarHuespedTableAdapter
            // 
            this.buscarHuespedTableAdapter.ClearBeforeFill = true;
            // 
            // iDHuespedDataGridViewTextBoxColumn
            // 
            this.iDHuespedDataGridViewTextBoxColumn.DataPropertyName = "ID_Huesped";
            this.iDHuespedDataGridViewTextBoxColumn.HeaderText = "ID_Huesped";
            this.iDHuespedDataGridViewTextBoxColumn.Name = "iDHuespedDataGridViewTextBoxColumn";
            this.iDHuespedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // apellidosDataGridViewTextBoxColumn
            // 
            this.apellidosDataGridViewTextBoxColumn.DataPropertyName = "Apellidos";
            this.apellidosDataGridViewTextBoxColumn.HeaderText = "Apellidos";
            this.apellidosDataGridViewTextBoxColumn.Name = "apellidosDataGridViewTextBoxColumn";
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            // 
            // UC_CustomerRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.AlloeRoombtn);
            this.Controls.Add(this.txtcorreo);
            this.Controls.Add(this.txttelefono);
            this.Controls.Add(this.txtapellidos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtname);
            this.Name = "UC_CustomerRegistration";
            this.Size = new System.Drawing.Size(850, 443);
            this.Load += new System.EventHandler(this.UC_CustomerRegistration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.huespedesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buscarHuespedBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2TextBox txtname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtcorreo;
        private Guna.UI2.WinForms.Guna2TextBox txttelefono;
        private Guna.UI2.WinForms.Guna2TextBox txtapellidos;
        private Guna.UI2.WinForms.Guna2Button AlloeRoombtn;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private System.Windows.Forms.BindingSource empleadosBindingSource;
        private System.Windows.Forms.BindingSource hotelDataSetBindingSource;
        private hotelDataSet hotelDataSet;
        private hotelDataSetTableAdapters.EmpleadosTableAdapter empleadosTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource huespedesBindingSource;
        private System.Windows.Forms.BindingSource empleadosBindingSource1;
        private hotelDataSetTableAdapters.HuespedesTableAdapter huespedesTableAdapter;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDHuespedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource buscarHuespedBindingSource;
        private hotelDataSet3 hotelDataSet3;
        private hotelDataSet3TableAdapters.BuscarHuespedTableAdapter buscarHuespedTableAdapter;
    }
}
