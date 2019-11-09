namespace lab5
{
    partial class Question3_Form
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
            this.q3Question_label = new System.Windows.Forms.Label();
            this.neverOption_radioButton = new System.Windows.Forms.RadioButton();
            this.q3Options_groupBox = new System.Windows.Forms.GroupBox();
            this.NAOption_radioButton = new System.Windows.Forms.RadioButton();
            this.AlwaysOption_radioButton = new System.Windows.Forms.RadioButton();
            this.MOTTOption_radioButton = new System.Windows.Forms.RadioButton();
            this.SOFTTOption_radioButton = new System.Windows.Forms.RadioButton();
            this.q3_progressBar = new System.Windows.Forms.ProgressBar();
            this.q3ProgressLabel = new System.Windows.Forms.Label();
            this.q3Next_button = new System.Windows.Forms.Button();
            this.q3Options_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // q3Question_label
            // 
            this.q3Question_label.AutoSize = true;
            this.q3Question_label.Location = new System.Drawing.Point(3, 9);
            this.q3Question_label.Name = "q3Question_label";
            this.q3Question_label.Size = new System.Drawing.Size(296, 13);
            this.q3Question_label.TabIndex = 0;
            this.q3Question_label.Text = "Professor demonstrates a thorough knowledge of the subject:";
            // 
            // neverOption_radioButton
            // 
            this.neverOption_radioButton.AutoSize = true;
            this.neverOption_radioButton.Location = new System.Drawing.Point(17, 19);
            this.neverOption_radioButton.Name = "neverOption_radioButton";
            this.neverOption_radioButton.Size = new System.Drawing.Size(54, 17);
            this.neverOption_radioButton.TabIndex = 1;
            this.neverOption_radioButton.TabStop = true;
            this.neverOption_radioButton.Text = "Never";
            this.neverOption_radioButton.UseVisualStyleBackColor = true;
            // 
            // q3Options_groupBox
            // 
            this.q3Options_groupBox.Controls.Add(this.NAOption_radioButton);
            this.q3Options_groupBox.Controls.Add(this.AlwaysOption_radioButton);
            this.q3Options_groupBox.Controls.Add(this.MOTTOption_radioButton);
            this.q3Options_groupBox.Controls.Add(this.SOFTTOption_radioButton);
            this.q3Options_groupBox.Controls.Add(this.neverOption_radioButton);
            this.q3Options_groupBox.Location = new System.Drawing.Point(15, 45);
            this.q3Options_groupBox.Name = "q3Options_groupBox";
            this.q3Options_groupBox.Size = new System.Drawing.Size(152, 140);
            this.q3Options_groupBox.TabIndex = 2;
            this.q3Options_groupBox.TabStop = false;
            this.q3Options_groupBox.Text = "Choose from the following:";
            // 
            // NAOption_radioButton
            // 
            this.NAOption_radioButton.AutoSize = true;
            this.NAOption_radioButton.Location = new System.Drawing.Point(17, 112);
            this.NAOption_radioButton.Name = "NAOption_radioButton";
            this.NAOption_radioButton.Size = new System.Drawing.Size(94, 17);
            this.NAOption_radioButton.TabIndex = 5;
            this.NAOption_radioButton.TabStop = true;
            this.NAOption_radioButton.Text = "Not Applicable";
            this.NAOption_radioButton.UseVisualStyleBackColor = true;
            // 
            // AlwaysOption_radioButton
            // 
            this.AlwaysOption_radioButton.AutoSize = true;
            this.AlwaysOption_radioButton.Location = new System.Drawing.Point(17, 89);
            this.AlwaysOption_radioButton.Name = "AlwaysOption_radioButton";
            this.AlwaysOption_radioButton.Size = new System.Drawing.Size(58, 17);
            this.AlwaysOption_radioButton.TabIndex = 4;
            this.AlwaysOption_radioButton.TabStop = true;
            this.AlwaysOption_radioButton.Text = "Always";
            this.AlwaysOption_radioButton.UseVisualStyleBackColor = true;
            // 
            // MOTTOption_radioButton
            // 
            this.MOTTOption_radioButton.AutoSize = true;
            this.MOTTOption_radioButton.Location = new System.Drawing.Point(17, 66);
            this.MOTTOption_radioButton.Name = "MOTTOption_radioButton";
            this.MOTTOption_radioButton.Size = new System.Drawing.Size(104, 17);
            this.MOTTOption_radioButton.TabIndex = 3;
            this.MOTTOption_radioButton.TabStop = true;
            this.MOTTOption_radioButton.Text = "Most of the Time";
            this.MOTTOption_radioButton.UseVisualStyleBackColor = true;
            // 
            // SOFTTOption_radioButton
            // 
            this.SOFTTOption_radioButton.AutoSize = true;
            this.SOFTTOption_radioButton.Location = new System.Drawing.Point(17, 43);
            this.SOFTTOption_radioButton.Name = "SOFTTOption_radioButton";
            this.SOFTTOption_radioButton.Size = new System.Drawing.Size(108, 17);
            this.SOFTTOption_radioButton.TabIndex = 2;
            this.SOFTTOption_radioButton.TabStop = true;
            this.SOFTTOption_radioButton.Text = "Some of the Time";
            this.SOFTTOption_radioButton.UseVisualStyleBackColor = true;
            // 
            // q3_progressBar
            // 
            this.q3_progressBar.Cursor = System.Windows.Forms.Cursors.No;
            this.q3_progressBar.Location = new System.Drawing.Point(173, 64);
            this.q3_progressBar.Name = "q3_progressBar";
            this.q3_progressBar.Size = new System.Drawing.Size(89, 17);
            this.q3_progressBar.Step = 33;
            this.q3_progressBar.TabIndex = 3;
            this.q3_progressBar.Value = 100;
            // 
            // q3ProgressLabel
            // 
            this.q3ProgressLabel.AutoSize = true;
            this.q3ProgressLabel.Location = new System.Drawing.Point(173, 45);
            this.q3ProgressLabel.Name = "q3ProgressLabel";
            this.q3ProgressLabel.Size = new System.Drawing.Size(79, 13);
            this.q3ProgressLabel.TabIndex = 4;
            this.q3ProgressLabel.Text = "Question 3 of 3";
            // 
            // q3Next_button
            // 
            this.q3Next_button.Location = new System.Drawing.Point(187, 151);
            this.q3Next_button.Name = "q3Next_button";
            this.q3Next_button.Size = new System.Drawing.Size(75, 23);
            this.q3Next_button.TabIndex = 5;
            this.q3Next_button.Text = "Next";
            this.q3Next_button.UseVisualStyleBackColor = true;
            this.q3Next_button.Click += new System.EventHandler(this.q3Next_button_Click);
            // 
            // Question3_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 192);
            this.Controls.Add(this.q3Next_button);
            this.Controls.Add(this.q3ProgressLabel);
            this.Controls.Add(this.q3_progressBar);
            this.Controls.Add(this.q3Options_groupBox);
            this.Controls.Add(this.q3Question_label);
            this.Name = "Question3_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Question3";
            this.q3Options_groupBox.ResumeLayout(false);
            this.q3Options_groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label q3Question_label;
        private System.Windows.Forms.ProgressBar q3_progressBar;
        private System.Windows.Forms.Label q3ProgressLabel;
        private System.Windows.Forms.Button q3Next_button;
        private System.Windows.Forms.RadioButton neverOption_radioButton;
        private System.Windows.Forms.RadioButton NAOption_radioButton;
        private System.Windows.Forms.RadioButton AlwaysOption_radioButton;
        private System.Windows.Forms.RadioButton MOTTOption_radioButton;
        private System.Windows.Forms.RadioButton SOFTTOption_radioButton;
        private System.Windows.Forms.GroupBox q3Options_groupBox;
    }
}