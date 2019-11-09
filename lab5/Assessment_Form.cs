using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab5
{
    
    public partial class Assessment_Form : Form
    {
        private const string fileName = "records.txt";
        private string courseCode;
        private string currentSemester;
        private string profName;
        private string q1_answer;
        private string q2_answer;
        private string q3_answer;
        private mainForm referenceMain;
        public Assessment_Form(mainForm form)
        {
            InitializeComponent();
            referenceMain = form;
            getCurrentInfo();
            displayInfo();
        }
        // This function write the users answers into a textFile
        private void serializeSurveyInstance()
        {
            FileStream stream = new FileStream(fileName, FileMode.Append);
            StreamWriter writer = new StreamWriter(stream);
            
            writer.WriteLine("Course Code: " + courseCode);
            writer.WriteLine("Semester: " + currentSemester);
            writer.WriteLine("Professor: " + profName);
            writer.WriteLine("Answers: ");
            writer.WriteLine("Overall, I would rate the quality of this course as: " + q1_answer);
            writer.WriteLine("Overall, I would rate this professor’s performance as: " + q2_answer);
            writer.WriteLine("Professor demonstrates a thorough knowledge of the subject: " + q3_answer);

            writer.Close();
        }

        private void getCurrentInfo()
        {
            mainForm main = new mainForm();
            Question1_Form q1Form = new Question1_Form(referenceMain);
            Question2_Form q2Form = new Question2_Form(referenceMain);
            Question3_Form q3Form = new Question3_Form(referenceMain);

            courseCode = main.courseCode;
            currentSemester = main.currentSemester.ToString();
            profName = main.profName;
            q1_answer = q1Form.Q1_Answer;
            q2_answer = q2Form.Q2_Answer;
            q3_answer = q3Form.Q3_Answer;
        }

        private void displayInfo()
        {
            display_textBox.AppendText("Course Code: " + courseCode + Environment.NewLine);
            display_textBox.AppendText("\nSemester: " + currentSemester + Environment.NewLine);
            display_textBox.AppendText("Professor: " + profName + Environment.NewLine);
            display_textBox.AppendText("Answers: " + Environment.NewLine);
            display_textBox.AppendText("Overall, I would rate the quality of this course as: " + q1_answer + Environment.NewLine);
            display_textBox.AppendText("Overall, I would rate this professor’s performance as: " + q2_answer + Environment.NewLine);
            display_textBox.AppendText("Professor demonstrates a thorough knowledge of the subject: " + q3_answer + Environment.NewLine);

        }


        private void yesChoice_button_Click(object sender, EventArgs e)
        {
            // save to file
            serializeSurveyInstance();
            // clear the main form
            referenceMain.mainForm_clear();
            // close the form
            this.Close();
        }
    }

}
