namespace TOMSOFT_Demo_9
{
    partial class frmDemo
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
            this.tabSvastaNesto = new System.Windows.Forms.TabControl();
            this.tabArtikli = new System.Windows.Forms.TabPage();
            this.btnTrazi = new System.Windows.Forms.Button();
            this.txtNazivArtila = new System.Windows.Forms.TextBox();
            this.lblNazivArtikla = new System.Windows.Forms.Label();
            this.grdArtikli = new System.Windows.Forms.DataGridView();
            this.tabObracunPlacanje = new System.Windows.Forms.TabPage();
            this.txtDatumDoP = new System.Windows.Forms.MaskedTextBox();
            this.txtDatumOdP = new System.Windows.Forms.MaskedTextBox();
            this.lblDoDatumaP = new System.Windows.Forms.Label();
            this.lblOdDatumaP = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTrazi2 = new System.Windows.Forms.Button();
            this.txtPoslovnaJedinicaP = new System.Windows.Forms.TextBox();
            this.lblPoslovnaJedinicaP = new System.Windows.Forms.Label();
            this.grdObracunPlacanje = new System.Windows.Forms.DataGridView();
            this.tabObracunArtikli = new System.Windows.Forms.TabPage();
            this.txtPoslovnaJedinicaA = new System.Windows.Forms.TextBox();
            this.lblPoslovnaJedinicaA = new System.Windows.Forms.Label();
            this.txtDatumDoA = new System.Windows.Forms.MaskedTextBox();
            this.txtDatumOdA = new System.Windows.Forms.MaskedTextBox();
            this.lblDoDatumaA = new System.Windows.Forms.Label();
            this.lblOdDatumaA = new System.Windows.Forms.Label();
            this.btnTrazi3 = new System.Windows.Forms.Button();
            this.grdObracunArtikli = new System.Windows.Forms.DataGridView();
            this.tabSvastaNesto.SuspendLayout();
            this.tabArtikli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdArtikli)).BeginInit();
            this.tabObracunPlacanje.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdObracunPlacanje)).BeginInit();
            this.tabObracunArtikli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdObracunArtikli)).BeginInit();
            this.SuspendLayout();
            // 
            // tabSvastaNesto
            // 
            this.tabSvastaNesto.Controls.Add(this.tabArtikli);
            this.tabSvastaNesto.Controls.Add(this.tabObracunPlacanje);
            this.tabSvastaNesto.Controls.Add(this.tabObracunArtikli);
            this.tabSvastaNesto.Location = new System.Drawing.Point(0, 0);
            this.tabSvastaNesto.Name = "tabSvastaNesto";
            this.tabSvastaNesto.SelectedIndex = 0;
            this.tabSvastaNesto.Size = new System.Drawing.Size(531, 321);
            this.tabSvastaNesto.TabIndex = 0;
            // 
            // tabArtikli
            // 
            this.tabArtikli.Controls.Add(this.btnTrazi);
            this.tabArtikli.Controls.Add(this.txtNazivArtila);
            this.tabArtikli.Controls.Add(this.lblNazivArtikla);
            this.tabArtikli.Controls.Add(this.grdArtikli);
            this.tabArtikli.Location = new System.Drawing.Point(4, 22);
            this.tabArtikli.Name = "tabArtikli";
            this.tabArtikli.Padding = new System.Windows.Forms.Padding(3);
            this.tabArtikli.Size = new System.Drawing.Size(523, 295);
            this.tabArtikli.TabIndex = 0;
            this.tabArtikli.Text = "ARTIKLI              ";
            this.tabArtikli.UseVisualStyleBackColor = true;
            // 
            // btnTrazi
            // 
            this.btnTrazi.Location = new System.Drawing.Point(440, 7);
            this.btnTrazi.Name = "btnTrazi";
            this.btnTrazi.Size = new System.Drawing.Size(75, 23);
            this.btnTrazi.TabIndex = 4;
            this.btnTrazi.Text = "Traži";
            this.btnTrazi.UseVisualStyleBackColor = true;
            this.btnTrazi.Click += new System.EventHandler(this.btnTrazi_Click);
            // 
            // txtNazivArtila
            // 
            this.txtNazivArtila.Location = new System.Drawing.Point(84, 14);
            this.txtNazivArtila.Name = "txtNazivArtila";
            this.txtNazivArtila.Size = new System.Drawing.Size(247, 20);
            this.txtNazivArtila.TabIndex = 0;
            // 
            // lblNazivArtikla
            // 
            this.lblNazivArtikla.AutoSize = true;
            this.lblNazivArtikla.Location = new System.Drawing.Point(7, 17);
            this.lblNazivArtikla.Name = "lblNazivArtikla";
            this.lblNazivArtikla.Size = new System.Drawing.Size(71, 13);
            this.lblNazivArtikla.TabIndex = 1;
            this.lblNazivArtikla.Text = "Naziv artikla: ";
            // 
            // grdArtikli
            // 
            this.grdArtikli.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdArtikli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdArtikli.Location = new System.Drawing.Point(6, 66);
            this.grdArtikli.Name = "grdArtikli";
            this.grdArtikli.Size = new System.Drawing.Size(509, 223);
            this.grdArtikli.TabIndex = 3;
            // 
            // tabObracunPlacanje
            // 
            this.tabObracunPlacanje.Controls.Add(this.txtDatumDoP);
            this.tabObracunPlacanje.Controls.Add(this.txtDatumOdP);
            this.tabObracunPlacanje.Controls.Add(this.lblDoDatumaP);
            this.tabObracunPlacanje.Controls.Add(this.lblOdDatumaP);
            this.tabObracunPlacanje.Controls.Add(this.label4);
            this.tabObracunPlacanje.Controls.Add(this.btnTrazi2);
            this.tabObracunPlacanje.Controls.Add(this.txtPoslovnaJedinicaP);
            this.tabObracunPlacanje.Controls.Add(this.lblPoslovnaJedinicaP);
            this.tabObracunPlacanje.Controls.Add(this.grdObracunPlacanje);
            this.tabObracunPlacanje.Location = new System.Drawing.Point(4, 22);
            this.tabObracunPlacanje.Name = "tabObracunPlacanje";
            this.tabObracunPlacanje.Padding = new System.Windows.Forms.Padding(3);
            this.tabObracunPlacanje.Size = new System.Drawing.Size(523, 295);
            this.tabObracunPlacanje.TabIndex = 1;
            this.tabObracunPlacanje.Text = "OBRAČUN PLAČANJE";
            this.tabObracunPlacanje.UseVisualStyleBackColor = true;
            // 
            // txtDatumDoP
            // 
            this.txtDatumDoP.Location = new System.Drawing.Point(250, 40);
            this.txtDatumDoP.Name = "txtDatumDoP";
            this.txtDatumDoP.Size = new System.Drawing.Size(80, 20);
            this.txtDatumDoP.TabIndex = 3;
            // 
            // txtDatumOdP
            // 
            this.txtDatumOdP.Location = new System.Drawing.Point(105, 40);
            this.txtDatumOdP.Name = "txtDatumOdP";
            this.txtDatumOdP.Size = new System.Drawing.Size(80, 20);
            this.txtDatumOdP.TabIndex = 2;
            // 
            // lblDoDatumaP
            // 
            this.lblDoDatumaP.AutoSize = true;
            this.lblDoDatumaP.Location = new System.Drawing.Point(190, 43);
            this.lblDoDatumaP.Name = "lblDoDatumaP";
            this.lblDoDatumaP.Size = new System.Drawing.Size(62, 13);
            this.lblDoDatumaP.TabIndex = 20;
            this.lblDoDatumaP.Text = "Do datuma:";
            // 
            // lblOdDatumaP
            // 
            this.lblOdDatumaP.AutoSize = true;
            this.lblOdDatumaP.Location = new System.Drawing.Point(7, 43);
            this.lblOdDatumaP.Name = "lblOdDatumaP";
            this.lblOdDatumaP.Size = new System.Drawing.Size(62, 13);
            this.lblOdDatumaP.TabIndex = 18;
            this.lblOdDatumaP.Text = "Od datuma:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 13;
            // 
            // btnTrazi2
            // 
            this.btnTrazi2.Location = new System.Drawing.Point(440, 7);
            this.btnTrazi2.Name = "btnTrazi2";
            this.btnTrazi2.Size = new System.Drawing.Size(75, 23);
            this.btnTrazi2.TabIndex = 7;
            this.btnTrazi2.Text = "Traži";
            this.btnTrazi2.UseVisualStyleBackColor = true;
            this.btnTrazi2.Click += new System.EventHandler(this.btnTrazi2_Click);
            // 
            // txtPoslovnaJedinicaP
            // 
            this.txtPoslovnaJedinicaP.Location = new System.Drawing.Point(105, 14);
            this.txtPoslovnaJedinicaP.Name = "txtPoslovnaJedinicaP";
            this.txtPoslovnaJedinicaP.Size = new System.Drawing.Size(225, 20);
            this.txtPoslovnaJedinicaP.TabIndex = 0;
            // 
            // lblPoslovnaJedinicaP
            // 
            this.lblPoslovnaJedinicaP.AutoSize = true;
            this.lblPoslovnaJedinicaP.Location = new System.Drawing.Point(7, 17);
            this.lblPoslovnaJedinicaP.Name = "lblPoslovnaJedinicaP";
            this.lblPoslovnaJedinicaP.Size = new System.Drawing.Size(93, 13);
            this.lblPoslovnaJedinicaP.TabIndex = 9;
            this.lblPoslovnaJedinicaP.Text = "Poslovna jedinica:";
            // 
            // grdObracunPlacanje
            // 
            this.grdObracunPlacanje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdObracunPlacanje.Location = new System.Drawing.Point(6, 66);
            this.grdObracunPlacanje.Name = "grdObracunPlacanje";
            this.grdObracunPlacanje.Size = new System.Drawing.Size(509, 223);
            this.grdObracunPlacanje.TabIndex = 6;
            // 
            // tabObracunArtikli
            // 
            this.tabObracunArtikli.Controls.Add(this.txtPoslovnaJedinicaA);
            this.tabObracunArtikli.Controls.Add(this.lblPoslovnaJedinicaA);
            this.tabObracunArtikli.Controls.Add(this.txtDatumDoA);
            this.tabObracunArtikli.Controls.Add(this.txtDatumOdA);
            this.tabObracunArtikli.Controls.Add(this.lblDoDatumaA);
            this.tabObracunArtikli.Controls.Add(this.lblOdDatumaA);
            this.tabObracunArtikli.Controls.Add(this.btnTrazi3);
            this.tabObracunArtikli.Controls.Add(this.grdObracunArtikli);
            this.tabObracunArtikli.Location = new System.Drawing.Point(4, 22);
            this.tabObracunArtikli.Name = "tabObracunArtikli";
            this.tabObracunArtikli.Padding = new System.Windows.Forms.Padding(3);
            this.tabObracunArtikli.Size = new System.Drawing.Size(523, 295);
            this.tabObracunArtikli.TabIndex = 2;
            this.tabObracunArtikli.Text = "OBRAČUN ARTIKLI";
            this.tabObracunArtikli.UseVisualStyleBackColor = true;
            // 
            // txtPoslovnaJedinicaA
            // 
            this.txtPoslovnaJedinicaA.Location = new System.Drawing.Point(105, 14);
            this.txtPoslovnaJedinicaA.Name = "txtPoslovnaJedinicaA";
            this.txtPoslovnaJedinicaA.Size = new System.Drawing.Size(225, 20);
            this.txtPoslovnaJedinicaA.TabIndex = 35;
            // 
            // lblPoslovnaJedinicaA
            // 
            this.lblPoslovnaJedinicaA.AutoSize = true;
            this.lblPoslovnaJedinicaA.Location = new System.Drawing.Point(7, 17);
            this.lblPoslovnaJedinicaA.Name = "lblPoslovnaJedinicaA";
            this.lblPoslovnaJedinicaA.Size = new System.Drawing.Size(93, 13);
            this.lblPoslovnaJedinicaA.TabIndex = 36;
            this.lblPoslovnaJedinicaA.Text = "Poslovna jedinica:";
            // 
            // txtDatumDoA
            // 
            this.txtDatumDoA.Location = new System.Drawing.Point(250, 40);
            this.txtDatumDoA.Name = "txtDatumDoA";
            this.txtDatumDoA.Size = new System.Drawing.Size(80, 20);
            this.txtDatumDoA.TabIndex = 24;
            // 
            // txtDatumOdA
            // 
            this.txtDatumOdA.Location = new System.Drawing.Point(105, 40);
            this.txtDatumOdA.Name = "txtDatumOdA";
            this.txtDatumOdA.Size = new System.Drawing.Size(80, 20);
            this.txtDatumOdA.TabIndex = 23;
            // 
            // lblDoDatumaA
            // 
            this.lblDoDatumaA.AutoSize = true;
            this.lblDoDatumaA.Location = new System.Drawing.Point(190, 43);
            this.lblDoDatumaA.Name = "lblDoDatumaA";
            this.lblDoDatumaA.Size = new System.Drawing.Size(62, 13);
            this.lblDoDatumaA.TabIndex = 34;
            this.lblDoDatumaA.Text = "Do datuma:";
            // 
            // lblOdDatumaA
            // 
            this.lblOdDatumaA.AutoSize = true;
            this.lblOdDatumaA.Location = new System.Drawing.Point(7, 43);
            this.lblOdDatumaA.Name = "lblOdDatumaA";
            this.lblOdDatumaA.Size = new System.Drawing.Size(62, 13);
            this.lblOdDatumaA.TabIndex = 33;
            this.lblOdDatumaA.Text = "Od datuma:";
            // 
            // btnTrazi3
            // 
            this.btnTrazi3.Location = new System.Drawing.Point(440, 7);
            this.btnTrazi3.Name = "btnTrazi3";
            this.btnTrazi3.Size = new System.Drawing.Size(75, 23);
            this.btnTrazi3.TabIndex = 28;
            this.btnTrazi3.Text = "Traži";
            this.btnTrazi3.UseVisualStyleBackColor = true;
            this.btnTrazi3.Click += new System.EventHandler(this.btnTrazi3_Click);
            // 
            // grdObracunArtikli
            // 
            this.grdObracunArtikli.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdObracunArtikli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdObracunArtikli.Location = new System.Drawing.Point(6, 77);
            this.grdObracunArtikli.Name = "grdObracunArtikli";
            this.grdObracunArtikli.Size = new System.Drawing.Size(509, 212);
            this.grdObracunArtikli.TabIndex = 27;
            // 
            // frmDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 324);
            this.Controls.Add(this.tabSvastaNesto);
            this.KeyPreview = true;
            this.Name = "frmDemo";
            this.Text = "Demo";
            this.tabSvastaNesto.ResumeLayout(false);
            this.tabArtikli.ResumeLayout(false);
            this.tabArtikli.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdArtikli)).EndInit();
            this.tabObracunPlacanje.ResumeLayout(false);
            this.tabObracunPlacanje.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdObracunPlacanje)).EndInit();
            this.tabObracunArtikli.ResumeLayout(false);
            this.tabObracunArtikli.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdObracunArtikli)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabSvastaNesto;
        private System.Windows.Forms.TabPage tabArtikli;
        private System.Windows.Forms.TextBox txtNazivArtila;
        private System.Windows.Forms.Label lblNazivArtikla;
        private System.Windows.Forms.DataGridView grdArtikli;
        private System.Windows.Forms.TabPage tabObracunPlacanje;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTrazi2;
        private System.Windows.Forms.TextBox txtPoslovnaJedinicaP;
        private System.Windows.Forms.Label lblPoslovnaJedinicaP;
        private System.Windows.Forms.DataGridView grdObracunPlacanje;
        private System.Windows.Forms.Label lblDoDatumaP;
        private System.Windows.Forms.Label lblOdDatumaP;
        private System.Windows.Forms.MaskedTextBox txtDatumDoP;
        private System.Windows.Forms.MaskedTextBox txtDatumOdP;
        private System.Windows.Forms.TabPage tabObracunArtikli;
        private System.Windows.Forms.MaskedTextBox txtDatumDoA;
        private System.Windows.Forms.MaskedTextBox txtDatumOdA;
        private System.Windows.Forms.Label lblDoDatumaA;
        private System.Windows.Forms.Label lblOdDatumaA;
        private System.Windows.Forms.Button btnTrazi3;
        private System.Windows.Forms.DataGridView grdObracunArtikli;
        private System.Windows.Forms.Label lblPoslovnaJedinicaA;
        private System.Windows.Forms.TextBox txtPoslovnaJedinicaA;
        private System.Windows.Forms.Button btnTrazi;
    }
}

