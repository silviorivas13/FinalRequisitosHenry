namespace FinalRequisitosHenry
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnpagos = new FontAwesome.Sharp.IconButton();
            this.btnregistromaterias = new FontAwesome.Sharp.IconButton();
            this.btnhorarios = new FontAwesome.Sharp.IconButton();
            this.btnasignaturas = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.paneltitlebar = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelescritorio = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.btnpagos);
            this.panel1.Controls.Add(this.btnregistromaterias);
            this.panel1.Controls.Add(this.btnhorarios);
            this.panel1.Controls.Add(this.btnasignaturas);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 493);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnpagos
            // 
            this.btnpagos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnpagos.FlatAppearance.BorderSize = 0;
            this.btnpagos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpagos.IconChar = FontAwesome.Sharp.IconChar.DollarSign;
            this.btnpagos.IconColor = System.Drawing.Color.Black;
            this.btnpagos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnpagos.IconSize = 32;
            this.btnpagos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnpagos.Location = new System.Drawing.Point(0, 280);
            this.btnpagos.Name = "btnpagos";
            this.btnpagos.Size = new System.Drawing.Size(240, 60);
            this.btnpagos.TabIndex = 5;
            this.btnpagos.Text = "Pagos";
            this.btnpagos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnpagos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnpagos.UseVisualStyleBackColor = true;
            this.btnpagos.Click += new System.EventHandler(this.btnpagos_Click);
            // 
            // btnregistromaterias
            // 
            this.btnregistromaterias.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnregistromaterias.FlatAppearance.BorderSize = 0;
            this.btnregistromaterias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnregistromaterias.IconChar = FontAwesome.Sharp.IconChar.EnvelopeOpenText;
            this.btnregistromaterias.IconColor = System.Drawing.Color.Black;
            this.btnregistromaterias.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnregistromaterias.IconSize = 32;
            this.btnregistromaterias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnregistromaterias.Location = new System.Drawing.Point(0, 220);
            this.btnregistromaterias.Name = "btnregistromaterias";
            this.btnregistromaterias.Size = new System.Drawing.Size(240, 60);
            this.btnregistromaterias.TabIndex = 3;
            this.btnregistromaterias.Text = "Registro de  Materias";
            this.btnregistromaterias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnregistromaterias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnregistromaterias.UseVisualStyleBackColor = true;
            this.btnregistromaterias.Click += new System.EventHandler(this.btnregistromaterias_Click);
            // 
            // btnhorarios
            // 
            this.btnhorarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnhorarios.FlatAppearance.BorderSize = 0;
            this.btnhorarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhorarios.IconChar = FontAwesome.Sharp.IconChar.CalendarAlt;
            this.btnhorarios.IconColor = System.Drawing.Color.Black;
            this.btnhorarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnhorarios.IconSize = 32;
            this.btnhorarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnhorarios.Location = new System.Drawing.Point(0, 160);
            this.btnhorarios.Name = "btnhorarios";
            this.btnhorarios.Size = new System.Drawing.Size(240, 60);
            this.btnhorarios.TabIndex = 2;
            this.btnhorarios.Text = "Horarios";
            this.btnhorarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnhorarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnhorarios.UseVisualStyleBackColor = true;
            this.btnhorarios.Click += new System.EventHandler(this.btnhorarios_Click);
            // 
            // btnasignaturas
            // 
            this.btnasignaturas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnasignaturas.FlatAppearance.BorderSize = 0;
            this.btnasignaturas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnasignaturas.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.btnasignaturas.IconColor = System.Drawing.Color.Black;
            this.btnasignaturas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnasignaturas.IconSize = 32;
            this.btnasignaturas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnasignaturas.Location = new System.Drawing.Point(0, 100);
            this.btnasignaturas.Name = "btnasignaturas";
            this.btnasignaturas.Size = new System.Drawing.Size(240, 60);
            this.btnasignaturas.TabIndex = 1;
            this.btnasignaturas.Text = "Asignaturas";
            this.btnasignaturas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnasignaturas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnasignaturas.UseVisualStyleBackColor = true;
            this.btnasignaturas.Click += new System.EventHandler(this.btnasignaturas_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(240, 100);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(234, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // paneltitlebar
            // 
            this.paneltitlebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(106)))), ((int)(((byte)(204)))));
            this.paneltitlebar.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltitlebar.Location = new System.Drawing.Point(240, 0);
            this.paneltitlebar.Name = "paneltitlebar";
            this.paneltitlebar.Size = new System.Drawing.Size(700, 80);
            this.paneltitlebar.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(240, 80);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(700, 10);
            this.panel3.TabIndex = 2;
            // 
            // panelescritorio
            // 
            this.panelescritorio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelescritorio.Location = new System.Drawing.Point(240, 90);
            this.panelescritorio.Name = "panelescritorio";
            this.panelescritorio.Size = new System.Drawing.Size(700, 403);
            this.panelescritorio.TabIndex = 3;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(940, 493);
            this.Controls.Add(this.panelescritorio);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.paneltitlebar);
            this.Controls.Add(this.panel1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton btnasignaturas;
        private FontAwesome.Sharp.IconButton btnpagos;
        private FontAwesome.Sharp.IconButton btnregistromaterias;
        private FontAwesome.Sharp.IconButton btnhorarios;
        private PictureBox pictureBox1;
        private Panel paneltitlebar;
        private Panel panel3;
        private Panel panelescritorio;
    }
}