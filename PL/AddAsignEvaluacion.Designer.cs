namespace RRHH.PL
{
    partial class AddAsignEvaluacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAsignEvaluacion));
            this.lblIdEval = new System.Windows.Forms.Label();
            this.btnGuardarOtro = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmbAplicantes = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbVacantes = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.PictureBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpFechaEval = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpHoraEval = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIdEval
            // 
            this.lblIdEval.AutoSize = true;
            this.lblIdEval.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdEval.Location = new System.Drawing.Point(327, 23);
            this.lblIdEval.Name = "lblIdEval";
            this.lblIdEval.Size = new System.Drawing.Size(76, 24);
            this.lblIdEval.TabIndex = 37;
            this.lblIdEval.Text = "IDEVAL";
            // 
            // btnGuardarOtro
            // 
            this.btnGuardarOtro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardarOtro.BackColor = System.Drawing.Color.LightGreen;
            this.btnGuardarOtro.FlatAppearance.BorderSize = 0;
            this.btnGuardarOtro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarOtro.ForeColor = System.Drawing.Color.Black;
            this.btnGuardarOtro.Location = new System.Drawing.Point(454, 418);
            this.btnGuardarOtro.Name = "btnGuardarOtro";
            this.btnGuardarOtro.Size = new System.Drawing.Size(123, 23);
            this.btnGuardarOtro.TabIndex = 36;
            this.btnGuardarOtro.Text = "Asignar otro";
            this.btnGuardarOtro.UseVisualStyleBackColor = false;
            this.btnGuardarOtro.Click += new System.EventHandler(this.btnGuardarOtro_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.BackColor = System.Drawing.Color.LightGreen;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.ForeColor = System.Drawing.Color.Black;
            this.btnGuardar.Location = new System.Drawing.Point(583, 418);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(123, 23);
            this.btnGuardar.TabIndex = 34;
            this.btnGuardar.Text = "Asignar y terminar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(17, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(770, 338);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Asignar aplicantes";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.DarkGray;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.dtpHoraEval);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.dtpFechaEval);
            this.panel3.Controls.Add(this.cmbAplicantes);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.cmbVacantes);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(29, 49);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(712, 283);
            this.panel3.TabIndex = 22;
            // 
            // cmbAplicantes
            // 
            this.cmbAplicantes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbAplicantes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAplicantes.FormattingEnabled = true;
            this.cmbAplicantes.Location = new System.Drawing.Point(12, 107);
            this.cmbAplicantes.Name = "cmbAplicantes";
            this.cmbAplicantes.Size = new System.Drawing.Size(693, 24);
            this.cmbAplicantes.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(8, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Aplicantes";
            // 
            // cmbVacantes
            // 
            this.cmbVacantes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbVacantes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVacantes.FormattingEnabled = true;
            this.cmbVacantes.Location = new System.Drawing.Point(10, 40);
            this.cmbVacantes.Name = "cmbVacantes";
            this.cmbVacantes.Size = new System.Drawing.Size(693, 24);
            this.cmbVacantes.TabIndex = 21;
            this.cmbVacantes.SelectionChangeCommitted += new System.EventHandler(this.cmbVacantes_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(6, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Vacante del aplicante";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.BackColor = System.Drawing.Color.LightGray;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.Location = new System.Drawing.Point(712, 418);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 33;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(13, 23);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(25, 25);
            this.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBack.TabIndex = 32;
            this.btnBack.TabStop = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panel11
            // 
            this.panel11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel11.BackColor = System.Drawing.Color.Black;
            this.panel11.Location = new System.Drawing.Point(17, 50);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(771, 5);
            this.panel11.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(42, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(290, 24);
            this.label5.TabIndex = 30;
            this.label5.Text = "Agregar asignacion a evaluacion:";
            // 
            // dtpFechaEval
            // 
            this.dtpFechaEval.Location = new System.Drawing.Point(12, 175);
            this.dtpFechaEval.Name = "dtpFechaEval";
            this.dtpFechaEval.Size = new System.Drawing.Size(691, 23);
            this.dtpFechaEval.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(8, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Fecha de evaluacion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(8, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "Hora de evaluacion";
            // 
            // dtpHoraEval
            // 
            this.dtpHoraEval.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraEval.Location = new System.Drawing.Point(12, 244);
            this.dtpHoraEval.Name = "dtpHoraEval";
            this.dtpHoraEval.Size = new System.Drawing.Size(691, 23);
            this.dtpHoraEval.TabIndex = 26;
            this.dtpHoraEval.Value = new System.DateTime(2020, 6, 9, 9, 44, 0, 0);
            // 
            // AddAsignEvaluacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblIdEval);
            this.Controls.Add(this.btnGuardarOtro);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddAsignEvaluacion";
            this.Text = "AddAsignEvaluacion";
            this.groupBox1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIdEval;
        private System.Windows.Forms.Button btnGuardarOtro;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cmbAplicantes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbVacantes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.PictureBox btnBack;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpFechaEval;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpHoraEval;
        private System.Windows.Forms.Label label1;
    }
}