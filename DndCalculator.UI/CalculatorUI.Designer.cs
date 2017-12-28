namespace DndCalculator.UI
{
    partial class CalculatorUI
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.difficultyClassTab = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.difficultyLabel = new System.Windows.Forms.Label();
            this.successPercentageTrackbar = new System.Windows.Forms.TrackBar();
            this.successPercentageLabel = new System.Windows.Forms.Label();
            this.difficultyClassValueLabel = new System.Windows.Forms.Label();
            this.optionsFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.advantageCheckbox = new System.Windows.Forms.CheckBox();
            this.disadvantageCheckbox = new System.Windows.Forms.CheckBox();
            this.modifierLabel = new System.Windows.Forms.Label();
            this.modifierUpDown = new System.Windows.Forms.NumericUpDown();
            this.expectedValueTab = new System.Windows.Forms.TabPage();
            this.evTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.evModifierUpDown = new System.Windows.Forms.NumericUpDown();
            this.evNumSidesUpDown = new System.Windows.Forms.NumericUpDown();
            this.evNumDiceUpDown = new System.Windows.Forms.NumericUpDown();
            this.plusLabel = new System.Windows.Forms.Label();
            this.dLabel = new System.Windows.Forms.Label();
            this.evLabel = new System.Windows.Forms.Label();
            this.evValueLabel = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.difficultyClassTab.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.successPercentageTrackbar)).BeginInit();
            this.optionsFlowLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modifierUpDown)).BeginInit();
            this.expectedValueTab.SuspendLayout();
            this.evTableLayoutPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.evModifierUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.evNumSidesUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.evNumDiceUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.difficultyClassTab);
            this.tabControl.Controls.Add(this.expectedValueTab);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(281, 275);
            this.tabControl.TabIndex = 0;
            // 
            // difficultyClassTab
            // 
            this.difficultyClassTab.Controls.Add(this.tableLayoutPanel);
            this.difficultyClassTab.Location = new System.Drawing.Point(4, 22);
            this.difficultyClassTab.Name = "difficultyClassTab";
            this.difficultyClassTab.Padding = new System.Windows.Forms.Padding(3);
            this.difficultyClassTab.Size = new System.Drawing.Size(273, 249);
            this.difficultyClassTab.TabIndex = 0;
            this.difficultyClassTab.Text = "DC Calc";
            this.difficultyClassTab.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 3;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.Controls.Add(this.difficultyLabel, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.successPercentageTrackbar, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.successPercentageLabel, 2, 0);
            this.tableLayoutPanel.Controls.Add(this.difficultyClassValueLabel, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.optionsFlowLayout, 0, 2);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 3;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(267, 243);
            this.tableLayoutPanel.TabIndex = 1;
            // 
            // difficultyLabel
            // 
            this.difficultyLabel.AutoSize = true;
            this.difficultyLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.difficultyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.difficultyLabel.Location = new System.Drawing.Point(3, 0);
            this.difficultyLabel.Name = "difficultyLabel";
            this.difficultyLabel.Size = new System.Drawing.Size(127, 97);
            this.difficultyLabel.TabIndex = 0;
            this.difficultyLabel.Text = "DC:";
            this.difficultyLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // successPercentageTrackbar
            // 
            this.successPercentageTrackbar.Dock = System.Windows.Forms.DockStyle.Right;
            this.successPercentageTrackbar.LargeChange = 1;
            this.successPercentageTrackbar.Location = new System.Drawing.Point(151, 3);
            this.successPercentageTrackbar.Maximum = 20;
            this.successPercentageTrackbar.Name = "successPercentageTrackbar";
            this.successPercentageTrackbar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tableLayoutPanel.SetRowSpan(this.successPercentageTrackbar, 2);
            this.successPercentageTrackbar.Size = new System.Drawing.Size(45, 188);
            this.successPercentageTrackbar.TabIndex = 1;
            this.successPercentageTrackbar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.successPercentageTrackbar.Value = 10;
            this.successPercentageTrackbar.Scroll += new System.EventHandler(this.successPercentageTrackbar_Scroll);
            // 
            // successPercentageLabel
            // 
            this.successPercentageLabel.AutoSize = true;
            this.successPercentageLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.successPercentageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.successPercentageLabel.Location = new System.Drawing.Point(202, 0);
            this.successPercentageLabel.Name = "successPercentageLabel";
            this.tableLayoutPanel.SetRowSpan(this.successPercentageLabel, 2);
            this.successPercentageLabel.Size = new System.Drawing.Size(30, 194);
            this.successPercentageLabel.TabIndex = 2;
            this.successPercentageLabel.Text = "50";
            this.successPercentageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // difficultyClassValueLabel
            // 
            this.difficultyClassValueLabel.AutoSize = true;
            this.difficultyClassValueLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.difficultyClassValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.difficultyClassValueLabel.Location = new System.Drawing.Point(3, 97);
            this.difficultyClassValueLabel.Name = "difficultyClassValueLabel";
            this.difficultyClassValueLabel.Size = new System.Drawing.Size(127, 97);
            this.difficultyClassValueLabel.TabIndex = 3;
            this.difficultyClassValueLabel.Text = "11";
            this.difficultyClassValueLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // optionsFlowLayout
            // 
            this.tableLayoutPanel.SetColumnSpan(this.optionsFlowLayout, 3);
            this.optionsFlowLayout.Controls.Add(this.advantageCheckbox);
            this.optionsFlowLayout.Controls.Add(this.disadvantageCheckbox);
            this.optionsFlowLayout.Controls.Add(this.modifierLabel);
            this.optionsFlowLayout.Controls.Add(this.modifierUpDown);
            this.optionsFlowLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.optionsFlowLayout.Location = new System.Drawing.Point(3, 197);
            this.optionsFlowLayout.Name = "optionsFlowLayout";
            this.optionsFlowLayout.Size = new System.Drawing.Size(261, 43);
            this.optionsFlowLayout.TabIndex = 4;
            // 
            // advantageCheckbox
            // 
            this.advantageCheckbox.AutoSize = true;
            this.advantageCheckbox.Location = new System.Drawing.Point(3, 3);
            this.advantageCheckbox.Name = "advantageCheckbox";
            this.advantageCheckbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.advantageCheckbox.Size = new System.Drawing.Size(45, 17);
            this.advantageCheckbox.TabIndex = 0;
            this.advantageCheckbox.Text = "Adv";
            this.advantageCheckbox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.advantageCheckbox.UseVisualStyleBackColor = true;
            this.advantageCheckbox.CheckedChanged += new System.EventHandler(this.advantageCheckbox_CheckedChanged);
            // 
            // disadvantageCheckbox
            // 
            this.disadvantageCheckbox.AutoSize = true;
            this.disadvantageCheckbox.Location = new System.Drawing.Point(66, 3);
            this.disadvantageCheckbox.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.disadvantageCheckbox.Name = "disadvantageCheckbox";
            this.disadvantageCheckbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.disadvantageCheckbox.Size = new System.Drawing.Size(41, 17);
            this.disadvantageCheckbox.TabIndex = 1;
            this.disadvantageCheckbox.Text = "Dis";
            this.disadvantageCheckbox.UseVisualStyleBackColor = true;
            this.disadvantageCheckbox.CheckedChanged += new System.EventHandler(this.disadvantageCheckbox_CheckedChanged);
            // 
            // modifierLabel
            // 
            this.modifierLabel.AutoSize = true;
            this.modifierLabel.Location = new System.Drawing.Point(125, 3);
            this.modifierLabel.Margin = new System.Windows.Forms.Padding(15, 3, 0, 3);
            this.modifierLabel.Name = "modifierLabel";
            this.modifierLabel.Size = new System.Drawing.Size(31, 13);
            this.modifierLabel.TabIndex = 2;
            this.modifierLabel.Text = "Mod:";
            this.modifierLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // modifierUpDown
            // 
            this.modifierUpDown.Location = new System.Drawing.Point(159, 3);
            this.modifierUpDown.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.modifierUpDown.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            -2147483648});
            this.modifierUpDown.Name = "modifierUpDown";
            this.modifierUpDown.Size = new System.Drawing.Size(34, 20);
            this.modifierUpDown.TabIndex = 3;
            this.modifierUpDown.ValueChanged += new System.EventHandler(this.modifierUpDown_ValueChanged);
            // 
            // expectedValueTab
            // 
            this.expectedValueTab.Controls.Add(this.evTableLayoutPanel);
            this.expectedValueTab.Location = new System.Drawing.Point(4, 22);
            this.expectedValueTab.Name = "expectedValueTab";
            this.expectedValueTab.Padding = new System.Windows.Forms.Padding(3);
            this.expectedValueTab.Size = new System.Drawing.Size(273, 249);
            this.expectedValueTab.TabIndex = 1;
            this.expectedValueTab.Text = "EV Calc";
            this.expectedValueTab.UseVisualStyleBackColor = true;
            // 
            // evTableLayoutPanel
            // 
            this.evTableLayoutPanel.ColumnCount = 1;
            this.evTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.evTableLayoutPanel.Controls.Add(this.panel1, 0, 0);
            this.evTableLayoutPanel.Controls.Add(this.evLabel, 0, 1);
            this.evTableLayoutPanel.Controls.Add(this.evValueLabel, 0, 2);
            this.evTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.evTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.evTableLayoutPanel.Name = "evTableLayoutPanel";
            this.evTableLayoutPanel.RowCount = 3;
            this.evTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.evTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.51852F));
            this.evTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.14815F));
            this.evTableLayoutPanel.Size = new System.Drawing.Size(267, 243);
            this.evTableLayoutPanel.TabIndex = 0;
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
            this.panel1.Size = new System.Drawing.Size(261, 75);
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
            this.evLabel.Location = new System.Drawing.Point(3, 81);
            this.evLabel.Name = "evLabel";
            this.evLabel.Size = new System.Drawing.Size(261, 44);
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
            this.evValueLabel.Location = new System.Drawing.Point(3, 125);
            this.evValueLabel.Name = "evValueLabel";
            this.evValueLabel.Size = new System.Drawing.Size(261, 118);
            this.evValueLabel.TabIndex = 2;
            this.evValueLabel.Text = "10.5";
            this.evValueLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CalculatorUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 275);
            this.Controls.Add(this.tabControl);
            this.Name = "CalculatorUI";
            this.Text = "D&D Calculator";
            this.tabControl.ResumeLayout(false);
            this.difficultyClassTab.ResumeLayout(false);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.successPercentageTrackbar)).EndInit();
            this.optionsFlowLayout.ResumeLayout(false);
            this.optionsFlowLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modifierUpDown)).EndInit();
            this.expectedValueTab.ResumeLayout(false);
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

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage difficultyClassTab;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Label difficultyLabel;
        private System.Windows.Forms.TrackBar successPercentageTrackbar;
        private System.Windows.Forms.Label successPercentageLabel;
        private System.Windows.Forms.Label difficultyClassValueLabel;
        private System.Windows.Forms.FlowLayoutPanel optionsFlowLayout;
        private System.Windows.Forms.CheckBox advantageCheckbox;
        private System.Windows.Forms.CheckBox disadvantageCheckbox;
        private System.Windows.Forms.Label modifierLabel;
        private System.Windows.Forms.NumericUpDown modifierUpDown;
        private System.Windows.Forms.TabPage expectedValueTab;
        private System.Windows.Forms.TableLayoutPanel evTableLayoutPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label plusLabel;
        private System.Windows.Forms.Label dLabel;
        private System.Windows.Forms.Label evLabel;
        private System.Windows.Forms.Label evValueLabel;
        private System.Windows.Forms.NumericUpDown evNumDiceUpDown;
        private System.Windows.Forms.NumericUpDown evModifierUpDown;
        private System.Windows.Forms.NumericUpDown evNumSidesUpDown;
    }
}

