namespace Serie3_Ejecicio2_ExamenFinal_0902_22_12338
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.RegistroGroupBox = new System.Windows.Forms.GroupBox();
            this.LabelCodigo = new System.Windows.Forms.Label();
            this.LabelNombre = new System.Windows.Forms.Label();
            this.LabelCategoría = new System.Windows.Forms.Label();
            this.LabelFecha = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.DatePickerFechaRegistro = new System.Windows.Forms.DateTimePicker();
            this.BtnRegistrar = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.dataGridViewTabla = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.RegistroGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTabla)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.RegistroGroupBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(536, 160);
            this.panel1.TabIndex = 0;
            // 
            // RegistroGroupBox
            // 
            this.RegistroGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RegistroGroupBox.Controls.Add(this.BtnSalir);
            this.RegistroGroupBox.Controls.Add(this.BtnLimpiar);
            this.RegistroGroupBox.Controls.Add(this.BtnRegistrar);
            this.RegistroGroupBox.Controls.Add(this.DatePickerFechaRegistro);
            this.RegistroGroupBox.Controls.Add(this.textBox3);
            this.RegistroGroupBox.Controls.Add(this.textBox2);
            this.RegistroGroupBox.Controls.Add(this.textBox1);
            this.RegistroGroupBox.Controls.Add(this.LabelFecha);
            this.RegistroGroupBox.Controls.Add(this.LabelCategoría);
            this.RegistroGroupBox.Controls.Add(this.LabelNombre);
            this.RegistroGroupBox.Controls.Add(this.LabelCodigo);
            this.RegistroGroupBox.Location = new System.Drawing.Point(12, 12);
            this.RegistroGroupBox.Name = "RegistroGroupBox";
            this.RegistroGroupBox.Size = new System.Drawing.Size(512, 132);
            this.RegistroGroupBox.TabIndex = 0;
            this.RegistroGroupBox.TabStop = false;
            this.RegistroGroupBox.Text = "Registro de Productos";
            // 
            // LabelCodigo
            // 
            this.LabelCodigo.AutoSize = true;
            this.LabelCodigo.Location = new System.Drawing.Point(6, 25);
            this.LabelCodigo.Name = "LabelCodigo";
            this.LabelCodigo.Size = new System.Drawing.Size(102, 13);
            this.LabelCodigo.TabIndex = 0;
            this.LabelCodigo.Text = "Codigo del producto";
            this.LabelCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabelNombre
            // 
            this.LabelNombre.AutoSize = true;
            this.LabelNombre.Location = new System.Drawing.Point(6, 50);
            this.LabelNombre.Name = "LabelNombre";
            this.LabelNombre.Size = new System.Drawing.Size(106, 13);
            this.LabelNombre.TabIndex = 1;
            this.LabelNombre.Text = "Nombre del producto";
            this.LabelNombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabelCategoría
            // 
            this.LabelCategoría.AutoSize = true;
            this.LabelCategoría.Location = new System.Drawing.Point(6, 74);
            this.LabelCategoría.Name = "LabelCategoría";
            this.LabelCategoría.Size = new System.Drawing.Size(54, 13);
            this.LabelCategoría.TabIndex = 2;
            this.LabelCategoría.Text = "Categoría";
            this.LabelCategoría.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabelFecha
            // 
            this.LabelFecha.AutoSize = true;
            this.LabelFecha.Location = new System.Drawing.Point(6, 98);
            this.LabelFecha.Name = "LabelFecha";
            this.LabelFecha.Size = new System.Drawing.Size(37, 13);
            this.LabelFecha.TabIndex = 3;
            this.LabelFecha.Text = "Fecha";
            this.LabelFecha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(114, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(175, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(113, 48);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(175, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(113, 74);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(175, 20);
            this.textBox3.TabIndex = 6;
            // 
            // DatePickerFechaRegistro
            // 
            this.DatePickerFechaRegistro.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DatePickerFechaRegistro.Location = new System.Drawing.Point(113, 100);
            this.DatePickerFechaRegistro.Name = "DatePickerFechaRegistro";
            this.DatePickerFechaRegistro.Size = new System.Drawing.Size(176, 20);
            this.DatePickerFechaRegistro.TabIndex = 7;
            // 
            // BtnRegistrar
            // 
            this.BtnRegistrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRegistrar.Location = new System.Drawing.Point(354, 27);
            this.BtnRegistrar.Name = "BtnRegistrar";
            this.BtnRegistrar.Size = new System.Drawing.Size(112, 23);
            this.BtnRegistrar.TabIndex = 8;
            this.BtnRegistrar.Text = "Registrar producto";
            this.BtnRegistrar.UseVisualStyleBackColor = true;
            this.BtnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnLimpiar.Location = new System.Drawing.Point(354, 56);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(112, 23);
            this.BtnLimpiar.TabIndex = 9;
            this.BtnLimpiar.Text = "Limpiar datos";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            // 
            // BtnSalir
            // 
            this.BtnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSalir.Location = new System.Drawing.Point(354, 85);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(112, 23);
            this.BtnSalir.TabIndex = 10;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTabla
            // 
            this.dataGridViewTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTabla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewTabla.Location = new System.Drawing.Point(0, 160);
            this.dataGridViewTabla.Name = "dataGridViewTabla";
            this.dataGridViewTabla.Size = new System.Drawing.Size(536, 159);
            this.dataGridViewTabla.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 319);
            this.Controls.Add(this.dataGridViewTabla);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.RegistroGroupBox.ResumeLayout(false);
            this.RegistroGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTabla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox RegistroGroupBox;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnRegistrar;
        private System.Windows.Forms.DateTimePicker DatePickerFechaRegistro;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label LabelFecha;
        private System.Windows.Forms.Label LabelCategoría;
        private System.Windows.Forms.Label LabelNombre;
        private System.Windows.Forms.Label LabelCodigo;
        private System.Windows.Forms.DataGridView dataGridViewTabla;
    }
}

