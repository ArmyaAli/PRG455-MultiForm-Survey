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
    public partial class Question1_Form : Form
    {
        private mainForm referenceMain;
        private static string q1Choice;
        public Question1_Form(mainForm form)
        {
            InitializeComponent();
            referenceMain = form;
        }

        public string Q1_Answer
        {
            get { return q1Choice; }
        }
        private void q1Next_button_Click(object sender, EventArgs e)
        {
            foreach (RadioButton option in q1Options_groupBox.Controls.OfType<RadioButton>()) // iterate through the radio buttons in the group box
            {
                if(option.Checked)
                    q1Choice = option.Text;
            }
            // close current form
            this.Close();
            // create question 2 form and show it
            Question2_Form q2_form = new Question2_Form(referenceMain);
            q2_form.Show();
            
        }
    }
}
