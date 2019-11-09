namespace lab5
{
    partial class mainForm
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
            this.courseCode_textBox = new System.Windows.Forms.TextBox();
            this.currSemester_textBox = new System.Windows.Forms.TextBox();
            this.profName_textBox = new System.Windows.Forms.TextBox();
            this.courseCode_label = new System.Windows.Forms.Label();
            this.currSemester_label = new System.Windows.Forms.Label();
            this.profName_label = new System.Windows.Forms.Label();
            this.startSurvey_Button = new System.Windows.Forms.Button();
            this.exit_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // courseCode_textBox
            // 
            this.courseCode_textBox.Location = new System.Drawing.Point(115, 32);
            this.courseCode_textBox.Name = "courseCode_textBox";
            this.courseCode_textBox.Size = new System.Drawing.Size(100, 20);
            this.courseCode_textBox.TabIndex = 0;
            // 
            // currSemester_textBox
            // 
            this.currSemester_textBox.Location = new System.Drawing.Point(115, 72);
            this.currSemester_textBox.Name = "currSemester_textBox";
            this.currSemester_textBox.Size = new System.Drawing.Size(100, 20);
            this.currSemester_textBox.TabIndex = 1;
            // 
            // profName_textBox
            // 
            this.profName_textBox.Location = new System.Drawing.Point(115, 110);
            this.profName_textBox.Name = "profName_textBox";
            this.profName_textBox.Size = new System.Drawing.Size(100, 20);
            this.profName_textBox.TabIndex = 2;
            // 
            // courseCode_label
            // 
            this.courseCode_label.AutoSize = true;
            this.courseCode_label.Location = new System.Drawing.Point(21, 35);
            this.courseCode_label.Name = "courseCode_label";
            this.courseCode_label.Size = new System.Drawing.Size(68, 13);
            this.courseCode_label.TabIndex = 3;
            this.courseCode_label.Text = "Course Code";
            // 
            // currSemester_label
            // 
            this.currSemester_label.AutoSize = true;
            this.currSemester_label.Location = new System.Drawing.Point(21, 75);
            this.currSemester_label.Name = "currSemester_label";
            this.currSemester_label.Size = new System.Drawing.Size(88, 13);
            this.currSemester_label.TabIndex = 4;
            this.currSemester_label.Text = "Current Semester";
            // 
            // profName_label
            // 
            this.profName_label.AutoSize = true;
            this.profName_label.Location = new System.Drawing.Point(21, 113);
            this.profName_label.Name = "profName_label";
            this.profName_label.Size = new System.Drawing.Size(89, 13);
            this.profName_label.TabIndex = 5;
            this.profName_label.Text = "Professor\'s Name";
            // 
            // startSurvey_Button
            // 
            this.startSurvey_Button.Location = new System.Drawing.Point(73, 152);
            this.startSurvey_Button.Name = "startSurvey_Button";
            this.startSurvey_Button.Size = new System.Drawing.Size(75, 23);
            this.startSurvey_Button.TabIndex = 6;
            this.startSurvey_Button.Text = "Start Survey";
            this.startSurvey_Button.UseVisualStyleBackColor = true;
            this.startSurvey_Button.Click += new System.EventHandler(this.startSurvey_Button_Click);
            // 
            // exit_Button
            // 
            this.exit_Button.Location = new System.Drawing.Point(73, 191);
            this.exit_Button.Name = "exit_Button";
            this.exit_Button.Size = new System.Drawing.Size(75, 23);
            this.exit_Button.TabIndex = 7;
            this.exit_Button.Text = "Exit";
            this.exit_Button.UseVisualStyleBackColor = true;
            this.exit_Button.Click += new System.EventHandler(this.exit_Button_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 232);
            this.Controls.Add(this.exit_Button);
            this.Controls.Add(this.startSurvey_Button);
            this.Controls.Add(this.profName_label);
            this.Controls.Add(this.currSemester_label);
            this.Controls.Add(this.courseCode_label);
            this.Controls.Add(this.profName_textBox);
            this.Controls.Add(this.currSemester_textBox);
            this.Controls.Add(this.courseCode_textBox);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Survey";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label courseCode_label;
        private System.Windows.Forms.Label currSemester_label;
        private System.Windows.Forms.Label profName_label;
        private System.Windows.Forms.Button startSurvey_Button;
        private System.Windows.Forms.Button exit_Button;
        public System.Windows.Forms.TextBox courseCode_textBox;
        public System.Windows.Forms.TextBox currSemester_textBox;
        public System.Windows.Forms.TextBox profName_textBox;
    }
}

