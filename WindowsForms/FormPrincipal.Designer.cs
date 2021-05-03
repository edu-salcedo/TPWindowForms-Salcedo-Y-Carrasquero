namespace WindowsForms
{
    partial class FormPrincipal
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
            this.dgvlista = new System.Windows.Forms.DataGridView();
            this.Saludo = new System.Windows.Forms.Label();
            this.btnIvolver = new System.Windows.Forms.Button();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.btnDetalle = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.tbfiltro = new System.Windows.Forms.TextBox();
            this.pbBuscar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvlista
            // 
            this.dgvlista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvlista.BackgroundColor = System.Drawing.Color.White;
            this.dgvlista.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvlista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvlista.Location = new System.Drawing.Point(32, 105);
            this.dgvlista.MultiSelect = false;
            this.dgvlista.Name = "dgvlista";
            this.dgvlista.ReadOnly = true;
            this.dgvlista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvlista.Size = new System.Drawing.Size(561, 254);
            this.dgvlista.TabIndex = 14;
            this.dgvlista.SelectionChanged += new System.EventHandler(this.dgvlista_SelectionChanged);
            // 
            // Saludo
            // 
            this.Saludo.AutoSize = true;
            this.Saludo.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Saludo.Location = new System.Drawing.Point(265, 9);
            this.Saludo.Name = "Saludo";
            this.Saludo.Size = new System.Drawing.Size(103, 32);
            this.Saludo.TabIndex = 15;
            this.Saludo.Text = "Hola  ";
            // 
            // btnIvolver
            // 
            this.btnIvolver.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnIvolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIvolver.ForeColor = System.Drawing.Color.Black;
            this.btnIvolver.Location = new System.Drawing.Point(671, 388);
            this.btnIvolver.Name = "btnIvolver";
            this.btnIvolver.Size = new System.Drawing.Size(116, 41);
            this.btnIvolver.TabIndex = 16;
            this.btnIvolver.Text = "VOLVER";
            this.btnIvolver.UseVisualStyleBackColor = false;
            this.btnIvolver.Click += new System.EventHandler(this.btnIvolver_Click);
            // 
            // pbImagen
            // 
            this.pbImagen.Location = new System.Drawing.Point(621, 105);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(214, 254);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagen.TabIndex = 17;
            this.pbImagen.TabStop = false;
            // 
            // btnDetalle
            // 
            this.btnDetalle.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetalle.ForeColor = System.Drawing.Color.Black;
            this.btnDetalle.Location = new System.Drawing.Point(667, 48);
            this.btnDetalle.Name = "btnDetalle";
            this.btnDetalle.Size = new System.Drawing.Size(120, 51);
            this.btnDetalle.TabIndex = 18;
            this.btnDetalle.Text = "VER DETALLE";
            this.btnDetalle.UseVisualStyleBackColor = false;
            this.btnDetalle.Click += new System.EventHandler(this.btnDetalle_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.Black;
            this.btnAgregar.Location = new System.Drawing.Point(32, 388);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(116, 41);
            this.btnAgregar.TabIndex = 19;
            this.btnAgregar.Text = "AREGAR";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // tbfiltro
            // 
            this.tbfiltro.Location = new System.Drawing.Point(89, 71);
            this.tbfiltro.Name = "tbfiltro";
            this.tbfiltro.Size = new System.Drawing.Size(279, 20);
            this.tbfiltro.TabIndex = 20;
            this.tbfiltro.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbfiltro_KeyUp);
            // 
            // pbBuscar
            // 
            this.pbBuscar.Image = global::WindowsForms.Properties.Resources.bus;
            this.pbBuscar.Location = new System.Drawing.Point(374, 63);
            this.pbBuscar.Name = "pbBuscar";
            this.pbBuscar.Size = new System.Drawing.Size(32, 28);
            this.pbBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBuscar.TabIndex = 21;
            this.pbBuscar.TabStop = false;
            this.pbBuscar.Click += new System.EventHandler(this.pbBuscar_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 450);
            this.Controls.Add(this.pbBuscar);
            this.Controls.Add(this.tbfiltro);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnDetalle);
            this.Controls.Add(this.pbImagen);
            this.Controls.Add(this.btnIvolver);
            this.Controls.Add(this.Saludo);
            this.Controls.Add(this.dgvlista);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvlista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvlista;
        private System.Windows.Forms.Label Saludo;
        private System.Windows.Forms.Button btnIvolver;
        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.Button btnDetalle;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox tbfiltro;
        private System.Windows.Forms.PictureBox pbBuscar;
    }
}