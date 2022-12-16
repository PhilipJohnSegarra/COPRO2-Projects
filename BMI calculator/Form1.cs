namespace BMI_calculator
{
    public partial class Form1 : Form
    {
        bool isMale;
        
     
        public Form1()
        {
            InitializeComponent();
            pnlResult.Hide();
            pnlGenAge.Hide();
            pbFemale.Hide();
            pbMale.Hide();
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

            if (isMale == true)
            {
                pbMale.Show();
                pbFemale.Hide();
            }
            else
            {
                pbFemale.Show();
                pbMale.Hide();
            }
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

       
    }
}