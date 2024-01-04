namespace LIBRARY_INFO_SYSTEM
{
    partial class menuform
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
            this.components = new System.ComponentModel.Container();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bOOKSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aDDBOOKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vEIWBOOKSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eXITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bOOKSToolStripMenuItem,
            this.eXITToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(835, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bOOKSToolStripMenuItem
            // 
            this.bOOKSToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bOOKSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aDDBOOKToolStripMenuItem,
            this.vEIWBOOKSToolStripMenuItem});
            this.bOOKSToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bOOKSToolStripMenuItem.Name = "bOOKSToolStripMenuItem";
            this.bOOKSToolStripMenuItem.Size = new System.Drawing.Size(63, 21);
            this.bOOKSToolStripMenuItem.Text = "BOOKS";
            // 
            // aDDBOOKToolStripMenuItem
            // 
            this.aDDBOOKToolStripMenuItem.Name = "aDDBOOKToolStripMenuItem";
            this.aDDBOOKToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aDDBOOKToolStripMenuItem.Text = "Add Book";
            this.aDDBOOKToolStripMenuItem.Click += new System.EventHandler(this.aDDBOOKToolStripMenuItem_Click);
            // 
            // vEIWBOOKSToolStripMenuItem
            // 
            this.vEIWBOOKSToolStripMenuItem.Name = "vEIWBOOKSToolStripMenuItem";
            this.vEIWBOOKSToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.vEIWBOOKSToolStripMenuItem.Text = "View Book";
            this.vEIWBOOKSToolStripMenuItem.Click += new System.EventHandler(this.vEIWBOOKSToolStripMenuItem_Click);
            // 
            // eXITToolStripMenuItem
            // 
            this.eXITToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eXITToolStripMenuItem.Name = "eXITToolStripMenuItem";
            this.eXITToolStripMenuItem.Size = new System.Drawing.Size(46, 21);
            this.eXITToolStripMenuItem.Text = "EXIT";
            this.eXITToolStripMenuItem.Click += new System.EventHandler(this.eXITToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::LIBRARY_INFO_SYSTEM.Properties.Resources._29660__1_;
            this.ClientSize = new System.Drawing.Size(835, 379);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "menuform";
            this.Text = "menuform";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bOOKSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aDDBOOKToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vEIWBOOKSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eXITToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}