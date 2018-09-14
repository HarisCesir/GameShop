namespace PEP_GameShop_Administracija.Aukcija
{
    partial class frmDodajAukciju
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
            this.labelNaslov = new System.Windows.Forms.Label();
            this.labelDatumDO = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.buttonSave = new System.Windows.Forms.Button();
            this.openFileDialogSlika = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.comboBoxIgre = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNaslov
            // 
            this.labelNaslov.AutoSize = true;
            this.labelNaslov.Location = new System.Drawing.Point(76, 10);
            this.labelNaslov.Name = "labelNaslov";
            this.labelNaslov.Size = new System.Drawing.Size(28, 13);
            this.labelNaslov.TabIndex = 0;
            this.labelNaslov.Text = "Igra:";
            // 
            // labelDatumDO
            // 
            this.labelDatumDO.AutoSize = true;
            this.labelDatumDO.Location = new System.Drawing.Point(47, 75);
            this.labelDatumDO.Name = "labelDatumDO";
            this.labelDatumDO.Size = new System.Drawing.Size(57, 13);
            this.labelDatumDO.TabIndex = 4;
            this.labelDatumDO.Text = "DatumDO:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(120, 69);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(172, 20);
            this.dateTimePicker1.TabIndex = 8;
            this.dateTimePicker1.Validating += new System.ComponentModel.CancelEventHandler(this.dateTimePicker1_Validating);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(152, 113);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(79, 33);
            this.buttonSave.TabIndex = 10;
            this.buttonSave.Text = "Sačuvaj";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // openFileDialogSlika
            // 
            this.openFileDialogSlika.FileName = "openFileDialog1";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // comboBoxIgre
            // 
            this.comboBoxIgre.FormattingEnabled = true;
            this.comboBoxIgre.Location = new System.Drawing.Point(120, 10);
            this.comboBoxIgre.Name = "comboBoxIgre";
            this.comboBoxIgre.Size = new System.Drawing.Size(172, 21);
            this.comboBoxIgre.TabIndex = 11;
            // 
            // frmDodajAukciju
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 194);
            this.Controls.Add(this.comboBoxIgre);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.labelDatumDO);
            this.Controls.Add(this.labelNaslov);
            this.MaximizeBox = false;
            this.Name = "frmDodajAukciju";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aukcija";
            this.Load += new System.EventHandler(this.frmDodajAukciju_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNaslov;
        private System.Windows.Forms.Label labelDatumDO;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.OpenFileDialog openFileDialogSlika;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox comboBoxIgre;
    }
}