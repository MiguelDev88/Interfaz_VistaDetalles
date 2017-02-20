namespace VistaDetalles
{
    partial class frmVistaDetalles
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMail = new System.Windows.Forms.Label();
            this.txtContacto = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.Label();
            this.lbMail = new System.Windows.Forms.Label();
            this.lbContacto = new System.Windows.Forms.Label();
            this.lbTlf = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbDni = new System.Windows.Forms.Label();
            this.listaClientes = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtMail);
            this.groupBox1.Controls.Add(this.txtContacto);
            this.groupBox1.Controls.Add(this.txtTelefono);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.txtDni);
            this.groupBox1.Controls.Add(this.lbMail);
            this.groupBox1.Controls.Add(this.lbContacto);
            this.groupBox1.Controls.Add(this.lbTlf);
            this.groupBox1.Controls.Add(this.lbNombre);
            this.groupBox1.Controls.Add(this.lbDni);
            this.groupBox1.Location = new System.Drawing.Point(171, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 256);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Cliente";
            // 
            // txtMail
            // 
            this.txtMail.AutoSize = true;
            this.txtMail.Location = new System.Drawing.Point(155, 225);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(0, 13);
            this.txtMail.TabIndex = 9;
            // 
            // txtContacto
            // 
            this.txtContacto.AutoSize = true;
            this.txtContacto.Location = new System.Drawing.Point(155, 179);
            this.txtContacto.Name = "txtContacto";
            this.txtContacto.Size = new System.Drawing.Size(0, 13);
            this.txtContacto.TabIndex = 8;
            // 
            // txtTelefono
            // 
            this.txtTelefono.AutoSize = true;
            this.txtTelefono.Location = new System.Drawing.Point(155, 133);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(0, 13);
            this.txtTelefono.TabIndex = 7;
            // 
            // txtNombre
            // 
            this.txtNombre.AutoSize = true;
            this.txtNombre.Location = new System.Drawing.Point(155, 87);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(0, 13);
            this.txtNombre.TabIndex = 6;
            // 
            // txtDni
            // 
            this.txtDni.AutoSize = true;
            this.txtDni.Location = new System.Drawing.Point(155, 41);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(0, 13);
            this.txtDni.TabIndex = 5;
            // 
            // lbMail
            // 
            this.lbMail.AutoSize = true;
            this.lbMail.Location = new System.Drawing.Point(32, 225);
            this.lbMail.Name = "lbMail";
            this.lbMail.Size = new System.Drawing.Size(38, 13);
            this.lbMail.TabIndex = 4;
            this.lbMail.Text = "E-mail:";
            // 
            // lbContacto
            // 
            this.lbContacto.AutoSize = true;
            this.lbContacto.Location = new System.Drawing.Point(32, 179);
            this.lbContacto.Name = "lbContacto";
            this.lbContacto.Size = new System.Drawing.Size(110, 13);
            this.lbContacto.TabIndex = 3;
            this.lbContacto.Text = "Persona de Contacto:";
            // 
            // lbTlf
            // 
            this.lbTlf.AutoSize = true;
            this.lbTlf.Location = new System.Drawing.Point(32, 133);
            this.lbTlf.Name = "lbTlf";
            this.lbTlf.Size = new System.Drawing.Size(52, 13);
            this.lbTlf.TabIndex = 2;
            this.lbTlf.Text = "Teléfono:";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(32, 87);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(47, 13);
            this.lbNombre.TabIndex = 1;
            this.lbNombre.Text = "Nombre:";
            // 
            // lbDni
            // 
            this.lbDni.AutoSize = true;
            this.lbDni.Location = new System.Drawing.Point(32, 41);
            this.lbDni.Name = "lbDni";
            this.lbDni.Size = new System.Drawing.Size(26, 13);
            this.lbDni.TabIndex = 0;
            this.lbDni.Text = "DNI";
            // 
            // listaClientes
            // 
            this.listaClientes.Location = new System.Drawing.Point(12, 12);
            this.listaClientes.Name = "listaClientes";
            this.listaClientes.Size = new System.Drawing.Size(153, 256);
            this.listaClientes.TabIndex = 2;
            this.listaClientes.UseCompatibleStateImageBehavior = false;
            this.listaClientes.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listaClientes_ItemSelectionChanged);
            // 
            // frmVistaDetalles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 274);
            this.Controls.Add(this.listaClientes);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmVistaDetalles";
            this.Text = "Vista Detallada de Clientes";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbMail;
        private System.Windows.Forms.Label lbContacto;
        private System.Windows.Forms.Label lbTlf;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbDni;
        private System.Windows.Forms.Label txtMail;
        private System.Windows.Forms.Label txtContacto;
        private System.Windows.Forms.Label txtTelefono;
        private System.Windows.Forms.Label txtNombre;
        private System.Windows.Forms.Label txtDni;
        private System.Windows.Forms.ListView listaClientes;
    }
}

