
namespace CapaPresentacion
{
    partial class FrmVisitas_General
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVisitas_General));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visitasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbxObjetivo = new System.Windows.Forms.ComboBox();
            this.txtMotivo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpSalida = new System.Windows.Forms.DateTimePicker();
            this.cbxEdificio = new System.Windows.Forms.ComboBox();
            this.btnRegistrarVisita = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dtpEntrada = new System.Windows.Forms.DateTimePicker();
            this.txtCarrera = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.label9);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(603, 69);
            this.panel1.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(180, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(257, 29);
            this.label9.TabIndex = 4;
            this.label9.Text = "REGISTRO DE VISITA";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 69);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(603, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
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
            // cbxObjetivo
            // 
            this.cbxObjetivo.FormattingEnabled = true;
            this.cbxObjetivo.Location = new System.Drawing.Point(181, 412);
            this.cbxObjetivo.Name = "cbxObjetivo";
            this.cbxObjetivo.Size = new System.Drawing.Size(291, 21);
            this.cbxObjetivo.TabIndex = 59;
            // 
            // txtMotivo
            // 
            this.txtMotivo.Location = new System.Drawing.Point(181, 330);
            this.txtMotivo.Multiline = true;
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Size = new System.Drawing.Size(291, 70);
            this.txtMotivo.TabIndex = 58;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 417);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 57;
            this.label1.Text = "Se dirigio a";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(56, 334);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 16);
            this.label8.TabIndex = 56;
            this.label8.Text = "Motivo de Visita";
            // 
            // dtpSalida
            // 
            this.dtpSalida.Location = new System.Drawing.Point(181, 294);
            this.dtpSalida.Name = "dtpSalida";
            this.dtpSalida.Size = new System.Drawing.Size(291, 20);
            this.dtpSalida.TabIndex = 55;
            // 
            // cbxEdificio
            // 
            this.cbxEdificio.FormattingEnabled = true;
            this.cbxEdificio.Location = new System.Drawing.Point(181, 223);
            this.cbxEdificio.Name = "cbxEdificio";
            this.cbxEdificio.Size = new System.Drawing.Size(291, 21);
            this.cbxEdificio.TabIndex = 54;
            this.cbxEdificio.SelectedIndexChanged += new System.EventHandler(this.cbxEdificio_SelectedIndexChanged);
            // 
            // btnRegistrarVisita
            // 
            this.btnRegistrarVisita.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnRegistrarVisita.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnRegistrarVisita.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegistrarVisita.BorderRadius = 0;
            this.btnRegistrarVisita.ButtonText = "Registrar Visita";
            this.btnRegistrarVisita.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrarVisita.DisabledColor = System.Drawing.Color.Gray;
            this.btnRegistrarVisita.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRegistrarVisita.Iconcolor = System.Drawing.Color.Transparent;
            this.btnRegistrarVisita.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnRegistrarVisita.Iconimage")));
            this.btnRegistrarVisita.Iconimage_right = null;
            this.btnRegistrarVisita.Iconimage_right_Selected = null;
            this.btnRegistrarVisita.Iconimage_Selected = null;
            this.btnRegistrarVisita.IconMarginLeft = 0;
            this.btnRegistrarVisita.IconMarginRight = 0;
            this.btnRegistrarVisita.IconRightVisible = true;
            this.btnRegistrarVisita.IconRightZoom = 0D;
            this.btnRegistrarVisita.IconVisible = true;
            this.btnRegistrarVisita.IconZoom = 70D;
            this.btnRegistrarVisita.IsTab = false;
            this.btnRegistrarVisita.Location = new System.Drawing.Point(201, 450);
            this.btnRegistrarVisita.Name = "btnRegistrarVisita";
            this.btnRegistrarVisita.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnRegistrarVisita.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnRegistrarVisita.OnHoverTextColor = System.Drawing.Color.White;
            this.btnRegistrarVisita.selected = false;
            this.btnRegistrarVisita.Size = new System.Drawing.Size(169, 48);
            this.btnRegistrarVisita.TabIndex = 53;
            this.btnRegistrarVisita.Text = "Registrar Visita";
            this.btnRegistrarVisita.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrarVisita.Textcolor = System.Drawing.Color.White;
            this.btnRegistrarVisita.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarVisita.Click += new System.EventHandler(this.btnRegistrarVisita_Click);
            // 
            // dtpEntrada
            // 
            this.dtpEntrada.Location = new System.Drawing.Point(181, 262);
            this.dtpEntrada.Name = "dtpEntrada";
            this.dtpEntrada.Size = new System.Drawing.Size(291, 20);
            this.dtpEntrada.TabIndex = 52;
            // 
            // txtCarrera
            // 
            this.txtCarrera.Location = new System.Drawing.Point(181, 190);
            this.txtCarrera.Name = "txtCarrera";
            this.txtCarrera.Size = new System.Drawing.Size(291, 20);
            this.txtCarrera.TabIndex = 51;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(181, 153);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(291, 20);
            this.txtApellido.TabIndex = 50;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(181, 119);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(291, 20);
            this.txtNombre.TabIndex = 49;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(36, 298);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 16);
            this.label7.TabIndex = 48;
            this.label7.Text = "Fecha/Hora Salida";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 16);
            this.label6.TabIndex = 47;
            this.label6.Text = "Fecha/Hora Entrada";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(115, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 46;
            this.label5.Text = "Edificio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(115, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 45;
            this.label4.Text = "Carrera";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(109, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 44;
            this.label3.Text = "Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(112, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 43;
            this.label2.Text = "Nombre";
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(516, 96);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 40);
            this.btnCerrar.TabIndex = 60;
            this.btnCerrar.Text = "Cerrar Sesión";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // FrmVisitas_General
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 517);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.cbxObjetivo);
            this.Controls.Add(this.txtMotivo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtpSalida);
            this.Controls.Add(this.cbxEdificio);
            this.Controls.Add(this.btnRegistrarVisita);
            this.Controls.Add(this.dtpEntrada);
            this.Controls.Add(this.txtCarrera);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmVisitas_General";
            this.Text = "FrmVisitas_General";
            this.Load += new System.EventHandler(this.FrmVisitas_General_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visitasToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbxObjetivo;
        private System.Windows.Forms.TextBox txtMotivo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpSalida;
        private System.Windows.Forms.ComboBox cbxEdificio;
        private Bunifu.Framework.UI.BunifuFlatButton btnRegistrarVisita;
        private System.Windows.Forms.DateTimePicker dtpEntrada;
        private System.Windows.Forms.TextBox txtCarrera;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCerrar;
    }
}