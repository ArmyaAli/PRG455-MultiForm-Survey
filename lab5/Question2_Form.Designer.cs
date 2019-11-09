namespace lab5
{
    partial class Question2_Form
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
            this.q2Question_label = new System.Windows.Forms.Label();
            this.poorOption_radioButton = new System.Windows.Forms.RadioButton();
            this.q2Options_groupBox = new System.Windows.Forms.GroupBox();
            this.noOption_radioButton = new System.Windows.Forms.RadioButton();
            this.excOption_radioButton = new System.Windows.Forms.RadioButton();
            this.vGoodOption_radioButton = new System.Windows.Forms.RadioButton();
            this.goodOption_radioButton = new System.Windows.Forms.RadioButton();
            this.fairOption_radioButton = new System.Windows.Forms.RadioButton();
            this.q2_progressBar = new System.Windows.Forms.ProgressBar();
            this.q2Progress_label = new System.Windows.Forms.Label();
            this.q2Next_button = new System.Windows.Forms.Button();
            this.q2Options_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // q2Question_label
            // 
            this.q2Question_label.AutoSize = true;
            this.q2Question_label.Location = new System.Drawing.Point(12, 22);
            this.q2Question_label.Name = "q2Question_label";
            this.q2Question_label.Size = new System.Drawing.Size(253, 13);
            this.q2Question_label.TabIndex = 0;
            this.q2Question_label.Text = "Overall, I would rate this professor’s performance as:";
            // 
            // poorOption_radioButton
            // 
            this.poorOption_radioButton.AutoSize = true;
            this.poorOption_radioButton.Location = new System.Drawing.Point(17, 19);
            this.poorOption_radioButton.Name = "poorOption_radioButton";
            this.poorOption_radioButton.Size = new System.Drawing.Size(47, 17);
            this.poorOption_radioButton.TabIndex = 1;
            this.poorOption_radioButton.TabStop = true;
            this.poorOption_radioButton.Text = "Poor";
            this.poorOption_radioButton.UseVisualStyleBackColor = true;
            // 
            // q2Options_groupBox
            // 
            this.q2Options_groupBox.Controls.Add(this.noOption_radioButton);
            this.q2Options_groupBox.Controls.Add(this.excOption_radioButton);
            this.q2Options_groupBox.Controls.Add(this.vGoodOption_radioButton);
            this.q2Options_groupBox.Controls.Add(this.goodOption_radioButton);
            this.q2Options_groupBox.Controls.Add(this.fairOption_radioButton);
            this.q2Options_groupBox.Controls.Add(this.poorOption_radioButton);
            this.q2Options_groupBox.Location = new System.Drawing.Point(15, 45);
            this.q2Options_groupBox.Name = "q2Options_groupBox";
            this.q2Options_groupBox.Size = new System.Drawing.Size(152, 164);
            this.q2Options_groupBox.TabIndex = 2;
            this.q2Options_groupBox.TabStop = false;
            this.q2Options_groupBox.Text = "Choose from the following:";
            // 
            // noOption_radioButton
            // 
            this.noOption_radioButton.AutoSize = true;
            this.noOption_radioButton.Location = new System.Drawing.Point(17, 135);
            this.noOption_radioButton.Name = "noOption_radioButton";
            this.noOption_radioButton.Size = new System.Drawing.Size(78, 17);
            this.noOption_radioButton.TabIndex = 6;
            this.noOption_radioButton.TabStop = true;
            this.noOption_radioButton.Text = "No Opinion";
            this.noOption_radioButton.UseVisualStyleBackColor = true;
            // 
            // excOption_radioButton
            // 
            this.excOption_radioButton.AutoSize = true;
            this.excOption_radioButton.Location = new System.Drawing.Point(17, 112);
            this.excOption_radioButton.Name = "excOption_radioButton";
            this.excOption_radioButton.Size = new System.Drawing.Size(68, 17);
            this.excOption_radioButton.TabIndex = 5;
            this.excOption_radioButton.TabStop = true;
            this.excOption_radioButton.Text = "Excellent";
            this.excOption_radioButton.UseVisualStyleBackColor = true;
            // 
            // vGoodOption_radioButton
            // 
            this.vGoodOption_radioButton.AutoSize = true;
            this.vGoodOption_radioButton.Location = new System.Drawing.Point(17, 89);
            this.vGoodOption_radioButton.Name = "vGoodOption_radioButton";
            this.vGoodOption_radioButton.Size = new System.Drawing.Size(75, 17);
            this.vGoodOption_radioButton.TabIndex = 4;
            this.vGoodOption_radioButton.TabStop = true;
            this.vGoodOption_radioButton.Text = "Very Good";
            this.vGoodOption_radioButton.UseVisualStyleBackColor = true;
            // 
            // goodOption_radioButton
            // 
            this.goodOption_radioButton.AutoSize = true;
            this.goodOption_radioButton.Location = new System.Drawing.Point(17, 66);
            this.goodOption_radioButton.Name = "goodOption_radioButton";
            this.goodOption_radioButton.Size = new System.Drawing.Size(51, 17);
            this.goodOption_radioButton.TabIndex = 3;
            this.goodOption_radioButton.TabStop = true;
            this.goodOption_radioButton.Text = "Good";
            this.goodOption_radioButton.UseVisualStyleBackColor = true;
            // 
            // fairOption_radioButton
            // 
            this.fairOption_radioButton.AutoSize = true;
            this.fairOption_radioButton.Location = new System.Drawing.Point(17, 43);
            this.fairOption_radioButton.Name = "fairOption_radioButton";
            this.fairOption_radioButton.Size = new System.Drawing.Size(42, 17);
            this.fairOption_radioButton.TabIndex = 2;
            this.fairOption_radioButton.TabStop = true;
            this.fairOption_radioButton.Text = "Fair";
            this.fairOption_radioButton.UseVisualStyleBackColor = true;
            // 
            // q2_progressBar
            // 
            this.q2_progressBar.Cursor = System.Windows.Forms.Cursors.No;
            this.q2_progressBar.ForeColor = System.Drawing.Color.LimeGreen;
            this.q2_progressBar.Location = new System.Drawing.Point(173, 64);
            this.q2_progressBar.Name = "q2_progressBar";
            this.q2_progressBar.Size = new System.Drawing.Size(89, 17);
            this.q2_progressBar.Step = 33;
            this.q2_progressBar.TabIndex = 3;
            this.q2_progressBar.Value = 66;
            // 
            // q2Progress_label
            // 
            this.q2Progress_label.AutoSize = true;
            this.q2Progress_label.Location = new System.Drawing.Point(173, 45);
            this.q2Progress_label.Name = "q2Progress_label";
            this.q2Progress_label.Size = new System.Drawing.Size(79, 13);
            this.q2Progress_label.TabIndex = 4;
            this.q2Progress_label.Text = "Question 2 of 3";
            // 
            // q2Next_button
            // 
            this.q2Next_button.Location = new System.Drawing.Point(187, 186);
            this.q2Next_button.Name = "q2Next_button";
            this.q2Next_button.Size = new System.Drawing.Size(75, 23);
            this.q2Next_button.TabIndex = 6;
            this.q2Next_button.Text = "Next";
            this.q2Next_button.UseVisualStyleBackColor = true;
            this.q2Next_button.Click += new System.EventHandler(this.q2Next_button_Click);
            // 
            // Question2_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 224);
            this.Controls.Add(this.q2Next_button);
            this.Controls.Add(this.q2Progress_label);
            this.Controls.Add(this.q2_progressBar);
            this.Controls.Add(this.q2Options_groupBox);
            this.Controls.Add(this.q2Question_label);
            this.Name = "Question2_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Question2";
            this.q2Options_groupBox.ResumeLayout(false);
            this.q2Options_groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label q2Question_label;
        private System.Windows.Forms.ProgressBar q2_progressBar;
        private System.Windows.Forms.Label q2Progress_label;
        private System.Windows.Forms.Button q2Next_button;
        private System.Windows.Forms.RadioButton poorOption_radioButton;
        private System.Windows.Forms.RadioButton noOption_radioButton;
        private System.Windows.Forms.RadioButton excOption_radioButton;
        private System.Windows.Forms.RadioButton vGoodOption_radioButton;
        private System.Windows.Forms.RadioButton goodOption_radioButton;
        private System.Windows.Forms.RadioButton fairOption_radioButton;
        private System.Windows.Forms.GroupBox q2Options_groupBox;
    }
}