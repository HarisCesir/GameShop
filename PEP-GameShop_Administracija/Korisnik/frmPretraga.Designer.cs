namespace PEP_GameShop_Administracija.Korisnik
{
    partial class frmPretraga
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPretraga));
            this.labelImeIprezime = new System.Windows.Forms.Label();
            this.textBoxImeIprezim = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.deaktivirajButton = new System.Windows.Forms.ToolStripButton();
            this.obrisiButton = new System.Windows.Forms.ToolStripButton();
            this.IzmjeneButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.izmjenaLičnihPodatakaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izmjenaStatusnihPodatakaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewKorisnici = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKorisnici)).BeginInit();
            this.SuspendLayout();
            // 
            // labelImeIprezime
            // 
            this.labelImeIprezime.AutoSize = true;
            this.labelImeIprezime.Location = new System.Drawing.Point(27, 9);
            this.labelImeIprezime.Name = "labelImeIprezime";
            this.labelImeIprezime.Size = new System.Drawing.Size(71, 13);
            this.labelImeIprezime.TabIndex = 0;
            this.labelImeIprezime.Text = "Ime i prezime:";
            // 
            // textBoxImeIprezim
            // 
            this.textBoxImeIprezim.Location = new System.Drawing.Point(104, 6);
            this.textBoxImeIprezim.Name = "textBoxImeIprezim";
            this.textBoxImeIprezim.Size = new System.Drawing.Size(219, 20);
            this.textBoxImeIprezim.TabIndex = 1;
            this.textBoxImeIprezim.TextChanged += new System.EventHandler(this.textBoxImeIprezim_TextChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deaktivirajButton,
            this.obrisiButton,
            this.IzmjeneButton});
            this.toolStrip1.Location = new System.Drawing.Point(3, 26);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(212, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // deaktivirajButton
            // 
            this.deaktivirajButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.deaktivirajButton.Image = ((System.Drawing.Image)(resources.GetObject("deaktivirajButton.Image")));
            this.deaktivirajButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deaktivirajButton.Name = "deaktivirajButton";
            this.deaktivirajButton.Size = new System.Drawing.Size(66, 22);
            this.deaktivirajButton.Text = "Deaktiviraj";
            this.deaktivirajButton.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // obrisiButton
            // 
            this.obrisiButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.obrisiButton.Image = ((System.Drawing.Image)(resources.GetObject("obrisiButton.Image")));
            this.obrisiButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.obrisiButton.Name = "obrisiButton";
            this.obrisiButton.Size = new System.Drawing.Size(42, 22);
            this.obrisiButton.Text = "Obriši";
            this.obrisiButton.Click += new System.EventHandler(this.obrisiButton_Click);
            // 
            // IzmjeneButton
            // 
            this.IzmjeneButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.IzmjeneButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.izmjenaLičnihPodatakaToolStripMenuItem,
            this.izmjenaStatusnihPodatakaToolStripMenuItem});
            this.IzmjeneButton.Image = ((System.Drawing.Image)(resources.GetObject("IzmjeneButton.Image")));
            this.IzmjeneButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.IzmjeneButton.Name = "IzmjeneButton";
            this.IzmjeneButton.Size = new System.Drawing.Size(61, 22);
            this.IzmjeneButton.Text = "Izmjene";
            this.IzmjeneButton.Click += new System.EventHandler(this.IzmjeneButton_Click);
            // 
            // izmjenaLičnihPodatakaToolStripMenuItem
            // 
            this.izmjenaLičnihPodatakaToolStripMenuItem.Name = "izmjenaLičnihPodatakaToolStripMenuItem";
            this.izmjenaLičnihPodatakaToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.izmjenaLičnihPodatakaToolStripMenuItem.Text = "Izmjena ličnih podataka";
            this.izmjenaLičnihPodatakaToolStripMenuItem.Click += new System.EventHandler(this.izmjenaLičnihPodatakaToolStripMenuItem_Click);
            // 
            // izmjenaStatusnihPodatakaToolStripMenuItem
            // 
            this.izmjenaStatusnihPodatakaToolStripMenuItem.Name = "izmjenaStatusnihPodatakaToolStripMenuItem";
            this.izmjenaStatusnihPodatakaToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.izmjenaStatusnihPodatakaToolStripMenuItem.Text = "Izmjena statusnih podataka";
            this.izmjenaStatusnihPodatakaToolStripMenuItem.Click += new System.EventHandler(this.izmjenaStatusnihPodatakaToolStripMenuItem_Click);
            // 
            // dataGridViewKorisnici
            // 
            this.dataGridViewKorisnici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKorisnici.Location = new System.Drawing.Point(3, 54);
            this.dataGridViewKorisnici.Name = "dataGridViewKorisnici";
            this.dataGridViewKorisnici.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewKorisnici.Size = new System.Drawing.Size(440, 208);
            this.dataGridViewKorisnici.TabIndex = 4;
            this.dataGridViewKorisnici.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewKorisnici_CellClick_1);
            this.dataGridViewKorisnici.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewKorisnici_CellContentClick);
            // 
            // frmPretraga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 261);
            this.Controls.Add(this.dataGridViewKorisnici);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.textBoxImeIprezim);
            this.Controls.Add(this.labelImeIprezime);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPretraga";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pretraga korisnika";
            this.Load += new System.EventHandler(this.frmPretraga_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKorisnici)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelImeIprezime;
        private System.Windows.Forms.TextBox textBoxImeIprezim;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton deaktivirajButton;
        private System.Windows.Forms.ToolStripButton obrisiButton;
        private System.Windows.Forms.ToolStripDropDownButton IzmjeneButton;
        private System.Windows.Forms.ToolStripMenuItem izmjenaLičnihPodatakaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izmjenaStatusnihPodatakaToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridViewKorisnici;
    }
}