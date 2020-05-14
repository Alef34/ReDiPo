namespace AppRedipo
{
    partial class frmJedla
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmJedla));
            this.dgvJedla = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnZatvor = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txtJedla = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cboKategorie = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnVymaz = new System.Windows.Forms.ToolStripButton();
            this.btnReceptura = new System.Windows.Forms.ToolStripButton();
            this.tlsEdit = new System.Windows.Forms.ToolStrip();
            this.btnClose = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.lblIdJ = new System.Windows.Forms.ToolStripLabel();
            this.txtJedlo = new System.Windows.Forms.ToolStripTextBox();
            this.lblIdKFk = new System.Windows.Forms.ToolStripLabel();
            this.cboKategoria = new System.Windows.Forms.ToolStripComboBox();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJedla)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.tlsEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvJedla
            // 
            this.dgvJedla.AllowUserToAddRows = false;
            this.dgvJedla.AllowUserToDeleteRows = false;
            this.dgvJedla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJedla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvJedla.Location = new System.Drawing.Point(0, 39);
            this.dgvJedla.MultiSelect = false;
            this.dgvJedla.Name = "dgvJedla";
            this.dgvJedla.ReadOnly = true;
            this.dgvJedla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvJedla.Size = new System.Drawing.Size(1195, 411);
            this.dgvJedla.TabIndex = 3;
            this.dgvJedla.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            this.dgvJedla.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.DataGridView1_DefaultValuesNeeded);
            this.dgvJedla.SelectionChanged += new System.EventHandler(this.DataGridView1_SelectionChanged);
            this.dgvJedla.DoubleClick += new System.EventHandler(this.DataGridView1_DoubleClick);
            this.dgvJedla.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DataGridView1_MouseClick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnZatvor,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.txtJedla,
            this.toolStripSeparator3,
            this.cboKategorie,
            this.toolStripButton1,
            this.toolStripSeparator2,
            this.btnVymaz,
            this.btnReceptura});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1195, 39);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnZatvor
            // 
            this.btnZatvor.Image = ((System.Drawing.Image)(resources.GetObject("btnZatvor.Image")));
            this.btnZatvor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnZatvor.Name = "btnZatvor";
            this.btnZatvor.Size = new System.Drawing.Size(77, 36);
            this.btnZatvor.Text = "Zatvor";
            this.btnZatvor.Click += new System.EventHandler(this.ToolStripButton1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(36, 36);
            this.toolStripLabel1.Text = "Filter:";
            // 
            // txtJedla
            // 
            this.txtJedla.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtJedla.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtJedla.Name = "txtJedla";
            this.txtJedla.Size = new System.Drawing.Size(100, 39);
            this.txtJedla.TextChanged += new System.EventHandler(this.TxtJedla_TextChanged);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 39);
            // 
            // cboKategorie
            // 
            this.cboKategorie.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboKategorie.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboKategorie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKategorie.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.cboKategorie.Name = "cboKategorie";
            this.cboKategorie.Size = new System.Drawing.Size(121, 39);
            this.cboKategorie.SelectedIndexChanged += new System.EventHandler(this.CboKategorie_SelectedIndexChanged);
            this.cboKategorie.Click += new System.EventHandler(this.CboKategorie_Click);
            this.cboKategorie.TextChanged += new System.EventHandler(this.CboKategorie_TextChanged);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(93, 36);
            this.toolStripButton1.Text = "Kategorie";
            this.toolStripButton1.Click += new System.EventHandler(this.ToolStripButton1_Click_1);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // btnVymaz
            // 
            this.btnVymaz.Image = ((System.Drawing.Image)(resources.GetObject("btnVymaz.Image")));
            this.btnVymaz.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnVymaz.Name = "btnVymaz";
            this.btnVymaz.Size = new System.Drawing.Size(78, 36);
            this.btnVymaz.Text = "Vymaz";
            this.btnVymaz.Click += new System.EventHandler(this.ToolStripButton4_Click);
            // 
            // btnReceptura
            // 
            this.btnReceptura.Image = ((System.Drawing.Image)(resources.GetObject("btnReceptura.Image")));
            this.btnReceptura.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReceptura.Name = "btnReceptura";
            this.btnReceptura.Size = new System.Drawing.Size(96, 36);
            this.btnReceptura.Text = "Receptura";
            this.btnReceptura.Click += new System.EventHandler(this.BtnReceptura_Click);
            // 
            // tlsEdit
            // 
            this.tlsEdit.Dock = System.Windows.Forms.DockStyle.None;
            this.tlsEdit.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.tlsEdit.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnClose,
            this.toolStripSeparator4,
            this.lblIdJ,
            this.txtJedlo,
            this.lblIdKFk,
            this.cboKategoria,
            this.btnSave});
            this.tlsEdit.Location = new System.Drawing.Point(387, 188);
            this.tlsEdit.Name = "tlsEdit";
            this.tlsEdit.Size = new System.Drawing.Size(622, 39);
            this.tlsEdit.TabIndex = 4;
            this.tlsEdit.Text = "toolStrip2";
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(77, 36);
            this.btnClose.Text = "Zatvor";
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 39);
            // 
            // lblIdJ
            // 
            this.lblIdJ.Name = "lblIdJ";
            this.lblIdJ.Size = new System.Drawing.Size(21, 36);
            this.lblIdJ.Text = "IdJ";
            // 
            // txtJedlo
            // 
            this.txtJedlo.AutoSize = false;
            this.txtJedlo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtJedlo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtJedlo.Name = "txtJedlo";
            this.txtJedlo.Size = new System.Drawing.Size(200, 39);
            // 
            // lblIdKFk
            // 
            this.lblIdKFk.Name = "lblIdKFk";
            this.lblIdKFk.Size = new System.Drawing.Size(36, 36);
            this.lblIdKFk.Text = "idKFk";
            // 
            // cboKategoria
            // 
            this.cboKategoria.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboKategoria.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboKategoria.AutoSize = false;
            this.cboKategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKategoria.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.cboKategoria.Name = "cboKategoria";
            this.cboKategoria.Size = new System.Drawing.Size(200, 39);
            this.cboKategoria.SelectedIndexChanged += new System.EventHandler(this.CboKategoria_SelectedIndexChanged);
            // 
            // btnSave
            // 
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(66, 36);
            this.btnSave.Text = "Ulož";
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // frmJedla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 450);
            this.Controls.Add(this.tlsEdit);
            this.Controls.Add(this.dgvJedla);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmJedla";
            this.Text = "frmJedla";
            this.Load += new System.EventHandler(this.FrmJedla_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJedla)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tlsEdit.ResumeLayout(false);
            this.tlsEdit.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvJedla;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnZatvor;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox txtJedla;
        private System.Windows.Forms.ToolStripButton btnVymaz;
        private System.Windows.Forms.ToolStripButton btnReceptura;
        private System.Windows.Forms.ToolStripComboBox cboKategorie;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStrip tlsEdit;
        private System.Windows.Forms.ToolStripButton btnClose;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel lblIdJ;
        private System.Windows.Forms.ToolStripTextBox txtJedlo;
        private System.Windows.Forms.ToolStripLabel lblIdKFk;
        private System.Windows.Forms.ToolStripComboBox cboKategoria;
        private System.Windows.Forms.ToolStripButton btnSave;
    }
}