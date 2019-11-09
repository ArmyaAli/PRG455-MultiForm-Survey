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
    public partial class Question3_Form : Form
    {
        private mainForm referenceMain;
        private static string q3Choice;
        public string Q3_Answer
        {
            get { return q3Choice; }
        }

        public Question3_Form(mainForm form)
        {
            InitializeComponent();
            referenceMain = form;
        }

        private void q3Next_button_Click(object sender, EventArgs e)
        {
            foreach (RadioButton option in q3Options_groupBox.Controls.OfType<RadioButton>()) // iterate through the radio buttons in the group box
            {
                if (option.Checked)
                    q3Choice = option.Text;
            }
            // close current form
            this.Close();

            Assessment_Form asses_Form = new Assessment_Form(referenceMain);
            asses_Form.Show();
        }
    }
}
