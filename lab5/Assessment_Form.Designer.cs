namespace lab5
{
    partial class Assessment_Form
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
            this.yesChoice_button = new System.Windows.Forms.Button();
            this.noChoice_button = new System.Windows.Forms.Button();
            this.exitChoice_label = new System.Windows.Forms.Label();
            this.answers_label = new System.Windows.Forms.Label();
            this.display_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // yesChoice_button
            // 
            this.yesChoice_button.Location = new System.Drawing.Point(91, 284);
            this.yesChoice_button.Name = "yesChoice_button";
            this.yesChoice_button.Size = new System.Drawing.Size(75, 23);
            this.yesChoice_button.TabIndex = 0;
            this.yesChoice_button.Text = "Yes";
            this.yesChoice_button.UseVisualStyleBackColor = true;
            this.yesChoice_button.Click += new System.EventHandler(this.yesChoice_button_Click);
            // 
            // noChoice_button
            // 
            this.noChoice_button.Location = new System.Drawing.Point(205, 284);
            this.noChoice_button.Name = "noChoice_button";
            this.noChoice_button.Size = new System.Drawing.Size(75, 23);
            this.noChoice_button.TabIndex = 1;
            this.noChoice_button.Text = "No";
            this.noChoice_button.UseVisualStyleBackColor = true;
            // 
            // exitChoice_label
            // 
            this.exitChoice_label.AutoSize = true;
            this.exitChoice_label.Location = new System.Drawing.Point(115, 256);
            this.exitChoice_label.Name = "exitChoice_label";
            this.exitChoice_label.Size = new System.Drawing.Size(165, 13);
            this.exitChoice_label.TabIndex = 2;
            this.exitChoice_label.Text = "Would you like to close this form?";
            // 
            // answers_label
            // 
            this.answers_label.AutoSize = true;
            this.answers_label.Location = new System.Drawing.Point(29, 32);
            this.answers_label.Name = "answers_label";
            this.answers_label.Size = new System.Drawing.Size(74, 13);
            this.answers_label.TabIndex = 3;
            this.answers_label.Text = "Your answers:";
            // 
            // display_textBox
            // 
            this.display_textBox.Location = new System.Drawing.Point(0, 58);
            this.display_textBox.Multiline = true;
            this.display_textBox.Name = "display_textBox";
            this.display_textBox.ReadOnly = true;
            this.display_textBox.Size = new System.Drawing.Size(391, 182);
            this.display_textBox.TabIndex = 4;
            // 
            // Assessment_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 320);
            this.Controls.Add(this.display_textBox);
            this.Controls.Add(this.answers_label);
            this.Controls.Add(this.exitChoice_label);
            this.Controls.Add(this.noChoice_button);
            this.Controls.Add(this.yesChoice_button);
            this.Name = "Assessment_Form";
            this.Text = "Assessment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button yesChoice_button;
        private System.Windows.Forms.Button noChoice_button;
        private System.Windows.Forms.Label exitChoice_label;
        private System.Windows.Forms.Label answers_label;
        private System.Windows.Forms.TextBox display_textBox;
    }
}