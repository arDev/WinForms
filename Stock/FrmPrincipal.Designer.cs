namespace Stock
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
            this.txtEtiqueta = new System.Windows.Forms.Label();
            this.tbxNombre = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.Label();
            this.btnSaludar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lbxAlumnos = new System.Windows.Forms.ListBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.tbxNombre2 = new System.Windows.Forms.TextBox();
            this.tbxApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.btnBorrarLista = new System.Windows.Forms.Button();
            this.btnBorrarItem = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtEtiqueta
            // 
            this.txtEtiqueta.AutoSize = true;
            this.txtEtiqueta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEtiqueta.ForeColor = System.Drawing.Color.Orange;
            this.txtEtiqueta.Location = new System.Drawing.Point(29, 37);
            this.txtEtiqueta.Name = "txtEtiqueta";
            this.txtEtiqueta.Size = new System.Drawing.Size(191, 25);
            this.txtEtiqueta.TabIndex = 0;
            this.txtEtiqueta.Text = "Ingrese su nombre";
            // 
            // tbxNombre
            // 
            this.tbxNombre.Location = new System.Drawing.Point(262, 40);
            this.tbxNombre.Name = "tbxNombre";
            this.tbxNombre.Size = new System.Drawing.Size(165, 22);
            this.tbxNombre.TabIndex = 1;
            // 
            // txtEstado
            // 
            this.txtEstado.AutoSize = true;
            this.txtEstado.Location = new System.Drawing.Point(271, 98);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(50, 16);
            this.txtEstado.TabIndex = 2;
            this.txtEstado.Text = "Saludo";
            // 
            // btnSaludar
            // 
            this.btnSaludar.Location = new System.Drawing.Point(453, 41);
            this.btnSaludar.Name = "btnSaludar";
            this.btnSaludar.Size = new System.Drawing.Size(161, 23);
            this.btnSaludar.TabIndex = 3;
            this.btnSaludar.Text = "Agregar a la lista";
            this.btnSaludar.UseVisualStyleBackColor = true;
            this.btnSaludar.Click += new System.EventHandler(this.btnSaludar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(453, 70);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(161, 23);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lbxAlumnos
            // 
            this.lbxAlumnos.FormattingEnabled = true;
            this.lbxAlumnos.ItemHeight = 16;
            this.lbxAlumnos.Location = new System.Drawing.Point(34, 98);
            this.lbxAlumnos.Name = "lbxAlumnos";
            this.lbxAlumnos.Size = new System.Drawing.Size(120, 84);
            this.lbxAlumnos.TabIndex = 5;
            this.lbxAlumnos.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(515, 252);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(134, 23);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // tbxNombre2
            // 
            this.tbxNombre2.Location = new System.Drawing.Point(262, 253);
            this.tbxNombre2.Name = "tbxNombre2";
            this.tbxNombre2.Size = new System.Drawing.Size(215, 22);
            this.tbxNombre2.TabIndex = 7;
            // 
            // tbxApellido
            // 
            this.tbxApellido.Location = new System.Drawing.Point(262, 281);
            this.tbxApellido.Name = "tbxApellido";
            this.tbxApellido.Size = new System.Drawing.Size(215, 22);
            this.tbxApellido.TabIndex = 7;
            // 
            // txtNombre
            // 
            this.txtNombre.AutoSize = true;
            this.txtNombre.Location = new System.Drawing.Point(196, 256);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(59, 16);
            this.txtNombre.TabIndex = 8;
            this.txtNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(196, 287);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(60, 16);
            this.lblApellido.TabIndex = 9;
            this.lblApellido.Text = "Apellido:";
            // 
            // btnBorrarLista
            // 
            this.btnBorrarLista.Location = new System.Drawing.Point(199, 144);
            this.btnBorrarLista.Name = "btnBorrarLista";
            this.btnBorrarLista.Size = new System.Drawing.Size(139, 23);
            this.btnBorrarLista.TabIndex = 10;
            this.btnBorrarLista.Text = "Borrar Lista";
            this.btnBorrarLista.UseVisualStyleBackColor = true;
            this.btnBorrarLista.Click += new System.EventHandler(this.btnBorrarLista_Click);
            // 
            // btnBorrarItem
            // 
            this.btnBorrarItem.Location = new System.Drawing.Point(199, 173);
            this.btnBorrarItem.Name = "btnBorrarItem";
            this.btnBorrarItem.Size = new System.Drawing.Size(139, 23);
            this.btnBorrarItem.TabIndex = 11;
            this.btnBorrarItem.Text = "Borrar Item";
            this.btnBorrarItem.UseVisualStyleBackColor = true;
            this.btnBorrarItem.Click += new System.EventHandler(this.btnBorrarItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(551, 335);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(551, 364);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "button1";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(551, 393);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "button1";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnBorrarItem);
            this.Controls.Add(this.btnBorrarLista);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.tbxApellido);
            this.Controls.Add(this.tbxNombre2);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lbxAlumnos);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnSaludar);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.tbxNombre);
            this.Controls.Add(this.txtEtiqueta);
            this.Name = "FrmPrincipal";
            this.Text = "Mi programa de Stock";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtEtiqueta;
        private System.Windows.Forms.TextBox tbxNombre;
        private System.Windows.Forms.Label txtEstado;
        private System.Windows.Forms.Button btnSaludar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.ListBox lbxAlumnos;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox tbxNombre2;
        private System.Windows.Forms.TextBox tbxApellido;
        private System.Windows.Forms.Label txtNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Button btnBorrarLista;
        private System.Windows.Forms.Button btnBorrarItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

