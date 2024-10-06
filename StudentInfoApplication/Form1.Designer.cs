namespace StudentInfoApplication
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtStudentNum = new TextBox();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            listLastName = new ListBox();
            listStudentNum = new ListBox();
            listFirstName = new ListBox();
            submitButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 0;
            label1.Text = "Student ID *";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(256, 9);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 1;
            label2.Text = "Last name *";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(496, 9);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 2;
            label3.Text = "First name *";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 92);
            label4.Name = "label4";
            label4.Size = new Size(105, 20);
            label4.TabIndex = 3;
            label4.Text = "Student ID List";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(265, 92);
            label5.Name = "label5";
            label5.Size = new Size(106, 20);
            label5.TabIndex = 4;
            label5.Text = "First Name List";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(496, 92);
            label6.Name = "label6";
            label6.Size = new Size(105, 20);
            label6.TabIndex = 5;
            label6.Text = "Last Name List";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(415, 255);
            label7.Name = "label7";
            label7.Size = new Size(0, 20);
            label7.TabIndex = 6;
            // 
            // txtStudentNum
            // 
            txtStudentNum.Location = new Point(12, 32);
            txtStudentNum.Name = "txtStudentNum";
            txtStudentNum.Size = new Size(236, 27);
            txtStudentNum.TabIndex = 7;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(254, 32);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(236, 27);
            txtLastName.TabIndex = 8;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(496, 32);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(234, 27);
            txtFirstName.TabIndex = 9;
            // 
            // listLastName
            // 
            listLastName.FormattingEnabled = true;
            listLastName.Location = new Point(496, 115);
            listLastName.Name = "listLastName";
            listLastName.Size = new Size(213, 204);
            listLastName.TabIndex = 10;
            // 
            // listStudentNum
            // 
            listStudentNum.FormattingEnabled = true;
            listStudentNum.Location = new Point(35, 115);
            listStudentNum.Name = "listStudentNum";
            listStudentNum.Size = new Size(213, 204);
            listStudentNum.TabIndex = 11;
            // 
            // listFirstName
            // 
            listFirstName.FormattingEnabled = true;
            listFirstName.Location = new Point(265, 115);
            listFirstName.Name = "listFirstName";
            listFirstName.Size = new Size(214, 204);
            listFirstName.TabIndex = 14;
            // 
            // submitButton
            // 
            submitButton.BackColor = SystemColors.WindowFrame;
            submitButton.ForeColor = SystemColors.Control;
            submitButton.Location = new Point(626, 65);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(104, 29);
            submitButton.TabIndex = 13;
            submitButton.Text = "Submit";
            submitButton.UseVisualStyleBackColor = false;
            submitButton.Click += submitButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(742, 340);
            Controls.Add(submitButton);
            Controls.Add(listFirstName);
            Controls.Add(listStudentNum);
            Controls.Add(listLastName);
            Controls.Add(txtFirstName);
            Controls.Add(txtLastName);
            Controls.Add(txtStudentNum);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtStudentNum;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private ListBox listLastName;
        private ListBox listStudentNum;
        private ListBox listFirstName;
        private Button submitButton;
    }
}
