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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtapellidos = new Guna.UI2.WinForms.Guna2TextBox();
            this.txttelefono = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtcorreo = new Guna.UI2.WinForms.Guna2TextBox();
            this.checkin = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtroomPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Bedlimtcmbx = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Roomtypecmbx = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.RoomNocmbx = new Guna.UI2.WinForms.Guna2ComboBox();
            this.AlloeRoombtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
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
            this.txtname.Location = new System.Drawing.Point(42, 130);
            this.txtname.Name = "txtname";
            this.txtname.PasswordChar = '\0';
            this.txtname.PlaceholderText = "Ingresa Nombre Completo";
            this.txtname.SelectedText = "";
            this.txtname.Size = new System.Drawing.Size(331, 36);
            this.txtname.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer Registration";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Check-in";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Correo Electrónico:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Teléfono:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Apellidos:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 100);
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
            this.txtapellidos.Location = new System.Drawing.Point(42, 185);
            this.txtapellidos.Name = "txtapellidos";
            this.txtapellidos.PasswordChar = '\0';
            this.txtapellidos.PlaceholderText = "Ingresa Apellido Completo";
            this.txtapellidos.SelectedText = "";
            this.txtapellidos.Size = new System.Drawing.Size(331, 36);
            this.txtapellidos.TabIndex = 7;
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
            this.txttelefono.Location = new System.Drawing.Point(42, 247);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.PasswordChar = '\0';
            this.txttelefono.PlaceholderText = "Ingresa Numero de Telefono";
            this.txttelefono.SelectedText = "";
            this.txttelefono.Size = new System.Drawing.Size(331, 36);
            this.txttelefono.TabIndex = 8;
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
            this.txtcorreo.Location = new System.Drawing.Point(42, 307);
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.PasswordChar = '\0';
            this.txtcorreo.PlaceholderText = "Ingresa Correo Electronico";
            this.txtcorreo.SelectedText = "";
            this.txtcorreo.Size = new System.Drawing.Size(331, 36);
            this.txtcorreo.TabIndex = 9;
            // 
            // checkin
            // 
            this.checkin.Checked = true;
            this.checkin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.checkin.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.checkin.Location = new System.Drawing.Point(42, 370);
            this.checkin.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.checkin.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.checkin.Name = "checkin";
            this.checkin.Size = new System.Drawing.Size(200, 36);
            this.checkin.TabIndex = 10;
            this.checkin.Value = new System.DateTime(2023, 7, 13, 14, 23, 38, 963);
            // 
            // txtroomPrice
            // 
            this.txtroomPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtroomPrice.DefaultText = "";
            this.txtroomPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtroomPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtroomPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtroomPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtroomPrice.Enabled = false;
            this.txtroomPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtroomPrice.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtroomPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtroomPrice.Location = new System.Drawing.Point(499, 316);
            this.txtroomPrice.Name = "txtroomPrice";
            this.txtroomPrice.PasswordChar = '\0';
            this.txtroomPrice.PlaceholderText = "";
            this.txtroomPrice.SelectedText = "";
            this.txtroomPrice.Size = new System.Drawing.Size(331, 36);
            this.txtroomPrice.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(496, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Bed Limit";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(496, 238);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Room Type";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(496, 300);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Price";
            // 
            // Bedlimtcmbx
            // 
            this.Bedlimtcmbx.BackColor = System.Drawing.Color.Transparent;
            this.Bedlimtcmbx.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Bedlimtcmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Bedlimtcmbx.Enabled = false;
            this.Bedlimtcmbx.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Bedlimtcmbx.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Bedlimtcmbx.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Bedlimtcmbx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.Bedlimtcmbx.ItemHeight = 30;
            this.Bedlimtcmbx.Location = new System.Drawing.Point(499, 185);
            this.Bedlimtcmbx.Name = "Bedlimtcmbx";
            this.Bedlimtcmbx.Size = new System.Drawing.Size(331, 36);
            this.Bedlimtcmbx.TabIndex = 19;
            this.Bedlimtcmbx.SelectedIndexChanged += new System.EventHandler(this.Bedlimtcmbx_SelectedIndexChanged);
            // 
            // Roomtypecmbx
            // 
            this.Roomtypecmbx.BackColor = System.Drawing.Color.Transparent;
            this.Roomtypecmbx.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Roomtypecmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Roomtypecmbx.Enabled = false;
            this.Roomtypecmbx.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Roomtypecmbx.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Roomtypecmbx.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Roomtypecmbx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.Roomtypecmbx.ItemHeight = 30;
            this.Roomtypecmbx.Location = new System.Drawing.Point(499, 261);
            this.Roomtypecmbx.Name = "Roomtypecmbx";
            this.Roomtypecmbx.Size = new System.Drawing.Size(331, 36);
            this.Roomtypecmbx.TabIndex = 20;
            this.Roomtypecmbx.SelectedIndexChanged += new System.EventHandler(this.Roomtypecmbx_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(499, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "No.Room";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // RoomNocmbx
            // 
            this.RoomNocmbx.BackColor = System.Drawing.Color.Transparent;
            this.RoomNocmbx.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.RoomNocmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RoomNocmbx.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RoomNocmbx.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RoomNocmbx.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.RoomNocmbx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.RoomNocmbx.ItemHeight = 30;
            this.RoomNocmbx.Location = new System.Drawing.Point(499, 112);
            this.RoomNocmbx.Name = "RoomNocmbx";
            this.RoomNocmbx.Size = new System.Drawing.Size(331, 36);
            this.RoomNocmbx.TabIndex = 23;
            this.RoomNocmbx.SelectedIndexChanged += new System.EventHandler(this.RoomNocmbx_SelectedIndexChanged);
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
            this.AlloeRoombtn.Location = new System.Drawing.Point(553, 370);
            this.AlloeRoombtn.Name = "AlloeRoombtn";
            this.AlloeRoombtn.Size = new System.Drawing.Size(180, 45);
            this.AlloeRoombtn.TabIndex = 24;
            this.AlloeRoombtn.Text = "Allote Room";
            this.AlloeRoombtn.Click += new System.EventHandler(this.AlloeRoombtn_Click);
            // 
            // UC_CustomerRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AlloeRoombtn);
            this.Controls.Add(this.RoomNocmbx);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Roomtypecmbx);
            this.Controls.Add(this.Bedlimtcmbx);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtroomPrice);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.checkin);
            this.Controls.Add(this.txtcorreo);
            this.Controls.Add(this.txttelefono);
            this.Controls.Add(this.txtapellidos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtname);
            this.Name = "UC_CustomerRegistration";
            this.Size = new System.Drawing.Size(897, 443);
            this.Load += new System.EventHandler(this.UC_CustomerRegistration_Load);
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
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtcorreo;
        private Guna.UI2.WinForms.Guna2TextBox txttelefono;
        private Guna.UI2.WinForms.Guna2TextBox txtapellidos;
        private Guna.UI2.WinForms.Guna2DateTimePicker checkin;
        private Guna.UI2.WinForms.Guna2TextBox txtroomPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2ComboBox Roomtypecmbx;
        private Guna.UI2.WinForms.Guna2ComboBox Bedlimtcmbx;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2ComboBox RoomNocmbx;
        private Guna.UI2.WinForms.Guna2Button AlloeRoombtn;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
    }
}
