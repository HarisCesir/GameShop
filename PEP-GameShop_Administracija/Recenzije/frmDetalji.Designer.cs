namespace PEP_GameShop_Administracija.Recenzije
{
    partial class frmDetalji
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
            this.components = new System.ComponentModel.Container();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxNaslov = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSadrzaj = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDatum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxAutor = new System.Windows.Forms.TextBox();
            this.buttonIzmjeni = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonSacuvaj = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxNaslov
            // 
            this.textBoxNaslov.Location = new System.Drawing.Point(35, 27);
            this.textBoxNaslov.Name = "textBoxNaslov";
            this.textBoxNaslov.ReadOnly = true;
            this.textBoxNaslov.Size = new System.Drawing.Size(415, 20);
            this.textBoxNaslov.TabIndex = 0;
            this.textBoxNaslov.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(202, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Naslov:";
            // 
            // textBoxSadrzaj
            // 
            this.textBoxSadrzaj.Location = new System.Drawing.Point(12, 71);
            this.textBoxSadrzaj.Multiline = true;
            this.textBoxSadrzaj.Name = "textBoxSadrzaj";
            this.textBoxSadrzaj.ReadOnly = true;
            this.textBoxSadrzaj.Size = new System.Drawing.Size(475, 179);
            this.textBoxSadrzaj.TabIndex = 2;
            this.textBoxSadrzaj.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textBoxSadrzaj.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxSadrzaj_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sadržaj:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Datum objave:";
            // 
            // textBoxDatum
            // 
            this.textBoxDatum.Location = new System.Drawing.Point(86, 277);
            this.textBoxDatum.Name = "textBoxDatum";
            this.textBoxDatum.ReadOnly = true;
            this.textBoxDatum.Size = new System.Drawing.Size(130, 20);
            this.textBoxDatum.TabIndex = 5;
            this.textBoxDatum.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(280, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Autor:";
            // 
            // textBoxAutor
            // 
            this.textBoxAutor.Location = new System.Drawing.Point(321, 273);
            this.textBoxAutor.Name = "textBoxAutor";
            this.textBoxAutor.ReadOnly = true;
            this.textBoxAutor.Size = new System.Drawing.Size(166, 20);
            this.textBoxAutor.TabIndex = 7;
            this.textBoxAutor.TextChanged += new System.EventHandler(this.textBoxAutor_TextChanged);
            // 
            // buttonIzmjeni
            // 
            this.buttonIzmjeni.Location = new System.Drawing.Point(35, 312);
            this.buttonIzmjeni.Name = "buttonIzmjeni";
            this.buttonIzmjeni.Size = new System.Drawing.Size(75, 23);
            this.buttonIzmjeni.TabIndex = 8;
            this.buttonIzmjeni.Text = "Izmjeni";
            this.buttonIzmjeni.UseVisualStyleBackColor = true;
            this.buttonIzmjeni.Click += new System.EventHandler(this.buttonIzmjeni_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(163, 311);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Odustani";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonSacuvaj
            // 
            this.buttonSacuvaj.Enabled = false;
            this.buttonSacuvaj.Location = new System.Drawing.Point(321, 311);
            this.buttonSacuvaj.Name = "buttonSacuvaj";
            this.buttonSacuvaj.Size = new System.Drawing.Size(75, 23);
            this.buttonSacuvaj.TabIndex = 10;
            this.buttonSacuvaj.Text = "Sačuvaj";
            this.buttonSacuvaj.UseVisualStyleBackColor = true;
            this.buttonSacuvaj.Click += new System.EventHandler(this.buttonSacuvaj_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 340);
            this.Controls.Add(this.buttonSacuvaj);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonIzmjeni);
            this.Controls.Add(this.textBoxAutor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxDatum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxSadrzaj);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNaslov);
            this.MaximizeBox = false;
            this.Name = "frmDetalji";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalji";
            this.Load += new System.EventHandler(this.frmDetalji_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TextBox textBoxNaslov;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSadrzaj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxDatum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxAutor;
        private System.Windows.Forms.Button buttonIzmjeni;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonSacuvaj;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}