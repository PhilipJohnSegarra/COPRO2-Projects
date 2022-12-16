namespace Activity78_Group4
{
    public partial class frmConverter : Form
    {
        public frmConverter()
        {
            InitializeComponent();

        }
        //this is the code for the button on the uppermost right. This closes the application when clicked
        private void button14_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //this button minimizes the form
        private void button16_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn1_Click(object sender, EventArgs e)
        {

            
            if (txtNum1.Text == "" && txtNum1.Text != null)
            {
                txtNum1.Text = "1";
            }else
            {
                txtNum1.Text += "1";
            }
            
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            
            if (txtNum1.Text == "" && txtNum1.Text != null)
            {
                txtNum1.Text = "2";
            }
            else
            {
                txtNum1.Text += "2";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            
            if (txtNum1.Text == "" && txtNum1.Text != null)
            {
                txtNum1.Text = "3";
            }
            else
            {
                txtNum1.Text += "3";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            
            if (txtNum1.Text == "" && txtNum1.Text != null)
            {
                txtNum1.Text = "4";
            }
            else
            {
                txtNum1.Text += "4";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            
            if (txtNum1.Text == "" && txtNum1.Text != null)
            {
                txtNum1.Text = "5";
            }
            else
            {
                txtNum1.Text += "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            
            if (txtNum1.Text == "" && txtNum1.Text != null)
            {
                txtNum1.Text = "6";
            }
            else
            {
                txtNum1.Text += "6";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            
            if (txtNum1.Text == "" && txtNum1.Text != null)
            {
                txtNum1.Text = "7";
            }
            else
            {
                txtNum1.Text += "7";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
           
            if (txtNum1.Text == "" && txtNum1.Text != null)
            {
                txtNum1.Text = "8";
            }
            else
            {
                txtNum1.Text += "8";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            
            if (txtNum1.Text == "" && txtNum1.Text != null)
            {
                txtNum1.Text = "9";
            }
            else
            {
                txtNum1.Text += "9";
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            
            if (txtNum1.Text == "" && txtNum1.Text != null)
            {
                txtNum1.Text = "0";
            }
            else
            {
                txtNum1.Text += "0";
            }
        }
        //This button writes "." on the txtNum1 only once.
        private void btnPoint_Click(object sender, EventArgs e)
        {
            
            txtNum1.Text += ".";
            btnPoint.Enabled = false;
            
        }
        //The convert button determines the text in combobox, and if clicked, performs
        //calculations based on what units are being selected
        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (cbxUnit1.Text == "Kilogram" && cbxUnit2.Text == "Kilogram")
            {
                txtNum2.Text = txtNum1.Text;
            }
            else if (cbxUnit1.Text == "Milligram" && cbxUnit2.Text == "Milligram")
            {
                txtNum2.Text = txtNum1.Text;
            }
            else if (cbxUnit1.Text == "Pounds" && cbxUnit2.Text == "Pounds")
            {
                txtNum2.Text = txtNum1.Text;
            }
            else if (cbxUnit1.Text == "Kilogram" && cbxUnit2.Text == "Milligram")
            {
                double Num1 = Convert.ToDouble(txtNum1.Text);
                double Num2 = Num1 * 1000000;
                txtNum1.Text = txtNum1.Text;
                txtNum2.Text = Convert.ToString(Num2);
            }
            else if (cbxUnit1.Text == "Milligram" && cbxUnit2.Text == "Kilogram")
            {
                double Num1 = Convert.ToDouble(txtNum1.Text);
                double Num2 = Num1 / 1000000;
                txtNum1.Text = txtNum1.Text;
                txtNum2.Text = Convert.ToString(Num2);
            }
            else if (cbxUnit1.Text == "Kilogram" && cbxUnit2.Text == "Pounds")
            {
                double Num1 = Convert.ToDouble(txtNum1.Text);
                double Num2 = Num1 * 2.20462262185;
                txtNum1.Text = txtNum1.Text;
                txtNum2.Text = Convert.ToString(Num2);
            }
            else if (cbxUnit1.Text == "Pounds" && cbxUnit2.Text == "Kilogram")
            {
                double Num1 = Convert.ToDouble(txtNum1.Text);
                double Num2 = Num1 / 2.20462262185;
                txtNum1.Text = txtNum1.Text;
                txtNum2.Text = Convert.ToString(Num2);
            }
            else if (cbxUnit1.Text == "Milligram" && cbxUnit2.Text == "Pounds")
            {
                double Num1 = Convert.ToDouble(txtNum1.Text);
                double Num2 = Num1 * 0.00000220462;
                txtNum1.Text = txtNum1.Text;
                txtNum2.Text = Convert.ToString(Num2);
            }
            else if (cbxUnit1.Text == "Pounds" && cbxUnit2.Text == "Milligram")
            {
                double Num1 = Convert.ToDouble(txtNum1.Text);
                double Num2 = Num1 / 0.00000220462;
                txtNum1.Text = txtNum1.Text;
                txtNum2.Text = Convert.ToString(Num2);
            }
            //if the user did not choose at least one unit, the combobox 
            //where there is no unit selected will show, "choose a unit"
            //if a unit is not selected the form will not do anything
            else if (cbxUnit1.Text == "Unit" && cbxUnit2.Text == "Unit" || cbxUnit1.Text == "Unit" && cbxUnit2.Text != "Unit" || cbxUnit1.Text != "Unit" && cbxUnit2.Text == "Unit")
            {
                
                cbxUnit1.Text = "Choose a unit";
                cbxUnit2.Text = "Choose a unit";
                
            }
            
            
        }
        //This code makes the form return to its initial appearance
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNum1.Clear();
            txtNum2.Clear();
            cbxUnit1.Text = "Unit";
            cbxUnit2.Text = "Unit";
            btnPoint.Enabled = true;
        }
        //This code closes the application
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            string title = "Closing App";
            string message = "Thank you";
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
        //This button acts as a backspace, erasing the last character in txtNum1.Text,
        //enables when textbox is not empty, otherwise, disables.
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (txtNum1.Text.Length < 0)
            {
                button1.Enabled = false;
            }else if (txtNum1.Text.Length > 0)
            {
                button1.Enabled = true;
                string newtxtNum1 = txtNum1.Text.Remove(txtNum1.Text.Length - 1, 1);
                txtNum1.Text = newtxtNum1;
            }
        }

        private void txtNum1_TextChanged(object sender, EventArgs e)
        {
            //this code indicates that we want txtNum1 to subscribe to KeyPress as a new keypress eventhandler, therefore
            //enabling us to handle exceptions that involve using the keys on the keyboard.
            this.txtNum1.KeyPress += new KeyPressEventHandler(this.txtNum1_KeyPress);
            if (txtNum1.Text == "")
            {
                btnPoint.Enabled = true;
            }
            if (txtNum1.Text.Contains(".") == false)
            {
                btnPoint.Enabled = true;
            }
        }
        //the code below disallows the user to type non numeric values.
        private void txtNum1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }

}