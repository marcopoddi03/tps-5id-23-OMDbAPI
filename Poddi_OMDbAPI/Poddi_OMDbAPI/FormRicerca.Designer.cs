﻿namespace Poddi_OMDbAPI
{
    partial class FormRicerca
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
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.checkBoxAnno = new System.Windows.Forms.CheckBox();
            this.txtAnno = new System.Windows.Forms.TextBox();
            this.domainUpDownType = new System.Windows.Forms.DomainUpDown();
            this.groupbox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxP = new System.Windows.Forms.GroupBox();
            this.groupBoxR = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCont = new System.Windows.Forms.Button();
            this.groupbox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBoxP.SuspendLayout();
            this.groupBoxR.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(13, 32);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(141, 20);
            this.txtTitle.TabIndex = 0;
            // 
            // checkBoxAnno
            // 
            this.checkBoxAnno.AutoSize = true;
            this.checkBoxAnno.Location = new System.Drawing.Point(29, 31);
            this.checkBoxAnno.Name = "checkBoxAnno";
            this.checkBoxAnno.Size = new System.Drawing.Size(51, 17);
            this.checkBoxAnno.TabIndex = 1;
            this.checkBoxAnno.Text = "Anno";
            this.checkBoxAnno.UseVisualStyleBackColor = true;
            // 
            // txtAnno
            // 
            this.txtAnno.Location = new System.Drawing.Point(105, 31);
            this.txtAnno.Name = "txtAnno";
            this.txtAnno.Size = new System.Drawing.Size(100, 20);
            this.txtAnno.TabIndex = 3;
            // 
            // domainUpDownType
            // 
            this.domainUpDownType.Items.Add("Tutto");
            this.domainUpDownType.Items.Add("movie");
            this.domainUpDownType.Items.Add("series");
            this.domainUpDownType.Items.Add("episode");
            this.domainUpDownType.Location = new System.Drawing.Point(105, 57);
            this.domainUpDownType.Name = "domainUpDownType";
            this.domainUpDownType.Size = new System.Drawing.Size(98, 20);
            this.domainUpDownType.TabIndex = 10;
            // 
            // groupbox1
            // 
            this.groupbox1.Controls.Add(this.label2);
            this.groupbox1.Controls.Add(this.domainUpDownType);
            this.groupbox1.Controls.Add(this.checkBoxAnno);
            this.groupbox1.Controls.Add(this.txtAnno);
            this.groupbox1.Location = new System.Drawing.Point(13, 86);
            this.groupbox1.Name = "groupbox1";
            this.groupbox1.Size = new System.Drawing.Size(230, 100);
            this.groupbox1.TabIndex = 11;
            this.groupbox1.TabStop = false;
            this.groupbox1.Text = "FILTRI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tipo";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(170, 32);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 12;
            this.btnOk.Text = "CERCA";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(25, 41);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(36, 20);
            this.numericUpDown1.TabIndex = 14;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Pagina";
            // 
            // groupBoxP
            // 
            this.groupBoxP.Controls.Add(this.numericUpDown1);
            this.groupBoxP.Controls.Add(this.label1);
            this.groupBoxP.Location = new System.Drawing.Point(668, 130);
            this.groupBoxP.Name = "groupBoxP";
            this.groupBoxP.Size = new System.Drawing.Size(88, 85);
            this.groupBoxP.TabIndex = 16;
            this.groupBoxP.TabStop = false;
            // 
            // groupBoxR
            // 
            this.groupBoxR.Controls.Add(this.txtTitle);
            this.groupBoxR.Controls.Add(this.groupbox1);
            this.groupBoxR.Controls.Add(this.btnOk);
            this.groupBoxR.Location = new System.Drawing.Point(43, 12);
            this.groupBoxR.Name = "groupBoxR";
            this.groupBoxR.Size = new System.Drawing.Size(284, 203);
            this.groupBoxR.TabIndex = 17;
            this.groupBoxR.TabStop = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(368, 16);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(279, 199);
            this.listBox1.TabIndex = 18;
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(381, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(247, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Fai doppio click sul film di cui vuoi vedere i dettagli!";
            // 
            // btnCont
            // 
            this.btnCont.Location = new System.Drawing.Point(102, 228);
            this.btnCont.Name = "btnCont";
            this.btnCont.Size = new System.Drawing.Size(141, 36);
            this.btnCont.TabIndex = 16;
            this.btnCont.Text = "FAI UN\'ALTRA RICERCA";
            this.btnCont.UseVisualStyleBackColor = true;
            this.btnCont.Click += new System.EventHandler(this.btnCont_Click);
            // 
            // FormRicerca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 276);
            this.Controls.Add(this.btnCont);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBoxR);
            this.Controls.Add(this.groupBoxP);
            this.Name = "FormRicerca";
            this.Text = "FormRicerca";
            this.groupbox1.ResumeLayout(false);
            this.groupbox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBoxP.ResumeLayout(false);
            this.groupBoxP.PerformLayout();
            this.groupBoxR.ResumeLayout(false);
            this.groupBoxR.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.CheckBox checkBoxAnno;
        private System.Windows.Forms.TextBox txtAnno;
        private System.Windows.Forms.DomainUpDown domainUpDownType;
        private System.Windows.Forms.GroupBox groupbox1;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxR;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCont;
    }
}