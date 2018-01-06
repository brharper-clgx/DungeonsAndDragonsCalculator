namespace DndCalculator.UI.Forms
{
    partial class DifficultyClassForm
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
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.optionsFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.advantageCheckbox = new System.Windows.Forms.CheckBox();
            this.disadvantageCheckbox = new System.Windows.Forms.CheckBox();
            this.modifierLabel = new System.Windows.Forms.Label();
            this.modifierUpDown = new System.Windows.Forms.NumericUpDown();
            this.successPercentageLabel = new System.Windows.Forms.Label();
            this.successPercentageTrackbar = new System.Windows.Forms.TrackBar();
            this.difficultyLabel = new System.Windows.Forms.Label();
            this.difficultyClassValueLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel.SuspendLayout();
            this.optionsFlowLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modifierUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.successPercentageTrackbar)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 3;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.Controls.Add(this.optionsFlowLayout, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.successPercentageLabel, 2, 0);
            this.tableLayoutPanel.Controls.Add(this.successPercentageTrackbar, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.difficultyLabel, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.difficultyClassValueLabel, 0, 1);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 3;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(233, 275);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // optionsFlowLayout
            // 
            this.tableLayoutPanel.SetColumnSpan(this.optionsFlowLayout, 3);
            this.optionsFlowLayout.Controls.Add(this.advantageCheckbox);
            this.optionsFlowLayout.Controls.Add(this.disadvantageCheckbox);
            this.optionsFlowLayout.Controls.Add(this.modifierLabel);
            this.optionsFlowLayout.Controls.Add(this.modifierUpDown);
            this.optionsFlowLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.optionsFlowLayout.Location = new System.Drawing.Point(3, 249);
            this.optionsFlowLayout.Name = "optionsFlowLayout";
            this.optionsFlowLayout.Size = new System.Drawing.Size(227, 23);
            this.optionsFlowLayout.TabIndex = 5;
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
            // successPercentageLabel
            // 
            this.successPercentageLabel.AutoSize = true;
            this.successPercentageLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.successPercentageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.successPercentageLabel.Location = new System.Drawing.Point(177, 0);
            this.successPercentageLabel.Name = "successPercentageLabel";
            this.tableLayoutPanel.SetRowSpan(this.successPercentageLabel, 2);
            this.successPercentageLabel.Size = new System.Drawing.Size(30, 246);
            this.successPercentageLabel.TabIndex = 3;
            this.successPercentageLabel.Text = "50";
            this.successPercentageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // successPercentageTrackbar
            // 
            this.successPercentageTrackbar.Dock = System.Windows.Forms.DockStyle.Right;
            this.successPercentageTrackbar.LargeChange = 1;
            this.successPercentageTrackbar.Location = new System.Drawing.Point(126, 3);
            this.successPercentageTrackbar.Maximum = 20;
            this.successPercentageTrackbar.Name = "successPercentageTrackbar";
            this.successPercentageTrackbar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tableLayoutPanel.SetRowSpan(this.successPercentageTrackbar, 2);
            this.successPercentageTrackbar.Size = new System.Drawing.Size(45, 240);
            this.successPercentageTrackbar.TabIndex = 2;
            this.successPercentageTrackbar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.successPercentageTrackbar.Value = 10;
            this.successPercentageTrackbar.Scroll += new System.EventHandler(this.successPercentageTrackbar_Scroll);
            // 
            // difficultyLabel
            // 
            this.difficultyLabel.AutoSize = true;
            this.difficultyLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.difficultyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.difficultyLabel.Location = new System.Drawing.Point(3, 0);
            this.difficultyLabel.Name = "difficultyLabel";
            this.difficultyLabel.Size = new System.Drawing.Size(110, 123);
            this.difficultyLabel.TabIndex = 0;
            this.difficultyLabel.Text = "DC:";
            this.difficultyLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // difficultyClassValueLabel
            // 
            this.difficultyClassValueLabel.AutoSize = true;
            this.difficultyClassValueLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.difficultyClassValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.difficultyClassValueLabel.Location = new System.Drawing.Point(3, 123);
            this.difficultyClassValueLabel.Name = "difficultyClassValueLabel";
            this.difficultyClassValueLabel.Size = new System.Drawing.Size(110, 123);
            this.difficultyClassValueLabel.TabIndex = 1;
            this.difficultyClassValueLabel.Text = "11";
            this.difficultyClassValueLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DifficultyClassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 275);
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "DifficultyClassForm";
            this.Text = "DifficultyClassForm";
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.optionsFlowLayout.ResumeLayout(false);
            this.optionsFlowLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modifierUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.successPercentageTrackbar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Label difficultyLabel;
        private System.Windows.Forms.Label difficultyClassValueLabel;
        private System.Windows.Forms.TrackBar successPercentageTrackbar;
        private System.Windows.Forms.Label successPercentageLabel;
        private System.Windows.Forms.FlowLayoutPanel optionsFlowLayout;
        private System.Windows.Forms.CheckBox advantageCheckbox;
        private System.Windows.Forms.CheckBox disadvantageCheckbox;
        private System.Windows.Forms.Label modifierLabel;
        private System.Windows.Forms.NumericUpDown modifierUpDown;
    }
}