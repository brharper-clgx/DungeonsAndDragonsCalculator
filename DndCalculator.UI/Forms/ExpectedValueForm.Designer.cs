namespace DndCalculator.UI.Forms
{
    partial class ExpectedValueForm
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
            this.evTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.evModifierUpDown = new System.Windows.Forms.NumericUpDown();
            this.evNumSidesUpDown = new System.Windows.Forms.NumericUpDown();
            this.evNumDiceUpDown = new System.Windows.Forms.NumericUpDown();
            this.plusLabel = new System.Windows.Forms.Label();
            this.dLabel = new System.Windows.Forms.Label();
            this.evLabel = new System.Windows.Forms.Label();
            this.evValueLabel = new System.Windows.Forms.Label();
            this.evTableLayoutPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.evModifierUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.evNumSidesUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.evNumDiceUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // evTableLayoutPanel
            // 
            this.evTableLayoutPanel.ColumnCount = 1;
            this.evTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.evTableLayoutPanel.Controls.Add(this.panel1, 0, 0);
            this.evTableLayoutPanel.Controls.Add(this.evLabel, 0, 1);
            this.evTableLayoutPanel.Controls.Add(this.evValueLabel, 0, 2);
            this.evTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.evTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.evTableLayoutPanel.Name = "evTableLayoutPanel";
            this.evTableLayoutPanel.RowCount = 3;
            this.evTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.evTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.51852F));
            this.evTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.14815F));
            this.evTableLayoutPanel.Size = new System.Drawing.Size(284, 261);
            this.evTableLayoutPanel.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.evModifierUpDown);
            this.panel1.Controls.Add(this.evNumSidesUpDown);
            this.panel1.Controls.Add(this.evNumDiceUpDown);
            this.panel1.Controls.Add(this.plusLabel);
            this.panel1.Controls.Add(this.dLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 81);
            this.panel1.TabIndex = 0;
            // 
            // evModifierUpDown
            // 
            this.evModifierUpDown.Location = new System.Drawing.Point(177, 52);
            this.evModifierUpDown.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.evModifierUpDown.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.evModifierUpDown.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.evModifierUpDown.Name = "evModifierUpDown";
            this.evModifierUpDown.Size = new System.Drawing.Size(35, 20);
            this.evModifierUpDown.TabIndex = 12;
            this.evModifierUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.evModifierUpDown.ValueChanged += new System.EventHandler(this.evModifierUpDown_ValueChanged);
            // 
            // evNumSidesUpDown
            // 
            this.evNumSidesUpDown.Location = new System.Drawing.Point(116, 52);
            this.evNumSidesUpDown.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.evNumSidesUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.evNumSidesUpDown.Name = "evNumSidesUpDown";
            this.evNumSidesUpDown.Size = new System.Drawing.Size(40, 20);
            this.evNumSidesUpDown.TabIndex = 11;
            this.evNumSidesUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.evNumSidesUpDown.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.evNumSidesUpDown.ValueChanged += new System.EventHandler(this.evNumSidesUpDown_ValueChanged);
            // 
            // evNumDiceUpDown
            // 
            this.evNumDiceUpDown.Location = new System.Drawing.Point(65, 52);
            this.evNumDiceUpDown.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.evNumDiceUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.evNumDiceUpDown.Name = "evNumDiceUpDown";
            this.evNumDiceUpDown.Size = new System.Drawing.Size(30, 20);
            this.evNumDiceUpDown.TabIndex = 10;
            this.evNumDiceUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.evNumDiceUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.evNumDiceUpDown.ValueChanged += new System.EventHandler(this.evNumDiceUpDown_ValueChanged);
            // 
            // plusLabel
            // 
            this.plusLabel.AutoSize = true;
            this.plusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusLabel.Location = new System.Drawing.Point(156, 50);
            this.plusLabel.Margin = new System.Windows.Forms.Padding(0);
            this.plusLabel.Name = "plusLabel";
            this.plusLabel.Size = new System.Drawing.Size(21, 24);
            this.plusLabel.TabIndex = 8;
            this.plusLabel.Text = "+";
            this.plusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dLabel
            // 
            this.dLabel.AutoSize = true;
            this.dLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dLabel.Location = new System.Drawing.Point(95, 50);
            this.dLabel.Margin = new System.Windows.Forms.Padding(0);
            this.dLabel.Name = "dLabel";
            this.dLabel.Size = new System.Drawing.Size(21, 24);
            this.dLabel.TabIndex = 6;
            this.dLabel.Text = "d";
            this.dLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // evLabel
            // 
            this.evLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.evLabel.AutoSize = true;
            this.evLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.evLabel.Location = new System.Drawing.Point(3, 87);
            this.evLabel.Name = "evLabel";
            this.evLabel.Size = new System.Drawing.Size(278, 48);
            this.evLabel.TabIndex = 1;
            this.evLabel.Text = "Expected Value:";
            this.evLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // evValueLabel
            // 
            this.evValueLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.evValueLabel.AutoSize = true;
            this.evValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.evValueLabel.Location = new System.Drawing.Point(3, 135);
            this.evValueLabel.Name = "evValueLabel";
            this.evValueLabel.Size = new System.Drawing.Size(278, 126);
            this.evValueLabel.TabIndex = 2;
            this.evValueLabel.Text = "10.5";
            this.evValueLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ExpectedValueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.evTableLayoutPanel);
            this.Name = "ExpectedValueForm";
            this.Text = "ExpectedValueForm";
            this.evTableLayoutPanel.ResumeLayout(false);
            this.evTableLayoutPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.evModifierUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.evNumSidesUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.evNumDiceUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel evTableLayoutPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown evModifierUpDown;
        private System.Windows.Forms.NumericUpDown evNumSidesUpDown;
        private System.Windows.Forms.NumericUpDown evNumDiceUpDown;
        private System.Windows.Forms.Label plusLabel;
        private System.Windows.Forms.Label dLabel;
        private System.Windows.Forms.Label evLabel;
        private System.Windows.Forms.Label evValueLabel;
    }
}