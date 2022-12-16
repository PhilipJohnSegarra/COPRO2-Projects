namespace BMI_calculator
{
    public partial class frmBMICalcu : Form
    {
        bool isMale;
        
     
        public frmBMICalcu()
        {
            InitializeComponent();
            pnlResult.Hide();
            pnlGenAge.Hide();
            pbFemale.Hide();
            pbMale.Hide();
            lblNoAge.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnMale.BackColor = Color.CornflowerBlue;
            rdbtnMale.Checked = true;
            btnFemale.BackColor = Color.Transparent;
        }
        private void btnFemale_Click(object sender, EventArgs e)
        {
            btnFemale.BackColor = Color.CornflowerBlue;
            rdbtnFemale.Checked = true;
            btnMale.BackColor = Color.Transparent;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {        
            tbCategory.Value = 2;

        }

     

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            isMale = true;
            btnMale.BackColor = Color.CornflowerBlue;
            btnFemale.BackColor = Color.Transparent;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            isMale = false;
            btnFemale.BackColor = Color.CornflowerBlue;
            btnMale.BackColor = Color.Transparent;
        }


        private void btnCompute_Click(object sender, EventArgs e)
        {

            //----------------------------------------------------------
            //Gen Age Panel
            if (isMale == true)
            {
                pbMale.Show();
                pbFemale.Hide();
                lblNone.Hide();
            }
            else
            {
                pbFemale.Show();
                pbMale.Hide();
                lblNone.Hide();
            } 
            if (rdbtnFemale.Checked == false && rdbtnMale.Checked == false)
            {
                pbFemale.Hide();
                pbMale.Hide();
                lblNone.Show();
            }
            if (txtAge.Text == "")
            {
                lblNoAge.Show();
            }else
            {
                lblNoAge.Hide();
            }
            //-----------------------------------------------------------
            //Error and Result
            if (txtHeight.Text == "" && txtWeight.Text == "")
            {
                pnlHeight.Show();
                pnlWeight.Show();
                pnlResult.Hide();
                pnlGenAge.Hide();
                string title = "Error";
                string message = "Please provide data for Height and Weight!";
                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {

                double Result;
                double Height;
                double Weight;
                double HeightSq;

                Height = double.Parse(txtHeight.Text);
                Weight = double.Parse(txtWeight.Text);
                HeightSq = Height * Height;

                Result = Weight * 703 / HeightSq;

                txtResult.Text = Convert.ToString(Result);
                pnlHeight.Hide();
                pnlWeight.Hide();
                pnlResult.Show();
                pnlGenAge.Show();

                lblAge.Text = txtAge.Text;
                if (Result < 18.5)
                {
                    tbCategory.Value = 2;
                    lblUnder.ForeColor = Color.CornflowerBlue;
                    lblNormal.ForeColor = Color.White;
                    lblOverweight.ForeColor = Color.White;
                    lblObese.ForeColor = Color.White;
                    tbCategory.Enabled = false;
                }
                else if (Result >= 18.5 && Result <= 24.9)
                {
                    tbCategory.Value = 8;
                    lblUnder.ForeColor = Color.White;
                    lblNormal.ForeColor = Color.CornflowerBlue;
                    lblOverweight.ForeColor = Color.White;
                    lblObese.ForeColor = Color.White;
                    tbCategory.Enabled = false;
                }
                else if (Result >= 25.0 && Result <= 29.9)
                {
                    tbCategory.Value = 14;
                    lblUnder.ForeColor = Color.White;
                    lblNormal.ForeColor = Color.White;
                    lblOverweight.ForeColor = Color.CornflowerBlue;
                    lblObese.ForeColor = Color.White;
                    tbCategory.Enabled = false;
                }
                else if (Result >= 30.0)
                {
                    tbCategory.Value = 19;
                    lblUnder.ForeColor = Color.White;
                    lblNormal.ForeColor = Color.White;
                    lblOverweight.ForeColor = Color.White;
                    lblObese.ForeColor = Color.CornflowerBlue;
                    tbCategory.Enabled = false;
                }
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            pnlResult.Hide();
            pnlGenAge.Hide();
            pnlHeight.Show();
            pnlWeight.Show();
            txtHeight.Clear();
            txtWeight.Clear();
            txtAge.Clear();
            btnMale.BackColor = Color.Transparent;
            btnFemale.BackColor = Color.Transparent;
            rdbtnMale.Checked = false;
            rdbtnFemale.Checked = false;
        }

        private void txtAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
 
            }
        }

        private void txtHeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsControl(ch) && !char.IsDigit(ch) && ch != 8 && ch != 46)
            {

       
                e.Handled = true;
                
            }
        }

        private void txtWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsControl(ch) && !char.IsDigit(ch) && ch != 8 && ch != 46)
            {


                e.Handled = true;

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}