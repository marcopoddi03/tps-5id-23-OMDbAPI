namespace Poddi_OMDbAPI
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.comboBoxTitle = new System.Windows.Forms.ComboBox();
            this.checkBoxPlot = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.domainUpDownType = new System.Windows.Forms.DomainUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxAnno = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(128, 72);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(143, 20);
            this.txtTitle.TabIndex = 0;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(259, 262);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(96, 35);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // comboBoxTitle
            // 
            this.comboBoxTitle.FormattingEnabled = true;
            this.comboBoxTitle.Items.AddRange(new object[] {
            "Titolo",
            "IMDb ID"});
            this.comboBoxTitle.Location = new System.Drawing.Point(42, 71);
            this.comboBoxTitle.Name = "comboBoxTitle";
            this.comboBoxTitle.Size = new System.Drawing.Size(80, 21);
            this.comboBoxTitle.TabIndex = 3;
            // 
            // checkBoxPlot
            // 
            this.checkBoxPlot.AutoSize = true;
            this.checkBoxPlot.Location = new System.Drawing.Point(43, 176);
            this.checkBoxPlot.Name = "checkBoxPlot";
            this.checkBoxPlot.Size = new System.Drawing.Size(182, 17);
            this.checkBoxPlot.TabIndex = 4;
            this.checkBoxPlot.Text = "Trama lunga (default trama corta)";
            this.checkBoxPlot.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(102, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 33);
            this.label1.TabIndex = 5;
            this.label1.Text = "OMBD Api";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(147, 114);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(100, 20);
            this.txtYear.TabIndex = 6;
            // 
            // domainUpDownType
            // 
            this.domainUpDownType.Items.Add("movie");
            this.domainUpDownType.Items.Add("series");
            this.domainUpDownType.Items.Add("episode");
            this.domainUpDownType.Location = new System.Drawing.Point(90, 226);
            this.domainUpDownType.Name = "domainUpDownType";
            this.domainUpDownType.Size = new System.Drawing.Size(98, 20);
            this.domainUpDownType.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tipo";
            // 
            // checkBoxAnno
            // 
            this.checkBoxAnno.AutoSize = true;
            this.checkBoxAnno.Location = new System.Drawing.Point(42, 117);
            this.checkBoxAnno.Name = "checkBoxAnno";
            this.checkBoxAnno.Size = new System.Drawing.Size(99, 17);
            this.checkBoxAnno.TabIndex = 10;
            this.checkBoxAnno.Text = "Cerca per anno";
            this.checkBoxAnno.UseVisualStyleBackColor = true;
            this.checkBoxAnno.CheckedChanged += new System.EventHandler(this.checkBoxAnno_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 318);
            this.Controls.Add(this.checkBoxAnno);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.domainUpDownType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBoxPlot);
            this.Controls.Add(this.comboBoxTitle);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.ComboBox comboBoxTitle;
        private System.Windows.Forms.CheckBox checkBoxPlot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.DomainUpDown domainUpDownType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxAnno;
    }
}

