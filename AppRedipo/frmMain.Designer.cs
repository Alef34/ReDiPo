namespace AppRedipo
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnZatvor = new System.Windows.Forms.ToolStripButton();
            this.btnSuroviny = new System.Windows.Forms.ToolStripButton();
            this.txtFilterS = new System.Windows.Forms.ToolStripTextBox();
            this.btnJedla = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.koniecToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ciselnikyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jedlaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kategorieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.surovinyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oknaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chladnickaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtFilterCount = new System.Windows.Forms.ToolStripTextBox();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnZatvor,
            this.btnSuroviny,
            this.txtFilterS,
            this.btnJedla,
            this.txtFilterCount});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
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
            // btnJedla
            // 
            this.btnJedla.Image = ((System.Drawing.Image)(resources.GetObject("btnJedla.Image")));
            this.btnJedla.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnJedla.Name = "btnJedla";
            this.btnJedla.Size = new System.Drawing.Size(69, 36);
            this.btnJedla.Text = "Jedla";
            this.btnJedla.Click += new System.EventHandler(this.BtnJedla_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.koniecToolStripMenuItem,
            this.ciselnikyToolStripMenuItem,
            this.oknaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // koniecToolStripMenuItem
            // 
            this.koniecToolStripMenuItem.Name = "koniecToolStripMenuItem";
            this.koniecToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.koniecToolStripMenuItem.Text = "Koniec";
            this.koniecToolStripMenuItem.Click += new System.EventHandler(this.KoniecToolStripMenuItem_Click);
            // 
            // ciselnikyToolStripMenuItem
            // 
            this.ciselnikyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jedlaToolStripMenuItem,
            this.kategorieToolStripMenuItem,
            this.surovinyToolStripMenuItem});
            this.ciselnikyToolStripMenuItem.Name = "ciselnikyToolStripMenuItem";
            this.ciselnikyToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.ciselnikyToolStripMenuItem.Text = "Ciselniky";
            // 
            // jedlaToolStripMenuItem
            // 
            this.jedlaToolStripMenuItem.Name = "jedlaToolStripMenuItem";
            this.jedlaToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.jedlaToolStripMenuItem.Text = "Jedla";
            this.jedlaToolStripMenuItem.Click += new System.EventHandler(this.JedlaToolStripMenuItem_Click);
            // 
            // kategorieToolStripMenuItem
            // 
            this.kategorieToolStripMenuItem.Name = "kategorieToolStripMenuItem";
            this.kategorieToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.kategorieToolStripMenuItem.Text = "Kategorie";
            this.kategorieToolStripMenuItem.Click += new System.EventHandler(this.KategorieToolStripMenuItem_Click);
            // 
            // surovinyToolStripMenuItem
            // 
            this.surovinyToolStripMenuItem.Name = "surovinyToolStripMenuItem";
            this.surovinyToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.surovinyToolStripMenuItem.Text = "Suroviny";
            this.surovinyToolStripMenuItem.Click += new System.EventHandler(this.SurovinyToolStripMenuItem_Click);
            // 
            // oknaToolStripMenuItem
            // 
            this.oknaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chladnickaToolStripMenuItem});
            this.oknaToolStripMenuItem.Name = "oknaToolStripMenuItem";
            this.oknaToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.oknaToolStripMenuItem.Text = "Okna";
            // 
            // chladnickaToolStripMenuItem
            // 
            this.chladnickaToolStripMenuItem.Name = "chladnickaToolStripMenuItem";
            this.chladnickaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.C)));
            this.chladnickaToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.chladnickaToolStripMenuItem.Text = "Chladnicka";
            this.chladnickaToolStripMenuItem.Click += new System.EventHandler(this.ChladnickaToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button2, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 63);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 313);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(394, 150);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            this.pictureBox1.DoubleClick += new System.EventHandler(this.PictureBox1_DoubleClick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Location = new System.Drawing.Point(3, 159);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(394, 151);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(403, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(394, 150);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Location = new System.Drawing.Point(403, 159);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(394, 151);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // txtFilterCount
            // 
            this.txtFilterCount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFilterCount.Name = "txtFilterCount";
            this.txtFilterCount.Size = new System.Drawing.Size(100, 39);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 376);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnZatvor;
        private System.Windows.Forms.ToolStripButton btnSuroviny;
        private System.Windows.Forms.ToolStripTextBox txtFilterS;
        private System.Windows.Forms.ToolStripButton btnJedla;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem koniecToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ciselnikyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem surovinyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oknaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chladnickaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kategorieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jedlaToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripTextBox txtFilterCount;
    }
}

