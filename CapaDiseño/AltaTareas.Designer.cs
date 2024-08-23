namespace CapaDiseño
{
    partial class AltaTareas
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAgregarBombero = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.listBoxBomberos = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCodigoBombero = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDescripcionHecho = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbEstadoTarea = new System.Windows.Forms.ComboBox();
            this.dtpFechaAsignacion = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpFechaFinalizacion = new System.Windows.Forms.DateTimePicker();
            this.btnAgregarTarea = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCodigoBomberoAcargo = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(822, 45);
            this.panel1.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-402, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = "Planilla De Asistencia";
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.Transparent;
            this.btnClose.Image = global::CapaDiseño.Properties.Resources.Icono_cerrar_FN;
            this.btnClose.Location = new System.Drawing.Point(776, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(46, 45);
            this.btnClose.TabIndex = 9;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(399, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 29);
            this.label3.TabIndex = 71;
            this.label3.Text = "ALTA TAREA";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(211, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(559, 29);
            this.label2.TabIndex = 70;
            this.label2.Text = "BOMBEROS VOLUNTARIOS DE SAN VICENTE";
            // 
            // btnAgregarBombero
            // 
            this.btnAgregarBombero.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarBombero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(63)))), ((int)(((byte)(95)))));
            this.btnAgregarBombero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarBombero.ForeColor = System.Drawing.Color.White;
            this.btnAgregarBombero.Location = new System.Drawing.Point(497, 250);
            this.btnAgregarBombero.Name = "btnAgregarBombero";
            this.btnAgregarBombero.Size = new System.Drawing.Size(97, 38);
            this.btnAgregarBombero.TabIndex = 72;
            this.btnAgregarBombero.Text = "Agregar";
            this.btnAgregarBombero.UseVisualStyleBackColor = false;
            this.btnAgregarBombero.Click += new System.EventHandler(this.btnAgregarBombero_Click);
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(12, 333);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(258, 25);
            this.label12.TabIndex = 76;
            this.label12.Text = "Bomberos Que Participaron:";
            // 
            // listBoxBomberos
            // 
            this.listBoxBomberos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxBomberos.FormattingEnabled = true;
            this.listBoxBomberos.ItemHeight = 16;
            this.listBoxBomberos.Location = new System.Drawing.Point(276, 333);
            this.listBoxBomberos.Name = "listBoxBomberos";
            this.listBoxBomberos.Size = new System.Drawing.Size(131, 36);
            this.listBoxBomberos.TabIndex = 75;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(265, 25);
            this.label4.TabIndex = 74;
            this.label4.Text = "Ingrese Codigo De Bombero:";
            // 
            // txtCodigoBombero
            // 
            this.txtCodigoBombero.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodigoBombero.Location = new System.Drawing.Point(298, 266);
            this.txtCodigoBombero.Name = "txtCodigoBombero";
            this.txtCodigoBombero.Size = new System.Drawing.Size(181, 22);
            this.txtCodigoBombero.TabIndex = 73;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(12, 421);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(210, 25);
            this.label8.TabIndex = 78;
            this.label8.Text = "Descripcion del hecho:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtDescripcionHecho
            // 
            this.txtDescripcionHecho.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescripcionHecho.Location = new System.Drawing.Point(242, 421);
            this.txtDescripcionHecho.Name = "txtDescripcionHecho";
            this.txtDescripcionHecho.Size = new System.Drawing.Size(560, 22);
            this.txtDescripcionHecho.TabIndex = 77;
            this.txtDescripcionHecho.TextChanged += new System.EventHandler(this.txtDescripcionHecho_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(434, 333);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 25);
            this.label5.TabIndex = 79;
            this.label5.Text = "Estado de tarea:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // cmbEstadoTarea
            // 
            this.cmbEstadoTarea.FormattingEnabled = true;
            this.cmbEstadoTarea.Items.AddRange(new object[] {
            "Pendiente",
            "En progreso",
            "Completada"});
            this.cmbEstadoTarea.Location = new System.Drawing.Point(624, 337);
            this.cmbEstadoTarea.Name = "cmbEstadoTarea";
            this.cmbEstadoTarea.Size = new System.Drawing.Size(178, 24);
            this.cmbEstadoTarea.TabIndex = 80;
            this.cmbEstadoTarea.SelectedIndexChanged += new System.EventHandler(this.cmbEstadoTarea_SelectedIndexChanged);
            // 
            // dtpFechaAsignacion
            // 
            this.dtpFechaAsignacion.Location = new System.Drawing.Point(216, 497);
            this.dtpFechaAsignacion.Name = "dtpFechaAsignacion";
            this.dtpFechaAsignacion.Size = new System.Drawing.Size(586, 22);
            this.dtpFechaAsignacion.TabIndex = 81;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(12, 495);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 25);
            this.label6.TabIndex = 82;
            this.label6.Text = "Fecha Asignacion:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(12, 579);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(181, 25);
            this.label7.TabIndex = 83;
            this.label7.Text = "Fecha Finalizacion:";
            // 
            // dtpFechaFinalizacion
            // 
            this.dtpFechaFinalizacion.Location = new System.Drawing.Point(216, 582);
            this.dtpFechaFinalizacion.Name = "dtpFechaFinalizacion";
            this.dtpFechaFinalizacion.Size = new System.Drawing.Size(586, 22);
            this.dtpFechaFinalizacion.TabIndex = 84;
            // 
            // btnAgregarTarea
            // 
            this.btnAgregarTarea.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarTarea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(63)))), ((int)(((byte)(95)))));
            this.btnAgregarTarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarTarea.ForeColor = System.Drawing.Color.White;
            this.btnAgregarTarea.Location = new System.Drawing.Point(661, 715);
            this.btnAgregarTarea.Name = "btnAgregarTarea";
            this.btnAgregarTarea.Size = new System.Drawing.Size(141, 39);
            this.btnAgregarTarea.TabIndex = 85;
            this.btnAgregarTarea.Text = "Agregar";
            this.btnAgregarTarea.UseVisualStyleBackColor = false;
            this.btnAgregarTarea.Click += new System.EventHandler(this.btnAgregarTarea_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaDiseño.Properties.Resources.file;
            this.pictureBox1.Location = new System.Drawing.Point(47, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 69;
            this.pictureBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(12, 209);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(333, 25);
            this.label9.TabIndex = 87;
            this.label9.Text = "Ingrese Codigo De Bombero Acargo:";
            // 
            // txtCodigoBomberoAcargo
            // 
            this.txtCodigoBomberoAcargo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodigoBomberoAcargo.Location = new System.Drawing.Point(368, 209);
            this.txtCodigoBomberoAcargo.Name = "txtCodigoBomberoAcargo";
            this.txtCodigoBomberoAcargo.Size = new System.Drawing.Size(226, 22);
            this.txtCodigoBomberoAcargo.TabIndex = 86;
            // 
            // AltaTareas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(822, 789);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtCodigoBomberoAcargo);
            this.Controls.Add(this.btnAgregarTarea);
            this.Controls.Add(this.dtpFechaFinalizacion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpFechaAsignacion);
            this.Controls.Add(this.cmbEstadoTarea);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtDescripcionHecho);
            this.Controls.Add(this.btnAgregarBombero);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.listBoxBomberos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCodigoBombero);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AltaTareas";
            this.Text = "AltaTareas";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAgregarBombero;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ListBox listBoxBomberos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCodigoBombero;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDescripcionHecho;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbEstadoTarea;
        private System.Windows.Forms.DateTimePicker dtpFechaAsignacion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpFechaFinalizacion;
        private System.Windows.Forms.Button btnAgregarTarea;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCodigoBomberoAcargo;
    }
}