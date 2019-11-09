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
    public partial class Question2_Form : Form
    {
        private mainForm referenceMain;
        private static string q2Choice;
        public string Q2_Answer
        {
            get { return q2Choice; }
        }
        public Question2_Form(mainForm form)
        {
            InitializeComponent();
            referenceMain = form;
        }
        private void q2Next_button_Click(object sender, EventArgs e)
        {
            foreach (RadioButton option in q2Options_groupBox.Controls.OfType<RadioButton>()) // iterate through the radio buttons in the group box
            {
                if (option.Checked)
                    q2Choice = option.Text;
            }
            // close current form
            this.Close();
            // close current form and go to question 3 form
            Question3_Form q3_form = new Question3_Form(referenceMain);
            q3_form.Show();
            
        }
    }
}
