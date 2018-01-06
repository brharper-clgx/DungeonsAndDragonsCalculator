namespace DndCalculator.UI
{
    partial class CalculatorRootUI
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newCalculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.difficultyClassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expectedValueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(856, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newCalculatorToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newCalculatorToolStripMenuItem
            // 
            this.newCalculatorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.difficultyClassToolStripMenuItem,
            this.expectedValueToolStripMenuItem});
            this.newCalculatorToolStripMenuItem.Name = "newCalculatorToolStripMenuItem";
            this.newCalculatorToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.newCalculatorToolStripMenuItem.Text = "New Calculator";
            // 
            // difficultyClassToolStripMenuItem
            // 
            this.difficultyClassToolStripMenuItem.Name = "difficultyClassToolStripMenuItem";
            this.difficultyClassToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.difficultyClassToolStripMenuItem.Text = "Difficulty Class";
            this.difficultyClassToolStripMenuItem.Click += new System.EventHandler(this.difficultyClassToolStripMenuItem_Click);
            // 
            // expectedValueToolStripMenuItem
            // 
            this.expectedValueToolStripMenuItem.Name = "expectedValueToolStripMenuItem";
            this.expectedValueToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.expectedValueToolStripMenuItem.Text = "Expected Value";
            this.expectedValueToolStripMenuItem.Click += new System.EventHandler(this.expectedValueToolStripMenuItem_Click);
            // 
            // CalculatorRootUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 594);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CalculatorRootUI";
            this.Text = "Dnd Calculator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newCalculatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem difficultyClassToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expectedValueToolStripMenuItem;
    }
}