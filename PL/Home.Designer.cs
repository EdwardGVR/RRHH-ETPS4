namespace RRHH.PL
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.btnVacantes = new System.Windows.Forms.Button();
            this.btnCapacitaciones = new System.Windows.Forms.Button();
            this.btnEvaluaciones = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.lblNivelUser = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.pnlContent);
            this.panel1.Controls.Add(this.pnlMenu);
            this.panel1.Controls.Add(this.pnlHeader);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.pnlTitulo);
            this.pnlHeader.Controls.Add(this.panel2);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(800, 80);
            this.pnlHeader.TabIndex = 0;
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.Black;
            this.pnlMenu.Controls.Add(this.label1);
            this.pnlMenu.Controls.Add(this.btnUsuarios);
            this.pnlMenu.Controls.Add(this.btnEvaluaciones);
            this.pnlMenu.Controls.Add(this.btnCapacitaciones);
            this.pnlMenu.Controls.Add(this.btnVacantes);
            this.pnlMenu.Controls.Add(this.btnEmpleados);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 80);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(200, 370);
            this.pnlMenu.TabIndex = 1;
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.Gray;
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(200, 80);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(600, 370);
            this.pnlContent.TabIndex = 2;
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.BackColor = System.Drawing.Color.Black;
            this.btnEmpleados.FlatAppearance.BorderSize = 0;
            this.btnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpleados.ForeColor = System.Drawing.Color.White;
            this.btnEmpleados.Location = new System.Drawing.Point(0, 78);
            this.btnEmpleados.Margin = new System.Windows.Forms.Padding(0);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(200, 42);
            this.btnEmpleados.TabIndex = 0;
            this.btnEmpleados.Text = "Empleados";
            this.btnEmpleados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpleados.UseVisualStyleBackColor = false;
            // 
            // btnVacantes
            // 
            this.btnVacantes.BackColor = System.Drawing.Color.Black;
            this.btnVacantes.FlatAppearance.BorderSize = 0;
            this.btnVacantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVacantes.ForeColor = System.Drawing.Color.White;
            this.btnVacantes.Location = new System.Drawing.Point(0, 120);
            this.btnVacantes.Margin = new System.Windows.Forms.Padding(0);
            this.btnVacantes.Name = "btnVacantes";
            this.btnVacantes.Size = new System.Drawing.Size(200, 42);
            this.btnVacantes.TabIndex = 0;
            this.btnVacantes.Text = "Vacantes";
            this.btnVacantes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVacantes.UseVisualStyleBackColor = false;
            // 
            // btnCapacitaciones
            // 
            this.btnCapacitaciones.BackColor = System.Drawing.Color.Black;
            this.btnCapacitaciones.FlatAppearance.BorderSize = 0;
            this.btnCapacitaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapacitaciones.ForeColor = System.Drawing.Color.White;
            this.btnCapacitaciones.Location = new System.Drawing.Point(0, 162);
            this.btnCapacitaciones.Margin = new System.Windows.Forms.Padding(0);
            this.btnCapacitaciones.Name = "btnCapacitaciones";
            this.btnCapacitaciones.Size = new System.Drawing.Size(200, 42);
            this.btnCapacitaciones.TabIndex = 0;
            this.btnCapacitaciones.Text = "Capacitaciones";
            this.btnCapacitaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCapacitaciones.UseVisualStyleBackColor = false;
            // 
            // btnEvaluaciones
            // 
            this.btnEvaluaciones.BackColor = System.Drawing.Color.Black;
            this.btnEvaluaciones.FlatAppearance.BorderSize = 0;
            this.btnEvaluaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEvaluaciones.ForeColor = System.Drawing.Color.White;
            this.btnEvaluaciones.Location = new System.Drawing.Point(0, 204);
            this.btnEvaluaciones.Margin = new System.Windows.Forms.Padding(0);
            this.btnEvaluaciones.Name = "btnEvaluaciones";
            this.btnEvaluaciones.Size = new System.Drawing.Size(200, 42);
            this.btnEvaluaciones.TabIndex = 0;
            this.btnEvaluaciones.Text = "Evaluaciones";
            this.btnEvaluaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEvaluaciones.UseVisualStyleBackColor = false;
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackColor = System.Drawing.Color.Black;
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnUsuarios.Location = new System.Drawing.Point(0, 246);
            this.btnUsuarios.Margin = new System.Windows.Forms.Padding(0);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(200, 42);
            this.btnUsuarios.TabIndex = 0;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Menú";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblNivelUser);
            this.panel2.Controls.Add(this.lblNombreUsuario);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 80);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNombreUsuario.Location = new System.Drawing.Point(68, 13);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(84, 13);
            this.lblNombreUsuario.TabIndex = 1;
            this.lblNombreUsuario.Text = "Nombre Apellido";
            // 
            // lblNivelUser
            // 
            this.lblNivelUser.AutoSize = true;
            this.lblNivelUser.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNivelUser.Location = new System.Drawing.Point(68, 29);
            this.lblNivelUser.Name = "lblNivelUser";
            this.lblNivelUser.Size = new System.Drawing.Size(31, 13);
            this.lblNivelUser.TabIndex = 2;
            this.lblNivelUser.Text = "Nivel";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(248, 38);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(116, 13);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Recursos Humanos";
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.Controls.Add(this.lblTitulo);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(200, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(600, 80);
            this.pnlTitulo.TabIndex = 3;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.Tag = "Homes";
            this.Text = "Home";
            this.Resize += new System.EventHandler(this.Home_Resize);
            this.panel1.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnEvaluaciones;
        private System.Windows.Forms.Button btnCapacitaciones;
        private System.Windows.Forms.Button btnVacantes;
        private System.Windows.Forms.Button btnEmpleados;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblNivelUser;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlTitulo;
    }
}