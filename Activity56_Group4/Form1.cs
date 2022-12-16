namespace Activity56_Group4
{
    public partial class Form1 : Form
    {
        //This Operator variable will be used to determine what operation will be used depending on what button is being clicked
        //Alternately, we can use the lblOperator.Text for this purpose but we believe the code will be more understandable this way.
        string Operator;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
       
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Operator = "+";
            lblOperator.Text = "+";
        }
     
        private void btnSubtract_Click(object sender, EventArgs e)
        {
            Operator = "-";
            lblOperator.Text = "-";
        }
     
        private void btnMultiply_Click(object sender, EventArgs e)
        {
            Operator = "*";
            lblOperator.Text = "*";
        }
      
        private void btnDivide_Click(object sender, EventArgs e)
        {
            Operator = "/";
            lblOperator.Text = "/";
        }
        //The equals button is the real deal, a number of things will happen when this button is clicked.
        private void btnEquals_Click(object sender, EventArgs e)
        {
            //The label "Enter a number:" on the above textbox in the form will change to "Result:"
            //The lbl.Operator will then become empty
            //The new variables result, Firstnum and SecondNum will be used to contain the int version of the textboxes.
            lblResult.Text = "Result:";
            lblOperator.Text = "";
            double result = 0;
            double FirstNum = 0;
            double SecondNum = 0;
            if (Operator == "+")
            {
                //When Equals button is clicked, the values in txtFnumber and txtSnumber will be converted to int.
                //This is so that we can perform mathematical operations with them.                
                FirstNum = Convert.ToDouble(txtFnumber.Text);
                SecondNum = Convert.ToDouble(txtSnumber.Text);
                //When Add button is clicked, the operator becomes "+", and the code below will run.
                result = FirstNum + SecondNum;
                //Result is contained in the txtFnumber, so that if the user wants to perform a mathematical operation with the result, they can type the new number in the txtSnumber.
                txtFnumber.Text = Convert.ToString(result);
                //txtSnumber should be emptied so that the user can continue computing.
                txtSnumber.Clear();
            }else if (Operator == "-")
            {
                FirstNum = Convert.ToDouble(txtFnumber.Text);
                SecondNum = Convert.ToDouble(txtSnumber.Text);
                result = FirstNum - SecondNum;
                txtFnumber.Text = Convert.ToString(result);
                txtSnumber.Clear();
            }else if (Operator == "*")
            {
                FirstNum = Convert.ToDouble(txtFnumber.Text);
                SecondNum = Convert.ToDouble(txtSnumber.Text);
                result = FirstNum * SecondNum;
                txtFnumber.Text = Convert.ToString(result);
                txtSnumber.Clear();
            }else if (Operator == "/")
            {
                FirstNum = Convert.ToDouble(txtFnumber.Text);
                SecondNum = Convert.ToDouble(txtSnumber.Text);
                result = FirstNum / SecondNum;
                txtFnumber.Text = Convert.ToString(result);
                txtSnumber.Clear();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFnumber.Clear();
            txtSnumber.Clear();
            lblOperator.Text = "";
            //when clear button is clicked, the labels will return to their initial appearnce.
            lblResult.Text = "Enter a \nNumber:";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            MessageBox.Show("Thank you!");
            this.Close();
        }
        //this is the button X that can be seen on the uppermost right, and its function is to close the application.
        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}