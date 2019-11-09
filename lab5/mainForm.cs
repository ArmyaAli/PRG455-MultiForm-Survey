using System;
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

    public partial class mainForm : Form // interface for getting info
    {
        private static string courseCodeText;
        private static int currSemText_number;
        private static string profNameText;
        private static bool clearFlag = false;
        private static mainForm refToMyself;
        public mainForm()
        {
            InitializeComponent();
        }

        public mainForm refMyself
        {
            get { return this; }
        }

      

        public string courseCode
        {
            get { return courseCodeText; }
        }

        public int currentSemester
        {
            get { return currSemText_number; }
        }

        public string profName
        {
            get { return profNameText; }
        }
        private void startSurvey_Button_Click(object sender, EventArgs e)
        {
            int currSemester;
            // check to see if all fields are filled
            bool allFilled = (courseCode_textBox.Text.Length > 0) && 
                (currSemester_textBox.Text.Length > 0) && 
                (profName_textBox.Text.Length > 0);

            bool validCurrSem = Int32.TryParse(currSemester_textBox.Text, out currSemester);

            // first check if all boxes are filled out and then check if the current semester is a valid number
            if(allFilled)
            {
                if(validCurrSem)
                {
                    Question1_Form q1_form = new Question1_Form(this); 

                    courseCodeText = courseCode_textBox.Text;
                    currSemText_number = currSemester;
                    profNameText = profName_textBox.Text;

                    q1_form.Show();
                }
                else
                {
                    MessageBox.Show("That is not a valid semester");
                }
               
            }
            else
            {
                MessageBox.Show("Please fill out all fields");
            }
            
        }
        private void exit_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void mainForm_clear()
        {
            this.courseCode_textBox.Clear();
            this.profName_textBox.Clear();
            this.currSemester_textBox.Clear();
        }
    }
}
