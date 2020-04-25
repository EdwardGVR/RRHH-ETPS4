namespace RRHH.PL
{
    partial class Recientes
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
            this.pnlRecientes = new System.Windows.Forms.Panel();
            this.btnVerTodasEvaluaciones = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnVerTodasCapacitaciones = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnVerTodasVacantes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvVacantesRecientes = new System.Windows.Forms.DataGridView();
            this.dgvCapaRecientes = new System.Windows.Forms.DataGridView();
            this.dgvEvalRecientes = new System.Windows.Forms.DataGridView();
            this.pnlRecientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVacantesRecientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCapaRecientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvalRecientes)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlRecientes
            // 
            this.pnlRecientes.AutoScroll = true;
            this.pnlRecientes.Controls.Add(this.dgvVacantesRecientes);
            this.pnlRecientes.Controls.Add(this.dgvEvalRecientes);
            this.pnlRecientes.Controls.Add(this.dgvCapaRecientes);
            this.pnlRecientes.Controls.Add(this.btnVerTodasEvaluaciones);
            this.pnlRecientes.Controls.Add(this.label3);
            this.pnlRecientes.Controls.Add(this.btnVerTodasCapacitaciones);
            this.pnlRecientes.Controls.Add(this.label2);
            this.pnlRecientes.Controls.Add(this.btnVerTodasVacantes);
            this.pnlRecientes.Controls.Add(this.label1);
            this.pnlRecientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRecientes.Location = new System.Drawing.Point(0, 0);
            this.pnlRecientes.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.pnlRecientes.Name = "pnlRecientes";
            this.pnlRecientes.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.pnlRecientes.Size = new System.Drawing.Size(800, 430);
            this.pnlRecientes.TabIndex = 0;
            // 
            // btnVerTodasEvaluaciones
            // 
            this.btnVerTodasEvaluaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVerTodasEvaluaciones.BackColor = System.Drawing.Color.Silver;
            this.btnVerTodasEvaluaciones.FlatAppearance.BorderSize = 0;
            this.btnVerTodasEvaluaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerTodasEvaluaciones.Location = new System.Drawing.Point(688, 447);
            this.btnVerTodasEvaluaciones.Name = "btnVerTodasEvaluaciones";
            this.btnVerTodasEvaluaciones.Size = new System.Drawing.Size(92, 23);
            this.btnVerTodasEvaluaciones.TabIndex = 8;
            this.btnVerTodasEvaluaciones.Text = "Ver todas";
            this.btnVerTodasEvaluaciones.UseVisualStyleBackColor = false;
            this.btnVerTodasEvaluaciones.Click += new System.EventHandler(this.btnVerTodasEvaluaciones_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 448);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Evaluaciones recientes";
            // 
            // btnVerTodasCapacitaciones
            // 
            this.btnVerTodasCapacitaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVerTodasCapacitaciones.BackColor = System.Drawing.Color.Silver;
            this.btnVerTodasCapacitaciones.FlatAppearance.BorderSize = 0;
            this.btnVerTodasCapacitaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerTodasCapacitaciones.Location = new System.Drawing.Point(688, 228);
            this.btnVerTodasCapacitaciones.Name = "btnVerTodasCapacitaciones";
            this.btnVerTodasCapacitaciones.Size = new System.Drawing.Size(92, 23);
            this.btnVerTodasCapacitaciones.TabIndex = 5;
            this.btnVerTodasCapacitaciones.Text = "Ver todas";
            this.btnVerTodasCapacitaciones.UseVisualStyleBackColor = false;
            this.btnVerTodasCapacitaciones.Click += new System.EventHandler(this.btnVerTodasCapacitaciones_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Capacitaciones recientes";
            // 
            // btnVerTodasVacantes
            // 
            this.btnVerTodasVacantes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVerTodasVacantes.BackColor = System.Drawing.Color.Silver;
            this.btnVerTodasVacantes.FlatAppearance.BorderSize = 0;
            this.btnVerTodasVacantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerTodasVacantes.Location = new System.Drawing.Point(688, 13);
            this.btnVerTodasVacantes.Name = "btnVerTodasVacantes";
            this.btnVerTodasVacantes.Size = new System.Drawing.Size(92, 23);
            this.btnVerTodasVacantes.TabIndex = 2;
            this.btnVerTodasVacantes.Text = "Ver todas";
            this.btnVerTodasVacantes.UseVisualStyleBackColor = false;
            this.btnVerTodasVacantes.Click += new System.EventHandler(this.btnVerTodasVacantes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vacantes recientes";
            // 
            // dgvVacantesRecientes
            // 
            this.dgvVacantesRecientes.AllowUserToAddRows = false;
            this.dgvVacantesRecientes.AllowUserToDeleteRows = false;
            this.dgvVacantesRecientes.AllowUserToResizeColumns = false;
            this.dgvVacantesRecientes.AllowUserToResizeRows = false;
            this.dgvVacantesRecientes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVacantesRecientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVacantesRecientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvVacantesRecientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVacantesRecientes.Location = new System.Drawing.Point(18, 43);
            this.dgvVacantesRecientes.Name = "dgvVacantesRecientes";
            this.dgvVacantesRecientes.Size = new System.Drawing.Size(763, 131);
            this.dgvVacantesRecientes.TabIndex = 0;
            // 
            // dgvCapaRecientes
            // 
            this.dgvCapaRecientes.AllowUserToAddRows = false;
            this.dgvCapaRecientes.AllowUserToDeleteRows = false;
            this.dgvCapaRecientes.AllowUserToResizeColumns = false;
            this.dgvCapaRecientes.AllowUserToResizeRows = false;
            this.dgvCapaRecientes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCapaRecientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCapaRecientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCapaRecientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCapaRecientes.Location = new System.Drawing.Point(18, 263);
            this.dgvCapaRecientes.Name = "dgvCapaRecientes";
            this.dgvCapaRecientes.Size = new System.Drawing.Size(762, 131);
            this.dgvCapaRecientes.TabIndex = 1;
            // 
            // dgvEvalRecientes
            // 
            this.dgvEvalRecientes.AllowUserToAddRows = false;
            this.dgvEvalRecientes.AllowUserToDeleteRows = false;
            this.dgvEvalRecientes.AllowUserToResizeColumns = false;
            this.dgvEvalRecientes.AllowUserToResizeRows = false;
            this.dgvEvalRecientes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEvalRecientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEvalRecientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEvalRecientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEvalRecientes.Location = new System.Drawing.Point(16, 481);
            this.dgvEvalRecientes.Name = "dgvEvalRecientes";
            this.dgvEvalRecientes.Size = new System.Drawing.Size(764, 131);
            this.dgvEvalRecientes.TabIndex = 2;
            // 
            // Recientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlRecientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Recientes";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.Text = "Recientes";
            this.Resize += new System.EventHandler(this.Recientes_Resize);
            this.pnlRecientes.ResumeLayout(false);
            this.pnlRecientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVacantesRecientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCapaRecientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvalRecientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlRecientes;
        private System.Windows.Forms.Button btnVerTodasEvaluaciones;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnVerTodasCapacitaciones;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnVerTodasVacantes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvVacantesRecientes;
        private System.Windows.Forms.DataGridView dgvEvalRecientes;
        private System.Windows.Forms.DataGridView dgvCapaRecientes;
    }
}