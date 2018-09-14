namespace PEP_GameShop_Administracija.Izvještaji
{
    partial class frmProdajaPoDatumu
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dateTimePickerDatumDO = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDatumOD = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PEP_GameShop_Administracija.Izvještaji.ProdajaDatum.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(1, 37);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(625, 237);
            this.reportViewer1.TabIndex = 0;
            // 
            // dateTimePickerDatumDO
            // 
            this.dateTimePickerDatumDO.Location = new System.Drawing.Point(342, 6);
            this.dateTimePickerDatumDO.Name = "dateTimePickerDatumDO";
            this.dateTimePickerDatumDO.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDatumDO.TabIndex = 1;
            // 
            // dateTimePickerDatumOD
            // 
            this.dateTimePickerDatumOD.Location = new System.Drawing.Point(74, 6);
            this.dateTimePickerDatumOD.Name = "dateTimePickerDatumOD";
            this.dateTimePickerDatumOD.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDatumOD.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Datum od:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(280, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Datum do:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(548, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Prikaži";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmProdajaPoDatumu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 273);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerDatumOD);
            this.Controls.Add(this.dateTimePickerDatumDO);
            this.Controls.Add(this.reportViewer1);
            this.MaximizeBox = false;
            this.Name = "frmProdajaPoDatumu";
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prodaja po datumu";
            this.Load += new System.EventHandler(this.frmProdajaPoDatumu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DateTimePicker dateTimePickerDatumDO;
        private System.Windows.Forms.DateTimePicker dateTimePickerDatumOD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}