namespace DndCalculator.UI
{
    partial class DifficultyClassUI
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
            this.tabControl.SuspendLayout();
            this.difficultyClassTab.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.successPercentageTrackbar)).BeginInit();
            this.optionsFlowLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modifierUpDown)).BeginInit();
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
            this.expectedValueTab.Location = new System.Drawing.Point(4, 22);
            this.expectedValueTab.Name = "expectedValueTab";
            this.expectedValueTab.Padding = new System.Windows.Forms.Padding(3);
            this.expectedValueTab.Size = new System.Drawing.Size(273, 249);
            this.expectedValueTab.TabIndex = 1;
            this.expectedValueTab.Text = "EV Calc";
            this.expectedValueTab.UseVisualStyleBackColor = true;
            // 
            // DifficultyClassUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 275);
            this.Controls.Add(this.tabControl);
            this.Name = "DifficultyClassUI";
            this.Text = "DC Calculator";
            this.tabControl.ResumeLayout(false);
            this.difficultyClassTab.ResumeLayout(false);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.successPercentageTrackbar)).EndInit();
            this.optionsFlowLayout.ResumeLayout(false);
            this.optionsFlowLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modifierUpDown)).EndInit();
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
    }
}

