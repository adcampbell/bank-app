namespace ITSE2453_Bank
{
    partial class bankForm
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
            this.accButton = new System.Windows.Forms.Button();
            this.exeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.accTextBox = new System.Windows.Forms.TextBox();
            this.amtTextBox = new System.Windows.Forms.TextBox();
            this.depRadio = new System.Windows.Forms.RadioButton();
            this.withRadio = new System.Windows.Forms.RadioButton();
            this.balRadio = new System.Windows.Forms.RadioButton();
            this.exitButton = new System.Windows.Forms.Button();
            this.outLabel = new System.Windows.Forms.Label();
            this.checkingRadButton = new System.Windows.Forms.RadioButton();
            this.savingRadButton = new System.Windows.Forms.RadioButton();
            this.endButton = new System.Windows.Forms.Button();
            this.reportButton = new System.Windows.Forms.Button();
            this.collegeCheckBox = new System.Windows.Forms.CheckBox();
            this.seniorCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // accButton
            // 
            this.accButton.Location = new System.Drawing.Point(12, 210);
            this.accButton.Name = "accButton";
            this.accButton.Size = new System.Drawing.Size(107, 23);
            this.accButton.TabIndex = 0;
            this.accButton.Text = "Create Account";
            this.accButton.UseVisualStyleBackColor = true;
            this.accButton.Click += new System.EventHandler(this.accButton_Click);
            // 
            // exeButton
            // 
            this.exeButton.Location = new System.Drawing.Point(169, 210);
            this.exeButton.Name = "exeButton";
            this.exeButton.Size = new System.Drawing.Size(107, 23);
            this.exeButton.TabIndex = 1;
            this.exeButton.Text = "Execute";
            this.exeButton.UseVisualStyleBackColor = true;
            this.exeButton.Click += new System.EventHandler(this.exeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 38);
            this.label1.TabIndex = 6;
            this.label1.Text = "ITSE 2453 Bank\r\nDallas, Texas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Account ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(205, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Amount";
            // 
            // accTextBox
            // 
            this.accTextBox.Location = new System.Drawing.Point(12, 62);
            this.accTextBox.Name = "accTextBox";
            this.accTextBox.Size = new System.Drawing.Size(100, 20);
            this.accTextBox.TabIndex = 9;
            // 
            // amtTextBox
            // 
            this.amtTextBox.Location = new System.Drawing.Point(176, 62);
            this.amtTextBox.Name = "amtTextBox";
            this.amtTextBox.Size = new System.Drawing.Size(100, 20);
            this.amtTextBox.TabIndex = 10;
            // 
            // depRadio
            // 
            this.depRadio.AutoSize = true;
            this.depRadio.Location = new System.Drawing.Point(187, 162);
            this.depRadio.Name = "depRadio";
            this.depRadio.Size = new System.Drawing.Size(61, 17);
            this.depRadio.TabIndex = 11;
            this.depRadio.TabStop = true;
            this.depRadio.Text = "Deposit";
            this.depRadio.UseVisualStyleBackColor = true;
            // 
            // withRadio
            // 
            this.withRadio.AutoSize = true;
            this.withRadio.Location = new System.Drawing.Point(187, 139);
            this.withRadio.Name = "withRadio";
            this.withRadio.Size = new System.Drawing.Size(70, 17);
            this.withRadio.TabIndex = 12;
            this.withRadio.TabStop = true;
            this.withRadio.Text = "Withdraw";
            this.withRadio.UseVisualStyleBackColor = true;
            // 
            // balRadio
            // 
            this.balRadio.AutoSize = true;
            this.balRadio.Location = new System.Drawing.Point(187, 116);
            this.balRadio.Name = "balRadio";
            this.balRadio.Size = new System.Drawing.Size(64, 17);
            this.balRadio.TabIndex = 13;
            this.balRadio.TabStop = true;
            this.balRadio.Text = "Balance";
            this.balRadio.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(201, 381);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 14;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // outLabel
            // 
            this.outLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outLabel.Location = new System.Drawing.Point(12, 265);
            this.outLabel.Name = "outLabel";
            this.outLabel.Size = new System.Drawing.Size(264, 113);
            this.outLabel.TabIndex = 15;
            // 
            // checkingRadButton
            // 
            this.checkingRadButton.AutoSize = true;
            this.checkingRadButton.Location = new System.Drawing.Point(31, 116);
            this.checkingRadButton.Name = "checkingRadButton";
            this.checkingRadButton.Size = new System.Drawing.Size(70, 17);
            this.checkingRadButton.TabIndex = 16;
            this.checkingRadButton.TabStop = true;
            this.checkingRadButton.Text = "Checking";
            this.checkingRadButton.UseVisualStyleBackColor = true;
            // 
            // savingRadButton
            // 
            this.savingRadButton.AutoSize = true;
            this.savingRadButton.Location = new System.Drawing.Point(31, 162);
            this.savingRadButton.Name = "savingRadButton";
            this.savingRadButton.Size = new System.Drawing.Size(63, 17);
            this.savingRadButton.TabIndex = 17;
            this.savingRadButton.TabStop = true;
            this.savingRadButton.Text = "Savings";
            this.savingRadButton.UseVisualStyleBackColor = true;
            // 
            // endButton
            // 
            this.endButton.Location = new System.Drawing.Point(12, 239);
            this.endButton.Name = "endButton";
            this.endButton.Size = new System.Drawing.Size(107, 23);
            this.endButton.TabIndex = 18;
            this.endButton.Text = "End of Month";
            this.endButton.UseVisualStyleBackColor = true;
            this.endButton.Click += new System.EventHandler(this.endButton_Click);
            // 
            // reportButton
            // 
            this.reportButton.Location = new System.Drawing.Point(169, 239);
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(107, 23);
            this.reportButton.TabIndex = 19;
            this.reportButton.Text = "Report";
            this.reportButton.UseVisualStyleBackColor = true;
            this.reportButton.Click += new System.EventHandler(this.reportButton_Click);
            // 
            // collegeCheckBox
            // 
            this.collegeCheckBox.AutoSize = true;
            this.collegeCheckBox.Location = new System.Drawing.Point(35, 139);
            this.collegeCheckBox.Name = "collegeCheckBox";
            this.collegeCheckBox.Size = new System.Drawing.Size(101, 17);
            this.collegeCheckBox.TabIndex = 20;
            this.collegeCheckBox.Text = "College Student";
            this.collegeCheckBox.UseVisualStyleBackColor = true;
            // 
            // seniorCheckBox
            // 
            this.seniorCheckBox.AutoSize = true;
            this.seniorCheckBox.Location = new System.Drawing.Point(35, 185);
            this.seniorCheckBox.Name = "seniorCheckBox";
            this.seniorCheckBox.Size = new System.Drawing.Size(90, 17);
            this.seniorCheckBox.TabIndex = 21;
            this.seniorCheckBox.Text = "Senior Citizen";
            this.seniorCheckBox.UseVisualStyleBackColor = true;
            // 
            // bankForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 416);
            this.Controls.Add(this.seniorCheckBox);
            this.Controls.Add(this.collegeCheckBox);
            this.Controls.Add(this.reportButton);
            this.Controls.Add(this.endButton);
            this.Controls.Add(this.savingRadButton);
            this.Controls.Add(this.checkingRadButton);
            this.Controls.Add(this.outLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.balRadio);
            this.Controls.Add(this.withRadio);
            this.Controls.Add(this.depRadio);
            this.Controls.Add(this.amtTextBox);
            this.Controls.Add(this.accTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exeButton);
            this.Controls.Add(this.accButton);
            this.Name = "bankForm";
            this.Text = "Bank Account";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button accButton;
        private System.Windows.Forms.Button exeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox accTextBox;
        private System.Windows.Forms.TextBox amtTextBox;
        private System.Windows.Forms.RadioButton depRadio;
        private System.Windows.Forms.RadioButton withRadio;
        private System.Windows.Forms.RadioButton balRadio;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label outLabel;
        private System.Windows.Forms.RadioButton checkingRadButton;
        private System.Windows.Forms.RadioButton savingRadButton;
        private System.Windows.Forms.Button endButton;
        private System.Windows.Forms.Button reportButton;
        private System.Windows.Forms.CheckBox collegeCheckBox;
        private System.Windows.Forms.CheckBox seniorCheckBox;
    }
}

