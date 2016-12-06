namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.naturalBornCitizen = new System.Windows.Forms.CheckBox();
            this.age = new System.Windows.Forms.TextBox();
            this.noOfYears = new System.Windows.Forms.TextBox();
            this.noOfTerms = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rebelledUS = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // naturalBornCitizen
            // 
            this.naturalBornCitizen.AutoSize = true;
            this.naturalBornCitizen.Location = new System.Drawing.Point(30, 12);
            this.naturalBornCitizen.Name = "naturalBornCitizen";
            this.naturalBornCitizen.Size = new System.Drawing.Size(119, 17);
            this.naturalBornCitizen.TabIndex = 0;
            this.naturalBornCitizen.Text = "Natural Born Citizen";
            this.naturalBornCitizen.UseVisualStyleBackColor = true;
            this.naturalBornCitizen.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // age
            // 
            this.age.Location = new System.Drawing.Point(155, 24);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(100, 20);
            this.age.TabIndex = 1;
            this.age.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // noOfYears
            // 
            this.noOfYears.Location = new System.Drawing.Point(281, 47);
            this.noOfYears.Name = "noOfYears";
            this.noOfYears.Size = new System.Drawing.Size(100, 20);
            this.noOfYears.TabIndex = 2;
            this.noOfYears.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // noOfTerms
            // 
            this.noOfTerms.Location = new System.Drawing.Point(223, 83);
            this.noOfTerms.Name = "noOfTerms";
            this.noOfTerms.Size = new System.Drawing.Size(100, 20);
            this.noOfTerms.TabIndex = 3;
            this.noOfTerms.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "What is your age?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "How many years have you resided in the US?";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "How many prior terms have you served?";
            // 
            // rebelledUS
            // 
            this.rebelledUS.AutoSize = true;
            this.rebelledUS.Location = new System.Drawing.Point(30, 113);
            this.rebelledUS.Name = "rebelledUS";
            this.rebelledUS.Size = new System.Drawing.Size(169, 17);
            this.rebelledUS.TabIndex = 8;
            this.rebelledUS.Text = "I have rebelled against the US";
            this.rebelledUS.UseVisualStyleBackColor = true;
            this.rebelledUS.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(76, 146);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 41);
            this.button1.TabIndex = 9;
            this.button1.Text = "Determine Eligibility";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(230, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 261);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rebelledUS);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.noOfTerms);
            this.Controls.Add(this.noOfYears);
            this.Controls.Add(this.age);
            this.Controls.Add(this.naturalBornCitizen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox naturalBornCitizen;
        private System.Windows.Forms.TextBox age;
        private System.Windows.Forms.TextBox noOfYears;
        private System.Windows.Forms.TextBox noOfTerms;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox rebelledUS;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
    }
}

