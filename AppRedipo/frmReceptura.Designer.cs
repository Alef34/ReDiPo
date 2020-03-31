namespace AppRedipo
{
    partial class frmReceptura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReceptura));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnZatvor = new System.Windows.Forms.ToolStripButton();
            this.lblId = new System.Windows.Forms.ToolStripLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvIngrediencie = new System.Windows.Forms.DataGridView();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnPridaj = new System.Windows.Forms.ToolStripButton();
            this.btnVymaz = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngrediencie)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnZatvor,
            this.lblId});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 39);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnZatvor
            // 
            this.btnZatvor.Image = ((System.Drawing.Image)(resources.GetObject("btnZatvor.Image")));
            this.btnZatvor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnZatvor.Name = "btnZatvor";
            this.btnZatvor.Size = new System.Drawing.Size(77, 36);
            this.btnZatvor.Text = "Zatvor";
            this.btnZatvor.Click += new System.EventHandler(this.BtnZatvor_Click);
            // 
            // lblId
            // 
            this.lblId.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(86, 36);
            this.lblId.Text = "toolStripLabel1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvIngrediencie);
            this.panel1.Controls.Add(this.toolStrip2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 411);
            this.panel1.TabIndex = 1;
            // 
            // dgvIngrediencie
            // 
            this.dgvIngrediencie.AllowUserToAddRows = false;
            this.dgvIngrediencie.AllowUserToDeleteRows = false;
            this.dgvIngrediencie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIngrediencie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvIngrediencie.Location = new System.Drawing.Point(0, 39);
            this.dgvIngrediencie.MultiSelect = false;
            this.dgvIngrediencie.Name = "dgvIngrediencie";
            this.dgvIngrediencie.ReadOnly = true;
            this.dgvIngrediencie.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIngrediencie.Size = new System.Drawing.Size(800, 372);
            this.dgvIngrediencie.TabIndex = 1;
            this.dgvIngrediencie.SelectionChanged += new System.EventHandler(this.DgvIngrediencie_SelectionChanged);
            this.dgvIngrediencie.DoubleClick += new System.EventHandler(this.DgvIngrediencie_DoubleClick);
            // 
            // toolStrip2
            // 
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnPridaj,
            this.btnVymaz});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(800, 39);
            this.toolStrip2.TabIndex = 0;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // btnPridaj
            // 
            this.btnPridaj.Image = ((System.Drawing.Image)(resources.GetObject("btnPridaj.Image")));
            this.btnPridaj.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPridaj.Name = "btnPridaj";
            this.btnPridaj.Size = new System.Drawing.Size(73, 36);
            this.btnPridaj.Text = "Pridaj";
            this.btnPridaj.Click += new System.EventHandler(this.ToolStripButton1_Click);
            // 
            // btnVymaz
            // 
            this.btnVymaz.Enabled = false;
            this.btnVymaz.Image = ((System.Drawing.Image)(resources.GetObject("btnVymaz.Image")));
            this.btnVymaz.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnVymaz.Name = "btnVymaz";
            this.btnVymaz.Size = new System.Drawing.Size(78, 36);
            this.btnVymaz.Text = "Vymaž";
            this.btnVymaz.Click += new System.EventHandler(this.BtnVymaz_Click);
            // 
            // frmReceptura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmReceptura";
            this.Text = "frmReceptura";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmReceptura_FormClosing);
            this.Load += new System.EventHandler(this.FrmReceptura_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngrediencie)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnZatvor;
        private System.Windows.Forms.ToolStripLabel lblId;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvIngrediencie;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btnPridaj;
        private System.Windows.Forms.ToolStripButton btnVymaz;
    }
}