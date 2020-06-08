namespace RRHH.PL
{
    partial class Capacitaciones
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAgregarCapacitacion = new System.Windows.Forms.Button();
            this.dgvCapacitaciones = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCapacitaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(17, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(771, 5);
            this.panel2.TabIndex = 7;
            // 
            // btnAgregarCapacitacion
            // 
            this.btnAgregarCapacitacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarCapacitacion.BackColor = System.Drawing.Color.Silver;
            this.btnAgregarCapacitacion.FlatAppearance.BorderSize = 0;
            this.btnAgregarCapacitacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCapacitacion.Location = new System.Drawing.Point(686, 393);
            this.btnAgregarCapacitacion.Name = "btnAgregarCapacitacion";
            this.btnAgregarCapacitacion.Size = new System.Drawing.Size(102, 39);
            this.btnAgregarCapacitacion.TabIndex = 6;
            this.btnAgregarCapacitacion.Text = "Agregar";
            this.btnAgregarCapacitacion.UseVisualStyleBackColor = false;
            this.btnAgregarCapacitacion.Click += new System.EventHandler(this.btnAgregarCapacitacion_Click);
            // 
            // dgvCapacitaciones
            // 
            this.dgvCapacitaciones.AllowUserToAddRows = false;
            this.dgvCapacitaciones.AllowUserToDeleteRows = false;
            this.dgvCapacitaciones.AllowUserToResizeColumns = false;
            this.dgvCapacitaciones.AllowUserToResizeRows = false;
            this.dgvCapacitaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCapacitaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCapacitaciones.BackgroundColor = System.Drawing.Color.DimGray;
            this.dgvCapacitaciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCapacitaciones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvCapacitaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCapacitaciones.Location = new System.Drawing.Point(12, 97);
            this.dgvCapacitaciones.MultiSelect = false;
            this.dgvCapacitaciones.Name = "dgvCapacitaciones";
            this.dgvCapacitaciones.ReadOnly = true;
            this.dgvCapacitaciones.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvCapacitaciones.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvCapacitaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCapacitaciones.Size = new System.Drawing.Size(776, 272);
            this.dgvCapacitaciones.TabIndex = 5;
            this.dgvCapacitaciones.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCapacitaciones_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Listado de capacitaciones";
            // 
            // Capacitaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnAgregarCapacitacion);
            this.Controls.Add(this.dgvCapacitaciones);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Capacitaciones";
            this.Text = "Capacitaciones";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCapacitaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAgregarCapacitacion;
        private System.Windows.Forms.DataGridView dgvCapacitaciones;
        private System.Windows.Forms.Label label1;
    }
}