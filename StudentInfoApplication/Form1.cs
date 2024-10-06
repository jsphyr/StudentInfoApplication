namespace StudentInfoApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public class studentData
        {
            private string sNum;
            private string lName;
            private string fName;

            public studentData()
            {
                studentNum = "";
                lastName = "";
                firstName = "";
            }
            public studentData(string sNum, string lName, string fName)
            {
                this.sNum = sNum;
                this.lName = lName;
                this.fName = fName;
            }
            public string studentNum
            {
                get { return sNum; }
                set { sNum = value; }
            }

            public string lastName
            {
                get { return lName; }
                set { lName = value; }
            }

            public string firstName
            {
                get { return fName; }
                set { fName = value; }
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            string sNumText = txtStudentNum.Text;
            int sNum;

            if (!int.TryParse(sNumText, out sNum))
            {
                MessageBox.Show("Please enter a valid number");
                return;
            }

            string lName = txtLastName.Text.Trim();
            string fName = txtFirstName.Text.Trim();

            if (string.IsNullOrEmpty(lName) || !isStringValid(lName))
            {
                MessageBox.Show("Please enter a valid last name");
                return;
            }
            if (string.IsNullOrEmpty(fName) || !isStringValid(fName))
            {
                MessageBox.Show("Please enter a valid first name");
                return;
            }


            studentData data = new studentData(sNum.ToString(), lName, fName);

            listStudentNum.Items.Add(data.studentNum);
            listLastName.Items.Add(data.lastName);
            listFirstName.Items.Add(data.firstName);

            txtStudentNum.Clear();
            txtLastName.Clear();
            txtFirstName.Clear();
        }

        private bool isStringValid(string str)
        {
            foreach (char c in str)
            {
                if (!char.IsLetter(c))
                {
                    return false;
                }
            }
            return true;
        }

    }
}