
namespace CapaPresentacion
{
    partial class FrmEdificios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEdificios));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visitaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edificioAulaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visitasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAgregarEdificio = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEditar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cbxEdificio = new System.Windows.Forms.ComboBox();
            this.cbxAula = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNuevo = new System.Windows.Forms.TextBox();
            this.btnAgregarAula = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(437, 69);
            this.panel1.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(69, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(259, 29);
            this.label9.TabIndex = 4;
            this.label9.Text = "REGISTRAR EDIFICIO";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(373, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 48);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarToolStripMenuItem,
            this.consultarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 69);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(437, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registrarToolStripMenuItem
            // 
            this.registrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visitaToolStripMenuItem,
            this.edificioAulaToolStripMenuItem});
            this.registrarToolStripMenuItem.Name = "registrarToolStripMenuItem";
            this.registrarToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.registrarToolStripMenuItem.Text = "Registrar";
            // 
            // visitaToolStripMenuItem
            // 
            this.visitaToolStripMenuItem.Name = "visitaToolStripMenuItem";
            this.visitaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.visitaToolStripMenuItem.Text = "Visita";
            this.visitaToolStripMenuItem.Click += new System.EventHandler(this.visitaToolStripMenuItem_Click);
            // 
            // edificioAulaToolStripMenuItem
            // 
            this.edificioAulaToolStripMenuItem.Name = "edificioAulaToolStripMenuItem";
            this.edificioAulaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.edificioAulaToolStripMenuItem.Text = "Nuevo Usuario";
            this.edificioAulaToolStripMenuItem.Click += new System.EventHandler(this.edificioAulaToolStripMenuItem_Click);
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visitasToolStripMenuItem});
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.consultarToolStripMenuItem.Text = "Consultar";
            // 
            // visitasToolStripMenuItem
            // 
            this.visitasToolStripMenuItem.Name = "visitasToolStripMenuItem";
            this.visitasToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.visitasToolStripMenuItem.Text = "Visitas";
            this.visitasToolStripMenuItem.Click += new System.EventHandler(this.visitasToolStripMenuItem_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(350, 96);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 40);
            this.btnCerrar.TabIndex = 24;
            this.btnCerrar.Text = "Cerrar Sesión";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(87, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 31;
            this.label3.Text = "Aula/Lugar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(110, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 30;
            this.label2.Text = "Edificio";
            // 
            // btnAgregarEdificio
            // 
            this.btnAgregarEdificio.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAgregarEdificio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnAgregarEdificio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregarEdificio.BorderRadius = 0;
            this.btnAgregarEdificio.ButtonText = "Agregar Edificio";
            this.btnAgregarEdificio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarEdificio.DisabledColor = System.Drawing.Color.Gray;
            this.btnAgregarEdificio.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAgregarEdificio.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAgregarEdificio.Iconimage")));
            this.btnAgregarEdificio.Iconimage_right = null;
            this.btnAgregarEdificio.Iconimage_right_Selected = null;
            this.btnAgregarEdificio.Iconimage_Selected = null;
            this.btnAgregarEdificio.IconMarginLeft = 0;
            this.btnAgregarEdificio.IconMarginRight = 0;
            this.btnAgregarEdificio.IconRightVisible = true;
            this.btnAgregarEdificio.IconRightZoom = 0D;
            this.btnAgregarEdificio.IconVisible = true;
            this.btnAgregarEdificio.IconZoom = 90D;
            this.btnAgregarEdificio.IsTab = false;
            this.btnAgregarEdificio.Location = new System.Drawing.Point(39, 309);
            this.btnAgregarEdificio.Name = "btnAgregarEdificio";
            this.btnAgregarEdificio.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnAgregarEdificio.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnAgregarEdificio.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAgregarEdificio.selected = false;
            this.btnAgregarEdificio.Size = new System.Drawing.Size(111, 48);
            this.btnAgregarEdificio.TabIndex = 34;
            this.btnAgregarEdificio.Text = "Agregar Edificio";
            this.btnAgregarEdificio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarEdificio.Textcolor = System.Drawing.Color.White;
            this.btnAgregarEdificio.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarEdificio.Click += new System.EventHandler(this.btnAgregarEdificio_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditar.BorderRadius = 0;
            this.btnEditar.ButtonText = "Editar Edificio";
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.DisabledColor = System.Drawing.Color.Gray;
            this.btnEditar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEditar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnEditar.Iconimage")));
            this.btnEditar.Iconimage_right = null;
            this.btnEditar.Iconimage_right_Selected = null;
            this.btnEditar.Iconimage_Selected = null;
            this.btnEditar.IconMarginLeft = 0;
            this.btnEditar.IconMarginRight = 0;
            this.btnEditar.IconRightVisible = true;
            this.btnEditar.IconRightZoom = 0D;
            this.btnEditar.IconVisible = true;
            this.btnEditar.IconZoom = 90D;
            this.btnEditar.IsTab = false;
            this.btnEditar.Location = new System.Drawing.Point(314, 309);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnEditar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnEditar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEditar.selected = false;
            this.btnEditar.Size = new System.Drawing.Size(111, 48);
            this.btnEditar.TabIndex = 35;
            this.btnEditar.Text = "Editar Edificio";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Textcolor = System.Drawing.Color.White;
            this.btnEditar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // cbxEdificio
            // 
            this.cbxEdificio.FormattingEnabled = true;
            this.cbxEdificio.Location = new System.Drawing.Point(176, 174);
            this.cbxEdificio.Name = "cbxEdificio";
            this.cbxEdificio.Size = new System.Drawing.Size(183, 21);
            this.cbxEdificio.TabIndex = 36;
            // 
            // cbxAula
            // 
            this.cbxAula.FormattingEnabled = true;
            this.cbxAula.Location = new System.Drawing.Point(176, 216);
            this.cbxAula.Name = "cbxAula";
            this.cbxAula.Size = new System.Drawing.Size(183, 21);
            this.cbxAula.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 38;
            this.label1.Text = "New Aula/Lugar";
            // 
            // txtNuevo
            // 
            this.txtNuevo.Location = new System.Drawing.Point(176, 254);
            this.txtNuevo.Name = "txtNuevo";
            this.txtNuevo.Size = new System.Drawing.Size(183, 20);
            this.txtNuevo.TabIndex = 39;
            // 
            // btnAgregarAula
            // 
            this.btnAgregarAula.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAgregarAula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnAgregarAula.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregarAula.BorderRadius = 0;
            this.btnAgregarAula.ButtonText = "Agregar Aula";
            this.btnAgregarAula.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarAula.DisabledColor = System.Drawing.Color.Gray;
            this.btnAgregarAula.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAgregarAula.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAgregarAula.Iconimage")));
            this.btnAgregarAula.Iconimage_right = null;
            this.btnAgregarAula.Iconimage_right_Selected = null;
            this.btnAgregarAula.Iconimage_Selected = null;
            this.btnAgregarAula.IconMarginLeft = 0;
            this.btnAgregarAula.IconMarginRight = 0;
            this.btnAgregarAula.IconRightVisible = true;
            this.btnAgregarAula.IconRightZoom = 0D;
            this.btnAgregarAula.IconVisible = true;
            this.btnAgregarAula.IconZoom = 90D;
            this.btnAgregarAula.IsTab = false;
            this.btnAgregarAula.Location = new System.Drawing.Point(176, 309);
            this.btnAgregarAula.Name = "btnAgregarAula";
            this.btnAgregarAula.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnAgregarAula.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnAgregarAula.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAgregarAula.selected = false;
            this.btnAgregarAula.Size = new System.Drawing.Size(111, 48);
            this.btnAgregarAula.TabIndex = 40;
            this.btnAgregarAula.Text = "Agregar Aula";
            this.btnAgregarAula.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarAula.Textcolor = System.Drawing.Color.White;
            this.btnAgregarAula.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarAula.Click += new System.EventHandler(this.btnAgregarAula_Click);
            // 
            // FrmEdificios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 382);
            this.Controls.Add(this.btnAgregarAula);
            this.Controls.Add(this.txtNuevo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxAula);
            this.Controls.Add(this.cbxEdificio);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAgregarEdificio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEdificios";
            this.Text = "FrmEdificios";
            this.Load += new System.EventHandler(this.FrmEdificios_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visitaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edificioAulaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visitasToolStripMenuItem;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuFlatButton btnAgregarEdificio;
        private Bunifu.Framework.UI.BunifuFlatButton btnEditar;
        private System.Windows.Forms.ComboBox cbxEdificio;
        private System.Windows.Forms.ComboBox cbxAula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNuevo;
        private Bunifu.Framework.UI.BunifuFlatButton btnAgregarAula;
    }
}