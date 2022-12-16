namespace BMI_calculator
{
    partial class frmBMICalcu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBMICalcu));
            this.label1 = new System.Windows.Forms.Label();
            this.btnMale = new System.Windows.Forms.Button();
            this.btnFemale = new System.Windows.Forms.Button();
            this.rdbtnMale = new System.Windows.Forms.RadioButton();
            this.rdbtnFemale = new System.Windows.Forms.RadioButton();
            this.pnlHeight = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.Height = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlWeight = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCompute = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlResult = new System.Windows.Forms.Panel();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.lblObese = new System.Windows.Forms.Label();
            this.lblOverweight = new System.Windows.Forms.Label();
            this.lblNormal = new System.Windows.Forms.Label();
            this.lblUnder = new System.Windows.Forms.Label();
            this.tbCategory = new System.Windows.Forms.TrackBar();
            this.lblBMI = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pnlGenAge = new System.Windows.Forms.Panel();
            this.lblNoAge = new System.Windows.Forms.Label();
            this.lblNone = new System.Windows.Forms.Label();
            this.pbFemale = new System.Windows.Forms.PictureBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.pbMale = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.pnlHeight.SuspendLayout();
            this.pnlWeight.SuspendLayout();
            this.pnlResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbCategory)).BeginInit();
            this.pnlGenAge.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFemale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMale)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "BMI Calculator";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnMale
            // 
            this.btnMale.BackColor = System.Drawing.Color.Transparent;
            this.btnMale.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMale.BackgroundImage")));
            this.btnMale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMale.FlatAppearance.BorderSize = 0;
            this.btnMale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMale.Location = new System.Drawing.Point(38, 51);
            this.btnMale.Name = "btnMale";
            this.btnMale.Size = new System.Drawing.Size(91, 76);
            this.btnMale.TabIndex = 1;
            this.btnMale.UseVisualStyleBackColor = false;
            this.btnMale.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnFemale
            // 
            this.btnFemale.BackColor = System.Drawing.Color.Transparent;
            this.btnFemale.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFemale.BackgroundImage")));
            this.btnFemale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFemale.FlatAppearance.BorderSize = 0;
            this.btnFemale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFemale.Location = new System.Drawing.Point(145, 51);
            this.btnFemale.Name = "btnFemale";
            this.btnFemale.Size = new System.Drawing.Size(91, 76);
            this.btnFemale.TabIndex = 2;
            this.btnFemale.UseVisualStyleBackColor = false;
            this.btnFemale.Click += new System.EventHandler(this.btnFemale_Click);
            // 
            // rdbtnMale
            // 
            this.rdbtnMale.AutoSize = true;
            this.rdbtnMale.FlatAppearance.BorderSize = 0;
            this.rdbtnMale.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightCoral;
            this.rdbtnMale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdbtnMale.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rdbtnMale.Location = new System.Drawing.Point(56, 133);
            this.rdbtnMale.Name = "rdbtnMale";
            this.rdbtnMale.Size = new System.Drawing.Size(50, 19);
            this.rdbtnMale.TabIndex = 3;
            this.rdbtnMale.TabStop = true;
            this.rdbtnMale.Text = "Male";
            this.rdbtnMale.UseVisualStyleBackColor = true;
            this.rdbtnMale.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdbtnFemale
            // 
            this.rdbtnFemale.AutoSize = true;
            this.rdbtnFemale.FlatAppearance.BorderSize = 0;
            this.rdbtnFemale.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightCoral;
            this.rdbtnFemale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdbtnFemale.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rdbtnFemale.Location = new System.Drawing.Point(159, 133);
            this.rdbtnFemale.Name = "rdbtnFemale";
            this.rdbtnFemale.Size = new System.Drawing.Size(62, 19);
            this.rdbtnFemale.TabIndex = 4;
            this.rdbtnFemale.TabStop = true;
            this.rdbtnFemale.Text = "Female";
            this.rdbtnFemale.UseVisualStyleBackColor = true;
            this.rdbtnFemale.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // pnlHeight
            // 
            this.pnlHeight.BackColor = System.Drawing.Color.Black;
            this.pnlHeight.Controls.Add(this.label3);
            this.pnlHeight.Controls.Add(this.txtHeight);
            this.pnlHeight.Controls.Add(this.Height);
            this.pnlHeight.Controls.Add(this.label2);
            this.pnlHeight.Location = new System.Drawing.Point(38, 170);
            this.pnlHeight.Name = "pnlHeight";
            this.pnlHeight.Size = new System.Drawing.Size(288, 111);
            this.pnlHeight.TabIndex = 5;
            this.pnlHeight.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(218, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "in";
            // 
            // txtHeight
            // 
            this.txtHeight.BackColor = System.Drawing.Color.Black;
            this.txtHeight.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHeight.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtHeight.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtHeight.Location = new System.Drawing.Point(50, 55);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(162, 20);
            this.txtHeight.TabIndex = 1;
            this.txtHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHeight_KeyPress);
            // 
            // Height
            // 
            this.Height.AutoSize = true;
            this.Height.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Height.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Height.Location = new System.Drawing.Point(50, 20);
            this.Height.Name = "Height";
            this.Height.Size = new System.Drawing.Size(70, 22);
            this.Height.TabIndex = 0;
            this.Height.Text = "Height";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Location = new System.Drawing.Point(50, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "_______________________________";
            // 
            // pnlWeight
            // 
            this.pnlWeight.BackColor = System.Drawing.Color.Black;
            this.pnlWeight.Controls.Add(this.label4);
            this.pnlWeight.Controls.Add(this.txtWeight);
            this.pnlWeight.Controls.Add(this.label5);
            this.pnlWeight.Controls.Add(this.label6);
            this.pnlWeight.Location = new System.Drawing.Point(38, 287);
            this.pnlWeight.Name = "pnlWeight";
            this.pnlWeight.Size = new System.Drawing.Size(288, 111);
            this.pnlWeight.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(218, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "lbs";
            // 
            // txtWeight
            // 
            this.txtWeight.BackColor = System.Drawing.Color.Black;
            this.txtWeight.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtWeight.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtWeight.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtWeight.Location = new System.Drawing.Point(50, 55);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(162, 20);
            this.txtWeight.TabIndex = 1;
            this.txtWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWeight_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(50, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 22);
            this.label5.TabIndex = 0;
            this.label5.Text = "Weight";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label6.Location = new System.Drawing.Point(50, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "_______________________________";
            // 
            // btnCompute
            // 
            this.btnCompute.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCompute.FlatAppearance.BorderSize = 0;
            this.btnCompute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompute.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCompute.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCompute.Location = new System.Drawing.Point(38, 404);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(288, 31);
            this.btnCompute.TabIndex = 7;
            this.btnCompute.Text = "Calculate BMI";
            this.btnCompute.UseVisualStyleBackColor = false;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Black;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnCancel.Location = new System.Drawing.Point(38, 441);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(140, 31);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Black;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClear.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnClear.Location = new System.Drawing.Point(184, 441);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(142, 31);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClose.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClose.Location = new System.Drawing.Point(323, -6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(46, 42);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "×";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.button4_Click);
            // 
            // pnlResult
            // 
            this.pnlResult.Controls.Add(this.txtResult);
            this.pnlResult.Controls.Add(this.lblObese);
            this.pnlResult.Controls.Add(this.lblOverweight);
            this.pnlResult.Controls.Add(this.lblNormal);
            this.pnlResult.Controls.Add(this.lblUnder);
            this.pnlResult.Controls.Add(this.tbCategory);
            this.pnlResult.Controls.Add(this.lblBMI);
            this.pnlResult.Controls.Add(this.label7);
            this.pnlResult.ForeColor = System.Drawing.Color.LightCoral;
            this.pnlResult.Location = new System.Drawing.Point(38, 170);
            this.pnlResult.Name = "pnlResult";
            this.pnlResult.Size = new System.Drawing.Size(288, 228);
            this.pnlResult.TabIndex = 11;
            // 
            // txtResult
            // 
            this.txtResult.BackColor = System.Drawing.Color.Black;
            this.txtResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResult.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtResult.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.txtResult.Location = new System.Drawing.Point(107, 61);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(69, 34);
            this.txtResult.TabIndex = 10;
            this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblObese
            // 
            this.lblObese.AutoSize = true;
            this.lblObese.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblObese.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblObese.Location = new System.Drawing.Point(242, 162);
            this.lblObese.Name = "lblObese";
            this.lblObese.Size = new System.Drawing.Size(43, 16);
            this.lblObese.TabIndex = 9;
            this.lblObese.Text = "Obese\r\n";
            // 
            // lblOverweight
            // 
            this.lblOverweight.AutoSize = true;
            this.lblOverweight.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOverweight.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblOverweight.Location = new System.Drawing.Point(154, 162);
            this.lblOverweight.Name = "lblOverweight";
            this.lblOverweight.Size = new System.Drawing.Size(72, 16);
            this.lblOverweight.TabIndex = 8;
            this.lblOverweight.Text = "Overweight";
            // 
            // lblNormal
            // 
            this.lblNormal.AutoSize = true;
            this.lblNormal.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNormal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNormal.Location = new System.Drawing.Point(95, 162);
            this.lblNormal.Name = "lblNormal";
            this.lblNormal.Size = new System.Drawing.Size(45, 16);
            this.lblNormal.TabIndex = 7;
            this.lblNormal.Text = "Normal";
            // 
            // lblUnder
            // 
            this.lblUnder.AutoSize = true;
            this.lblUnder.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUnder.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUnder.Location = new System.Drawing.Point(3, 162);
            this.lblUnder.Name = "lblUnder";
            this.lblUnder.Size = new System.Drawing.Size(77, 16);
            this.lblUnder.TabIndex = 6;
            this.lblUnder.Text = "Underweight";
            // 
            // tbCategory
            // 
            this.tbCategory.Location = new System.Drawing.Point(3, 114);
            this.tbCategory.Maximum = 20;
            this.tbCategory.Name = "tbCategory";
            this.tbCategory.Size = new System.Drawing.Size(282, 45);
            this.tbCategory.TabIndex = 3;
            this.tbCategory.Value = 19;
            // 
            // lblBMI
            // 
            this.lblBMI.AutoSize = true;
            this.lblBMI.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBMI.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblBMI.Location = new System.Drawing.Point(107, 54);
            this.lblBMI.Name = "lblBMI";
            this.lblBMI.Size = new System.Drawing.Size(0, 21);
            this.lblBMI.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(59, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(167, 22);
            this.label7.TabIndex = 0;
            this.label7.Text = "Body Mass Index:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(256, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 22);
            this.label8.TabIndex = 4;
            this.label8.Text = "Age:";
            // 
            // txtAge
            // 
            this.txtAge.BackColor = System.Drawing.Color.Black;
            this.txtAge.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAge.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAge.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtAge.Location = new System.Drawing.Point(261, 103);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(44, 30);
            this.txtAge.TabIndex = 12;
            this.txtAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAge_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label9.Location = new System.Drawing.Point(256, 133);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 15);
            this.label9.TabIndex = 13;
            this.label9.Text = "_________";
            // 
            // pnlGenAge
            // 
            this.pnlGenAge.Controls.Add(this.lblNoAge);
            this.pnlGenAge.Controls.Add(this.lblNone);
            this.pnlGenAge.Controls.Add(this.pbFemale);
            this.pnlGenAge.Controls.Add(this.lblAge);
            this.pnlGenAge.Controls.Add(this.pbMale);
            this.pnlGenAge.Controls.Add(this.panel2);
            this.pnlGenAge.Controls.Add(this.label11);
            this.pnlGenAge.Controls.Add(this.label10);
            this.pnlGenAge.Location = new System.Drawing.Point(38, 51);
            this.pnlGenAge.Name = "pnlGenAge";
            this.pnlGenAge.Size = new System.Drawing.Size(288, 113);
            this.pnlGenAge.TabIndex = 14;
            // 
            // lblNoAge
            // 
            this.lblNoAge.AutoSize = true;
            this.lblNoAge.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNoAge.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblNoAge.Location = new System.Drawing.Point(182, 47);
            this.lblNoAge.Name = "lblNoAge";
            this.lblNoAge.Size = new System.Drawing.Size(66, 32);
            this.lblNoAge.TabIndex = 15;
            this.lblNoAge.Text = "N/A";
            // 
            // lblNone
            // 
            this.lblNone.AutoSize = true;
            this.lblNone.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNone.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblNone.Location = new System.Drawing.Point(41, 47);
            this.lblNone.Name = "lblNone";
            this.lblNone.Size = new System.Drawing.Size(66, 32);
            this.lblNone.TabIndex = 6;
            this.lblNone.Text = "N/A";
            // 
            // pbFemale
            // 
            this.pbFemale.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbFemale.BackgroundImage")));
            this.pbFemale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbFemale.Location = new System.Drawing.Point(48, 43);
            this.pbFemale.Name = "pbFemale";
            this.pbFemale.Size = new System.Drawing.Size(53, 43);
            this.pbFemale.TabIndex = 5;
            this.pbFemale.TabStop = false;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAge.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblAge.Location = new System.Drawing.Point(186, 43);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(38, 41);
            this.lblAge.TabIndex = 4;
            this.lblAge.Text = "0";
            // 
            // pbMale
            // 
            this.pbMale.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbMale.BackgroundImage")));
            this.pbMale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbMale.Location = new System.Drawing.Point(48, 42);
            this.pbMale.Name = "pbMale";
            this.pbMale.Size = new System.Drawing.Size(53, 43);
            this.pbMale.TabIndex = 3;
            this.pbMale.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel2.Location = new System.Drawing.Point(146, 17);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 80);
            this.panel2.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(186, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 22);
            this.label11.TabIndex = 1;
            this.label11.Text = "Age:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(32, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 22);
            this.label10.TabIndex = 0;
            this.label10.Text = "Gender:";
            // 
            // btnMinimize
            // 
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMinimize.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMinimize.Location = new System.Drawing.Point(271, -2);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(46, 38);
            this.btnMinimize.TabIndex = 15;
            this.btnMinimize.Text = "—";
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // frmBMICalcu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(367, 503);
            this.Controls.Add(this.pnlGenAge);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCompute);
            this.Controls.Add(this.rdbtnFemale);
            this.Controls.Add(this.rdbtnMale);
            this.Controls.Add(this.btnFemale);
            this.Controls.Add(this.btnMale);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pnlResult);
            this.Controls.Add(this.pnlHeight);
            this.Controls.Add(this.pnlWeight);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBMICalcu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlHeight.ResumeLayout(false);
            this.pnlHeight.PerformLayout();
            this.pnlWeight.ResumeLayout(false);
            this.pnlWeight.PerformLayout();
            this.pnlResult.ResumeLayout(false);
            this.pnlResult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbCategory)).EndInit();
            this.pnlGenAge.ResumeLayout(false);
            this.pnlGenAge.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFemale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMale)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btnMale;
        private Button btnFemale;
        private RadioButton rdbtnMale;
        private RadioButton rdbtnFemale;
        private Panel pnlHeight;
        private Label label3;
        private Label label2;
        private TextBox txtHeight;
        private Label Height;
        private Panel pnlWeight;
        private Label label4;
        private TextBox txtWeight;
        private Label label5;
        private Label label6;
        private Button btnCompute;
        private Button btnCancel;
        private Button btnClear;
        private Button btnClose;
        private Panel pnlResult;
        private Label lblObese;
        private Label lblOverweight;
        private Label lblNormal;
        private Label lblUnder;
        private TrackBar tbCategory;
        private Label lblBMI;
        private Label label7;
        private TextBox txtResult;
        private Label label8;
        private TextBox txtAge;
        private Label label9;
        private Panel pnlGenAge;
        private PictureBox pbFemale;
        private Label lblAge;
        private PictureBox pbMale;
        private Panel panel2;
        private Label label11;
        private Label label10;
        private Label lblNone;
        private Label lblNoAge;
        private Button btnMinimize;
    }
}