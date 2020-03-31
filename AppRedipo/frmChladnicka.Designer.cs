namespace AppRedipo
{
    partial class frmChladnicka
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChladnicka));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPridaj = new System.Windows.Forms.Button();
            this.txtMnozstvo = new System.Windows.Forms.TextBox();
            this.cboSuroviny = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstSuroviny = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Surovina = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Mnozstvo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.btnVymaz = new System.Windows.Forms.ToolStripButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgvJedla = new System.Windows.Forms.DataGridView();
            this.dgvJedlaVsetky = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJedla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJedlaVsetky)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1029, 39);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.ToolStripButton1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPridaj);
            this.groupBox1.Controls.Add(this.txtMnozstvo);
            this.groupBox1.Controls.Add(this.cboSuroviny);
            this.groupBox1.Location = new System.Drawing.Point(12, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(475, 62);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btnPridaj
            // 
            this.btnPridaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPridaj.Location = new System.Drawing.Point(388, 19);
            this.btnPridaj.Name = "btnPridaj";
            this.btnPridaj.Size = new System.Drawing.Size(68, 28);
            this.btnPridaj.TabIndex = 2;
            this.btnPridaj.Text = "+";
            this.btnPridaj.UseVisualStyleBackColor = true;
            this.btnPridaj.Click += new System.EventHandler(this.BtnPridaj_Click);
            // 
            // txtMnozstvo
            // 
            this.txtMnozstvo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtMnozstvo.Location = new System.Drawing.Point(282, 20);
            this.txtMnozstvo.Name = "txtMnozstvo";
            this.txtMnozstvo.Size = new System.Drawing.Size(100, 26);
            this.txtMnozstvo.TabIndex = 1;
            // 
            // cboSuroviny
            // 
            this.cboSuroviny.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboSuroviny.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboSuroviny.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSuroviny.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cboSuroviny.FormattingEnabled = true;
            this.cboSuroviny.Location = new System.Drawing.Point(6, 19);
            this.cboSuroviny.Name = "cboSuroviny";
            this.cboSuroviny.Size = new System.Drawing.Size(269, 28);
            this.cboSuroviny.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstSuroviny);
            this.groupBox2.Controls.Add(this.toolStrip2);
            this.groupBox2.Location = new System.Drawing.Point(12, 110);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(475, 328);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // lstSuroviny
            // 
            this.lstSuroviny.AutoArrange = false;
            this.lstSuroviny.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Surovina,
            this.Mnozstvo});
            this.lstSuroviny.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstSuroviny.FullRowSelect = true;
            this.lstSuroviny.GridLines = true;
            this.lstSuroviny.HideSelection = false;
            this.lstSuroviny.Location = new System.Drawing.Point(3, 55);
            this.lstSuroviny.MultiSelect = false;
            this.lstSuroviny.Name = "lstSuroviny";
            this.lstSuroviny.Size = new System.Drawing.Size(469, 270);
            this.lstSuroviny.TabIndex = 1;
            this.lstSuroviny.UseCompatibleStateImageBehavior = false;
            this.lstSuroviny.View = System.Windows.Forms.View.Details;
            this.lstSuroviny.SelectedIndexChanged += new System.EventHandler(this.LstSuroviny_SelectedIndexChanged);
            // 
            // Id
            // 
            this.Id.Text = "Id";
            // 
            // Surovina
            // 
            this.Surovina.Text = "Surovina";
            // 
            // Mnozstvo
            // 
            this.Mnozstvo.Text = "Množstvo";
            // 
            // toolStrip2
            // 
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton2,
            this.btnVymaz});
            this.toolStrip2.Location = new System.Drawing.Point(3, 16);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(469, 39);
            this.toolStrip2.TabIndex = 0;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // btnVymaz
            // 
            this.btnVymaz.Enabled = false;
            this.btnVymaz.Image = ((System.Drawing.Image)(resources.GetObject("btnVymaz.Image")));
            this.btnVymaz.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnVymaz.Name = "btnVymaz";
            this.btnVymaz.Size = new System.Drawing.Size(83, 36);
            this.btnVymaz.Text = "Odober";
            this.btnVymaz.Click += new System.EventHandler(this.ToolStripButton3_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.splitContainer1);
            this.groupBox3.Location = new System.Drawing.Point(493, 42);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(494, 393);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 16);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgvJedla);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvJedlaVsetky);
            this.splitContainer1.Size = new System.Drawing.Size(488, 374);
            this.splitContainer1.SplitterDistance = 168;
            this.splitContainer1.TabIndex = 1;
            // 
            // dgvJedla
            // 
            this.dgvJedla.AllowUserToAddRows = false;
            this.dgvJedla.AllowUserToDeleteRows = false;
            this.dgvJedla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJedla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvJedla.Location = new System.Drawing.Point(0, 0);
            this.dgvJedla.Name = "dgvJedla";
            this.dgvJedla.ReadOnly = true;
            this.dgvJedla.Size = new System.Drawing.Size(488, 168);
            this.dgvJedla.TabIndex = 0;
            this.dgvJedla.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvJedla_CellContentClick);
            this.dgvJedla.DoubleClick += new System.EventHandler(this.DgvJedla_DoubleClick);
            // 
            // dgvJedlaVsetky
            // 
            this.dgvJedlaVsetky.AllowUserToAddRows = false;
            this.dgvJedlaVsetky.AllowUserToDeleteRows = false;
            this.dgvJedlaVsetky.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJedlaVsetky.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvJedlaVsetky.Location = new System.Drawing.Point(0, 0);
            this.dgvJedlaVsetky.Name = "dgvJedlaVsetky";
            this.dgvJedlaVsetky.ReadOnly = true;
            this.dgvJedlaVsetky.Size = new System.Drawing.Size(488, 202);
            this.dgvJedlaVsetky.TabIndex = 0;
            // 
            // frmChladnicka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmChladnicka";
            this.Text = "frmChladnicka";
            this.Load += new System.EventHandler(this.FrmChladnicka_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJedla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJedlaVsetky)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPridaj;
        private System.Windows.Forms.TextBox txtMnozstvo;
        private System.Windows.Forms.ComboBox cboSuroviny;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ListView lstSuroviny;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader Surovina;
        private System.Windows.Forms.ColumnHeader Mnozstvo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvJedla;
        private System.Windows.Forms.ToolStripButton btnVymaz;
        private System.Windows.Forms.DataGridView dgvJedlaVsetky;
    }
}