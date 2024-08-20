namespace CapaDiseño
{
    partial class EntradaEmergencia
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnIngreso = new System.Windows.Forms.Button();
            this.txtCodigoBomberoAcargo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAgregarBombero = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.listBoxBomberos = new System.Windows.Forms.ListBox();
            this.dtpFechaHoraSalida = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.btnIdentificar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAccionesTomadas = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDescripcionHecho = new System.Windows.Forms.TextBox();
            this.cbVehiculosAsignados = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDireccionHecho = new System.Windows.Forms.TextBox();
            this.cbTipoEmergencia = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpFechaHoraIngreso = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodigoBombero = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(47)))), ((int)(((byte)(70)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1155, 49);
            this.panel1.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = "Entrada A Emergencia";
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.Transparent;
            this.btnClose.Image = global::CapaDiseño.Properties.Resources.Icono_cerrar_FN;
            this.btnClose.Location = new System.Drawing.Point(1106, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(49, 49);
            this.btnClose.TabIndex = 9;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnIngreso
            // 
            this.btnIngreso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(63)))), ((int)(((byte)(95)))));
            this.btnIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngreso.ForeColor = System.Drawing.Color.White;
            this.btnIngreso.Location = new System.Drawing.Point(627, 90);
            this.btnIngreso.Name = "btnIngreso";
            this.btnIngreso.Size = new System.Drawing.Size(144, 44);
            this.btnIngreso.TabIndex = 28;
            this.btnIngreso.Text = "identificar";
            this.btnIngreso.UseVisualStyleBackColor = false;
            // 
            // txtCodigoBomberoAcargo
            // 
            this.txtCodigoBomberoAcargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoBomberoAcargo.Location = new System.Drawing.Point(390, 95);
            this.txtCodigoBomberoAcargo.Multiline = true;
            this.txtCodigoBomberoAcargo.Name = "txtCodigoBomberoAcargo";
            this.txtCodigoBomberoAcargo.Size = new System.Drawing.Size(204, 29);
            this.txtCodigoBomberoAcargo.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(34, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(339, 29);
            this.label2.TabIndex = 25;
            this.label2.Text = "Ingrese Codigo De Bombero:";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.Controls.Add(this.btnAgregarBombero);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.listBoxBomberos);
            this.panel2.Controls.Add(this.dtpFechaHoraSalida);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.btnIdentificar);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txtObservaciones);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txtAccionesTomadas);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtDescripcionHecho);
            this.panel2.Controls.Add(this.cbVehiculosAsignados);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtDireccionHecho);
            this.panel2.Controls.Add(this.cbTipoEmergencia);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.dtpFechaHoraIngreso);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtCodigoBombero);
            this.panel2.Location = new System.Drawing.Point(25, 189);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1118, 388);
            this.panel2.TabIndex = 29;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnAgregarBombero
            // 
            this.btnAgregarBombero.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarBombero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(63)))), ((int)(((byte)(95)))));
            this.btnAgregarBombero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarBombero.ForeColor = System.Drawing.Color.White;
            this.btnAgregarBombero.Location = new System.Drawing.Point(1002, 14);
            this.btnAgregarBombero.Name = "btnAgregarBombero";
            this.btnAgregarBombero.Size = new System.Drawing.Size(97, 35);
            this.btnAgregarBombero.TabIndex = 30;
            this.btnAgregarBombero.Text = "Agregar";
            this.btnAgregarBombero.UseVisualStyleBackColor = false;
            this.btnAgregarBombero.Click += new System.EventHandler(this.btnAgregarBombero_Click);
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(557, 60);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(222, 20);
            this.label12.TabIndex = 60;
            this.label12.Text = "Bomberos Que Participaron:";
            // 
            // listBoxBomberos
            // 
            this.listBoxBomberos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxBomberos.FormattingEnabled = true;
            this.listBoxBomberos.ItemHeight = 16;
            this.listBoxBomberos.Location = new System.Drawing.Point(810, 62);
            this.listBoxBomberos.Name = "listBoxBomberos";
            this.listBoxBomberos.Size = new System.Drawing.Size(289, 84);
            this.listBoxBomberos.TabIndex = 59;
            // 
            // dtpFechaHoraSalida
            // 
            this.dtpFechaHoraSalida.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpFechaHoraSalida.Location = new System.Drawing.Point(251, 62);
            this.dtpFechaHoraSalida.Name = "dtpFechaHoraSalida";
            this.dtpFechaHoraSalida.Size = new System.Drawing.Size(278, 22);
            this.dtpFechaHoraSalida.TabIndex = 58;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(23, 64);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(201, 20);
            this.label11.TabIndex = 57;
            this.label11.Text = "Fecha y hora de la salida:";
            // 
            // btnIdentificar
            // 
            this.btnIdentificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIdentificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(63)))), ((int)(((byte)(95)))));
            this.btnIdentificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIdentificar.ForeColor = System.Drawing.Color.White;
            this.btnIdentificar.Location = new System.Drawing.Point(921, 320);
            this.btnIdentificar.Name = "btnIdentificar";
            this.btnIdentificar.Size = new System.Drawing.Size(144, 44);
            this.btnIdentificar.TabIndex = 56;
            this.btnIdentificar.Text = "Guardar";
            this.btnIdentificar.UseVisualStyleBackColor = false;
            this.btnIdentificar.Click += new System.EventHandler(this.btnIdentificar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(59, 282);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 20);
            this.label10.TabIndex = 55;
            this.label10.Text = "Observaciones";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtObservaciones.Location = new System.Drawing.Point(212, 282);
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(887, 22);
            this.txtObservaciones.TabIndex = 54;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(43, 240);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(152, 20);
            this.label9.TabIndex = 53;
            this.label9.Text = "Acciones Tomadas";
            // 
            // txtAccionesTomadas
            // 
            this.txtAccionesTomadas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAccionesTomadas.Location = new System.Drawing.Point(219, 242);
            this.txtAccionesTomadas.Name = "txtAccionesTomadas";
            this.txtAccionesTomadas.Size = new System.Drawing.Size(880, 22);
            this.txtAccionesTomadas.TabIndex = 52;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(26, 201);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(176, 20);
            this.label8.TabIndex = 51;
            this.label8.Text = "Descripcion del hecho";
            // 
            // txtDescripcionHecho
            // 
            this.txtDescripcionHecho.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescripcionHecho.Location = new System.Drawing.Point(241, 201);
            this.txtDescripcionHecho.Name = "txtDescripcionHecho";
            this.txtDescripcionHecho.Size = new System.Drawing.Size(858, 22);
            this.txtDescripcionHecho.TabIndex = 50;
            // 
            // cbVehiculosAsignados
            // 
            this.cbVehiculosAsignados.FormattingEnabled = true;
            this.cbVehiculosAsignados.Items.AddRange(new object[] {
            "Autobomba",
            ""});
            this.cbVehiculosAsignados.Location = new System.Drawing.Point(212, 157);
            this.cbVehiculosAsignados.Name = "cbVehiculosAsignados";
            this.cbVehiculosAsignados.Size = new System.Drawing.Size(267, 24);
            this.cbVehiculosAsignados.TabIndex = 49;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(26, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 20);
            this.label7.TabIndex = 48;
            this.label7.Text = "Vehiculos asignados";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(514, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 20);
            this.label6.TabIndex = 47;
            this.label6.Text = "Direccion del hecho:";
            // 
            // txtDireccionHecho
            // 
            this.txtDireccionHecho.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDireccionHecho.Location = new System.Drawing.Point(702, 159);
            this.txtDireccionHecho.Name = "txtDireccionHecho";
            this.txtDireccionHecho.Size = new System.Drawing.Size(397, 22);
            this.txtDireccionHecho.TabIndex = 46;
            // 
            // cbTipoEmergencia
            // 
            this.cbTipoEmergencia.FormattingEnabled = true;
            this.cbTipoEmergencia.Items.AddRange(new object[] {
            "Incendio",
            "Rescate",
            "Accidente de trafico",
            "otro..."});
            this.cbTipoEmergencia.Location = new System.Drawing.Point(212, 118);
            this.cbTipoEmergencia.Name = "cbTipoEmergencia";
            this.cbTipoEmergencia.Size = new System.Drawing.Size(387, 24);
            this.cbTipoEmergencia.TabIndex = 45;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(26, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 20);
            this.label5.TabIndex = 44;
            this.label5.Text = "Tipo De Emergencia";
            // 
            // dtpFechaHoraIngreso
            // 
            this.dtpFechaHoraIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpFechaHoraIngreso.Location = new System.Drawing.Point(251, 27);
            this.dtpFechaHoraIngreso.Name = "dtpFechaHoraIngreso";
            this.dtpFechaHoraIngreso.Size = new System.Drawing.Size(278, 22);
            this.dtpFechaHoraIngreso.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(23, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 20);
            this.label4.TabIndex = 42;
            this.label4.Text = "Fecha y hora del ingreso:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(557, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 20);
            this.label3.TabIndex = 41;
            this.label3.Text = "Ingrese Codigo De Bombero:";
            // 
            // txtCodigoBombero
            // 
            this.txtCodigoBombero.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodigoBombero.Location = new System.Drawing.Point(810, 21);
            this.txtCodigoBombero.Name = "txtCodigoBombero";
            this.txtCodigoBombero.Size = new System.Drawing.Size(127, 22);
            this.txtCodigoBombero.TabIndex = 40;
            // 
            // EntradaEmergencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1155, 611);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnIngreso);
            this.Controls.Add(this.txtCodigoBomberoAcargo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EntradaEmergencia";
            this.Text = "EntradaEmergencia";
            this.Load += new System.EventHandler(this.EntradaEmergencia_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnIngreso;
        private System.Windows.Forms.TextBox txtCodigoBomberoAcargo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAccionesTomadas;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDescripcionHecho;
        private System.Windows.Forms.ComboBox cbVehiculosAsignados;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDireccionHecho;
        private System.Windows.Forms.ComboBox cbTipoEmergencia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpFechaHoraIngreso;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCodigoBombero;
        private System.Windows.Forms.Button btnIdentificar;
        private System.Windows.Forms.DateTimePicker dtpFechaHoraSalida;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListBox listBoxBomberos;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnAgregarBombero;
    }
}