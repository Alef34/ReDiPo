namespace AppRedipo
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnZatvor = new System.Windows.Forms.ToolStripButton();
            this.btnSuroviny = new System.Windows.Forms.ToolStripButton();
            this.txtFilterS = new System.Windows.Forms.ToolStripTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnJedla = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnZatvor,
            this.btnSuroviny,
            this.txtFilterS,
            this.btnJedla});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 39);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnZatvor
            // 
            this.btnZatvor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnZatvor.Image = ((System.Drawing.Image)(resources.GetObject("btnZatvor.Image")));
            this.btnZatvor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnZatvor.Name = "btnZatvor";
            this.btnZatvor.Size = new System.Drawing.Size(36, 36);
            this.btnZatvor.Text = "toolStripButton1";
            this.btnZatvor.Click += new System.EventHandler(this.ToolStripButton1_Click);
            // 
            // btnSuroviny
            // 
            this.btnSuroviny.Image = ((System.Drawing.Image)(resources.GetObject("btnSuroviny.Image")));
            this.btnSuroviny.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSuroviny.Name = "btnSuroviny";
            this.btnSuroviny.Size = new System.Drawing.Size(89, 36);
            this.btnSuroviny.Text = "Suroviny";
            this.btnSuroviny.Click += new System.EventHandler(this.ToolStripButton3_Click);
            // 
            // txtFilterS
            // 
            this.txtFilterS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFilterS.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFilterS.Name = "txtFilterS";
            this.txtFilterS.Size = new System.Drawing.Size(100, 39);
            this.txtFilterS.Click += new System.EventHandler(this.TxtFilterS_Click);
            this.txtFilterS.TextChanged += new System.EventHandler(this.TxtFilterS_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(800, 411);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnJedla
            // 
            this.btnJedla.Image = ((System.Drawing.Image)(resources.GetObject("btnJedla.Image")));
            this.btnJedla.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnJedla.Name = "btnJedla";
            this.btnJedla.Size = new System.Drawing.Size(69, 36);
            this.btnJedla.Text = "Jedla";
            this.btnJedla.Click += new System.EventHandler(this.BtnJedla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnZatvor;
        private System.Windows.Forms.ToolStripButton btnSuroviny;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripTextBox txtFilterS;
        private System.Windows.Forms.ToolStripButton btnJedla;
    }
}

