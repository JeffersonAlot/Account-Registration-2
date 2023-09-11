using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Account_Registration
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentInfoClass.StudentNo = Int32.Parse(StudentNoT.Text);
            StudentInfoClass.Age = Int32.Parse(AgeT.Text);
            StudentInfoClass.ContactNo = Int32.Parse(ContactT.Text);
            StudentInfoClass.Program = ProgramB.Text.ToString();
            StudentInfoClass.LastName = LastNameT.Text.ToString();
            StudentInfoClass.FirstName = FirstNameT.Text.ToString();
            StudentInfoClass.MiddleName = MiddleNameT.Text.ToString();
            StudentInfoClass.Address = AddressT.Text.ToString();
        }
    }
}
