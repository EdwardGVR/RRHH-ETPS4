namespace RRHH.PL
{
    partial class Vacantes
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvVacantes = new System.Windows.Forms.DataGridView();
            this.btnAgregarVacante = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVacantes)).BeginInit();
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
            this.panel2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Listado de vacantes";
            // 
            // dgvVacantes
            // 
            this.dgvVacantes.AllowUserToAddRows = false;
            this.dgvVacantes.AllowUserToDeleteRows = false;
            this.dgvVacantes.AllowUserToResizeColumns = false;
            this.dgvVacantes.AllowUserToResizeRows = false;
            this.dgvVacantes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVacantes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVacantes.BackgroundColor = System.Drawing.Color.DimGray;
            this.dgvVacantes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvVacantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVacantes.Location = new System.Drawing.Point(17, 98);
            this.dgvVacantes.Name = "dgvVacantes";
            this.dgvVacantes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvVacantes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVacantes.Size = new System.Drawing.Size(771, 267);
            this.dgvVacantes.TabIndex = 6;
            // 
            // btnAgregarVacante
            // 
            this.btnAgregarVacante.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarVacante.BackColor = System.Drawing.Color.Silver;
            this.btnAgregarVacante.FlatAppearance.BorderSize = 0;
            this.btnAgregarVacante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarVacante.Location = new System.Drawing.Point(686, 393);
            this.btnAgregarVacante.Name = "btnAgregarVacante";
            this.btnAgregarVacante.Size = new System.Drawing.Size(102, 39);
            this.btnAgregarVacante.TabIndex = 7;
            this.btnAgregarVacante.Text = "Agregar";
            this.btnAgregarVacante.UseVisualStyleBackColor = false;
            // 
            // Vacantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAgregarVacante);
            this.Controls.Add(this.dgvVacantes);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Vacantes";
            this.Text = "Vacantes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVacantes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvVacantes;
        private System.Windows.Forms.Button btnAgregarVacante;
    }
}