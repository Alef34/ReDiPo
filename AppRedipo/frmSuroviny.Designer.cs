namespace AppRedipo
{
    partial class frmSuroviny
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSuroviny));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnZatvor = new System.Windows.Forms.ToolStripButton();
            this.txtSurovina = new System.Windows.Forms.ToolStripTextBox();
            this.btnPrepis = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnVymaz = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txtText = new System.Windows.Forms.ToolStripTextBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnZatvor,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.txtSurovina,
            this.txtText,
            this.btnPrepis,
            this.btnVymaz});
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
            this.btnZatvor.Click += new System.EventHandler(this.ToolStripButton1_Click);
            // 
            // txtSurovina
            // 
            this.txtSurovina.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSurovina.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSurovina.Name = "txtSurovina";
            this.txtSurovina.Size = new System.Drawing.Size(100, 39);
            this.txtSurovina.Click += new System.EventHandler(this.TxtSurovina_Click);
            this.txtSurovina.TextChanged += new System.EventHandler(this.TxtSurovina_TextChanged);
            // 
            // btnPrepis
            // 
            this.btnPrepis.Image = ((System.Drawing.Image)(resources.GetObject("btnPrepis.Image")));
            this.btnPrepis.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrepis.Name = "btnPrepis";
            this.btnPrepis.Size = new System.Drawing.Size(75, 36);
            this.btnPrepis.Text = "Prepis";
            this.btnPrepis.Click += new System.EventHandler(this.ToolStripButton3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 39);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(800, 411);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.DataGridView1_SelectionChanged);
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
            // txtText
            // 
            this.txtText.AutoSize = false;
            this.txtText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtText.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(200, 39);
            // 
            // frmSuroviny
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmSuroviny";
            this.Text = "frmSuroviny";
            this.Load += new System.EventHandler(this.FrmSuroviny_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnZatvor;
        private System.Windows.Forms.ToolStripTextBox txtSurovina;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripButton btnPrepis;
        private System.Windows.Forms.ToolStripButton btnVymaz;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox txtText;
    }
}