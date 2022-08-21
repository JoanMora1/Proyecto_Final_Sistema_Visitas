
namespace CapaPresentacion
{
    partial class FrmVerVisitas_General
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVerVisitas_General));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visitaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnVerVisitas = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cbxBuscarVisitas = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.label9);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(633, 69);
            this.panel1.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(196, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(243, 29);
            this.label9.TabIndex = 4;
            this.label9.Text = "VISUALIZAR VISITAS";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 69);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(633, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registrarToolStripMenuItem
            // 
            this.registrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visitaToolStripMenuItem});
            this.registrarToolStripMenuItem.Name = "registrarToolStripMenuItem";
            this.registrarToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.registrarToolStripMenuItem.Text = "Registrar";
            // 
            // visitaToolStripMenuItem
            // 
            this.visitaToolStripMenuItem.Name = "visitaToolStripMenuItem";
            this.visitaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.visitaToolStripMenuItem.Text = "Visitas";
            this.visitaToolStripMenuItem.Click += new System.EventHandler(this.visitaToolStripMenuItem_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(546, 96);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 40);
            this.btnCerrar.TabIndex = 26;
            this.btnCerrar.Text = "Cerrar Sesión";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnVerVisitas
            // 
            this.btnVerVisitas.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnVerVisitas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnVerVisitas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVerVisitas.BorderRadius = 0;
            this.btnVerVisitas.ButtonText = "Ver Visitas";
            this.btnVerVisitas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerVisitas.DisabledColor = System.Drawing.Color.Gray;
            this.btnVerVisitas.Iconcolor = System.Drawing.Color.Transparent;
            this.btnVerVisitas.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnVerVisitas.Iconimage")));
            this.btnVerVisitas.Iconimage_right = null;
            this.btnVerVisitas.Iconimage_right_Selected = null;
            this.btnVerVisitas.Iconimage_Selected = null;
            this.btnVerVisitas.IconMarginLeft = 0;
            this.btnVerVisitas.IconMarginRight = 0;
            this.btnVerVisitas.IconRightVisible = true;
            this.btnVerVisitas.IconRightZoom = 0D;
            this.btnVerVisitas.IconVisible = true;
            this.btnVerVisitas.IconZoom = 90D;
            this.btnVerVisitas.IsTab = false;
            this.btnVerVisitas.Location = new System.Drawing.Point(323, 122);
            this.btnVerVisitas.Name = "btnVerVisitas";
            this.btnVerVisitas.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnVerVisitas.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnVerVisitas.OnHoverTextColor = System.Drawing.Color.White;
            this.btnVerVisitas.selected = false;
            this.btnVerVisitas.Size = new System.Drawing.Size(199, 48);
            this.btnVerVisitas.TabIndex = 29;
            this.btnVerVisitas.Text = "Ver Visitas";
            this.btnVerVisitas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerVisitas.Textcolor = System.Drawing.SystemColors.Control;
            this.btnVerVisitas.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerVisitas.Click += new System.EventHandler(this.btnVerVisitas_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 176);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(614, 270);
            this.dataGridView1.TabIndex = 28;
            // 
            // cbxBuscarVisitas
            // 
            this.cbxBuscarVisitas.FormattingEnabled = true;
            this.cbxBuscarVisitas.Location = new System.Drawing.Point(25, 138);
            this.cbxBuscarVisitas.Name = "cbxBuscarVisitas";
            this.cbxBuscarVisitas.Size = new System.Drawing.Size(292, 21);
            this.cbxBuscarVisitas.TabIndex = 27;
            // 
            // FrmVerVisitas_General
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 462);
            this.Controls.Add(this.btnVerVisitas);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbxBuscarVisitas);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmVerVisitas_General";
            this.Text = "FrmVerVisitas_General";
            this.Load += new System.EventHandler(this.FrmVerVisitas_General_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visitaToolStripMenuItem;
        private System.Windows.Forms.Button btnCerrar;
        private Bunifu.Framework.UI.BunifuFlatButton btnVerVisitas;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbxBuscarVisitas;
    }
}