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
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRicerca = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(119, 34);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(143, 20);
            this.txtTitle.TabIndex = 0;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(420, 110);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 26);
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
            this.comboBoxTitle.Location = new System.Drawing.Point(33, 33);
            this.comboBoxTitle.Name = "comboBoxTitle";
            this.comboBoxTitle.Size = new System.Drawing.Size(80, 21);
            this.comboBoxTitle.TabIndex = 3;
            // 
            // checkBoxPlot
            // 
            this.checkBoxPlot.AutoSize = true;
            this.checkBoxPlot.Location = new System.Drawing.Point(301, 34);
            this.checkBoxPlot.Name = "checkBoxPlot";
            this.checkBoxPlot.Size = new System.Drawing.Size(182, 17);
            this.checkBoxPlot.TabIndex = 4;
            this.checkBoxPlot.Text = "Trama lunga (default trama corta)";
            this.checkBoxPlot.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(202, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 33);
            this.label1.TabIndex = 5;
            this.label1.Text = "OMDb API";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(138, 67);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(100, 20);
            this.txtYear.TabIndex = 6;
            // 
            // domainUpDownType
            // 
            this.domainUpDownType.Items.Add("movie");
            this.domainUpDownType.Items.Add("series");
            this.domainUpDownType.Items.Add("episode");
            this.domainUpDownType.Location = new System.Drawing.Point(347, 69);
            this.domainUpDownType.Name = "domainUpDownType";
            this.domainUpDownType.Size = new System.Drawing.Size(98, 20);
            this.domainUpDownType.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(298, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tipo";
            // 
            // checkBoxAnno
            // 
            this.checkBoxAnno.AutoSize = true;
            this.checkBoxAnno.Location = new System.Drawing.Point(33, 70);
            this.checkBoxAnno.Name = "checkBoxAnno";
            this.checkBoxAnno.Size = new System.Drawing.Size(99, 17);
            this.checkBoxAnno.TabIndex = 10;
            this.checkBoxAnno.Text = "Cerca per anno";
            this.checkBoxAnno.UseVisualStyleBackColor = true;
            this.checkBoxAnno.CheckedChanged += new System.EventHandler(this.checkBoxAnno_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Non sei sicuro dei dati da inserire? Prova la ricerca! -->";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Wheat;
            this.groupBox1.Controls.Add(this.comboBoxTitle);
            this.groupBox1.Controls.Add(this.txtTitle);
            this.groupBox1.Controls.Add(this.btnOk);
            this.groupBox1.Controls.Add(this.checkBoxAnno);
            this.groupBox1.Controls.Add(this.checkBoxPlot);
            this.groupBox1.Controls.Add(this.txtYear);
            this.groupBox1.Controls.Add(this.domainUpDownType);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(26, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(513, 151);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Visualizza i dettagli di un film a tua scelta!";
            // 
            // btnRicerca
            // 
            this.btnRicerca.Location = new System.Drawing.Point(300, 19);
            this.btnRicerca.Name = "btnRicerca";
            this.btnRicerca.Size = new System.Drawing.Size(63, 23);
            this.btnRicerca.TabIndex = 14;
            this.btnRicerca.Text = "CERCA";
            this.btnRicerca.UseVisualStyleBackColor = true;
            this.btnRicerca.Click += new System.EventHandler(this.btnRicerca_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Wheat;
            this.groupBox2.Controls.Add(this.btnRicerca);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(146, 272);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(393, 61);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "RICERCA";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(564, 402);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRicerca;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

