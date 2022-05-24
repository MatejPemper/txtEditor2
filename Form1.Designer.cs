namespace txtEditor
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
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uNDOToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.cUTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cOPYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bOLDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iTALICToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fONTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonNew = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(12, 47);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(530, 391);
            this.richTextBox.TabIndex = 0;
            this.richTextBox.Text = "";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(558, 356);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(230, 82);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(558, 261);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(229, 84);
            this.buttonOpen.TabIndex = 2;
            this.buttonOpen.Text = "Open";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.bOLDToolStripMenuItem,
            this.iTALICToolStripMenuItem,
            this.fONTToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uNDOToolStripMenuItem2,
            this.cUTToolStripMenuItem,
            this.cOPYToolStripMenuItem});
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.undoToolStripMenuItem.Text = "EDIT";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // uNDOToolStripMenuItem2
            // 
            this.uNDOToolStripMenuItem2.Name = "uNDOToolStripMenuItem2";
            this.uNDOToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.uNDOToolStripMenuItem2.Text = "UNDO";
            this.uNDOToolStripMenuItem2.Click += new System.EventHandler(this.uNDOToolStripMenuItem2_Click);
            // 
            // cUTToolStripMenuItem
            // 
            this.cUTToolStripMenuItem.Name = "cUTToolStripMenuItem";
            this.cUTToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cUTToolStripMenuItem.Text = "CUT";
            this.cUTToolStripMenuItem.Click += new System.EventHandler(this.cUTToolStripMenuItem_Click);
            // 
            // cOPYToolStripMenuItem
            // 
            this.cOPYToolStripMenuItem.Name = "cOPYToolStripMenuItem";
            this.cOPYToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cOPYToolStripMenuItem.Text = "COPY";
            this.cOPYToolStripMenuItem.Click += new System.EventHandler(this.cOPYToolStripMenuItem_Click);
            // 
            // bOLDToolStripMenuItem
            // 
            this.bOLDToolStripMenuItem.Name = "bOLDToolStripMenuItem";
            this.bOLDToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.bOLDToolStripMenuItem.Text = "BOLD";
            this.bOLDToolStripMenuItem.Click += new System.EventHandler(this.bOLDToolStripMenuItem_Click);
            // 
            // iTALICToolStripMenuItem
            // 
            this.iTALICToolStripMenuItem.Name = "iTALICToolStripMenuItem";
            this.iTALICToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.iTALICToolStripMenuItem.Text = "ITALIC";
            this.iTALICToolStripMenuItem.Click += new System.EventHandler(this.iTALICToolStripMenuItem_Click);
            // 
            // fONTToolStripMenuItem
            // 
            this.fONTToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6,
            this.toolStripMenuItem7});
            this.fONTToolStripMenuItem.Name = "fONTToolStripMenuItem";
            this.fONTToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.fONTToolStripMenuItem.Text = "FONT";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(86, 22);
            this.toolStripMenuItem2.Text = "10";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(86, 22);
            this.toolStripMenuItem3.Text = "12";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(86, 22);
            this.toolStripMenuItem4.Text = "15";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(86, 22);
            this.toolStripMenuItem5.Text = "18";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(86, 22);
            this.toolStripMenuItem6.Text = "20";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(86, 22);
            this.toolStripMenuItem7.Text = "25";
            this.toolStripMenuItem7.Click += new System.EventHandler(this.toolStripMenuItem7_Click);
            // 
            // buttonNew
            // 
            this.buttonNew.Location = new System.Drawing.Point(558, 159);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(229, 87);
            this.buttonNew.TabIndex = 4;
            this.buttonNew.Text = "New";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonNew);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uNDOToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem cUTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cOPYToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fONTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem bOLDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iTALICToolStripMenuItem;
        private System.Windows.Forms.Button buttonNew;
    }
}

